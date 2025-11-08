using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

namespace EC.Library.Core;

public enum EncodingType
{
    ANSIToUnicode = 0,
    UnicodeToANSI = 1
}
