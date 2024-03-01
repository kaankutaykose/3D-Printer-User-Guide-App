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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int startIndex = richTextBox1.Find("1-", 0);
            richTextBox1.Select(startIndex, "1-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("2-", 0);
            richTextBox1.Select(startIndex, "2-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("3-", 0);
            richTextBox1.Select(startIndex, "3-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("4-", 0);
            richTextBox1.Select(startIndex, "4-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("5-", 0);
            richTextBox1.Select(startIndex, "5-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("6-", 0);
            richTextBox1.Select(startIndex, "6-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("7-", 0);
            richTextBox1.Select(startIndex, "7-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox1.Find("8-", 0);
            richTextBox1.Select(startIndex, "8-".Length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();
            
            startIndex = richTextBox8.Find("Hız:", 0);
            richTextBox8.Select(startIndex, "Hız:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();
            
            startIndex = richTextBox8.Find("Miniadım Z:", 0);
            richTextBox8.Select(startIndex, "Miniadım Z:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();
            
            startIndex = richTextBox8.Find("Durdurma/Duraklatma:", 0);
            richTextBox8.Select(startIndex, "Durdurma/Duraklatma:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();

            startIndex = richTextBox8.Find("Filament Değiştirme:", 0);
            richTextBox8.Select(startIndex, "Filament Değiştirme:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();

            startIndex = richTextBox8.Find("Sıcaklık- Fan Hızı- Akış Oranı:", 0);
            richTextBox8.Select(startIndex, "Sıcaklık- Fan Hızı- Akış Oranı:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();

            startIndex = richTextBox8.Find("Led Değiştirme:", 0);
            richTextBox8.Select(startIndex, "Led Değiştirme:".Length);
            richTextBox8.SelectionFont = new Font(richTextBox8.Font, FontStyle.Bold);
            richTextBox8.DeselectAll();

        }

       
    }
}
