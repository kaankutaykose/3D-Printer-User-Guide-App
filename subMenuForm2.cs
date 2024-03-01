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
    public partial class subMenuForm2 : Form
    {
        public subMenuForm2()
        {
            InitializeComponent();
            
        }

        private void subMenuForm2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int startIndex = richTextBox2.Find("Lütfen dikkat ediniz(!).", 0);
            richTextBox2.Select(startIndex, "Lütfen dikkat ediniz(!).".Length);
            richTextBox2.SelectionColor = Color.Red;
            richTextBox2.DeselectAll();
            startIndex = richTextBox2.Find("Lütfen iyi bir havalandırma sağlandığından emin olunuz ve çıkan gazları çok", 0);
            richTextBox2.Select(startIndex, "Lütfen iyi bir havalandırma sağlandığından emin olunuz ve çıkan gazları çok".Length);
            richTextBox2.SelectionColor = Color.Red;
            richTextBox2.DeselectAll();
            startIndex = richTextBox2.Find("fazla solumayınız(!).", 0);
            richTextBox2.Select(startIndex, "fazla solumayınız(!).".Length);
            richTextBox2.SelectionColor = Color.Red;
            richTextBox2.DeselectAll();

        }
    }
}
