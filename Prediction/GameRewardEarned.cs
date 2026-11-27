namespace Kafadanat.Contracts;

/// <summary>
/// Published by Prediction when a user's pick wins a game (an exact top-3 in order). Prediction reports the
/// fact only; Wallet decides the amount and any caps. Wallet must treat PickId as the idempotency key.
/// </summary>
/// <param name="PickId">The winning pick; unique per user and race.</param>
/// <param name="Kind">The reward kind, e.g. "TopThreeExact". Wallet maps it to an amount.</param>
public sealed record GameRewardEarned(
    Guid PickId,
    Guid UserId,
    Guid RaceId,
    string Kind,
    DateTimeOffset EarnedAt);
