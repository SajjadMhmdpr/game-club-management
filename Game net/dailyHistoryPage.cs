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
    public partial class dailyHistoryPage : Form
    {

        bl_history blh = new bl_history();
        bl_game blg = new bl_game();
        bool pardakhtSHod = false;
        bool pardakhtNashod = true;
        bool darEjra = false;

        int hiId=-1;


        public dailyHistoryPage()
        {
            InitializeComponent();
        }

        private void dailyHistoryPage_Load(object sender, EventArgs e)
        {
            dataGridView_factor.AutoSize = false;
            dataGridView_factor.AutoGenerateColumns = false;
            checkBox2_pardakhtSHod.Checked = false;
            checkBox1_pardakhtNashod.Checked = true;
            //checkBox1_pardakhtNashod.Enabled = false;
            setContexMeno();
            styleDataGrid();
            

            dataGridView_factor.DataSource=blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod,false);
        }




        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                pardakhtPage pr = new pardakhtPage(hiId);
                pr.ShowDialog();

                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, false);
            }
        }


        private void اتمامبازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                History h = blh.showInformationPardakht(hiId);
                oneGameFactor pf = new oneGameFactor(h);
                pf.button1_confirm.Visible = true;
                pf.ShowDialog();

                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, darEjra);
            }
        }
        private void تغییربازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                History h = blh.showInformationPardakht(hiId);

                oneGameFactor pf = new oneGameFactor(h);
                pf.button_changeGame.Visible = true;
                pf.ShowDialog();

                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, darEjra);
            }
        }
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                var r = MessageBox.Show("ایا از حذف این تاریخچه اطمینان دارید ؟", "حذف تاریخچه", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (r == DialogResult.Yes)
                {
                    blh.delete(hiId);
                    dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, darEjra);
                }
            }
        }


        private void تغییربازیکنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                changePlayer chp = new changePlayer(hiId);
                chp.ShowDialog();
                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, true);

            }
        }
        private void تغییربازیکنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                changePlayer chp = new changePlayer(hiId);
                chp.ShowDialog();
                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, false);
            }
        }

        private void پایانبازیوپرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && hiId != -1)
            {
                History h = blh.showInformationPardakht(hiId);
                bl_player blp = new bl_player();
                blp.closeGame(h);

                pardakhtPage pr = new pardakhtPage(hiId);
                pr.ShowDialog();

                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, false, false, true);
            }
        }








        private void dataGridView_factor_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_factor.Rows[e.RowIndex].Selected = true;
                hiId = (int)dataGridView_factor.Rows[e.RowIndex].Cells["iidd"].Value;
            }
        }
        private void dataGridView_factor_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_factor.Rows[e.RowIndex].Selected = false;
                hiId = -1;
            }
        }



        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, darEjra);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2_pardakhtSHod.Checked)
            {
                setContexMeno();

                pardakhtSHod = true;
                //checkBox1_pardakhtNashod.Enabled = true;
            }
            else
            {
                setContexMeno();

                pardakhtSHod = false;
                //checkBox1_pardakhtNashod.Enabled = false;
            }
            dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_pardakhtNashod.Checked)
            {
                setContexMeno();
                pardakhtNashod = true;
                //checkBox2_pardakhtSHod.Enabled = true;
            }
            else
            {
                setContexMeno();
                pardakhtNashod = false;
                //checkBox2_pardakhtSHod.Enabled = false;
            }
            dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod, false);
        }

        private void checkBox_darhalEjra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_darhalEjra.Checked)
            {
                setContexMeno();
                darEjra = true;
                checkBox2_pardakhtSHod.Enabled = false;
                checkBox1_pardakhtNashod.Enabled = false;
                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, false, false, true);
            }
            else
            {
                setContexMeno();
                darEjra = false;
                checkBox2_pardakhtSHod.Enabled = true;
                checkBox1_pardakhtNashod.Enabled = true;
                dataGridView_factor.DataSource = blh.showAndSearchInDayliHistory(textBoxX1.Text, pardakhtSHod, pardakhtNashod,false);
            }
            
        }








        void styleDataGrid()
        {
            dataGridView_factor.BorderStyle = BorderStyle.None;
            dataGridView_factor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_factor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_factor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_factor.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_factor.BackgroundColor = Color.White;

            //dataGridView_factor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_factor.EnableHeadersVisualStyles = false;
            dataGridView_factor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_factor.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_factor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_factor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void setContexMeno()
        {
            if(checkBox1_pardakhtNashod.Checked && !checkBox2_pardakhtSHod.Checked)
                dataGridView_factor.ContextMenuStrip = cms_pardakhtNashod;

            if (checkBox2_pardakhtSHod.Checked)
                dataGridView_factor.ContextMenuStrip = null;

            if (checkBox_darhalEjra.Checked)
                dataGridView_factor.ContextMenuStrip = cms_darhalEjra;

        }

        
    }
}
