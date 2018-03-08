using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConversionApplication
{
    public partial class Form1 : Form
    {
        // Custom class coded to validate user inputs
        private BinaryValidator myValidator = new BinaryValidator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Text = "";
            this.radUnsigned.Checked = true;
        }

        
        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
