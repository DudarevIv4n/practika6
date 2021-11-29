using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_6
{
    class Pair
    {
        public Pair(int first = 5, int second = 3)
        {
            First = first;
            Second = second;
        }

        private int First { get; set; }
        private int Second { get; set; }

        public static bool operator >(Pair firstpair, Pair secondpair)
        {
            if (firstpair.First > secondpair.First) return true;
            if (firstpair.First == secondpair.First && secondpair.First > secondpair.Second) return true;
            return false;
        }

        public static bool operator <(Pair firstpair, Pair secondpair)
        {
            if (firstpair.First > secondpair.First) return false;
            if (firstpair.First == secondpair.First && secondpair.First > secondpair.Second) return false;
            return true;
        }

        public void SetParams(int first, int second)
        {
            First = first;
            Second = second;
        }

        public void SetParams(int first)
        {
            First = first;
        }

        public void SetParams(double second)
        {
            Second = Convert.ToInt32(second);
        }
    }
}
