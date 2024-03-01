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
    public partial class guideForm : Form
    {
        public guideForm()
        {
            InitializeComponent();
        }

        private void guideForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int startIndex = richTextBox1.Find("kutuyu dikkatlice açınız.", 0);
            richTextBox1.Select(startIndex, "kutuyu dikkatlice açınız.".Length);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.DeselectAll();
            startIndex = richTextBox1.Find("Cihazın içindeki elektronik panele ve", 0);
            richTextBox1.Select(startIndex, "Cihazın içindeki elektronik panele ve".Length);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.DeselectAll();
            startIndex = richTextBox1.Find("ekstrüdere dokunmayınız(!).", 0);
            richTextBox1.Select(startIndex, "ekstrüdere dokunmayınız(!).".Length);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.DeselectAll();
        }
    }
}
