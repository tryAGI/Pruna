#nullable enable

namespace Pruna.JsonConverters
{
    /// <inheritdoc />
    public sealed class PredictionInputResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pruna.PredictionInputResolution>
    {
        /// <inheritdoc />
        public override global::Pruna.PredictionInputResolution Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Pruna.PredictionInputResolutionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Pruna.PredictionInputResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Pruna.PredictionInputResolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pruna.PredictionInputResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Pruna.PredictionInputResolutionExtensions.ToValueString(value));
        }
    }
}
