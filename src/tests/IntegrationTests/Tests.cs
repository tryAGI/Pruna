namespace Pruna.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PrunaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PRUNA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PRUNA_API_KEY environment variable is not found.");

        var client = new PrunaClient(apiKey);
        
        return client;
    }
}
