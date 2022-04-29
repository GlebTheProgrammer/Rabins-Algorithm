using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RabinsAlgorithm.domain
{
    static internal class Decryptor
    {
        public static byte[]? decryptedBytes = null;
        public static void DecryptMessage(BigInteger p, BigInteger q, BigInteger b)
        {
            if (FileContext.bufferDigit == null)
                return;

            BigInteger[] discriminants = new BigInteger[FileContext.bufferDigit.Length];

            // Вычисляем дискриминант по формуле D = (b^2 + 4 * c) mod n, где c - зашифрованное число, n = p * q
            // Причем при вычислении D можно вычислить mod по частям: (b^2) mod n и (4 * c) mod n, после чего сложить
            // Результаты. И если результат окажется > n, то необходимо взять mod ещё один раз.
            for (int i = 0; i < discriminants.Length; i++)
            {
                BigInteger leftPart = ValuesChecker.FastPowModFunc(b, 2, p * q);
                BigInteger rightPart = ValuesChecker.FastPowModFunc(4 * FileContext.bufferDigit[i], 1, p * q);
                if (leftPart + rightPart > p * q)
                    discriminants[i] = (leftPart + rightPart) % (p * q);
                else
                    discriminants[i] = leftPart + rightPart;
            }

            // На этом этапе имеем посчитанный дискриминант для каждого числа

            // Далее вычисляем Mp и Mq для каждого из полученных дискриминантов

            BigInteger[] mPValues = new BigInteger[discriminants.Length];
            BigInteger[] mQValues = new BigInteger[discriminants.Length];

            for (int i = 0; i < discriminants.Length; i++)
            {
                mPValues[i] = ValuesChecker.FastPowModFunc(discriminants[i], (p + 1) / 4, p);
                mQValues[i] = ValuesChecker.FastPowModFunc(discriminants[i], (q + 1) / 4, q);
            }

            // На этом этапе имеем посчитанные Mp и Mq

            // Далее вычисляем Yр и Yq по Расширенному Алгоритму Евклида 

            BigInteger yPValue;
            BigInteger yQValue;

            EvklidsAlgorithm(p, q, out yPValue, out yQValue);

            // На этом этапе имеем посчитанные Mp и Mq вместе с Yp и Yq

            // Далее высчитываем d1, d2, d3 и d4 по формулам
            // d1 = (Yp * p * Mq + Yq * q * Mp) mod n
            // d2 = n - d1
            // d3 = (Yp * p * Mq - Yq * q * Mp) mod n
            // d4 = n - d3

            BigInteger[] d1Values = new BigInteger[discriminants.Length];
            BigInteger[] d2Values = new BigInteger[discriminants.Length];
            BigInteger[] d3Values = new BigInteger[discriminants.Length];
            BigInteger[] d4Values = new BigInteger[discriminants.Length];

            for (int i = 0; i < discriminants.Length; i++)
            {
                d1Values[i] = (yPValue * p * mQValues[i] + yQValue * q * mPValues[i]) % (p * q);
                d2Values[i] = (p * q) - d1Values[i];
                d3Values[i] = (yPValue * p * mQValues[i] - yQValue * q * mPValues[i]) % (p * q);
                d4Values[i] = (p * q) - d3Values[i];
            }

            // На этом этапе имеем посчитанные d1, d2, d3 и d4 значения

            // Далее высчитываем m1, m2, m3 и m4 

            BigInteger[] m1Values = new BigInteger[discriminants.Length];
            BigInteger[] m2Values = new BigInteger[discriminants.Length];
            BigInteger[] m3Values = new BigInteger[discriminants.Length];
            BigInteger[] m4Values = new BigInteger[discriminants.Length];

            for (int i = 0; i < discriminants.Length; i++)
            {
                // Алгоритм из Тестов

                //if ((discriminants[i] - b) % 2 == 0)
                //{
                //    m1Values[i] = ((-b + d1Values[i]) / 2) % (p * q);
                //    m2Values[i] = ((-b + d2Values[i]) / 2) % (p * q);
                //    m3Values[i] = ((-b + d3Values[i]) / 2) % (p * q);
                //    m4Values[i] = ((-b + d4Values[i]) / 2) % (p * q);
                //}
                //else
                //{
                //    m1Values[i] = ((-b + (p * q) + d1Values[i]) / 2) % (p * q);
                //    m2Values[i] = ((-b + (p * q) + d2Values[i]) / 2) % (p * q);
                //    m3Values[i] = ((-b + (p * q) + d3Values[i]) / 2) % (p * q);
                //    m4Values[i] = ((-b + (p * q) + d4Values[i]) / 2) % (p * q);
                //}

                // Алгоритм из Методы

                if ((d1Values[i] - b) % 2 == 0)
                    m1Values[i] = ((-b + d1Values[i]) / 2) % (p * q);
                else
                    m1Values[i] = ((-b + (p * q) + d1Values[i]) / 2) % (p * q);

                if ((d2Values[i] - b) % 2 == 0)
                    m2Values[i] = ((-b + d2Values[i]) / 2) % (p * q);
                else
                    m2Values[i] = ((-b + (p * q) + d2Values[i]) / 2) % (p * q);

                if ((d3Values[i] - b) % 2 == 0)
                    m3Values[i] = ((-b + d3Values[i]) / 2) % (p * q);
                else
                    m3Values[i] = ((-b + (p * q) + d3Values[i]) / 2) % (p * q);

                if ((d4Values[i] - b) % 2 == 0)
                    m4Values[i] = ((-b + d4Values[i]) / 2) % (p * q);
                else
                    m4Values[i] = ((-b + (p * q) + d4Values[i]) / 2) % (p * q);
            }

            // На этом этапе имеем посчитанные m1, m2, m3 и m4 значения

            // Далее необходимо выбрать нужное нам m проверкой всех значений на < 256
            // Как только находим такое значение -> переходим на следующую итерацию

            decryptedBytes = new byte[discriminants.Length];

            for (int i = 0; i < decryptedBytes.Length; i++)
            {
                if (m1Values[i] < 256 && m1Values[i] >= 0)
                {
                    decryptedBytes[i] = (byte)m1Values[i];
                    continue;
                }
                if (m2Values[i] < 256 && m2Values[i] >= 0)
                {
                    decryptedBytes[i] = (byte)m2Values[i];
                    continue;
                }
                if (m3Values[i] < 256 && m3Values[i] >= 0)
                {
                    decryptedBytes[i] = (byte)m3Values[i];
                    continue;
                }
                decryptedBytes[i] = (byte)m4Values[i];
            }
        }

        private static BigInteger EvklidsAlgorithm(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            BigInteger gcd = EvklidsAlgorithm(b % a, a, out x, out y);

            BigInteger newY = x;
            BigInteger newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }
    }
}
