using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_work
{
    public class Approach
    {
        float weight;
        int repetition;
        public Approach(float w, int r)
        {
            weight = w;
            repetition = r;
        }
        public Approach()
        {

        }
        public float Weight
        {
            set{ weight = value; }
            get{ return weight; }
        }
        public int Repetition
        {
            set { repetition = value; }
            get { return repetition; }
        }
    }
}
