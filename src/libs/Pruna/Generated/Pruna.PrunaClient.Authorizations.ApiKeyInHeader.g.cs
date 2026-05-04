
#nullable enable

namespace Pruna
{
    public sealed partial class PrunaClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "apikey")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Pruna.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyApikey",
                Location = "Header",
                Name = "apikey",
                Value = apiKey,
            });
        }
    }
}