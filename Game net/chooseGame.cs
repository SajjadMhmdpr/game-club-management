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
    public partial class chooseGame : Form
    {
        bl_game blg = new bl_game();
        bl_history blh = new bl_history();
        bl_player blp = new bl_player();
        Player p = new Player();
        Employee emp = new Employee();

        string date;
        string startTime;

        public chooseGame(Player pp ,Employee e)
        {
            InitializeComponent();
            p = pp;
            emp = e ;
        }

        

        private void chooseGame_Load(object sender, EventArgs e)
        {
            update();
            PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
            
            //date = DateTime.Now.ToString("yyyy/MM/dd");
            date = persianDate.Date.ToString("yyyy/MM/dd");
            startTime = DateTime.Now.ToString("HH:mm:ss");
        }

        private void comboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForDesk();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void button_start1_Click(object sender, EventArgs e)
        {
            /*bool condition;
            condition = blp.chekActiveGame(p.id);

            if (!condition)
            {
                blp.startGame(p.id, comboBoxGame.Text, comboBoxDesk.Text, Convert.ToInt32(numericUpDown1.Value)
                    , blh.add(emp.id, date, startTime));

                MessageBox.Show("با موفقیت ثبت شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
                MessageBox.Show("ثبت نشد\nدر حال حاضر بازیکن در حال انجام یک بازی است", "وضعیت",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                    , MessageBoxOptions.RightAlign);*/

            blp.startGame(p.id, comboBoxGame.Text, comboBoxDesk.Text, Convert.ToInt32(numericUpDown1.Value)
                    , blh.add(emp.id, date, startTime));

            this.Close();
        }









        private void labelX1_MouseHover(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Red;
        }

        private void labelX1_MouseLeave(object sender, EventArgs e)
        {
            labelX1.ForeColor = Color.Black;
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void update()
        {
            comboBoxGame.DataSource = blg.readGamesForChoosePage();
            comboBoxGame.DisplayMember = "acName";
            comboBoxGame.ValueMember = "id";

            comboBoxDesk.DataSource = blg.readDesks(comboBoxGame.Text);
            comboBoxDesk.DisplayMember = "deskCode";
            comboBoxDesk.ValueMember = "id";
        }
        
        void updateForDesk()
        {

            comboBoxDesk.DataSource = blg.readDesks(comboBoxGame.Text);
            comboBoxDesk.DisplayMember = "deskCode";
            comboBoxDesk.ValueMember = "id";
        }

        
    }
}
