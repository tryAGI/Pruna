#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Pruna.CLI.Commands;

internal static partial class UploadFileCommandApiCommand
{
    private static Option<byte[]> Content { get; } = new(
        name: @"--content")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Contentname { get; } = new(
        name: @"--contentname")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Pruna.FileObject value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Pruna.FileObject value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"upload-file", @"Upload a file for prediction inputs.");
                        command.Options.Add(Content);
                        command.Options.Add(Contentname);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var content = parseResult.GetRequiredValue(Content);
                        var contentname = parseResult.GetRequiredValue(Contentname);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.UploadFileAsync(
                                    content: content,
                                    contentname: contentname,
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