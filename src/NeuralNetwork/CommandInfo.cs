// <copyright file="CommandInfo.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace NeuralNetwork;

public enum CommandType
{
    None,
    Invalid,
    Help,
    Clear,
    PrintImage,
    RecognizeImage,
    TrainNetwork,
    SaveNetwork,
    LoadNetwork,
    Quit,
}

public class CommandInfo
{
    private static readonly CommandInfo None = new() { Command = CommandType.None };
    private static readonly CommandInfo Quit = new() { Command = CommandType.Quit };
    private static readonly CommandInfo Clear = new() { Command = CommandType.Clear };
    private static readonly CommandInfo Help = new() { Command = CommandType.Help };
    private static readonly CommandInfo Invalid = new() { Command = CommandType.Invalid };

    public required CommandType Command { get; init; }

    public List<object>? Arguments { get; init; }

    public static CommandInfo Parse(string? text)
    {
        if(text == null)
        {
            return None;
        }
        var command = text.Trim().Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        if (command.Length >= 1)
        {
            switch (command[0].ToUpper())
            {
                case "C":
                    return Clear;
                case "Q":
                    return Quit;
                case "H":
                    return Help;
                case "P":
                    if (command.Length == 1)
                    {
                        return new CommandInfo { Command = CommandType.PrintImage };
                    }
                    else if (command.Length == 2)
                    {
                        if (int.TryParse(command[1], out var value))
                        {
                            return new CommandInfo { Command = CommandType.PrintImage, Arguments = [value] };
                        }
                    }
                    return Invalid;
                case "R":
                    if(command.Length == 1)
                    {
                        return new CommandInfo { Command = CommandType.RecognizeImage };
                    }
                    else if (command.Length == 2)
                    {
                        if (int.TryParse(command[1], out var value))
                        {
                            return new CommandInfo { Command = CommandType.RecognizeImage, Arguments = [value] };
                        }
                    }
                    return Invalid;
                case "T":
                    if (command.Length == 1)
                    {
                        return new CommandInfo { Command = CommandType.TrainNetwork };
                    }
                    else if (command.Length == 2)
                    {
                        if (int.TryParse(command[1], out var value))
                        {
                            return new CommandInfo { Command = CommandType.TrainNetwork, Arguments = [value] };
                        }
                    }
                    return Invalid;
                default:
                    return Invalid;
            }
        }
        return None;
    }
}
