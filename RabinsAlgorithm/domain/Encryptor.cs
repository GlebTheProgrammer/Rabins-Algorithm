using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RabinsAlgorithm.domain
{
    internal static class Encryptor
    {
        public static BigInteger[]? encryptedText = null;
        public static void EncryptInput(byte[] bufferBytes, BigInteger b, BigInteger n)
        {
            encryptedText = new BigInteger[bufferBytes.Length];
            for (int i = 0; i < bufferBytes.Length; i++)
                encryptedText[i] = (BigInteger)bufferBytes[i]*((BigInteger)bufferBytes[i]+b) % n;
        }
    }
}
