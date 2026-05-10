
#nullable enable

namespace Pruna
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pruna.JsonConverters.PredictionInputResolutionJsonConverter))]
        public global::Pruna.PredictionInputResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pruna.JsonConverters.PredictionInputAspectRatioJsonConverter))]
        public global::Pruna.PredictionInputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_audio")]
        public bool? SaveAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_frame_image")]
        public string? LastFrameImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionInput" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="duration"></param>
        /// <param name="resolution"></param>
        /// <param name="fps"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="seed"></param>
        /// <param name="draft"></param>
        /// <param name="saveAudio"></param>
        /// <param name="lastFrameImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionInput(
            string? prompt,
            string? image,
            string? audio,
            int? duration,
            global::Pruna.PredictionInputResolution? resolution,
            int? fps,
            global::Pruna.PredictionInputAspectRatio? aspectRatio,
            long? seed,
            bool? draft,
            bool? saveAudio,
            string? lastFrameImage)
        {
            this.Prompt = prompt;
            this.Image = image;
            this.Audio = audio;
            this.Duration = duration;
            this.Resolution = resolution;
            this.Fps = fps;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
            this.Draft = draft;
            this.SaveAudio = saveAudio;
            this.LastFrameImage = lastFrameImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionInput" /> class.
        /// </summary>
        public PredictionInput()
        {
        }

    }
}