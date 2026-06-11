#nullable enable

using System.CommandLine;

namespace Pruna.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreatePredictionCommandApiCommand.Create());
                         command.Subcommands.Add(GetFileCommandApiCommand.Create());
                         command.Subcommands.Add(GetPredictionDeliveryCommandApiCommand.Create());
                         command.Subcommands.Add(GetPredictionStatusCommandApiCommand.Create());
                         command.Subcommands.Add(UploadFileCommandApiCommand.Create());
        return command;
    }
}