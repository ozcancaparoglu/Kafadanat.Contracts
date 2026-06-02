namespace Kafadanat.Contracts;

public sealed record PredictionReady(
    Guid RunId,
    Guid UserId,
    bool Succeeded);