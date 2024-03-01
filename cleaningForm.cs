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
    public partial class cleaningForm : Form
    {
        public cleaningForm()
        {
            InitializeComponent();
        }

        private void Cleaning_Load(object sender, EventArgs e)
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

            startIndex = richTextBox5.Find("UYARI: Cihazınıza bakım yapmadan önce cihazınızın kapalı konumda ve", 0);
            richTextBox5.Select(startIndex, "UYARI: Cihazınıza bakım yapmadan önce cihazınızın kapalı konumda ve".Length);
            richTextBox5.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox5.SelectionColor = Color.Red;
            richTextBox5.DeselectAll();
            
            startIndex = richTextBox5.Find("bile kesinlikle cihazın güç kaynağına müdahale etmeyiniz.", 0);
            richTextBox5.Select(startIndex, "bile kesinlikle cihazın güç kaynağına müdahale etmeyiniz.\r\n".Length);
            richTextBox5.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox5.SelectionColor = Color.Red;
            richTextBox5.DeselectAll();
            
            startIndex = richTextBox5.Find("fişinin prizden çıkarılmış olduğuna emin olun. Cihaz kapalı ve fişi çekilmiş olsa", 0);
            richTextBox5.Select(startIndex, "fişinin prizden çıkarılmış olduğuna emin olun. Cihaz kapalı ve fişi çekilmiş olsa".Length);
            richTextBox5.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox5.SelectionColor = Color.Red;
            richTextBox5.DeselectAll();

            startIndex = richTextBox6.Find("(Bu bölümde ısıtıcı fişek ve termistörü", 0);
            richTextBox6.Select(startIndex, "(Bu bölümde ısıtıcı fişek ve termistörü".Length);
            richTextBox6.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox6.SelectionColor = Color.Red;
            richTextBox6.DeselectAll();

            startIndex = richTextBox6.Find("değiştirmek isterseniz kablo bağlarını çıkartıp", 0);
            richTextBox6.Select(startIndex, "değiştirmek isterseniz kablo bağlarını çıkartıp".Length);
            richTextBox6.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox6.SelectionColor = Color.Red;
            richTextBox6.DeselectAll();

            startIndex = richTextBox6.Find("yeni ısıtıcı fişek ve termistörü çıkarırken", 0);
            richTextBox6.Select(startIndex, "yeni ısıtıcı fişek ve termistörü çıkarırken".Length);
            richTextBox6.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox6.SelectionColor = Color.Red;
            richTextBox6.DeselectAll();

            startIndex = richTextBox6.Find("bulundukları seviyeye kadar getirip", 0);
            richTextBox6.Select(startIndex, "bulundukları seviyeye kadar getirip".Length);
            richTextBox6.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox6.SelectionColor = Color.Red;
            richTextBox6.DeselectAll();

            startIndex = richTextBox6.Find("setskurlarını sıkınız.)", 0);
            richTextBox6.Select(startIndex, "setskurlarını sıkınız.)".Length);
            richTextBox6.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox6.SelectionColor = Color.Red;
            richTextBox6.DeselectAll();

        }
    }
}
