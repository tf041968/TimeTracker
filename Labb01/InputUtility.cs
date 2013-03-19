//InputUtility.cs
//Johan Persson tf041968, 
//Start 2012-01-26
//End 2012-02-02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class InputUtility
    {
        /// <summary>
        /// Gets added value and checks if its a double or not. 
        /// </summary>
        /// <param name="stringToConvert">Added value from tbHours</param>
        /// <param name="dblOutValue">Outvalue after check</param>
        /// <param name="minHours">Minimun added hours</param>
        /// <param name="maxHours">Maximum added hours</param>
        /// <returns>true or false</returns>

        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minHours, double maxHours)
        {
            if (double.TryParse(stringToConvert, out dblOutValue))
            {
                return (dblOutValue >= minHours && dblOutValue <= maxHours);
            }
            else
            {
                return false;
            }

        }
    }
}
