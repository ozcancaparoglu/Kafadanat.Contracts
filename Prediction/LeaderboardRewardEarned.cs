namespace Kafadanat.Contracts;

/// <summary>
/// Published by Prediction when an admin approves a leaderboard result for a shared motor's owner. Wallet decides
/// the amount from its own configuration (kind, then rank) and credits it once: a repeat of the same
/// (Kind, Period, Rank) is a no-op, and a missing or zero amount pays nothing.
/// </summary>
/// <param name="UserId">The Keycloak user id of the motor's owner.</param>
/// <param name="Kind">"WeeklyMostUsedMotor" or "MonthlyMotorChampion".</param>
/// <param name="Period">The period key: the Monday of the week ("2026-11-23") or the month ("2026-11").</param>
/// <param name="Rank">1 for the winner, 2 and 3 for the runners-up of a month.</param>
/// <param name="EarnedAt">When the admin approved it.</param>
public sealed record LeaderboardRewardEarned(
    Guid UserId,
    string Kind,
    string Period,
    int Rank,
    DateTimeOffset EarnedAt);
