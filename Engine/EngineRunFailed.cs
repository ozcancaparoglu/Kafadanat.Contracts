namespace Kafadanat.Contracts;

public sealed record EngineRunFailed(Guid RunId, string Code, string Description);
