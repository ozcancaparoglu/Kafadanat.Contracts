namespace Kafadanat.Contracts;

/// <summary>
/// Published by Auth when a user sets or changes their public username. Prediction keeps a snapshot of it on
/// the user's shared motors. Idempotent for consumers: apply Username as the current value.
/// </summary>
/// <param name="UserId">The Keycloak user id, the same id other services receive as the token subject.</param>
/// <param name="Username">The new public username (lower-case, already validated and unique).</param>
public sealed record UsernameChanged(
    Guid UserId,
    string Username,
    DateTimeOffset ChangedAt);
