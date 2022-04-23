using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEmployee
{
    public partial class Form1 : Form
    {
        public int i = 0;
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
            /**
             * Khagendra Khatri
             * Data Handling
             * 
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cCEMPLOYEEDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.cCEMPLOYEEDataSet.Employee);
            // Set to 1 second.  
            timer1.Start();

        }
        /**
         * 
         * @var found is false at start and become true as the data is found but remains false if no data is found
         * it goes to catch blocks when the data search is over
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {          
            Boolean found = false;
            i = 0;
            try
            {
                while (dataGridView1.Rows.Count > i)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals(textBox1.Text))
                    {
                        found = true;
                        break;
                    }
                    i++;
                }
            }
            catch
            {
                //do nothing just handling the exception is enough
            }
            if (found)
            {
                Display();
            }
            else
            {
                MessageBox.Show("No such data");
            }
        }
        /**
         * Closes the application
         */
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /**
         * increment the index and call the display
         */
        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            Display();
        }
        /**
         * 
         * private method to display if the indexed value got the corresponding value
         * 
         * 
         */
        private void Display()
        {
            try
            {
                textBox2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Out of boundary of the data");
                i = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            Display();
        }
        /**
         * tick is generated and incremented
         * 
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();
            if(_ticks == 300)
            {
                MessageBox.Show("Your 30 second is over");
                Environment.Exit(0);
            }
        }
    }
}
