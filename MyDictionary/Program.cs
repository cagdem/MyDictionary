using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1, "Çağlar");
            ogrenciler.Add(5, "Bulut");


        }
    }
}
