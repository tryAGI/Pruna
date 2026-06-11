#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Pruna.CLI.Commands;

internal static partial class CreatePredictionCommandApiCommand
{
    private static Option<global::Pruna.ModelId> Model { get; } = new(
        name: @"--model")
    {
        Description = @"",
        Required = true,
    };

    private static Option<bool?> TrySync { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--try-sync",
        description: @"");

    private static Option<global::Pruna.PredictionInput> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Pruna.Prediction value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Pruna.Prediction value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-prediction", @"Create a prediction for a Pruna model.");
                        command.Options.Add(Model);
                        command.Options.Add(TrySync);
                        command.Options.Add(InputOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var model = parseResult.GetRequiredValue(Model);
                        var trySync = parseResult.GetValue(TrySync);
                        var input = parseResult.GetRequiredValue(InputOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreatePredictionAsync(
                                    model: model,
                                    trySync: trySync,
                                    input: input,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Pruna.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}