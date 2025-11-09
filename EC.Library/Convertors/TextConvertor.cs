using EC.Library.Core;
using System.Text;

namespace EC.Library.Convertors;

public class TextConvertor(EncodingMapper encodingMap)
{

    public string Convert(string text, EncodingType encodingType)
    {
        var result = new char[text.Length];

        Parallel.For(0, text.Length, i =>
        {
            char input = text[i];
            result[i] = encodingMap.TryConvert(input, encodingType, out var converted) ? converted : input;
        });

        return new string(result);
    }
}
