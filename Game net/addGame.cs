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
    public partial class addGame : Form
    {
        Game game = new Game();
        bl_game blg = new bl_game();
        public addGame()
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
            if(textBoxX2.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام بازی را وارد کنید");
                textBoxX2.Focus();
            }
            else if(textBoxX3.Text.Trim().Length == 0 )
            {
                MessageBox.Show("قیمت را درست وارد کنید");
                textBoxX3.Focus();
            }
            else if (textBoxX1.Text.Trim().Length == 0 )
            {
                MessageBox.Show("قیمت دسته را درست وارد کنید");
                textBoxX1.Focus();
            }
            else
            {
                game.acName = textBoxX2.Text;
                game.acPrice = Convert.ToDouble(textBoxX3.Text);
                game.acControllerPrice = Convert.ToDouble(textBoxX1.Text);

                if (blg.addGame(game))
                {
                    MessageBox.Show("بازی با موفقیت اضافه شد\n\nمیتوانید با راست کلیک بر روی نام بازی به آن میز اضافه کنید", "افزودن بازی", MessageBoxButtons.OK, MessageBoxIcon.Information
                        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("این بازی از قبل در لیست موجود است\nلطفا دوباره امتحان کنید", "افزودن بازی", MessageBoxButtons.OK, MessageBoxIcon.Information
                        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }

            }
            
        }





        private void addGame_Load(object sender, EventArgs e)
        {
            textBoxX2.Focus();
        }

        private void labelX2_MouseHover(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.Red;
        }

        private void labelX2_MouseLeave(object sender, EventArgs e)
        {
            labelX2.ForeColor = Color.Black;
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
