using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingClasses
{
    public class Material
    {
        int _index;
        string _name;
        int _pos;
        public Material(int index,string name,int pos)
        {
            _index = index;
            _name = name;
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

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
             _name=name;
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
