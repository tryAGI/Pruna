#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Pruna.CLI.Commands;

internal static partial class GetPredictionDeliveryCommandApiCommand
{
    private static Argument<string> DeliveryPath { get; } = new(
        name: @"delivery-path")
    {
        Description = @"",
    };

    public static Command Create()
    {
        var command = new Command(@"get-prediction-delivery", @"Download or retrieve a generated prediction artifact.");
                        command.Arguments.Add(DeliveryPath);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var deliveryPath = parseResult.GetRequiredValue(DeliveryPath);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetPredictionDeliveryAsync(
                                    deliveryPath: deliveryPath,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}