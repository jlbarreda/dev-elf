using System.Threading.RateLimiting;
using AwesomeAssertions;
using DevElf.Threading.RateLimiting;

namespace DevElf.Tests.Threading.RateLimiting;

[TestClass]
public class RateLimiterExtensionsTests
{
    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    public async Task ApplyToAsync_action_throws_ArgumentNullException_when_limiter_is_null()
    {
        // Arrange
        RateLimiter limiter = null!;
        Func<CancellationToken, Task> action = _ => Task.CompletedTask;

        // Act
        var act = async () => await limiter.ApplyToAsync(action, cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<ArgumentNullException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_throws_ArgumentNullException_when_action_is_null()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        Func<CancellationToken, Task> action = null!;

        // Act
        var act = async () => await limiter.ApplyToAsync(action, cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<ArgumentNullException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_executes_action_when_permits_are_available()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 10,
            QueueLimit = 0
        });

        bool actionExecuted = false;

        // Act
        await limiter.ApplyToAsync(
            _ =>
            {
                actionExecuted = true;

                return Task.CompletedTask;
            },
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = actionExecuted.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_acquires_and_releases_permit()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // Act
        await limiter.ApplyToAsync(
            _ => Task.CompletedTask,
            cancellationToken: TestContext.CancellationToken);

        // Assert: after execution, permit should be available again
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_releases_permit_even_when_action_throws()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // Act
        var act = async () => await limiter.ApplyToAsync(
            _ => throw new InvalidOperationException("Test exception"),
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<InvalidOperationException>();

        // verify permit is available again
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_waits_and_retries_when_permits_not_immediately_available()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = blockingLease.IsAcquired.Should().BeTrue();

        bool actionExecuted = false;
        var actionTask = Task.Run(
            async () => await limiter.ApplyToAsync(
                _ =>
                {
                    actionExecuted = true;

                    return Task.CompletedTask;
                },
                idleTime: TimeSpan.FromMilliseconds(10),
                cancellationToken: TestContext.CancellationToken),
            TestContext.CancellationToken);

        // wait a bit to ensure the action is waiting
        await Task.Delay(50, TestContext.CancellationToken);
        _ = actionExecuted.Should().BeFalse();

        // Act: release the permit
        blockingLease.Dispose();

        // wait for action to complete
        await actionTask;

        // Assert
        _ = actionExecuted.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_respects_permitCount_parameter()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 5,
            QueueLimit = 0
        });

        int permitCount = 3;
        bool canAcquireRemaining = false;

        // Act
        await limiter.ApplyToAsync(
            async ct =>
            {
                // while inside the action with 3 permits acquired,
                // we should be able to acquire the 2 remaining permits
                using var remainingLease = await limiter.AcquireAsync(2, ct);
                canAcquireRemaining = remainingLease.IsAcquired;
            },
            permitCount: permitCount,
            cancellationToken: TestContext.CancellationToken);

        // Assert: we should have been able to acquire the remaining 2 permits
        _ = canAcquireRemaining.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_respects_cancellationToken()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        using var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        using var cts = new CancellationTokenSource();

        // Act
        var actionTask = Task.Run(
            async () => await limiter.ApplyToAsync(
                _ => Task.CompletedTask,
                idleTime: TimeSpan.FromMilliseconds(10),
                cancellationToken: cts.Token),
            TestContext.CancellationToken);

        // wait a bit to ensure we're waiting for permits
        await Task.Delay(50, TestContext.CancellationToken);

        await cts.CancelAsync();

        var act = async () => await actionTask;

        // Assert
        _ = await act.Should().ThrowAsync<OperationCanceledException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_throws_ArgumentNullException_when_limiter_is_null()
    {
        // Arrange
        RateLimiter limiter = null!;
        Func<CancellationToken, Task<int>> request = _ => Task.FromResult(42);

        // Act
        var act = async () => await limiter.ApplyToAsync(request, cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<ArgumentNullException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_throws_ArgumentNullException_when_request_is_null()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        Func<CancellationToken, Task<int>> request = null!;

        // Act
        var act = async () => await limiter.ApplyToAsync(request, cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<ArgumentNullException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_executes_request_and_returns_result_when_permits_are_available()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 10,
            QueueLimit = 0
        });

        int expectedResult = 42;

        // Act
        int result = await limiter.ApplyToAsync(
            _ => Task.FromResult(expectedResult),
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = result.Should().Be(expectedResult);
    }

    [TestMethod]
    public async Task ApplyToAsync_request_acquires_and_releases_permit()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // Act
        _ = await limiter.ApplyToAsync(
            _ => Task.FromResult("result"),
            cancellationToken: TestContext.CancellationToken);

        // Assert: after execution, permit should be available again
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_releases_permit_even_when_request_throws()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // Act
        var act = async () => await limiter.ApplyToAsync<string>(
            _ => throw new InvalidOperationException("Test exception"),
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = await act.Should().ThrowAsync<InvalidOperationException>();

        // verify permit is available again
        using var lease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = lease.IsAcquired.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_waits_and_retries_when_permits_not_immediately_available()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);
        _ = blockingLease.IsAcquired.Should().BeTrue();

        bool requestExecuted = false;
        var requestTask = Task.Run(
            async () => await limiter.ApplyToAsync(
                _ =>
                {
                    requestExecuted = true;

                    return Task.FromResult(100);
                },
                idleTime: TimeSpan.FromMilliseconds(10),
                cancellationToken: TestContext.CancellationToken),
            TestContext.CancellationToken);

        // wait a bit to ensure the request is waiting
        await Task.Delay(50, TestContext.CancellationToken);
        _ = requestExecuted.Should().BeFalse();

        // Act: release the permit
        blockingLease.Dispose();

        // wait for request to complete
        int result = await requestTask;

        // Assert
        _ = requestExecuted.Should().BeTrue();
        _ = result.Should().Be(100);
    }

    [TestMethod]
    public async Task ApplyToAsync_request_respects_permitCount_parameter()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 5,
            QueueLimit = 0
        });

        int permitCount = 3;
        bool canAcquireRemaining = false;

        // Act
        string result = await limiter.ApplyToAsync(
            async ct =>
            {
                // while inside the request with 3 permits acquired,
                // we should be able to acquire the 2 remaining permits
                using var remainingLease = await limiter.AcquireAsync(2, ct);
                canAcquireRemaining = remainingLease.IsAcquired;

                return "success";
            },
            permitCount: permitCount,
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = result.Should().Be("success");
        _ = canAcquireRemaining.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_respects_cancellationToken()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        using var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        using var cts = new CancellationTokenSource();

        // Act
        var requestTask = Task.Run(
            async () => await limiter.ApplyToAsync(
                _ => Task.FromResult(42),
                idleTime: TimeSpan.FromMilliseconds(10),
                cancellationToken: cts.Token),
            TestContext.CancellationToken);

        // wait a bit to ensure we're waiting for permits
        await Task.Delay(50, TestContext.CancellationToken);

        await cts.CancelAsync();

        var act = async () => await requestTask;

        // Assert
        _ = await act.Should().ThrowAsync<OperationCanceledException>();
    }

    [TestMethod]
    public async Task ApplyToAsync_action_uses_custom_idleTime()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        using var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        var customIdleTime = TimeSpan.FromMilliseconds(100);
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        var actionTask = Task.Run(
            async () =>
            {
                await limiter.ApplyToAsync(
                    _ => Task.CompletedTask,
                    idleTime: customIdleTime,
                    cancellationToken: TestContext.CancellationToken);
            },
            TestContext.CancellationToken);

        // wait to ensure multiple retry attempts
        await Task.Delay(250, TestContext.CancellationToken);

        blockingLease.Dispose();
        await actionTask;

        stopwatch.Stop();

        // Assert: should have taken at least 2 idle periods
        _ = stopwatch.ElapsedMilliseconds.Should().BeGreaterThanOrEqualTo(200);
    }

    [TestMethod]
    public async Task ApplyToAsync_request_works_with_complex_return_types()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 10,
            QueueLimit = 0
        });

        var expectedList = new List<string> { "a", "b", "c" };

        // Act
        List<string> result = await limiter.ApplyToAsync(
            _ => Task.FromResult(expectedList),
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = result.Should().BeSameAs(expectedList);
    }

    [TestMethod]
    public async Task ApplyToAsync_action_uses_custom_timeProvider()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        using var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        var frozenTime = new DateTimeOffset(2024, 1, 1, 12, 0, 0, TimeSpan.Zero);
        var timeProvider = new FrozenTimeProvider(frozenTime);
        bool actionExecuted = false;

        var actionTask = Task.Run(
            async () =>
            {
                await limiter.ApplyToAsync(
                    _ =>
                    {
                        actionExecuted = true;

                        return Task.CompletedTask;
                    },
                    idleTime: TimeSpan.FromMilliseconds(100),
                    timeProvider: timeProvider,
                    cancellationToken: TestContext.CancellationToken);
            },
            TestContext.CancellationToken);

        // wait to ensure the action is waiting
        await Task.Delay(50, TestContext.CancellationToken);

        // Act: release the permit
        blockingLease.Dispose();
        await actionTask;

        // Assert
        _ = actionExecuted.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_uses_custom_timeProvider()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 1,
            QueueLimit = 0
        });

        // acquire the only permit
        using var blockingLease = await limiter.AcquireAsync(1, TestContext.CancellationToken);

        var frozenTime = new DateTimeOffset(2024, 1, 1, 12, 0, 0, TimeSpan.Zero);
        var timeProvider = new FrozenTimeProvider(frozenTime);

        var requestTask = Task.Run(
            async () => await limiter.ApplyToAsync(
                _ => Task.FromResult(42),
                idleTime: TimeSpan.FromMilliseconds(100),
                timeProvider: timeProvider,
                cancellationToken: TestContext.CancellationToken),
            TestContext.CancellationToken);

        // wait to ensure the request is waiting
        await Task.Delay(50, TestContext.CancellationToken);

        // Act: release the permit
        blockingLease.Dispose();
        int result = await requestTask;

        // Assert
        _ = result.Should().Be(42);
    }

    [TestMethod]
    public async Task ApplyToAsync_action_uses_System_timeProvider_when_null()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 10,
            QueueLimit = 0
        });

        bool actionExecuted = false;

        // Act: pass null for timeProvider, should use TimeProvider.System
        await limiter.ApplyToAsync(
            _ =>
            {
                actionExecuted = true;

                return Task.CompletedTask;
            },
            timeProvider: null,
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = actionExecuted.Should().BeTrue();
    }

    [TestMethod]
    public async Task ApplyToAsync_request_uses_System_timeProvider_when_null()
    {
        // Arrange
        using var limiter = new ConcurrencyLimiter(new ConcurrencyLimiterOptions
        {
            PermitLimit = 10,
            QueueLimit = 0
        });

        // Act: pass null for timeProvider, should use TimeProvider.System
        int result = await limiter.ApplyToAsync(
            _ => Task.FromResult(100),
            timeProvider: null,
            cancellationToken: TestContext.CancellationToken);

        // Assert
        _ = result.Should().Be(100);
    }
}
