/*
order: 10
title: P-Video
slug: p-video

Create a Pruna P-Video text-to-video prediction.
*/

namespace Pruna.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_PVideo()
    {
        using var client = GetAuthenticatedClient();

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

        response.Id.Should().NotBeNullOrWhiteSpace();
    }
}
