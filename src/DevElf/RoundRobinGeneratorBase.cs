using DevElf.ArgumentValidation;

namespace DevElf;

/// <summary>
/// Provides a base implementation for round-robin generators using a comparer.
/// </summary>
/// <typeparam name="T">A type implementing <see cref="IComparable{T}"/>.</typeparam>
public abstract class RoundRobinGeneratorBase<T> : IRoundRobinGenerator<T>
    where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    private readonly Lock syncRoot = new();
    private readonly T start;
    private readonly T end;

    private T previous;

    /// <summary>
    /// Initializes a new instance of the <see cref="RoundRobinGeneratorBase{T}"/> class.
    /// </summary>
    /// <param name="start">The starting value of the sequence.</param>
    /// <param name="end">The ending value of the sequence.</param>
    /// <param name="comparer">The comparer to use for value comparison. If <see langword="null"/>, the default comparer is used.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="start"/> is greater than <paramref name="end"/>.</exception>
    protected RoundRobinGeneratorBase(T start, T end, IComparer<T>? comparer = null)
    {
        start.ThrowIfGreaterThan(end);

        this.comparer = comparer ?? Comparer<T>.Default;
        this.start = start;
        this.end = end;
        this.previous = end;
    }

    /// <summary>
    /// Gets the next value in the round-robin sequence.
    /// </summary>
    /// <returns>The next value in the sequence.</returns>
    public T NextValue()
    {
        lock (this.syncRoot)
        {
            if (this.comparer.Compare(this.start, this.end) == 0)
            {
                return this.start;
            }

            if (this.comparer.Compare(this.previous, this.end) >= 0)
            {
                this.previous = this.start;

                return this.previous;
            }

            return Increment(ref this.previous);
        }
    }

    /// <summary>
    /// Increments the value for the next round-robin step.
    /// </summary>
    /// <param name="value">The value to increment.</param>
    /// <returns>The incremented value.</returns>
    protected abstract T Increment(ref T value);
}
