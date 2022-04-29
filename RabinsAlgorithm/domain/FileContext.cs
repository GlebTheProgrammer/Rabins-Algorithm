using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RabinsAlgorithm.domain
{
    internal static class FileContext
    {
        public static byte[]? bufferByte = null;
        public static BigInteger[]? bufferDigit = null;

        // Считывает файл по байтам -> Выдаёт последовательность байт (актуально для "Чистых" файлов)
        internal static void TakeBytesFromPath(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(@$"{path}", FileMode.Open))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);

                    bufferByte = buffer;
                }
            }
            catch (Exception ex)
            {
                bufferByte = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Считывает файл по байтам -> Выдаёт последовательность чисел (актуально для зашифрованных методом "As Stream" файлов)
        internal static void TakeDigitsFromPathEncrypted(string path)
        {
            using (FileStream fstream = new FileStream(@$"{path}", FileMode.Open))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);

                bufferByte = buffer;
            }
            string content = Encoding.UTF8.GetString(bufferByte);

            bufferDigit = new BigInteger[content.Length];
            for (int i = 0; i < content.Length; i++)
                bufferDigit[i] = (BigInteger)content[i];
            
        }

        // Считывает файл по содержимому (строка) -> Выдаёт последовательность чисел (актуально для зашифрованных методом "As Text" файлов)
        internal static void TakeASCIIFromPath(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = reader.ReadToEnd();
                    int numbersOfDigits = text.ToCharArray().Where(c => c == ' ').Count();

                    bufferDigit = new BigInteger[numbersOfDigits+1];

                    for (int i = 0; i < numbersOfDigits; i++)
                    {
                        bufferDigit[i] = BigInteger.Parse(text.Substring(0, text.IndexOf(' ')));
                        text = text.Remove(0, text.IndexOf(' ')+1);
                    }
                    bufferDigit[bufferDigit.Length-1] = BigInteger.Parse(text);
                }

            }
            catch (Exception ex)
            {
                bufferDigit = null;
                MessageBox.Show("Can Not Parse From Text Into Byte Digits. Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
