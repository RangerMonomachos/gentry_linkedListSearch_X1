using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gentry_linkedListSearch_X1
{
    class MetaData
    {
        private string Name;
        private string Gender;
        private int Popularity;

        public MetaData(string name, string gender, int popularity)
        {
            Name = name;
            Gender = gender;
            Popularity = popularity;
        }
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
