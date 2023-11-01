using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary_Test
{

    public class InputManager
    {
        public static void HandleUserInput(MyDictionary<int, string> myDictionary)
        {
            Console.Write("Komutlar: (Anahtar: 'key', Liste: 'list', Çıkış: 'exit')");
            while (true)
            {
                Console.Write("\nKomut: ");
                string komut = Console.ReadLine();

                if (komut == "exit")
                    break;
                else if (komut == "key")
                {
                    Console.Write("Anahtar: ");
                    string anahtarGirisi = Console.ReadLine();

                    if (!int.TryParse(anahtarGirisi, out int anahtar))
                    {
                        Console.WriteLine("Anahtar Int değil!");
                        continue;
                    }

                    Console.Write("Value: ");
                    string deger = Console.ReadLine();

                    myDictionary.Add(anahtar, deger);
                }
                else if (komut == "list")
                {
                    Listele(myDictionary);
                }
                else
                {
                    Console.WriteLine("Err!");
                }
            }
        }

        public static void Listele(MyDictionary<int, string> myDictionary)
        {
            Console.WriteLine("\n---------|Keys|---------");
            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine("Anahtar: " + item.Key + ", Değer: " + item.Value);
            }
            Console.WriteLine("------------------------");
        }
    }

}
