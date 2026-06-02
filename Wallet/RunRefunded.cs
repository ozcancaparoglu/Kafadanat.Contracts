namespace Kafadanat.Contracts;

public sealed record RunRefunded(
    Guid RunId,
    Guid UserId,
    Guid ReservationId,
    string Reason);