namespace MAVN.Service.Credentials.Domain.Enums
{
    public enum PasswordResetErrorCodes
    {
        None,
        ThereIsNoIdentifierForThisCustomer,
        ReachedMaximumRequestForPeriod,
        IdentifierMismatch,
        ProvidedIdentifierHasExpired,
        CustomerDoesNotExist
    }
}
