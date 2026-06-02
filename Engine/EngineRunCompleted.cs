namespace Kafadanat.Contracts;

public sealed record EngineRunCompleted(
    Guid RunId,
    IReadOnlyList<string> Ranking,
    IReadOnlyDictionary<string, decimal> Scores);