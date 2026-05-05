#nullable enable

namespace Pruna
{
    public partial interface IPrunaClient
    {
        /// <summary>
        /// Upload a file for prediction inputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pruna.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.FileObject> UploadFileAsync(

            global::Pruna.UploadFileRequest request,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file for prediction inputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pruna.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.AutoSDKHttpResponse<global::Pruna.FileObject>> UploadFileAsResponseAsync(

            global::Pruna.UploadFileRequest request,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file for prediction inputs.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="contentname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.FileObject> UploadFileAsync(
            byte[] content,
            string contentname,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file for prediction inputs.
        /// </summary>
        /// <param name="content">
        /// The stream to send as the multipart 'content' file part.
        /// </param>
        /// <param name="contentname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pruna.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.FileObject> UploadFileAsync(
            global::System.IO.Stream content,
            string contentname,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file for prediction inputs.
        /// </summary>
        /// <param name="content">
        /// The stream to send as the multipart 'content' file part.
        /// </param>
        /// <param name="contentname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pruna.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pruna.AutoSDKHttpResponse<global::Pruna.FileObject>> UploadFileAsResponseAsync(
            global::System.IO.Stream content,
            string contentname,
            global::Pruna.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}