using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarbantartokForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'karbantartokDataSet.Karbantartok' table. You can move, or remove it, as needed.
            this.karbantartokTableAdapter.Fill(this.karbantartokDataSet.Karbantartok);
            // TODO: This line of code loads data into the 'karbantartokDataSet.karbantartasok' table. You can move, or remove it, as needed.
            this.karbantartasokTableAdapter.Fill(this.karbantartokDataSet.karbantartasok);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
