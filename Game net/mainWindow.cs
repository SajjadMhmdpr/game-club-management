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
using model;

namespace Game_net
{
    public partial class mainWindow : Form
    {
        Employee employee = new Employee();
        public mainWindow(Employee e)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            employee = e;
        }

        Form ActiveForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            multiPanel2.Controls.Add(childForm);
            multiPanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mainWindow_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            if(employee.manager == false)
            {
                btn_gameList.Visible = false;
                btn_employeeList.Visible = false;
                btn_filterHistory.Visible = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new playerList(employee));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new darhalEjra(employee));
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new employeeList());
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new historyFilterPage());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new addPlayer());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new gameList());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dailyHistoryPage());
        }














        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        private void labelX1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX1_MouseHover(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Red;
        }

        private void labelX1_MouseLeave(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.White;
        }

        private void labelX2_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
            
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.Cyan;
        }

        private void labelX2_MouseLeave(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.White;
        }

        private void labelX3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelX3_MouseHover(object sender, EventArgs e)
        {
            labelX3.ForeColor = Color.Cyan;
        }

        private void labelX3_MouseLeave(object sender, EventArgs e)
        {
            labelX3.ForeColor = Color.White;
        }

        
    }
}
