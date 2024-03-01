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
    public partial class dictionaryForm : Form
    {
        public dictionaryForm()
        {
            InitializeComponent();
        }

        private void dictionaryForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            int startIndex = richTextBox2.Find(".GCODE:", 0);
            richTextBox2.Select(startIndex, ".GCODE:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();
            
            startIndex = richTextBox2.Find(".OBJ-.AMF:", 0);
            richTextBox2.Select(startIndex, ".OBJ-.AMF:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find(".STL:", 0);
            richTextBox2.Select(startIndex, ".STL:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("3 Boyutlu Baskı:", 0);
            richTextBox2.Select(startIndex, "3 Boyutlu Baskı:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("ABS:", 0);
            richTextBox2.Select(startIndex, "ABS:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Baskı Hızı Çarpanı:", 0);
            richTextBox2.Select(startIndex, "Baskı Hızı Çarpanı:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Dahili Depolama:", 0);
            richTextBox2.Select(startIndex, "Dahili Depolama:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Destek:", 0);
            richTextBox2.Select(startIndex, "Destek:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Dilimleme Yazılımı:", 0);
            richTextBox2.Select(startIndex, "Dilimleme Yazılımı:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Ekstruder:", 0);
            richTextBox2.Select(startIndex, "Ekstruder:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Fan:", 0);
            richTextBox2.Select(startIndex, "Fan:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("FDM:", 0);
            richTextBox2.Select(startIndex, "FDM:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("FLEX:", 0);
            richTextBox2.Select(startIndex, "FLEX:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Filament:", 0);
            richTextBox2.Select(startIndex, "Filament:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Filament Sensörü: ", 0);
            richTextBox2.Select(startIndex, "Filament Sensörü:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Isıtıcı Fişek:", 0);
            richTextBox2.Select(startIndex, "Isıtıcı Fişek:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Kılavuz Tüp:", 0);
            richTextBox2.Select(startIndex, "Kılavuz Tüp:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("LCD Ekran:", 0);
            richTextBox2.Select(startIndex, "LCD Ekran:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Manyetik Baskı Tablası:", 0);
            richTextBox2.Select(startIndex, "Manyetik Baskı Tablası:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Nozül:", 0);
            richTextBox2.Select(startIndex, "Nozül:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("PLA:", 0);
            richTextBox2.Select(startIndex, "PLA:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Set Değeri:", 0);
            richTextBox2.Select(startIndex, "Set Değeri:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("SD Kart:", 0);
            richTextBox2.Select(startIndex, "SD Kart:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();

            startIndex = richTextBox2.Find("Yazdırma:", 0);
            richTextBox2.Select(startIndex, "Yazdırma:".Length);
            richTextBox2.SelectionFont = new Font(richTextBox2.Font, FontStyle.Bold);
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.DeselectAll();
        }
    }
}
