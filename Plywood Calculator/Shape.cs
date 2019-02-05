using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plywood_Calculator
{
    class Shape
    {
        private List<Side> sides = new List<Side>();
        private List<Point> shapePoints = new List<Point>();


        public Shape(List<Side> list_of_sides)
        {
            sides = list_of_sides;
        }

        public bool validateShape()
        {
            return true;
        }
    }
}
