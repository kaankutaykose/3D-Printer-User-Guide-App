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
    public partial class errorForm : Form
    {
        public errorForm()
        {
            InitializeComponent();
        }

        private void errorForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void errorForm_OnMouseWheel(object sender, MouseEventArgs e)
        {
            // Fare tekerleği yukarı doğru döndürülürse, formda yukarı kaydırın.
            if (e.Delta > 0)
            {
                this.AutoScrollPosition = new Point(this.AutoScrollPosition.X, this.AutoScrollPosition.Y - e.Delta);
            }
            // Fare tekerleği aşağı doğru döndürülürse, formda aşağı kaydırın.
            else if (e.Delta < 0)
            {
                this.AutoScrollPosition = new Point(this.AutoScrollPosition.X, this.AutoScrollPosition.Y - e.Delta);
            }
        }
    }
}
