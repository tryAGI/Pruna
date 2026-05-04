
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Pruna
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Pruna.JsonConverters.ModelIdJsonConverter),

            typeof(global::Pruna.JsonConverters.ModelIdNullableJsonConverter),

            typeof(global::Pruna.JsonConverters.PredictionInputResolutionJsonConverter),

            typeof(global::Pruna.JsonConverters.PredictionInputResolutionNullableJsonConverter),

            typeof(global::Pruna.JsonConverters.PredictionInputAspectRatioJsonConverter),

            typeof(global::Pruna.JsonConverters.PredictionInputAspectRatioNullableJsonConverter),

            typeof(global::Pruna.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.ModelId), TypeInfoPropertyName = "ModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.CreatePredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.PredictionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.PredictionInputResolution), TypeInfoPropertyName = "PredictionInputResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.PredictionInputAspectRatio), TypeInfoPropertyName = "PredictionInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.FileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pruna.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}