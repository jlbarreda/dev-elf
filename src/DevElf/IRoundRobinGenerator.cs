namespace DevElf;

/// <summary>
/// Defines a generator that produces values in a round-robin sequence.
/// </summary>
/// <typeparam name="T">A type that implements <see cref="IComparable{T}"/>.</typeparam>
public interface IRoundRobinGenerator<T>
    where T : IComparable<T>
{
    /// <summary>
    /// Gets the next value in the round-robin sequence.
    /// </summary>
    /// <returns>The next value in the sequence.</returns>
    T NextValue();
}
