#nullable enable

namespace Pruna
{
    public partial interface IPrunaClient
    {
        /// <summary>
        /// Create a prediction for a Pruna model.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trySync"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pruna.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.Prediction> CreatePredictionAsync(
            global::Pruna.ModelId model,

            global::Pruna.CreatePredictionRequest request,
            bool? trySync = default,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a prediction for a Pruna model.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trySync"></param>
        /// <param name="input"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.Prediction> CreatePredictionAsync(
            global::Pruna.ModelId model,
            global::Pruna.PredictionInput input,
            bool? trySync = default,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}