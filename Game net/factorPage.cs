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
    public partial class factorPage : Form
    {
        Player p = new Player();
        bl_player blp = new bl_player();
        bl_history blh = new bl_history();
        int ID = -1;

        public factorPage(Player pp)
        {
            InitializeComponent();
            p = pp;
            //dataGridView_factor.AutoGenerateColumns = false;
            //dataGridView_factor.AutoSize = false;
        }

        private void factorPage_Load(object sender, EventArgs e)
        {
            styleDataGrid();
            labelX_nameAndFamily1.Text = p.plName + " " + p.plFamily;
            labelX_code1.Text = p.plCode.ToString();
            labelX_tel1.Text = p.plPhone;

            labelX_bedehi1.Text = p.plHazineBedehi.ToString();
            //if (p.plHazineBedehi > 0)
            //labelX_bedehi1.Text = "دارد";

            dataGridView_factor.AutoGenerateColumns = false;
            dataGridView_factor.AutoSize = false;
            dataGridView_factor.DataSource = blh.showFactor(p.id , 1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "نمایش")
            {
                //dataGridView_factor.AutoGenerateColumns = false;
                dataGridView_factor.DataSource = blh.showFactor(p.id, 0);
                button3_kolBedehi.Visible = true;
                button1.Text = "برگشت";
                if(dataGridView_factor.RowCount >0)
                    dataGridView_factor.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                //dataGridView_factor.AutoGenerateColumns = false;
                dataGridView_factor.DataSource = blh.showFactor(p.id, 1);
                button3_kolBedehi.Visible = false;
                button1.Text = "نمایش";
                dataGridView_factor.ContextMenuStrip = null;
            }
        }

        private void button3_kolBedehi_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("ایا از صفر کردن کل بدهی های این بازیکن اطمینان دارید ؟", "پرداخت کل بدهی ها", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (r == DialogResult.Yes)
            {
                blp.paidAllBedehiInAllTime(p.id);
                labelX_bedehi1.Text = "0";
                dataGridView_factor.DataSource = blh.showFactor(p.id, 0);
            }
            
        }



        private void پرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && ID!=-1)
            {

                labelX_bedehi1.Text = blh.pardakhtKolBedehi(ID).ToString();

                //dataGridView_factor.AutoGenerateColumns = false;
                //dataGridView_factor.AutoSize = false;
                dataGridView_factor.DataSource = blh.showFactor(p.id, 0);

                if (dataGridView_factor.RowCount == 0)
                {
                    dataGridView_factor.ContextMenuStrip = null;
                }
            }
        }

        private void پرداختنصفهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && ID != -1)
            {
                nesfePardakht np = new nesfePardakht(ID);
                np.ShowDialog();

                p = blp.search(p.id);
                labelX_bedehi1.Text = p.plHazineBedehi.ToString();
                //MessageBox.Show("بدهی با موفقیت پرداخت شد", "پرداخت بدهی", MessageBoxButtons.OK, MessageBoxIcon.Information
                //        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                //dataGridView_factor.AutoGenerateColumns = false;
                //dataGridView_factor.AutoSize = false;
                dataGridView_factor.DataSource = blh.showFactor(p.id, 0);

                if (dataGridView_factor.RowCount == 0)
                {
                    dataGridView_factor.ContextMenuStrip = null;
                }

            }
        }








        private void dataGridView_factor_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_factor.Rows[e.RowIndex].Selected = true;
                ID = (int)dataGridView_factor.Rows[e.RowIndex].Cells["iidd"].Value;
            }
        }

        private void dataGridView_factor_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_factor.Rows[e.RowIndex].Selected = false;
                ID = -1;
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










        void styleDataGrid()
        {
            dataGridView_factor.BorderStyle = BorderStyle.None;
            dataGridView_factor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_factor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_factor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_factor.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_factor.BackgroundColor = Color.FromArgb(246, 246, 246);

            dataGridView_factor.EnableHeadersVisualStyles = false;
            dataGridView_factor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_factor.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_factor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_factor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        
    }
}
