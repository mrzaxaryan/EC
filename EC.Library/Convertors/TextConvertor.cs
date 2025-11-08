using EC.Library.Core;
using System.Text;

namespace EC.Library.Convertors;

public class TextConvertor(EncodingMapper encodingMap) 
{
    public Action<double>? OnProgress { get; set; }

    public string Convert(string text, EncodingType encodingType)
    {
        double progressMaximum =100;

        var stringBuilder = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            char input = text[i];

            if (!encodingMap.TryConvert(input, encodingType, out var converted))
                converted = input;

            stringBuilder.Append(converted);

            OnProgress?.Invoke((i + 1) * progressMaximum / text.Length);
        }

        return stringBuilder.ToString();
    }
}
