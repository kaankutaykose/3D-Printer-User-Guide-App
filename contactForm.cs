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
    public partial class contactForm : Form
    {
        public contactForm()
        {
            InitializeComponent();
        }

        private void contactForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int startIndex = richTextBox3.Find("Bu işlem mekan sıcaklık ve nem değerlerinde çok bir değişiklik olmadığı", 0);
            richTextBox3.Select(startIndex, "Bu işlem mekan sıcaklık ve nem değerlerinde çok bir değişiklik olmadığı".Length);
            richTextBox3.SelectionFont = new Font(richTextBox3.Font, FontStyle.Bold);
            richTextBox3.SelectionColor = Color.Red;
            richTextBox3.DeselectAll();
            
            startIndex = richTextBox3.Find("sürece 4-5 ayda bir yapılmalıdır.", 0);
            richTextBox3.Select(startIndex, "sürece 4-5 ayda bir yapılmalıdır.".Length);
            richTextBox3.SelectionFont = new Font(richTextBox3.Font, FontStyle.Bold);
            richTextBox3.SelectionColor = Color.Red;
            richTextBox3.DeselectAll();

        }

       
    }
}
