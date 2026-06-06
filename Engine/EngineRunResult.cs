namespace Kafadanat.Contracts;

public sealed record CriterionWeight(string Key, int Rank, string Direction, double Weight);

public sealed record SawAlgorithmResult(
    string Algorithm,
    IReadOnlyList<SawRankedAlternative> Ranking);

public sealed record SawRankedAlternative(
    string AlternativeId,
    int Position,
    double Score,
    double Percent,
    IReadOnlyList<CriterionContribution> Breakdown);

public sealed record CriterionContribution(
    string Key,
    double Normalized,
    double Weight,
    double Weighted,
    double SharePercent);

public sealed record TopsisAlgorithmResult(
    string Algorithm,
    IReadOnlyDictionary<string, double> IdealPositive,
    IReadOnlyDictionary<string, double> IdealNegative,
    IReadOnlyList<TopsisRankedAlternative> Ranking);

public sealed record TopsisRankedAlternative(
    string AlternativeId,
    int Position,
    double SPlus,
    double SMinus,
    double Closeness,
    double Percent);

public sealed record RankingComparison(
    double ExactAgreementPercent,
    double WithinOneAgreementPercent,
    IReadOnlyList<AlternativeComparison> PerAlternative);

public sealed record AlternativeComparison(
    string AlternativeId,
    int SawRank,
    int TopsisRank,
    int Diff);
