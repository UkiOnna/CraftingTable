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
        private int _position;
        public Material(int index,int pos)
        {
            _index = index;
           
            _position = pos;
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
            return _position;
        }

        public void SetPos(int pos)
        {
            _position = pos;
        }

        public static Material operator +(Material pos, Material position)
        {
           int reservePosition= pos.GetPos()+position.GetPos();
            pos.SetPos(reservePosition);
            return pos;
        }



    }
}
