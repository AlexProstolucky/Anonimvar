using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace Запити
{
    class Програма
    {
        static void Main(string[] args)
        {
            int[] масив = { 15, 24, 27, 12, 44, 12, 21, 108, 25, 33, 41 };
            var запит = from i in масив
                                     select i;
            WriteLine("Усі елементи джерела даних: ");
            foreach (var елемент in запит)
            {
                Write($"{елемент}\t");
            }
            WriteLine();
            масив[0] = 5;
            foreach (var елемент in запит)
            {
                Write($"{елемент}\t");
            }
        }
    }
}