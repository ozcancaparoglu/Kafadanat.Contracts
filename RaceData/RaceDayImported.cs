namespace Kafadanat.Contracts;

public sealed record RaceDayImported(
    DateOnly RaceDate,
    IReadOnlyList<Guid> RaceIds);