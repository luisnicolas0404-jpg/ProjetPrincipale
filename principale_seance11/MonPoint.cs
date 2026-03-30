using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principale_seance11
{

    public class MonPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MonPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

}
