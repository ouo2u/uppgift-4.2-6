using System;

namespace uppgift_4._26
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("skriv ett heltal");
                string heltal = Console.ReadLine();

                for (int i = 0; i < heltal.Length; i++)
                {
                    string tecken = heltal[i].ToString();
                    int siffra = int.Parse(tecken);

                    switch (siffra)
                    {
                        case 9:
                            siffra = 0;
                            break;
                        default:
                            siffra++;
                            break;
                    }
                    Console.WriteLine(siffra);

                }


            }
        }
    }
}