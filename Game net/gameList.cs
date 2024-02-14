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
    public partial class gameList : Form
    {
        bl_game blg = new bl_game();
        int IDg, IDd;


        public gameList()
        {
            InitializeComponent();
        }

        private void gameList_Load(object sender, EventArgs e)
        {
            styleDataGrid();
            dataGridView_games.DataSource = blg.readGames(false);
            //dataGridView1.Rows.Add();
        }

        

        private void جذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("ایا از حذف  بازی (" +blg.searchGame(IDg).acName+ ") اطمینان دارید ؟", "حذف بازی", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (r == DialogResult.Yes)
            {
                blg.deleteGame(IDg);
                MessageBox.Show("بازی با موفقیت حذف شد", "حذف بازی", MessageBoxButtons.OK, MessageBoxIcon.Information
                        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                dataGridView_games.DataSource = blg.readGames(false);
                dataGridView_desks.DataSource = blg.readDesks(IDg);
            }
            
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("ایا از حذف میز (" + blg.searchDesk(IDd).deskCode + ") اطمینان دارید ؟", "حذف میز", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (r == DialogResult.Yes)
            {
                blg.deleteDesk(IDd);
                MessageBox.Show("میز با موفقیت حذف شد", "حذف میز", MessageBoxButtons.OK, MessageBoxIcon.Information
                        , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                dataGridView_games.DataSource = blg.readGames(false);
                dataGridView_desks.DataSource = blg.readDesks(IDg);
            }
            
        }

        private void افزودنمیزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDesk f = new addDesk(IDg);
            f.ShowDialog();
            dataGridView_games.DataSource = blg.readGames(false);
            dataGridView_desks.DataSource = blg.readDesks(IDg);
        }

        
        private void button_add_Click(object sender, EventArgs e)
        {
            addGame f = new addGame();
            f.ShowDialog();
            dataGridView_games.DataSource = blg.readGames(false);
            dataGridView_desks.DataSource = blg.readDesks(IDg);
        }

        private void ویرایشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateGame f = new updateGame(IDg);
            f.ShowDialog();
            
            dataGridView_desks.DataSource = blg.readDesks(IDg);
            dataGridView_games.DataSource = blg.readGames(false);

        }



        private void dataGridView_desks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_desks.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_desks.Rows[e.RowIndex].Selected = true;
                IDd = (int)dataGridView_desks.Rows[e.RowIndex].Cells["iddd"].Value;
            }
        }
        private void dataGridView_desks_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_desks.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_desks.Rows[e.RowIndex].Selected = false;
            }
        }




        /*private void dataGridView_games_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_games.RowCount > 0)
            {
                IDg = (int)dataGridView_games.SelectedRows[0].Cells["id"].Value;
                //IDg = (int)dataGridView_games.CurrentRow.Cells["idG"].Value;
                dataGridView_desks.DataSource = blg.readDesks(IDg);
            }
        }*/
        private void dataGridView_games_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_games.RowCount > 0 && e.RowIndex != -1)
            {

                dataGridView_games.Rows[e.RowIndex].Selected = true;
                IDg = (int)dataGridView_games.Rows[e.RowIndex].Cells["id"].Value;
                //dataGridView_desks.DataSource = blg.readDesks(IDg);
            }
        }
        private void dataGridView_games_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_games.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_games.Rows[e.RowIndex].Selected = false;
            }
        }

        private void dataGridView_games_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_games.RowCount > 0)
            {
                //IDg = (int)dataGridView_games.SelectedRows[0].Cells["id"].Value;
                //IDg = (int)dataGridView_games.CurrentRow.Cells["idG"].Value;
                dataGridView_desks.DataSource = blg.readDesks(IDg);
            }
        }

        void styleDataGrid()
        {
            dataGridView_games.BorderStyle = BorderStyle.None;
            dataGridView_games.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_games.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_games.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_games.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_games.BackgroundColor = Color.White;

            dataGridView_games.EnableHeadersVisualStyles = false;
            dataGridView_games.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_games.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_games.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_games.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            dataGridView_desks.BorderStyle = BorderStyle.None;
            dataGridView_desks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_desks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_desks.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_desks.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_desks.BackgroundColor = Color.White;

            dataGridView_desks.EnableHeadersVisualStyles = false;
            dataGridView_desks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_desks.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_desks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_desks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
    }
}
