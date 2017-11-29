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
            bool isIndexChoosed=false;
            bool isPositionChoosed=false;
            int indexOfMateria=0;
            int posOfMateria=0;
            int exit=1;
            int position = 0;
            object first = ' ', second = ' ', third = ' ', fourth = ' ', fifth = ' ', sixth = ' ', seventh = ' ', eights = ' ', nineth = ' ';//позиции верстака
            int choose = 0;
            Material[] materia = new Material[9];
            Recipe recipe=new Recipe();
            

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("__________");
                Console.WriteLine("{0} | {1} | {2}", first, second, third);
                Console.WriteLine("__________");
                Console.WriteLine("{0} | {1} | {2}", fourth, fifth, sixth);
                Console.WriteLine("__________");
                Console.WriteLine("{0} | {1} | {2}", seventh, eights, nineth);
                Console.WriteLine("__________");




                Console.WriteLine("1 - Выбор позиции");
                Console.WriteLine("2 - Выбор Материала");
                Console.WriteLine("3 - Выход");
                Console.WriteLine("4 - Стереть крафт");
                Console.WriteLine("5 - Проверить крафт");
                int.TryParse(Console.ReadLine(), out choose);
                switch (choose) {
                    case 1 :
                        Console.WriteLine("Введите позицию (1-9)");
                        int.TryParse(Console.ReadLine(), out posOfMateria);
                        isPositionChoosed = true;
               
                        break;

                    case 2:
                        isIndexChoosed = true;
                        Console.WriteLine("Выберите материал");
                        Console.WriteLine("1 - Палка , 2 - Железо , 3 - Алмаз , 4 - Золото , 5 - Мифриловый камень");
                        int.TryParse(Console.ReadLine(), out indexOfMateria);
                if (indexOfMateria == 1)
                {
                    indexOfMateria = 0;
                            if (posOfMateria == 1)
                {
                            first=0;
                }
                else if (posOfMateria == 2)
                {
                            second=0;
                }
                else if (posOfMateria == 3)
                {
                            third=0;
                }
                else if (posOfMateria == 4)
                {
                            fourth=0;
                }
                else if (posOfMateria == 5)
                {
                            fifth=0;
                }
                else if (posOfMateria == 6)
                {
                            sixth=0;
                }
                else if (posOfMateria == 7)
                {
                            seventh=0;
                }
                else if (posOfMateria == 8)
                {
                            eights=0; 
                }
                else if (posOfMateria == 9)
                {
                            nineth=0;
                }
               
                }
                else
                {
                    indexOfMateria = 1;
                            if (posOfMateria == 1)
                            {
                                first = 1;
                            }
                            else if (posOfMateria == 2)
                            {
                                second = 1;
                            }
                            else if (posOfMateria == 3)
                            {
                                third = 1;
                            }
                            else if (posOfMateria == 4)
                            {
                                fourth = 1;
                            }
                            else if (posOfMateria == 5)
                            {
                                fifth = 1;
                            }
                            else if (posOfMateria == 6)
                            {
                                sixth = 1;
                            }
                            else if (posOfMateria == 7)
                            {
                                seventh = 1;
                            }
                            else if (posOfMateria == 8)
                            {
                                eights = 1 ;
                            }
                            else if (posOfMateria == 9)
                            {
                                nineth = 1;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Выйти?  Для выхода введите ноль.");
                int.TryParse(Console.ReadLine(), out exit);
                if (exit == 0)
                {
                            Environment.Exit(0);
                        }
                       break;

                    case 4:
                        recipe.Delete();
                        first = ' '; second = ' '; third = ' '; fourth = ' '; fifth = ' '; sixth = ' '; seventh = ' '; eights = ' '; nineth = ' ';
                        break;

                    case 5:
if (recipe.IsSword())
            {
                Console.WriteLine("Поздравляю вы создали меч!");
            }
                         else if(recipe.IsHoe()){
                            Console.WriteLine("Поздравляю вы создали мотыгу!");
                        }
                    else if (recipe.IsPickaxe())
                        {
                            Console.WriteLine("Поздравляю вы создали кирку!");
                        }
                     else if (recipe.isShowel())
                        {
                            Console.WriteLine("Поздравляю вы создали Лопату!");
                        }
                       

                        else {
                            Console.WriteLine("Вы ввели неправильный крафт");
                        } Console.ReadLine();
                        break;
                }


                if (isIndexChoosed && isPositionChoosed)
                {
                    materia[position] = new Material(indexOfMateria, posOfMateria);
                    recipe.SetMaterial(materia[position]);
                    isIndexChoosed = false;
                    isPositionChoosed = false; position++;
                }

                Console.Clear();
                
            }
            
            
            Console.ReadLine();
        }
    }
}
