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
    public partial class pardakhtPage : Form
    {
        bl_history blh = new bl_history();
        bl_player blp = new bl_player();
        Player player = new Player();
        int hiId =-1 ;
        
        public pardakhtPage(int hiid)
        {
            InitializeComponent();
            player = blh.searchAndReturnHistory(hiid).player;
        }

        private void pardakhtPage_Load(object sender, EventArgs e)
        {
            dataGridView_dailyHistory.AutoSize = false;
            dataGridView_dailyHistory.AutoGenerateColumns = false;

            styleDataGrid();
            
            labelX_code1.Text = player.plCode.ToString();
            labelX_nameAndFamily1.Text = player.plName + " " + player.plFamily;
            labelX_tel1.Text = player.plPhone;

            updateDataGride();

            if (dataGridView_dailyHistory.RowCount == 0 )
            {
                dataGridView_dailyHistory.ContextMenuStrip = null;
            }


        }


        private void button3_kolHazine_Click(object sender, EventArgs e)
        {
            blp.paidAllGameToday(player.id);
            this.Close();
        }

        private void پرداختکاملToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hiId != -1)
            {
                blh.pardakhtKolBedehi(hiId);
                updateDataGride();

                if (dataGridView_dailyHistory.Rows.Count == 0)
                    this.Close();
            }
        }

        private void پرداختنصفهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hiId != -1)
            {
                nesfePardakht np = new nesfePardakht(hiId);
                np.ShowDialog();

                updateDataGride();

            }
        }










        private void dataGridView_dailyHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_dailyHistory.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_dailyHistory.Rows[e.RowIndex].Selected = true;
                hiId = (int)dataGridView_dailyHistory.Rows[e.RowIndex].Cells["iidd"].Value;
            }
        }

        private void dataGridView_dailyHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_dailyHistory.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_dailyHistory.Rows[e.RowIndex].Selected = false;
                hiId = -1;
            }
        }








        void styleDataGrid()
        {
            dataGridView_dailyHistory.BorderStyle = BorderStyle.None;
            dataGridView_dailyHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_dailyHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_dailyHistory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_dailyHistory.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_dailyHistory.BackgroundColor = Color.FromArgb(246, 246, 246);

            dataGridView_dailyHistory.EnableHeadersVisualStyles = false;
            dataGridView_dailyHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_dailyHistory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_dailyHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_dailyHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void updateDataGride()
        {
            labelX_hazineKol1.Text = blh.calPriceFactorsInPardahktPage(player.id).ToString();
            dataGridView_dailyHistory.DataSource = blh.showGamesPlayed(player.id);
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
