using System;

namespace sessizHarf
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Aralarında Boşluk Bırakarak Kelime Giriniz:");
            string[] kelimeler = Console.ReadLine().Split();

            foreach (var item in kelimeler)
            {
                bool deger = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (Sessiz(item[i]) == Sessiz(item[i - 1]))
                        deger = true;
                }
                
                Console.Write(deger + " ");
            }

            bool Sessiz(char c)
            {
                return !"aeıioöuü".ToCharArray().Contains(c);
            }
        }
    }
}