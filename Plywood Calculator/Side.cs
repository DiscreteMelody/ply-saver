using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plywood_Calculator
{
    class Side
    {
        
        private float length;
        private bool isObtuse;

        private float maxLength = 96;   //the max length in inches of a piece of plywood

        public Side(float length_of_side, bool next_angle_obtuse)
        {
            length = length_of_side;
            isObtuse = next_angle_obtuse;
        }

        public bool validateSide()
        {
            if(length > maxLength)
            {
                return false;
            }
            return true;
        }
    }
}
