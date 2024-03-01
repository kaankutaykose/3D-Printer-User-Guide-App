using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teira3D
{
    public partial class calibrationForm : Form
    {
        public calibrationForm()
        {
            InitializeComponent();
        }

        private void calibrationForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
