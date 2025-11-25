using System;
using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;
using EC.CLI;
using EC.Library.Converters;
using EC.Library.Core;
using Xunit;

namespace EC.CLI.Tests;

public class ProgramTests
{
    [Fact]
    public void ParseCommandLine_ReturnsError_WhenMapFileMissing()
    {
        var args = new[] { "--type", "0", "--file", "nofile.txt" };
        int result = Program.ParseCommandLine(args);
        Assert.Equal(1, result);
    }

    [Fact]
    public void ParseCommandLine_ReturnsError_WhenFileAndDirectoryMissing()
    {
        var tempMap = Path.GetTempFileName();
        var args = new[] { "--type", "0", "--map", tempMap };
        int result = Program.ParseCommandLine(args);
        Assert.Equal(1, result);
        File.Delete(tempMap);
    }

    [Fact]
    public void ProcessFile_ThrowsNotSupportedException_ForUnsupportedExtension()
    {
        var tempFile = Path.GetTempFileName() + ".unsupported";
        File.WriteAllText(tempFile, "test");
        var encodingMapper = new EncodingMapper(Array.Empty<char>(), Array.Empty<char>());
        var wordConverter = new WordConverter( new TextConverter(encodingMapper), true);
        var excelConverter = new ExcelConverter( new TextConverter(encodingMapper), true);
        Assert.Throws<NotSupportedException>(() =>
            Program.ProcessFile(new FileInfo(tempFile), EncodingType.ANSIToUnicode, "Arial", wordConverter, excelConverter));
        File.Delete(tempFile);
    }

    [Fact]
    public void ProcessDirectory_ProcessesSupportedFiles()
    {
        var tempDir = Directory.CreateTempSubdirectory();
        var txtFile = Path.Combine(tempDir.FullName, "file.txt");
        File.WriteAllText(txtFile, "test");
        var encodingMapper = new EncodingMapper(Array.Empty<char>(), Array.Empty<char>());
        var wordConverter = new WordConverter(new TextConverter(encodingMapper), true);
        var excelConverter = new ExcelConverter(new TextConverter(encodingMapper), true);
        Program.ProcessDirectory(new DirectoryInfo(tempDir.FullName), EncodingType.ANSIToUnicode, "Arial", wordConverter, excelConverter);
        Assert.True(File.Exists(txtFile));
        tempDir.Delete(true);
    }
}