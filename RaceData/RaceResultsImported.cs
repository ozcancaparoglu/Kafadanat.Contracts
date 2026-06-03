namespace Kafadanat.Contracts;

// Published once per race when finishing order is confirmed.
// Results contains only horses that finished (not scratched).
public sealed record RaceResultsImported(
    Guid RaceId,
    DateTimeOffset FinishedAtUtc,
    IReadOnlyList<HorseResult> Results);

public sealed record HorseResult(int HorseNo, int FinishPosition);