using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingClasses
{
    public class Recipe
    {
        private Material[] _materials = new Material[9];
        private int _pos;
        public Recipe()
        {
            _pos = 0;
        }

        public void SetMaterial(Material material)
        {
            _materials[_pos] = material;
        }
        public void Delete(){

            Array.Clear(_materials, 0, _materials.Length);
   
        }
        public bool isShowel(Material materials)
        {
            return false;
        }
    }
}
