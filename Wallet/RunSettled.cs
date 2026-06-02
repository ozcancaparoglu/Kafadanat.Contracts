namespace Kafadanat.Contracts;

public sealed record RunSettled(
    Guid RunId,
    Guid UserId,
    Guid ReservationId);