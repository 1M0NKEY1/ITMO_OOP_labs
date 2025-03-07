﻿using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Commands.FileCommands;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ParseCopyFileCommand : CommandHandlerBase
{
    private const string KeyWordFile = "file";
    private const string KeyWordCopy = "copy";
    protected override bool CanHandle(IList<string> parts)
    {
        return parts[0].Equals(KeyWordFile, StringComparison.Ordinal) &&
               parts[1].Equals(KeyWordCopy, StringComparison.Ordinal);
    }

    protected override ICommand? Process(IList<string> parts)
    {
        string sourcePath = parts[2];
        string destinationPath = parts[3];

        return new CopyFileCommand(sourcePath, destinationPath);
    }
}