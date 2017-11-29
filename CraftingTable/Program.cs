using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraftingClasses;
namespace CraftingTable
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] table = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    table[i, j] = 0;
                    Console.Write("{0}   ", table[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Начать работу?");
           //CraftingTAble craft=new CraftingTAble(true);
            //введите позицию
            //Выберите материал
            //Проверить рецепт      1-топор 2-меч  3-кирка  4-мотыга   5-лопата
            //
        }
    }
}
