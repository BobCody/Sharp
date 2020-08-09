using System;
using System.ComponentModel.Design.Serialization;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ща определю можно ли тебе бухать!");
            Console.WriteLine("твое Имя:");
            string name = Console.ReadLine();


            Console.WriteLine("Возраст:");
            int age=0;
            int i=0;

            while (i == 0)
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out age))
                {
                    i = 1;
                }
                else
                {
                    Console.WriteLine("ты ебанутый? мб цифры напишешь? давай еще раз нахуй:");
                    i = 0;
                }
            }




            Console.WriteLine("Пол (м или ж):");
            int k = 0;
            string gender = "";
            while (k == 0)
            {
                gender = Console.ReadLine();
                switch (gender)
                {
                    case "м":
                        Console.Write("ты вершина эволюции, поэтому тебе, ");
                        k = 1;
                        break;
                    case "ж":
                        Console.Write("ну ты пиздец конечно, ");
                        k = 1;
                        break;
                    default:
                        Console.WriteLine("ну давай, расскажи что есть 54 гендера. но выбирай из двух- м или ж");
                        break;
                }
            }

            if (gender == "м" && age < 18){
                Console.WriteLine($"{name}, с пацанами в падике пивко само то");
            }
            else if (gender == "м" && age > 18)
            {
                Console.WriteLine($"{name}, было бы странно не бухать, чувак");
            }
            else if (gender == "ж" && age < 18)
            {
                Console.WriteLine($"{name}, дырка малолетняя, нех бухать");
            }
            else if (gender == "ж" && age > 18)
            {
                Console.WriteLine($"{name}, пизда старая, нех бухать");
            }
            Console.ReadKey();
        }
    }
}
