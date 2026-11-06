namespace Kafadanat.Contracts;

/// <summary>
/// Published by Auth when an account is deleted, by the user or an admin. Final: the identity is gone and
/// will never sign in again; a person who registers again gets a new UserId.
/// </summary>
/// <param name="UserId">The Keycloak user id — the same id other services receive as the token subject.</param>
public sealed record UserDeleted(
    Guid UserId,
    DateTimeOffset DeletedAt);
