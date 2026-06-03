namespace Kafadanat.Contracts;

// Published once per race on first card import.
// PostTime is the UTC betting-close / start instant; consumers use it as the admission cutoff.
public sealed record RaceDayImported(
    Guid RaceId,
    Guid CityId,
    string CityName,
    DateOnly RaceDate,
    int RaceNo,
    DateTimeOffset? PostTime);