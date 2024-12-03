using System;
using Class_Library_3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Misto misto_1 = MistoSingleton.GetInstance("Харкiв", 49.9935, 36.2304); 
            Misto misto_2 = MistoSingleton.GetInstance("Харкiв", 49.9935, 36.2304);
            Misto misto_3 = MistoSingleton.GetInstance("Київ", 50.4501, 30.5234);

            Console.WriteLine($"Мiсто 1: {misto_1.Nazva_Mista}, Широта: {misto_1.Shyrota}, Довгота: {misto_1.Dovgota}");
            Console.WriteLine($"Мiсто 2: {misto_2.Nazva_Mista}, Широта: {misto_2.Shyrota}, Довгота: {misto_2.Dovgota}");
            Console.WriteLine($"Мiсто 3: {misto_3.Nazva_Mista}, Широта: {misto_3.Shyrota}, Довгота: {misto_3.Dovgota}");

            Console.WriteLine($"Часовий пояс: {misto_1.Chasovyi_Poyas()}");
            Console.WriteLine($"Пiвкуля: {misto_1.Pivkulya()}");

            Console.ReadLine();

        }
    }
}
