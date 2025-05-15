

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генератор_пароля
{
    internal class Program
    {
        public static string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };

        static void Main(string[] args)
        {
            Random rand = new Random();
            PasswordGenerate(rand);
            Console.ReadLine();
        }
        public static int SymbolGenerate(Random rand, int min, int max)
        {
            int random = rand.Next(min, max);
            return random;
        }

        public static void PasswordGenerate(Random rand)
        {
            Console.WriteLine("Введите длину пароля");
            int length = Int32.Parse(Console.ReadLine());
            try
            {
                string password = "";
                for (int i = 0; i < length; i++)
                {
                    int rnd = SymbolGenerate(rand, 1, 5);
                    switch (rnd)
                    {
                        case 1:
                            int a = SymbolGenerate(rand, 0, digits.Length);
                            password += digits[a];
                            break;
                        case 2:
                            int b = SymbolGenerate(rand, 0, lowercaseLetters.Length);
                            password += lowercaseLetters[b];
                            break;
                        case 3:
                            int c = SymbolGenerate(rand, 0, uppercaseLetters.Length);
                            password += uppercaseLetters[c];
                            break;
                        case 4:
                            int d = SymbolGenerate(rand, 0, specialSymbols.Length);
                            password += specialSymbols[d];
                            break;
                    }
                }
                Console.WriteLine(password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка введите кол-во символов для пароля!");
            }
        }

    }
}

