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
    public partial class oneGameFactor : Form
    {
        History h = new History();
        bl_player blp = new bl_player();
        bl_history blh = new bl_history();
        int ID = 0;
        PersianDateTime p = new PersianDateTime(DateTime.Now);


        public oneGameFactor(History hh)
        {
            InitializeComponent();
            h=hh;
            //dataGridView_factor.AutoSize = false;
        }


        private void pardakhtPage_Load(object sender, EventArgs e)
        {
            labelX_nameAndFamily1.Text = h.player.plName +" "+ h.player.plFamily;
            labelX_act1.Text = h.desk.deGame.acName;
            labelX_desk1.Text = h.desk.deskCode;
            labelX_startTime1.Text = h.startTime;
            labelX_endTime1.Text = h.endTime;
            labelX_code1.Text = h.player.plCode.ToString();
            labelX1_activeTime1.Text = h.activityTime.ToString();
            labelX1_cntrlNum1.Text = h.controlNum.ToString();


            int haz = (int)h.hiHazineKol;
            labelX1_hazine.Text = haz.ToString();

            button1_confirm.Focus();
            button_changeGame.Focus();

        }




        private void button_changeGame_Click(object sender, EventArgs e)
        {
            blp.closeGame(h);
            chooseGame cgf = new chooseGame(h.player , h.employee);
            cgf.labelX1.Visible = false;
            cgf.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blp.closeGame(h);
            this.Close();
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
