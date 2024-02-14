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
    public partial class addDesk : Form
    {
        int idG;
        bl_game blg = new bl_game();

        public addDesk(int id)
        {
            InitializeComponent();
            idG = id;
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
            if (textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام میز را وارد کنید");
                textBoxX2.Focus();
            }
            else
            {
                if (blg.addDesk(textBoxX2.Text, idG))
                {
                    MessageBox.Show("میز با موفقیت اضافه شد", "افزودن میز", MessageBoxButtons.OK, MessageBoxIcon.Information
                            , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    textBoxX2.Clear();
                }
                else
                {
                    MessageBox.Show("این میز از قبل در لیست موجود است\nلطفا دوباره امتحان کنید", "افزودن میز", MessageBoxButtons.OK, MessageBoxIcon.Error
                            , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }


            
        }

        private void addDesk_Load(object sender, EventArgs e)
        {
            textBoxX2.Focus();
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
