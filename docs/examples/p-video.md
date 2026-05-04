# P-Video

Create a Pruna P-Video text-to-video prediction.

This example assumes `using Pruna;` is in scope and `apiKey` contains your Pruna API key.

```csharp
using var client = new PrunaClient(apiKey);

var response = await client.CreatePredictionAsync(
    model: ModelId.PVideo,
    trySync: false,
    request: new CreatePredictionRequest
    {
        Input = new PredictionInput
        {
            Prompt = "A sports car drifting through a neon-lit city at night, cinematic aerial shot.",
            Duration = 5,
            Resolution = PredictionInputResolution.x720p,
            AspectRatio = PredictionInputAspectRatio.x16_9,
        },
    });
```