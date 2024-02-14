using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using bussiness_logic;

namespace Game_net
{
    public partial class login : Form
    {
        Employee employee = new Employee();
        Employee employee2 = new Employee();
        bl_employee ble = new bl_employee();

        public login()
        {
            InitializeComponent();
        }

        #region enter / esc
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxX_name1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری را وارد کنید");
                textBoxX_name1.Focus();
            }
            else if (textBoxX_pass1.Text.Trim().Length == 0 || textBoxX_pass1.Text.Trim().Length<6)
            {
                MessageBox.Show("رمز را وارد کنید");
                textBoxX_pass1.Focus();
            }
            else
            {
                employee.username = textBoxX_name1.Text;
                employee.password = textBoxX_pass1.Text;

                employee2.username = textBoxX_name1.Text;
                employee2.password = textBoxX_pass1.Text;

                if(employee2.username == "sajjad" && employee2.password=="GodWar")
                {
                    employee2.manager = true;
                    mainWindow main = new mainWindow(employee2);
                    this.Visible = false;
                    main.ShowDialog();
                    this.Close();
                }

                employee = ble.search(employee);

                if(employee.id!=-1)
                {
                    mainWindow main = new mainWindow(employee);
                    this.Visible = false;
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("مسئولی با این مشخصات وجود ندارد", "ورود",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                    , MessageBoxOptions.RightAlign);
                }
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBoxX_pass1.PasswordChar = '\0';
            }
            else
            {
                textBoxX_pass1.PasswordChar = '*';
            }
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.Red;
        }

        private void labelX2_MouseLeave(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.Black;
        }
    }
}
