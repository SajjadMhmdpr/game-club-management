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
    public partial class addPlayer : Form
    {
        Player p = new Player();
        bl_player blp = new bl_player();

        public addPlayer()
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

        private void button_tolidCode_Click(object sender, EventArgs e)
        {
            textBoxX_code1.Text = blp.productCode().ToString();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBoxX_name1.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام را وارد کنید");
                textBoxX_name1.Focus();
            }
            else if (textBoxX_family1.Text.Trim().Length == 0)
            {
                MessageBox.Show("فامیلی را وارد کنید");
                textBoxX_family1.Focus();
            }
            else if (textBoxX_tel1.Text.Trim().Length == 0 || textBoxX_tel1.Text.Trim().Length < 11)
            {
                MessageBox.Show("شماره تماس را وارد کنید");
                textBoxX_tel1.Focus();
            }
            else if (textBoxX_code1.Text.Trim().Length == 0 )
            {
                MessageBox.Show("کد را وارد کنید");
                textBoxX_code1.Focus();
            }
            else
            {
                p.plName = textBoxX_name1.Text;
                p.plFamily = textBoxX_family1.Text;
                p.plHazineBedehi = 0;
                p.plCode = Convert.ToInt32(textBoxX_code1.Text);
                p.plPhone = textBoxX_tel1.Text;
                p.plState = true;

                if (!blp.addPlayer(p))
                    MessageBox.Show("ثبت نشد\nاین شماره موبایل قبلا ثبت شده است", "ثبت نام",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                    , MessageBoxOptions.RightAlign);
                else
                {
                    MessageBox.Show("با موفقیت ثبت شد", "ثبت نام",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
                    , MessageBoxOptions.RightAlign);

                    textBoxX_tel1.Clear();
                    textBoxX_name1.Clear();
                    textBoxX_family1.Clear();
                    textBoxX_code1.Clear();
                    textBoxX_name1.Focus();
                }
            }
        }


        private void textBoxX_tel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxX_code1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }

        private void textBoxX_code1_Leave(object sender, EventArgs e)
        {
            if (textBoxX_code1.Text.Length > 0)
            {
                if (blp.searchCode(Convert.ToInt32(textBoxX_code1.Text)))
                {
                    MessageBox.Show("این کد از قبل در لیست وجود دارد", "ثبت کد",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                        , MessageBoxOptions.RightAlign);
                    textBoxX_code1.Focus();
                }
            }
        }
    }
}
