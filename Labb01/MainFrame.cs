//MainFrame.cs
//Johan Persson tf041968, 
//Start 2012-01-26
//End 2012-02-02
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainFrame : Form
    {
        TimeTable table = new TimeTable();
        
        /// <summary>
        /// Constants for max and min working hours. 
        /// </summary>
        private const double minHours = 0;
        private const double maxHours = 10;

        public MainFrame()
        {
            InitializeComponent();
            InitializeGui();

        }
        /// <summary>
        /// Fills cbMonth with months collected from enums in class MonthOfYear.cs
        /// Fills cdDay with 31 one days. 
        /// </summary>
        private void InitializeGui()
        {
            cmbMonth.DataSource = Enum.GetNames(typeof(months));
            cmbMonth.SelectedIndex = (int)DateTime.Now.Month - 1;
            cmbDay.SelectedIndex = (int)DateTime.Now.Day-1;

            for (int i = 0; i <= 10; i++)
            {
                cbYear.Items.Add((i + 2010).ToString(""));       
            }
            cbYear.SelectedIndex = 2;
        }

        /// <summary>
        /// Clears table and adds the number of hours that the user has added. 
        /// Shows the total sum of added hours. 
        /// </summary>
        private void UpdateGUI()
        {
            lbGrid.Items.Clear();
            lbGrid.Items.AddRange(table.GetArray());
            lblOutput.Text = table.GetTotSum().ToString();

            /// Fills comboboxes with month and day
            int numberDays;

            if (cmbMonth.SelectedIndex == 0 ||
                cmbMonth.SelectedIndex == 2 ||
                cmbMonth.SelectedIndex == 4 ||
                cmbMonth.SelectedIndex == 6 ||
                cmbMonth.SelectedIndex == 7 ||
                cmbMonth.SelectedIndex == 9 ||
                cmbMonth.SelectedIndex == 11)
            {
                numberDays = 31;
            }
            else if (cmbMonth.SelectedIndex == 3 ||
                cmbMonth.SelectedIndex == 5 ||
                cmbMonth.SelectedIndex == 8 ||
                cmbMonth.SelectedIndex == 10)
            {
                numberDays = 30;
            }
            else
            {
                if (cbYear.SelectedIndex == 2 ||
                    cbYear.SelectedIndex == 6 ||
                    cbYear.SelectedIndex == 10)
                {
                    numberDays = 29;
                }
                else
                {
                    numberDays = 28;
                }
            }

            cmbDay.Items.Clear();

            for (int i = 0; i < numberDays; i++)
            {
                cmbDay.Items.Add((i + 1).ToString("00"));
            }
            cmbDay.SelectedIndex = 0;
        }
        //DateTime.IsLeapYear(DateTime.Now.Year)
        
        /// <summary>
        /// Send added value to InputUtility to check if its a double. 
        /// Sends error message if not. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double outHours; 
            string hours = tbHours.Text.ToString();
            int day = cmbDay.SelectedIndex;
            int month = cmbMonth.SelectedIndex;
            bool isNumber = InputUtility.GetDouble(hours, out outHours, minHours, maxHours); 
            if (isNumber)
            {
                table.Hours(outHours, day, month);
            }
            else
            {
                MessageBox.Show("Du måste ange ett tal mellan 0 och 10");
            }      
            UpdateGUI();      
        }

        /// <summary>
        /// Uppdates GUI when month combobox is changed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        /// <summary>
        /// Updates GUI when year combobox is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }
    }
}
