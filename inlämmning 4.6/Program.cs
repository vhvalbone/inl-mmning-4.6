﻿using System;
namespace inlämmning_4._6
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Ange antal steg åt höger");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
