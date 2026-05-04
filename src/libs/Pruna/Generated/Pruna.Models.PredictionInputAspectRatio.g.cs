
#nullable enable

namespace Pruna
{
    /// <summary>
    /// 
    /// </summary>
    public enum PredictionInputAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionInputAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionInputAspectRatio value)
        {
            return value switch
            {
                PredictionInputAspectRatio.x16_9 => "16:9",
                PredictionInputAspectRatio.x1_1 => "1:1",
                PredictionInputAspectRatio.x2_3 => "2:3",
                PredictionInputAspectRatio.x3_2 => "3:2",
                PredictionInputAspectRatio.x3_4 => "3:4",
                PredictionInputAspectRatio.x4_3 => "4:3",
                PredictionInputAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionInputAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => PredictionInputAspectRatio.x16_9,
                "1:1" => PredictionInputAspectRatio.x1_1,
                "2:3" => PredictionInputAspectRatio.x2_3,
                "3:2" => PredictionInputAspectRatio.x3_2,
                "3:4" => PredictionInputAspectRatio.x3_4,
                "4:3" => PredictionInputAspectRatio.x4_3,
                "9:16" => PredictionInputAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}