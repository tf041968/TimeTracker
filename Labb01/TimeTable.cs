//TimeTable.cs
//Johan Persson tf041968, 
//Start 2012-01-26
//End 2012-02-02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class TimeTable
    {
        /// <summary>
        /// Constants with number of cols and rows
        /// Declaration of 2 dimensional array
        /// </summary>
        private const int totCols = 12; //NumberOfMonths
        private const int totRows = 31; //NumberOfDays
        private double[,] timeTable;    //2dimarray

        /// <summary>
        /// Constructor
        /// </summary>
        public TimeTable()
        {
            //SkaparTable array
            timeTable = new double[totCols, totRows];
        }

       
        /// <summary>
        /// Runs through the array and get the added hours to show in lbGrid. 
        /// </summary>
        /// <returns>Number of hours to tbGrid</returns>
        public string[] GetArray()
        {
            string[] infoString = new string[totRows + 2]; //Array of string with 2 extra rows
            string formatString;
            int row;

            //Loopar varje rad
            for (row = 0; row < totRows; row++)
            {
                formatString = (row + 1).ToString("00") + " : "; //Skriver ut datum till vänster
                
                //Loopar varje column på varje dag. 
                for (int col = 0; col < totCols; col++)
                {
                    formatString += String.Format("{0, 5:f1}",timeTable[col, row]) + " : "; //Formaterar output
                }
                infoString[row] = formatString; //Sparar den formaterade strängen i outputArrayen
            }
            infoString[row++] = ""; //Lägger till blankrad före månaderna nedan.
            infoString[row++] = "Day    Jan     Feb     Mar     Apr     May     Jun     Jul     Aug     Sep     Oct     Nov     Dec";

            return infoString;

        }

        
        /// <summary>
        /// Adds the amount of hours to the timeTable array. 
        /// </summary>
        /// <param name="hours">Amount of added hours</param>
        /// <param name="day">Day to add hours to</param>
        /// <param name="month">Month to add hours to</param>
        public void Hours(double hours, int day, int month)
        {
            timeTable[month, day] = hours;
        }

        public double GetTotSum()
        {
            double totSum = 0;

            for (int col = 0; col < totCols; col++)
            {
                for (int row = 0; row < totRows; row++)
                {
                    totSum += timeTable[col, row];
                                       
                }
            }
            return totSum;
        }
    }
}
