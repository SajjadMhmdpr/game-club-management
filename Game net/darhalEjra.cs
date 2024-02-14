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
    public partial class darhalEjra : Form
    {
        //Player p = new Player();
        bl_player blp = new bl_player();
        bl_history blh = new bl_history();
        Employee employee = new Employee();
        int ID=-1;
        public darhalEjra(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private void darhalEjra_Load(object sender, EventArgs e)
        {
            styleDataGrid();
            dataGridDarhalEjra2.AutoGenerateColumns = false;
            //dataGridDarhalEjra2.AutoSize = false;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = blh.readAndShowForDarhalEjra();
            dataGridDarhalEjra2.DataSource = blh.readAndShowForDarhalEjra();
        }



        private void dataGridDarhalEjra2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && e.RowIndex != -1)
            {

                dataGridDarhalEjra2.Rows[e.RowIndex].Selected = true;
                ID = (int)dataGridDarhalEjra2.Rows[e.RowIndex].Cells["hi_id"].Value;
            }
        }
        private void dataGridDarhalEjra2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridDarhalEjra2.Rows[e.RowIndex].Selected = false;
                ID = -1;
            }
        }





        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
        }

        private void پایانبازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && ID!=-1)
            {
                History h = blh.showInformationPardakht(ID);
                //blp.closeGame(h);
                oneGameFactor pf = new oneGameFactor(h);
                pf.button1_confirm.Visible = true;
                pf.ShowDialog();

                dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
            }
        }
        private void تغییربازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && ID != -1)
            {
                History h = blh.showInformationPardakht(ID);
                //blp.closeGame(h);
                oneGameFactor pf = new oneGameFactor(h);
                pf.button_changeGame.Visible = true;
                pf.ShowDialog();

                //h = blh.searchAndReturnHistory(ID);
                //chooseGame chgF = new chooseGame(h.player, employee);
                //chgF.ShowDialog();

                dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && ID != -1)
            {
                var r = MessageBox.Show("ایا از حذف این تاریخچه اطمینان دارید ؟", "حذف تاریخچه", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (r == DialogResult.Yes)
                {
                    blh.delete(ID);
                    //MessageBox.Show("تاریخچه با موفقیت حذف شد", "حذف تاریخچه", MessageBoxButtons.OK, MessageBoxIcon.Information
                    //        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
                }
            }
        }

        private void تغییربازیکنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && ID != -1)
            {
                changePlayer chp = new changePlayer(ID);
                chp.ShowDialog();
                //dataGridDarhalEjra2.DataSource = blh.readAndShowForDarhalEjra();
                dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
            }
        }
        private void پایانبازیوپرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridDarhalEjra2.RowCount > 0 && ID != -1)
            {
                History h = blh.showInformationPardakht(ID);
                blp.closeGame(h);

                pardakhtPage pr = new pardakhtPage(ID);
                pr.ShowDialog();
                //dataGridDarhalEjra2.DataSource = blh.readAndShowForDarhalEjra();
                dataGridDarhalEjra2.DataSource = blh.searchAndShowForDarhalEjra(textBoxX2.Text);
            }
        }







        void styleDataGrid()
        {
            dataGridDarhalEjra2.BorderStyle = BorderStyle.None;
            dataGridDarhalEjra2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridDarhalEjra2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridDarhalEjra2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridDarhalEjra2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridDarhalEjra2.BackgroundColor = Color.White;

            dataGridDarhalEjra2.EnableHeadersVisualStyles = false;
            dataGridDarhalEjra2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridDarhalEjra2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridDarhalEjra2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridDarhalEjra2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        
    }
}
