namespace Kafadanat.Contracts;

public static class RoutingKeys
{
    public const string RaceDayImported      = "racedata.imported";
    public const string RaceResultsImported  = "racedata.results.imported";
    public const string EngineRunRequested   = "prediction.run.requested";
    public const string EngineRunCompleted   = "prediction.run.completed";
    public const string RunSettled           = "wallet.run.settled";
    public const string RunRefunded          = "wallet.run.refunded";
    public const string EngineRunFailed      = "prediction.run.failed";
    public const string PredictionReady      = "prediction.ready";
    public const string UserDeleted          = "wallet.user.deleted";
}