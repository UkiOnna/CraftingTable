using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingClasses
{
    public class Material
    {
       private int _index;
        private int _pos;
        public Material(int index,int pos)
        {
            _index = index;
           
            _pos = pos;
        }
        public int GetIndex()
        {
            return _index;
        }
        public void SetIndex(int index)
        {
            _index = index;
        }

        

        public int GetPos()
        {
            return _pos;
        }

        public void SetPos(int pos)
        {
            _pos = pos;
        }


       
      
       
    }
}
