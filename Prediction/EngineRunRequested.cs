namespace Kafadanat.Contracts;

public sealed record EngineRunRequested(
    Guid RunId,
    IReadOnlyList<CriterionInput> Criteria,
    IReadOnlyList<string> Alternatives,
    decimal[][] Matrix);
