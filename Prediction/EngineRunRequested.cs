namespace Kafadanat.Contracts;

public sealed record EngineRunRequested(
    Guid RunId,
    string Algorithm,
    IReadOnlyList<CriterionInput> Criteria,
    IReadOnlyList<string> Alternatives,
    decimal[][] Matrix);