﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingClasses
{
    public class Recipe
    {
        private Material[] _materials = new Material[9];
        private int _size;
        public Recipe()
        {
            _size = 0;
        }

       
    public void SetMaterial(Material materia)
        {
            _materials[_size] = new Material(materia.GetIndex(), materia.GetPos());
            _size++;
        }
        public void Delete(){

            Array.Clear(_materials, 0, _size);
            _size = 0;
            

        }
        public bool isShowel(Material materials)
        {
            return false;
        }

        public bool isShowel()
        {
            bool isSticksOk = false;
            bool isMaterialOk = false;
            int countSticks=0;
            int countMaterial = 0;
            int posOfFirstStick=0,posOfSecondStick=0,differenceOfStick=3;
            int posOfMaterial=0;
            for(int i = 0; i < _size; i++)
            {
                if (_materials[i].GetIndex() == 0)
                {
                    if(_materials[i].GetPos()==1||_materials[i].GetPos()==2|| _materials[i].GetPos() == 3)
                    {
                        return false;
                    }
                    else
                    {
                        countSticks++;
                        if (countSticks == 1)
                        {
                            posOfFirstStick = _materials[i].GetPos();
                        }
                        else if (countSticks == 2)
                        {
                            posOfSecondStick = _materials[i].GetPos();

                        }
                        else
                        {
                            return false;
                        }
                    
                    }
                    
                    
                    
                }

                else if(_materials[i].GetIndex() == 1)
                {
                    if (_materials[i].GetPos()>3)
                    {
                        return false;
                    }
                    else
                    {
                        countMaterial++;
                        if (countMaterial == 1)
                        {
                            posOfMaterial = _materials[i].GetPos();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (countSticks == 0||countSticks==1)
            {
                return false;
            }
            else
            {
                if (posOfSecondStick > posOfFirstStick)
                {
                    if (posOfSecondStick - posOfFirstStick != differenceOfStick)
                    {
                        return false;
                    }
                    else
                    {
                        isSticksOk = true;
                    }
                }
                else
                {
                    if ((posOfFirstStick - posOfSecondStick) != differenceOfStick)
                    {
                        return false;
                    }
                    else
                    {
                        isSticksOk = true;
                    }
                }
            }
            if (countMaterial == 0)
            {
                return false;
            }
            else
            {
                if ((posOfFirstStick + posOfSecondStick + posOfMaterial) % 3 == 0)
                {
                    isMaterialOk = true;
                }
            }

            if (isMaterialOk && isSticksOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSword()
        {
            bool isMaterialOk = false;
            bool isSticksOk = false;
            int countMaterial = 0;
            int countSticks = 0;
            int posOfStick = 0, differenceOfMaterial = 3;
            int posOfFirstMaterial = 0,posOfSecondMaterial=0;
            for (int i = 0; i < _size; i++)
            {
                if (_materials[i].GetIndex() == 1)
                {
                    if (_materials[i].GetPos() == 7 || _materials[i].GetPos() == 8 || _materials[i].GetPos() == 9)
                    {
                        return false;
                    }
                    else
                    {
                        countMaterial++;
                        if (countMaterial == 1)
                        {
                            posOfFirstMaterial = _materials[i].GetPos();
                        }
                        else if (countMaterial == 2)
                        {
                            posOfSecondMaterial = _materials[i].GetPos();

                        }
                        else
                        {
                            return false;
                        }

                    }



                }

                else if (_materials[i].GetIndex() == 0)
                {
                    if (_materials[i].GetPos()<7)
                    {
                        return false;
                    }
                    else
                    {
                        countSticks++;
                        if (countSticks == 1)
                        {
                            posOfStick = _materials[i].GetPos();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (countMaterial == 0 || countMaterial == 1)
            {
                return false;
            }
            else
            {
                if (posOfSecondMaterial > posOfFirstMaterial)
                {
                    if ((posOfSecondMaterial - posOfFirstMaterial) != differenceOfMaterial)
                    {
                        return false;
                    }
                    else
                    {
                        isMaterialOk = true;
                    }
                }
                else
                {
                    if ((posOfFirstMaterial - posOfSecondMaterial) != differenceOfMaterial)
                    {
                        return false;
                    }
                    else
                    {
                        isMaterialOk = true;
                    }
                }
            }
            if (countSticks == 0)
            {
                return false;
            }
            else
            {
                if ((posOfStick + posOfFirstMaterial + posOfSecondMaterial) % 3 == 0)
                {
                    isSticksOk = true;
                }
            }

            if (isMaterialOk && isSticksOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsPickaxe()
        {
            bool isSticksOk = false;
            bool isMaterialOk = false;
            int countSticks = 0;
            int countMaterial = 0;
            int posOfFirstStick = 0, posOfSecondStick = 0, differenceOfStick = 3;
            int posOfFirstMaterial = 0, posOfSecondMaterial = 0, posOfThirdMaterial = 0;
            for (int i = 0; i < _size; i++)
            {
                if (_materials[i].GetIndex() == 0)
                {
                    if (_materials[i].GetPos() == 1 || _materials[i].GetPos() == 2 || _materials[i].GetPos() == 3)
                    {
                        return false;
                    }
                    else
                    {
                        countSticks++;
                        if (countSticks == 1)
                        {
                            posOfFirstStick = _materials[i].GetPos();
                        }
                        else if (countSticks == 2)
                        {
                            posOfSecondStick = _materials[i].GetPos();

                        }
                        else
                        {
                            return false;
                        }

                    }



                }

                else if (_materials[i].GetIndex() == 1)
                {
                    if (_materials[i].GetPos() > 3)
                    {
                        return false;
                    }
                    else
                    {
                        countMaterial++;
                        if (countMaterial == 1)
                        {
                            posOfFirstMaterial = _materials[i].GetPos();
                        }
                        else if (countMaterial == 2)
                        {
                            posOfSecondMaterial = _materials[i].GetPos();
                        }
                        else if (countMaterial == 3)
                        {
                            posOfThirdMaterial = _materials[i].GetPos();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (countSticks == 0 || countSticks == 1)
            {
                return false;
            }
            else
            {
                if (posOfFirstStick == 5 && posOfSecondStick == 8)
                {
                    isSticksOk = true;
                }
                else if (posOfFirstStick == 8 && posOfSecondStick == 5)
                {
                    isSticksOk = true;
                }
            }
            if (countMaterial == 0|| countMaterial == 1 || countMaterial == 2 )
            {
                return false;
            }
            else
            {
                    isMaterialOk = true;
            }

            if (isMaterialOk && isSticksOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsHoe()
        {
            bool isSticksOk = false;
            bool isMaterialOk = false;
            int countSticks = 0;
            int countMaterial = 0;
            int posOfFirstStick = 0, posOfSecondStick = 0, differenceOfStick = 3;
            int posOfFirstMaterial = 0, posOfSecondMaterial = 0;
            for (int i = 0; i < _size; i++)
            {
                if (_materials[i].GetIndex() == 0)
                {
                    if (_materials[i].GetPos() == 1 || _materials[i].GetPos() == 2 || _materials[i].GetPos() == 3)
                    {
                        return false;
                    }
                    else
                    {
                        countSticks++;
                        if (countSticks == 1)
                        {
                            posOfFirstStick = _materials[i].GetPos();
                        }
                        else if (countSticks == 2)
                        {
                            posOfSecondStick = _materials[i].GetPos();

                        }
                        else
                        {
                            return false;
                        }

                    }



                }

                else if (_materials[i].GetIndex() == 1)
                {
                    if (_materials[i].GetPos() > 3)
                    {
                        return false;
                    }
                    else
                    {
                        countMaterial++;
                        if (countMaterial == 1)
                        {
                            posOfFirstMaterial = _materials[i].GetPos();
                        }
                        else if (countMaterial == 2)
                        {
                            posOfSecondMaterial = _materials[i].GetPos();
                        }
                       
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (countSticks == 0 || countSticks == 1)
            {
                return false;
            }
            else
            {
                if (posOfSecondStick > posOfFirstStick)
                {
                    if ((posOfSecondStick - posOfFirstStick) != differenceOfStick)
                    {
                        return false;
                    }
                    else
                    {
                        isSticksOk = true;
                    }
                }
                else
                {
                    if ((posOfFirstStick - posOfSecondStick) != differenceOfStick)
                    {
                        return false;
                    }
                    else
                    {
                        isSticksOk = true;
                    }
                }
            }
            if (countMaterial == 0|| countMaterial == 1 )
            {
                return false;
            }
            else
            {
                if ((posOfFirstMaterial == 1 && posOfSecondMaterial == 3) || (posOfFirstMaterial == 3 && posOfSecondMaterial == 1))
                {
                    isMaterialOk = false;
                }
                else
                {
                    isMaterialOk = true;
                }
                    
            }

            if (isMaterialOk && isSticksOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
