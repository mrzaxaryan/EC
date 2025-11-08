namespace EC.Library.Core;

public class EncodingMapper
{
    private Dictionary<char, char> AnsiToUnicode { get; } = [];
    private Dictionary<char, char> UnicodeToAnsi { get; } = [];

    public int Count => AnsiToUnicode.Count;

    public EncodingMapper(char[] ansi, char[] unicode)
    {
        if (ansi.Length != unicode.Length)
            throw new ArgumentException("ANSI and Unicode arrays must have the same length.");

        for (int i = 0; i < ansi.Length; i++)
        {
            AnsiToUnicode[ansi[i]] = unicode[i];
            UnicodeToAnsi[unicode[i]] = ansi[i];
        }
    }

    public bool TryConvert(char input, EncodingType encodingType, out char output)
    {
        return encodingType switch
        {
            EncodingType.ANSIToUnicode => AnsiToUnicode.TryGetValue(input, out output),
            EncodingType.UnicodeToANSI => UnicodeToAnsi.TryGetValue(input, out output),
            _ => throw new ArgumentException(null, nameof(encodingType)),
        };
    }
    public static EncodingMapper FromFile(string filePath)
    {
        var ansi = new List<char>();
        var unicode = new List<char>();

        foreach (var rawLine in File.ReadLines(filePath))
        {
            var line = rawLine.Trim();

            if (string.IsNullOrEmpty(line) || line.StartsWith("#"))
                continue;

            int eq = line.IndexOf('=');
            if (eq <= 0 || eq == line.Length - 1)
                continue; // skip malformed lines

            var left = line[..eq].Trim();
            var right = line[(eq + 1)..].Trim();

            if (left.Length == 0 || right.Length == 0)
                continue;

            ansi.Add(left[0]);
            unicode.Add(right[0]);
        }

        return new EncodingMapper([.. ansi], [.. unicode]);
    }
}
