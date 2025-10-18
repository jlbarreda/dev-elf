using System.Threading.RateLimiting;
using AwesomeAssertions;
using DevElf.Threading.RateLimiting;

namespace DevElf.Tests.Threading.RateLimiting;

[TestClass]
public class NoLimitRateLimiterTests
{
    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    public void Instance_returns_singleton_instance()
    {
        // Arrange & Act
        var instance1 = NoLimitRateLimiter.Instance;
        var instance2 = NoLimitRateLimiter.Instance;

        // Assert
        _ = instance1.Should().BeSameAs(instance2);
    }

    [TestMethod]
    public void IdleDuration_returns_null()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        TimeSpan? idleDuration = limiter.IdleDuration;

        // Assert
        _ = idleDuration.Should().BeNull();
    }

    [TestMethod]
    public void GetStatistics_returns_null()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        RateLimiterStatistics? statistics = limiter.GetStatistics();

        // Assert
        _ = statistics.Should().BeNull();
    }

    [TestMethod]
    public async Task AcquireAsync_always_succeeds_with_single_permit()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task AcquireAsync_always_succeeds_with_multiple_permits()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = await limiter.AcquireAsync(100, TestContext.CancellationToken);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task AcquireAsync_always_succeeds_with_zero_permits()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = await limiter.AcquireAsync(0, TestContext.CancellationToken);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task AcquireAsync_succeeds_immediately_without_waiting()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        // Act
        using var lease = await limiter.AcquireAsync(1000, TestContext.CancellationToken);
        stopwatch.Stop();

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
        _ = stopwatch.ElapsedMilliseconds.Should().BeLessThan(100);
    }

    [TestMethod]
    public async Task AcquireAsync_can_acquire_multiple_leases_concurrently()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease1 = await limiter.AcquireAsync(50, TestContext.CancellationToken);
        using var lease2 = await limiter.AcquireAsync(50, TestContext.CancellationToken);
        using var lease3 = await limiter.AcquireAsync(50, TestContext.CancellationToken);

        // Assert
        _ = lease1.IsAcquired.Should().BeTrue();
        _ = lease2.IsAcquired.Should().BeTrue();
        _ = lease3.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public void AttemptAcquire_always_succeeds_with_single_permit()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = limiter.AttemptAcquire(1);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public void AttemptAcquire_always_succeeds_with_multiple_permits()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = limiter.AttemptAcquire(100);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public void AttemptAcquire_always_succeeds_with_zero_permits()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease = limiter.AttemptAcquire(0);

        // Assert
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public void AttemptAcquire_can_acquire_multiple_leases_concurrently()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease1 = limiter.AttemptAcquire(50);
        using var lease2 = limiter.AttemptAcquire(50);
        using var lease3 = limiter.AttemptAcquire(50);

        // Assert
        _ = lease1.IsAcquired.Should().BeTrue();
        _ = lease2.IsAcquired.Should().BeTrue();
        _ = lease3.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task Lease_MetadataNames_returns_empty_collection()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Act
        var metadataNames = lease.MetadataNames.ToList();

        // Assert
        _ = metadataNames.Should().BeEmpty();
    }

    [TestMethod]
    public async Task Lease_TryGetMetadata_always_returns_false()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Act
        bool result = lease.TryGetMetadata("SomeKey", out object? metadata);

        // Assert
        _ = result.Should().BeFalse();
        _ = metadata.Should().BeNull();
    }

    [TestMethod]
    public async Task Lease_TryGetMetadata_returns_false_for_any_key()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Act & Assert
        _ = lease.TryGetMetadata("Key1", out object? metadata1).Should().BeFalse();
        _ = metadata1.Should().BeNull();

        _ = lease.TryGetMetadata("Key2", out object? metadata2).Should().BeFalse();
        _ = metadata2.Should().BeNull();

        _ = lease.TryGetMetadata(string.Empty, out object? metadata3).Should().BeFalse();
        _ = metadata3.Should().BeNull();
    }

    [TestMethod]
    public async Task Lease_can_be_disposed_multiple_times_safely()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Act & Assert: disposing multiple times should not throw
        lease.Dispose();
        lease.Dispose();
        lease.Dispose();
    }

    [TestMethod]
    public async Task Multiple_leases_share_same_instance()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        using var lease1 = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        using var lease2 = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Assert: the leases should be the same singleton instance
        _ = lease1.Should().BeSameAs(lease2);
    }

    [TestMethod]
    public async Task AcquireAsync_completes_synchronously()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        ValueTask<RateLimitLease> task = limiter.AcquireAsync(1, TestContext.CancellationToken);

        // Assert: should be completed synchronously
        _ = task.IsCompleted.Should().BeTrue();

        using var lease = await task;
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task Works_with_RateLimiterExtensions_ApplyToAsync_action()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        bool actionExecuted = false;

        // Act
        await limiter.ApplyToAsync(
            _ =>
            {
                actionExecuted = true;

                return Task.CompletedTask;
            },
            permitCount: 100,
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = actionExecuted.Should().BeTrue();
    }

    [TestMethod]
    public async Task Works_with_RateLimiterExtensions_ApplyToAsync_request()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;

        // Act
        int result = await limiter.ApplyToAsync(
            _ => Task.FromResult(42),
            permitCount: 100,
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = result.Should().Be(42);
    }

    [TestMethod]
    public async Task Supports_high_concurrency_without_blocking()
    {
        // Arrange
        var limiter = NoLimitRateLimiter.Instance;
        int taskCount = 100;
        int executionCount = 0;

        // Act
        var tasks = Enumerable.Range(0, taskCount)
            .Select(async _ =>
            {
                using var lease = await limiter.AcquireAsync(10, TestContext.CancellationToken);
                _ = Interlocked.Increment(ref executionCount);
            });

        await Task.WhenAll(tasks);

        // Assert
        _ = executionCount.Should().Be(taskCount);
    }

    [TestMethod]
    public void Can_create_new_instance_separate_from_singleton()
    {
        // Arrange & Act
        var instance1 = NoLimitRateLimiter.Instance;
        var instance2 = new NoLimitRateLimiter();

        // Assert: they should be different instances but behave identically
        _ = instance1.Should().NotBeSameAs(instance2);
        _ = instance1.IdleDuration.Should().Be(instance2.IdleDuration);
        _ = instance1.GetStatistics().Should().Be(instance2.GetStatistics());
    }
}
