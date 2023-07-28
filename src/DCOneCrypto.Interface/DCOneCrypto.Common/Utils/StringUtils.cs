using System.Text;

namespace DCOneCrypto.Common.Utils;

public static class StringUtils
{
    public static string ToHex(this string utf8String)
    {
        return string.Concat(Encoding.UTF8.GetBytes(utf8String).Select(b => b.ToString("x2")));
    }

    public static string FromHex(this string hexString)
    {
        byte[] utf8Bytes = Enumerable.Range(0, hexString.Length / 2)
                                      .Select(i => Convert.ToByte(hexString.Substring(i * 2, 2), 16))
                                      .ToArray();
        return Encoding.UTF8.GetString(utf8Bytes);
    }
}