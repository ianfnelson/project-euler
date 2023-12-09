using System.Security.Cryptography;
using System.Text;

namespace EulerLib.Extensions;

public static class Md5Extensions
{
    public static string ToMd5Hash(this string input)
    {
        using var md5Hash = MD5.Create();
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        return string.Concat(data.Select(t => t.ToString("x2")));
    }

    public static bool VerifyMd5Hash(this string input, string hash)
    {
        var actualHash = input.ToMd5Hash();
        return actualHash.Equals(hash, StringComparison.OrdinalIgnoreCase);
    }
}