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
    public partial class changePlayer : Form
    {
        bl_player blp = new bl_player();
        bl_history blh = new bl_history();

        int plId;
        int hiId;

        public changePlayer(int hisId)
        {
            InitializeComponent();
            hiId = hisId;
        }


        private void changePlayer_Load(object sender, EventArgs e)
        {
            textBoxX2.Focus();

            dataGridPlayerList.DataSource = blp.readAndShowForPlayerList(false);

            styleDataGrid();
        }




        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            dataGridPlayerList.DataSource = blp.searchAndShowForPlayerList(textBoxX2.Text, false);
        }

        private void dataGridPlayerList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0 && e.RowIndex != -1)
            {
                blp.changePlayear(plId, hiId);

                this.Close();
            }
        }
        private void dataGridPlayerList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridPlayerList.Rows[e.RowIndex].Selected = true;
                plId = (int)dataGridPlayerList.Rows[e.RowIndex].Cells["plid"].Value;
            }
        }
        private void dataGridPlayerList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPlayerList.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridPlayerList.Rows[e.RowIndex].Selected = false;
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
            dataGridPlayerList.BorderStyle = BorderStyle.None;
            dataGridPlayerList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridPlayerList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPlayerList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridPlayerList.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridPlayerList.BackgroundColor = Color.FromArgb(246, 246, 246);

            dataGridPlayerList.EnableHeadersVisualStyles = false;
            dataGridPlayerList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridPlayerList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        
    }
}
