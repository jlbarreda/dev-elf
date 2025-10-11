using System.Numerics;
using DevElf.ArgumentValidation;

namespace DevElf;

/// <summary>
/// Generates numbers in a round-robin fashion between a start and end value.
/// </summary>
/// <typeparam name="T">A numeric type implementing <see cref="INumber{T}"/> and <see cref="IComparable{T}"/>.</typeparam>
public class RoundRobinNumberGenerator<T> : IRoundRobinGenerator<T>
    where T : INumber<T>, IComparable<T>
{
    private readonly Lock syncRoot = new();
    private readonly T start;
    private readonly T end;

    private T last;

    /// <summary>
    /// Initializes a new instance of the <see cref="RoundRobinNumberGenerator{T}"/> class.
    /// </summary>
    /// <param name="start">The starting value of the sequence.</param>
    /// <param name="end">The ending value of the sequence.</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="start"/> is greater than <paramref name="end"/>.</exception>
    public RoundRobinNumberGenerator(T start, T end)
    {
        start.ThrowIfGreaterThan(end);

        this.start = start;
        this.end = end;
        this.last = end;
    }

    /// <summary>
    /// Gets the next value in the round-robin sequence.
    /// </summary>
    /// <returns>The next value in the sequence.</returns>
    public T NextValue()
    {
        lock (this.syncRoot)
        {
            if (this.start == this.end)
            {
                return this.start;
            }

            if (this.last >= this.end)
            {
                this.last = this.start;

                return this.last;
            }

            return ++this.last;
        }
    }
}
