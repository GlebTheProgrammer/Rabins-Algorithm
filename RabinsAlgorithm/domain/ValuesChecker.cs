using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RabinsAlgorithm.domain
{
    internal static class ValuesChecker
    {
        // Валидация строки на содержание в ней цифр и ничего другого
        public static string ValidateTextBoxInput(string TextBoxMssg)
        {
            string digits = "0123456789";

            for (int i = 0; i < TextBoxMssg.Length; i++)
            {
                if (!digits.Contains(TextBoxMssg[i]))
                {
                    TextBoxMssg = TextBoxMssg.Replace($"{TextBoxMssg[i]}", String.Empty);
                    i--;
                }
            }
            return TextBoxMssg;
        }

        // Проверка ввода p и q на правильность и на mod 4 == 3 (без проверки на простоту)
        public static string CheckTextBoxForInputErrors(string text, bool isPValueCheck,bool isCheckForRange = false, string secondStrIfCheck = "")
        {
            // Пустая строка
            if (string.IsNullOrEmpty(text))
                return "String can't be empty.";

            // Не число
            if (!BigInteger.TryParse(text, out BigInteger value))
                return "Input isn't a digit.";

            // Отрицательное число
            if (value < 0)
                return "Digit must be positive.";

            // Проверка числа на mod 4 == 3 ?
            if (value % 4 != 3)
                return "Mod 4 must be equal 3.";

            // Проверка на p * q = n > 256
            if (isCheckForRange && BigInteger.TryParse(secondStrIfCheck, out BigInteger value2))
            {
                if (value * value2 <= 256)
                    return "p * q must > 256.";
            }

            //// Проверка на диапазон p > 3
            //if (isPValueCheck && value <= 3)
            //    return "p must be > 3.";

            //if (!isPValueCheck && value <= 3511)
            //    return "q must be > 3511.";


            return string.Empty;
        }

        // Тест через цикл на простоту числа
        public static bool IsPrimary_SympleCycleTest(BigInteger value)
        {
            byte dividersCount = 0;
            for (BigInteger i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    dividersCount++;
                    if (dividersCount > 2)
                        return false;
                }
            }
            return true;
        }

        // Тест Ферма на простоту числа
        public static bool IsPrimary_FermatsTest(BigInteger p)
        {
            // Будем использовать Функцию быстрой возведении в степень по модулю
            // Так как (a^p - a) mod p = ((a^p) mod p) - ((a^1) mod p)
            for (int a = 1; a < p; a++)
            {
                BigInteger aPow = FastPowModFunc(a, p, p);
                BigInteger aNoPow = FastPowModFunc(a, 1, p);
                if (aPow - aNoPow == 0)
                    continue;
                else
                    return false;
            }
            return true;
        }

        // Тест Миллера-Рабина на простоту числа
        public static bool IsPrimary_MillersRabinsTest(BigInteger n, int s) // s - число раундов для b_i
        {
            // если n == 2 или n == 3 - эти числа простые, возвращаем true
            if (n == 2 || n == 3)
                return true;

            // если n < 2 или n четное - возвращаем false
            if (n < 2 || n % 2 == 0)
                return false;


            // представим n − 1 в виде (2^k)*m, где m нечётно, это можно сделать последовательным делением n - 1 на 2
            BigInteger m = n - 1;

            int k = 0;

            while (m % 2 == 0)
            {
                m /= 2;
                k += 1;
            }

            // повторить s раз
            for (int i = 0; i < s; i++)
            {
                // выберем случайное целое число a в отрезке [2, n − 2]

                RNGCryptoServiceProvider rng = new();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);

                // b_i ← (a^m) mod n, вычислим с помощью быстрого алгоритма возведения в степень по модулю
                BigInteger b_i = FastPowModFunc(a, m, n);

                // если b_i == 1 или b_i == n − 1, то перейти на следующую итерацию цикла
                if (b_i == 1 || b_i == n - 1)
                    continue;

                // повторить k − 1 раз
                for (int r = 1; r < k; r++)
                {
                    // b_i ← (b_i)^2 mod n
                    b_i = FastPowModFunc(b_i, 2, n);

                    // если b_i == 1, то вернуть "составное"
                    if (b_i == 1)
                        return false;

                    // если b_i == n − 1, то перейти на следующую итерацию внешнего цикла
                    if (b_i == n - 1)
                        break;
                }

                if (b_i != n - 1)
                    return false;
            }

            // вернуть "вероятно простое"
            return true;

        }

        // Функция быстрого возведения в степень по модулю
        public static BigInteger FastPowModFunc(BigInteger Number, BigInteger Pow, BigInteger Mod)
        {
            BigInteger Result = 1;
            BigInteger Bit = Number % Mod;

            while (Pow > 0)
            {
                if ((Pow & 1) == 1)
                {
                    Result *= Bit;
                    Result %= Mod;
                }
                Bit *= Bit;
                Bit %= Mod;
                Pow >>= 1;
            }
            return Result;
        }
        
        // Проверка ввода b на правильность
        public static string CheckTextBoxWithBForErrors(string text, BigInteger p, BigInteger q)
        {
            // Пустая строка
            if (string.IsNullOrEmpty(text))
                return "String can't be empty.";

            // Не число
            if (!BigInteger.TryParse(text, out BigInteger value))
                return "Input isn't a digit.";

            // Отрицательное число
            if (value < 0)
                return "Digit must be positive.";

            // Проверка на диапазон значений
            if (value >= p * q)
                return "b must be < p * q.";

            // Проверка на ненатурально число
            if (value == 0)
                return "Digit must be natural (1,2,...).";

            // Проверка на диапазон значений 2
            //if (value > 10544)
            //    return "b range must be: 0 < b < 10533.";

            return String.Empty;
        }
    }
}
