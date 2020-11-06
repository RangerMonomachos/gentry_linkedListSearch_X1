using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gentry_linkedListSearch_X1
{
    class Node
    {
        private string Name;
        private string Gender;
        private int Popularity;
        public Node Previos;
        public Node Next;

        public Node(MetaData data)
        {
            Name = data.GetName();
            Gender = data.GetGender();
            Popularity = data.GetPopularity();
            Next = null;
        }

        //return the data in the node
        public string GetName()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public int GetPopularity()
        {
            return Popularity;
        }
    }
}
