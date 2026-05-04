
#nullable enable

namespace Pruna
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelId
    {
        /// <summary>
        /// 
        /// </summary>
        FluxDev,
        /// <summary>
        /// 
        /// </summary>
        FluxDevLora,
        /// <summary>
        /// 
        /// </summary>
        PImage,
        /// <summary>
        /// 
        /// </summary>
        PImageEdit,
        /// <summary>
        /// 
        /// </summary>
        PImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        PVideo,
        /// <summary>
        /// 
        /// </summary>
        QwenImage,
        /// <summary>
        /// 
        /// </summary>
        QwenImageEditPlus,
        /// <summary>
        /// 
        /// </summary>
        Vace,
        /// <summary>
        /// 
        /// </summary>
        WanI2v,
        /// <summary>
        /// 
        /// </summary>
        WanImageSmall,
        /// <summary>
        /// 
        /// </summary>
        WanT2v,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelId value)
        {
            return value switch
            {
                ModelId.FluxDev => "flux-dev",
                ModelId.FluxDevLora => "flux-dev-lora",
                ModelId.PImage => "p-image",
                ModelId.PImageEdit => "p-image-edit",
                ModelId.PImageUpscale => "p-image-upscale",
                ModelId.PVideo => "p-video",
                ModelId.QwenImage => "qwen-image",
                ModelId.QwenImageEditPlus => "qwen-image-edit-plus",
                ModelId.Vace => "vace",
                ModelId.WanI2v => "wan-i2v",
                ModelId.WanImageSmall => "wan-image-small",
                ModelId.WanT2v => "wan-t2v",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelId? ToEnum(string value)
        {
            return value switch
            {
                "flux-dev" => ModelId.FluxDev,
                "flux-dev-lora" => ModelId.FluxDevLora,
                "p-image" => ModelId.PImage,
                "p-image-edit" => ModelId.PImageEdit,
                "p-image-upscale" => ModelId.PImageUpscale,
                "p-video" => ModelId.PVideo,
                "qwen-image" => ModelId.QwenImage,
                "qwen-image-edit-plus" => ModelId.QwenImageEditPlus,
                "vace" => ModelId.Vace,
                "wan-i2v" => ModelId.WanI2v,
                "wan-image-small" => ModelId.WanImageSmall,
                "wan-t2v" => ModelId.WanT2v,
                _ => null,
            };
        }
    }
}