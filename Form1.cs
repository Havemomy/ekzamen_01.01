using mebl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mebelnoye_bezumie
{
    public partial class Form1 : Form
    {
        private mebel _name;
        public Form1()
        {
            InitializeComponent();
            _name = new mebel();
            _name.InInitialize();

            mebels_datagrid.DataSource = _name.mebel.ToList();
        }

        private void search_Click(object sender, EventArgs e)
        {
            
        }
    }
}
