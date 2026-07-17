using System.Security.Cryptography;

namespace EulerLib.Data;

/// <summary>
/// DELIBERATELY INSECURE - added only to validate GitHub CodeQL scanning.
/// Uses broken cryptography that the CodeQL default query suite reports.
/// Do not merge.
/// </summary>
public class WeakCrypto
{
    // CodeQL: cs/ecb-encryption - AES used in insecure ECB mode.
    public byte[] EncryptEcb(byte[] data, byte[] key)
    {
        using var aes = Aes.Create();
        aes.Key = key;
        aes.Mode = CipherMode.ECB;
        aes.Padding = PaddingMode.PKCS7;
        using var encryptor = aes.CreateEncryptor();
        return encryptor.TransformFinalBlock(data, 0, data.Length);
    }

    // CodeQL: cs/weak-encryption + cs/insufficient-key-size - DES (56-bit).
    public byte[] EncryptDes(byte[] data, byte[] key, byte[] iv)
    {
        using var des = DES.Create();
        des.Key = key;
        des.IV = iv;
        using var encryptor = des.CreateEncryptor();
        return encryptor.TransformFinalBlock(data, 0, data.Length);
    }

    // CodeQL: cs/insufficient-key-size + cs/inadequate-rsa-padding - 1024-bit
    // RSA with PKCS#1 v1.5 padding.
    public byte[] EncryptRsa(byte[] data)
    {
        using var rsa = RSA.Create(1024);
        return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
    }
}
