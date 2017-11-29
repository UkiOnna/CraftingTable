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
            int indexOfMateria;
            int posOfMateria;
            int exit=1;
            int pos = 0;
            Material[] materia = new Material[9];
            Recipe recipe=new Recipe();
            int[,] table = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = 0;
                    Console.Write("{0}   ", table[i, j]);
                }
                Console.WriteLine();
               

                //введите позицию
                //Выберите материал
                //Проверить рецепт      1-топор 2-меч  3-кирка  4-мотыга   5-лопата
                //
            }
            while (true)
            {
 Console.WriteLine("Позиция");
               int.TryParse(Console.ReadLine(), out posOfMateria);
                Console.WriteLine("Материал");
                int.TryParse(Console.ReadLine(), out indexOfMateria);
                if (indexOfMateria == 1)
                {
                    indexOfMateria = 0;
                }
                else
                {
                    indexOfMateria = 1;
                }
                materia[pos] = new Material(indexOfMateria, posOfMateria);
                recipe.SetMaterial(materia[pos]);
                Console.WriteLine("Выйти?");
                int.TryParse(Console.ReadLine(), out exit);
                if (exit == 0)
                {
                    break;
                }
                else
                {
                    pos++;
                }
            }
            if (recipe.isShowel())
            {
                Console.WriteLine("КАЕЕЕЕЕФ");
            }
            else
            {
                Console.WriteLine("ZA CHTOOOOOOOO");
            }
            Console.ReadLine();
        }
    }
}
