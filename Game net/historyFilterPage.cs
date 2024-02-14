using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using model;
using bussiness_logic;


namespace Game_net
{
    public partial class historyFilterPage : Form
    {

        PersianCalendar p = new PersianCalendar();
        //DateTime d = dateTimePicker1.Value.Date;
        //MessageBox.Show(p.GetYear(d).ToString());

        bl_history blh = new bl_history();
        bl_game blg = new bl_game();

        List<string> selectedGames = new List<string>();
        List<string> selectedDesks = new List<string>();

        public historyFilterPage()
        {
            InitializeComponent();
            
        }


        private void historyPage_Load(object sender, EventArgs e)
        {
            //checkedListBox1.Items.AddRange(blg.readGames().ToArray());
            //checkedListBox1.DisplayMember = "acName";
            styleDataGrid();
            int i = 0;
            foreach (var item in blg.readGames(true))
            {
                checkedListBox1_game.Items.Add(item.acName);
                checkedListBox1_game.SetItemChecked(i, true);
                i++;
            }

            setSelectedGames();

            List<string> games = blg.getSelectedGameDesks(selectedGames);
            i = 0;
            foreach (var item in games)
            {
                checkedListBox2_desk.Items.Add(item);
                checkedListBox2_desk.SetItemChecked(i, true);
                i++;
            }

            //dataGridView_factor.AutoSize = false;
            dataGridView_factor.AutoGenerateColumns = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sdate = persianDatePicker_start.PersianDate.ToString()
                , edate = persianDatePicker2_end.PersianDate.ToString();
            
            if(sdate=="" )
            {
                MessageBox.Show("تاریخ شروع را وارد کنید");
                persianDatePicker_start.Focus();
            }
            else if( edate == "")
            {
                MessageBox.Show("تاریخ پایان را وارد کنید");
                persianDatePicker2_end.Focus();
            }
            else
            {
                int daramad = 0 , bedehi = 0;
                dataGridView_factor.DataSource = blh.showAllHistory(sdate, edate,ref daramad,ref bedehi);
                textBoxX_dramad1.Text = daramad.ToString();
                textBoxX_bedehi1.Text = bedehi.ToString();
            }

        }


        private void button_filter_Click(object sender, EventArgs e)
        {
            string sdate = persianDatePicker_start.PersianDate.ToString()
                , edate = persianDatePicker2_end.PersianDate.ToString();
            setSelectedDesks();

            if (sdate == "")
            {
                MessageBox.Show("تاریخ شروع را وارد کنید");
                persianDatePicker_start.Focus();
            }
            else if (edate == "")
            {
                MessageBox.Show("تاریخ پایان را وارد کنید");
                persianDatePicker2_end.Focus();
            }
            else
            {
                int daramad = 0, bedehi = 0;
                dataGridView_factor.DataSource = blh.showAllHistorysWhitFilters(sdate, edate, selectedDesks, ref daramad, ref bedehi);
                textBoxX_dramad1.Text = daramad.ToString();
                textBoxX_bedehi1.Text = bedehi.ToString();
            }
        }








        private void checkedListBox1_game_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            setSelectedGames();

            checkedListBox2_desk.Items.Clear();

            List<string> games = blg.getSelectedGameDesks(selectedGames);
            int i = 0;
            foreach (var item in games)
            {
                checkedListBox2_desk.Items.Add(item);
                checkedListBox2_desk.SetItemChecked(i,true);
                i++;
            }
        }

        void setSelectedGames()
        {
            selectedGames.Clear();
            foreach (var item in checkedListBox1_game.CheckedItems)
            {
                selectedGames.Add( item.ToString());
            }
        }

        void setSelectedDesks()
        {
            selectedDesks.Clear();
            foreach (var item in checkedListBox2_desk.CheckedItems)
            {
                selectedDesks.Add(item.ToString());
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

        private void dataGridView_factor_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {

                dataGridView_factor.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridView_factor_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_factor.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_factor.Rows[e.RowIndex].Selected = false;
            }
        }
    }
}
