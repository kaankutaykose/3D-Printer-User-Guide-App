using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teira3D
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        errorForm errorForm;
        aboutForm aboutForm;
        contactForm contactForm;
        guideForm guideForm;
        subMenuForm subMenuForm;
        subMenuForm2 subMenuForm2;
        cleaningForm cleaningForm;
        guaranteeForm guaranteeForm;
        dictionaryForm dictionaryForm;
        calibrationForm calibrationForm;

        
        public Form1()
        {
            InitializeComponent();
            mdiProp();
            
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += panel1_MouseDown;

        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 165)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                    
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 7;
                if(sidebar.Width <= 53)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnGuide.Width = sidebar.Width;
                    pnErrors.Width = sidebar.Width;
                    pnContact.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 7;
                if(sidebar.Width >= 238)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnGuide.Width = sidebar.Width;
                    pnErrors.Width = sidebar.Width;
                    pnContact.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width; 
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        
        // Hata Kodları Sayfası
        private void buttonErrors_Click(object sender, EventArgs e)
        {
            if(errorForm == null)
            {
                errorForm = new errorForm();
                errorForm.FormClosed += errorForm_FormClosed;
                errorForm.MdiParent = this;
                errorForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                errorForm.Show();
            }
            else
            {
                errorForm.Activate();
                //sidebarTransition.Start();
            }
        }

        private void errorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            errorForm = null;
        }

        // İletişim Sayfası
        private void buttonContact_Click(object sender, EventArgs e)
        {
            if (contactForm == null)
            {
                contactForm = new contactForm();
                contactForm.FormClosed += contactForm_FormClosed;
                contactForm.MdiParent = this;
                contactForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                contactForm.Show();
            }
            else
            {
                contactForm.Activate();
                //sidebarTransition.Start();
            }
        }
        private void contactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            contactForm = null;
        }
        
        // Hakkımızda Sayfası
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new aboutForm();
                aboutForm.FormClosed += aboutForm_FormClosed;
                aboutForm.MdiParent = this;
                aboutForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                aboutForm.Show();
            }
            else
            {
                aboutForm.Activate();
                //sidebarTransition.Start();
            }
        }
        private void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutForm = null;
        }

        // Kullanım Kılavuzu Sayfası
        private void buttonUserGuide_Click(object sender, EventArgs e)
        {
            if (guideForm == null)
            {
                guideForm = new guideForm();
                guideForm.FormClosed += guideForm_FormClosed;
                guideForm.MdiParent = this;
                guideForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                guideForm.Show();
            }
            else
            {
                guideForm.Activate();
                //sidebarTransition.Start();
            }
        }

        private void guideForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            guideForm = null;
        }
        // Sub Menu 1
        private void subMenu1_Click(object sender, EventArgs e)
        {
            if (subMenuForm == null)
            {
                subMenuForm = new subMenuForm();
                subMenuForm.FormClosed += subMenuForm_FormClosed;
                subMenuForm.MdiParent = this;
                subMenuForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                subMenuForm.Show();
            }
            else
            {
                subMenuForm.Activate();
                //sidebarTransition.Start();
            }
        }

        private void subMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            subMenuForm = null;
        }

        // Sub Menu 2
        private void subMenu2_Click(object sender, EventArgs e)
        {
            if (subMenuForm2 == null)
            {
                subMenuForm2 = new subMenuForm2();
                subMenuForm2.FormClosed += subMenuForm2_FormClosed;
                subMenuForm2.MdiParent = this;
                subMenuForm2.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                subMenuForm2.Show();
            }
            else
            {
                subMenuForm2.Activate();
                //sidebarTransition.Start();
            }
        }

        private void subMenuForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            subMenuForm2 = null;
        }

        // Bakım ve Temizlik
        private void btnCleaning_Click(object sender, EventArgs e)
        {
            if (cleaningForm == null)
            {
                cleaningForm = new cleaningForm();
                cleaningForm.FormClosed += cleaningForm_FormClosed;
                cleaningForm.MdiParent = this;
                cleaningForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                cleaningForm.Show();
            }
            else
            {
                cleaningForm.Activate();
                //sidebarTransition.Start();
            }

        }

        private void cleaningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cleaningForm = null;
        }

        // Garanti
        private void btnGuarantee_Click(object sender, EventArgs e)
        {
            if (guaranteeForm == null)
            {
                guaranteeForm = new guaranteeForm();
                guaranteeForm.FormClosed += guaranteeForm_FormClosed;
                guaranteeForm.MdiParent = this;
                guaranteeForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                guaranteeForm.Show();
            }
            else
            {
                guaranteeForm.Activate();
                //sidebarTransition.Start();
            }
        }

        private void guaranteeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            guaranteeForm = null;
        }

        // Sözlük

         private void btnDictionary_Click(object sender, EventArgs e)
        {
            if (dictionaryForm == null)
            {
                dictionaryForm = new dictionaryForm();
                dictionaryForm.FormClosed += dictionaryForm_FormClosed;
                dictionaryForm.MdiParent = this;
                dictionaryForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                dictionaryForm.Show();
            }
            else
            {
                dictionaryForm.Activate();
                //sidebarTransition.Start();
            }
        }
        private void dictionaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dictionaryForm = null;
        }

        // İletişim
        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            if (calibrationForm == null)
            {
                calibrationForm = new calibrationForm();
                calibrationForm.FormClosed += calibrationForm_FormClosed;
                calibrationForm.MdiParent = this;
                calibrationForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                calibrationForm.Show();
            }
            else
            {
                calibrationForm.Activate();
                //sidebarTransition.Start();
            }
        }

        private void calibrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            calibrationForm = null;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Formu sürükleme işlemini başlat
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (calibrationForm == null)
            {
                calibrationForm = new calibrationForm();
                calibrationForm.FormClosed += calibrationForm_FormClosed;
                calibrationForm.MdiParent = this;
                calibrationForm.Dock = DockStyle.Fill;
                //sidebarTransition.Start();
                calibrationForm.Show();
            }
            else
            {
                calibrationForm.Activate();
                //sidebarTransition.Start();
            }
        }
    }
}
