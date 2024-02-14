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
    public partial class nesfePardakht : Form
    {
        bl_history blh = new bl_history();
        History history = new History();

        public nesfePardakht(int hiid)
        {
            InitializeComponent();
            history = blh.searchAndReturnHistory(hiid);
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

        private void nesfePardakht_Load(object sender, EventArgs e)
        {
            labelX_mande.Text = (history.hiHazineKol - history.Paid).ToString();
            textBoxX2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxX2.Text.Trim().Length<4)
            {
                MessageBox.Show("مبلغ نمیتواند کمتر از 1000 تومان باید");
                textBoxX2.Focus();
            }
            else
            {

                if(blh.pardakhtNesfeOneHistory( history.id , Convert.ToInt32(textBoxX2.Text) ) )
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("مقدار نا معتبر", "ثبت بدهی",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                    , MessageBoxOptions.RightAlign);

                    textBoxX2.Focus();
                }

                
            }
        }



        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void labelX1_MouseHover(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Red;
        }

        private void labelX1_MouseLeave(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.White;
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
