using MyDictionary_Test;
using System;
class Program
{
    static void Main(string[] args)
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

        InputManager.HandleUserInput(myDictionary);

        foreach (var item in myDictionary.Items)
        {
            Console.WriteLine("Anahtar: " + item.Key + ", Değer: " + item.Value);
        }
    }
}

