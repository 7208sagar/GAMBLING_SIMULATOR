using System;

namespace GamblingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****WELLCOME GAMBLING SIMULATION!*****");
            Gambler gambler = new Gambler();
            gambler.Betting();
        }
    }
}
