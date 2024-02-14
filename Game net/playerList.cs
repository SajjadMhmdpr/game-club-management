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
    public partial class playerList : Form
    {
        Employee emp = new Employee();
        Player p = new Player();
        bl_player blp  = new bl_player();
        int ID=-1;

        bool c = false;

        public playerList(Employee e)
        {
            InitializeComponent();
            emp = e;
        }

        private void playerList_Load(object sender, EventArgs e)
        {
            styleDataGrid();

            dataGridPlayerList.DataSource = blp.searchAndShowForPlayerList(textBoxX2.Text, c);

        }



        private void شروعبازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                p = blp.search(ID);
                chooseGame chgF = new chooseGame(p, emp);
                chgF.ShowDialog();
            }
        }
        private void فاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                p = blp.search(ID);
                factorPage facF = new factorPage(p);
                facF.ShowDialog();

                dataGridPlayerList.DataSource = blp.searchAndShowForPlayerList(textBoxX2.Text, c);
            }
        }


        /*private void dataGridPlayerList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0)
            {
                ID = (int)dataGridPlayerList.SelectedRows[0].Cells["plid"].Value;
                p = blp.search(ID);
            }
                
            //MessageBox.Show(ID.ToString());
        }*/

        private void dataGridPlayerList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0 && e.RowIndex!=-1)
            {

                dataGridPlayerList.Rows[e.RowIndex].Selected = true;
                ID = (int)dataGridPlayerList.Rows[e.RowIndex].Cells["plid"].Value; 
            }
        }
        private void dataGridPlayerList_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridPlayerList.Rows[e.RowIndex].Selected = false;
                ID = -1;
            }

        }





        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                c = true;
            else
                c = false;

            dataGridPlayerList.DataSource = blp.searchAndShowForPlayerList(textBoxX2.Text, c);
        }
        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            dataGridPlayerList.DataSource = blp.searchAndShowForPlayerList(textBoxX2.Text, c);
        }






        void styleDataGrid()
        {
            dataGridPlayerList.BorderStyle = BorderStyle.None;
            dataGridPlayerList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridPlayerList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPlayerList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridPlayerList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridPlayerList.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridPlayerList.BackgroundColor = Color.White;

            dataGridPlayerList.EnableHeadersVisualStyles = false;
            dataGridPlayerList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        
    }
}
