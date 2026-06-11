<div class="docs-hero">
  <h1>Pruna</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Pruna generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/Pruna/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/Pruna"></a>
    <a href="https://github.com/tryAGI/Pruna/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Pruna/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Pruna/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Pruna"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://example.com/pruna-openapi.yaml">Pruna's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Pruna;

using var client = new PrunaClient(apiKey);
```

### CLI

```bash
dotnet tool install --global Pruna.CLI --prerelease
pruna api --help
```

<!-- EXAMPLES:START -->
### P-Video
Create a Pruna P-Video text-to-video prediction.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Pruna/issues">tryAGI/Pruna</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Pruna/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
