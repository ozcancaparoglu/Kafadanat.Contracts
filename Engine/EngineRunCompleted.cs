namespace Kafadanat.Contracts;

public sealed record EngineRunCompleted(
    Guid RunId,
    IReadOnlyList<CriterionWeight> Weights,
    SawAlgorithmResult Saw,
    TopsisAlgorithmResult Topsis,
    RankingComparison Comparison);
