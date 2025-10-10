using DevElf.ArgumentValidation;

namespace DevElf;

/// <summary>
/// A <see cref="TimeProvider"/> that always returns a fixed point in time.
/// Useful for tests and deterministic time-dependent logic.
/// </summary>
public sealed class FrozenTimeProvider : TimeProvider
{
    private readonly DateTimeOffset _utcNow;

    /// <summary>
    /// Creates a new instance that will always return the provided instant in UTC.
    /// The provided <see cref="DateTimeOffset"/> is converted to UTC internally.
    /// </summary>
    /// <param name="now">The instant to freeze.</param>
    public FrozenTimeProvider(DateTimeOffset now)
        => this._utcNow = now.ToUniversalTime();

    /// <summary>
    /// Creates a new instance that is frozen to the current value of the
    /// specified <see cref="TimeProvider"/>.
    /// </summary>
    /// <param name="timeProvider">The source time provider used to obtain the instant to freeze.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="timeProvider"/> is <see langword="null"/>.</exception>
    public FrozenTimeProvider(TimeProvider timeProvider)
    {
        timeProvider.ThrowIfNull();

        this._utcNow = timeProvider.GetUtcNow();
    }

    /// <summary>
    /// Returns the frozen instant as a UTC <see cref="DateTimeOffset"/>.
    /// </summary>
    /// <returns>The frozen UTC instant.</returns>
    public override DateTimeOffset GetUtcNow() => this._utcNow;
}
