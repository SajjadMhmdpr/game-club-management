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

using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;


namespace Game_net
{
    public partial class employeeList : Form
    {
        int ID = -1;
        Employee employee = new Employee();
        bl_employee ble = new bl_employee();

        public employeeList()
        {
            InitializeComponent();
        }
        #region enter / esc
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        private void employeeList_Load(object sender, EventArgs e)
        {
            styleDataGrid();
//dataGridView_employee.AutoSize = false;
            dataGridView_employee.DataSource = ble.showEmployees();
        }




        private void dataGridView_employee_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_employee.RowCount > 0 && e.RowIndex != -1)
            {

                dataGridView_employee.Rows[e.RowIndex].Selected = true;
                ID = (int)dataGridView_employee.Rows[e.RowIndex].Cells["emid"].Value;
            }
        }

        private void dataGridView_employee_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_employee.RowCount > 0 && e.RowIndex != -1)
            {
                dataGridView_employee.Rows[e.RowIndex].Selected = false;
                ID = -1;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "افزودن مسئول جدید")
            {

                if (textBoxX_name1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام را وارد کنید");
                    textBoxX_name1.Focus();
                }
                else if (textBoxX_family1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("فامیلی را وارد کنید");
                    textBoxX_family1.Focus();
                }
                else if (textBoxX_tel1.Text.Trim().Length == 0 && textBoxX_tel1.Text.Trim().Length < 11)
                {
                    MessageBox.Show("شماره تماس را وارد کنید");
                    textBoxX_tel1.Focus();
                }
                else if (textBoxX_username1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام کاربری را وارد کنید");
                    textBoxX_username1.Focus();
                }
                else if (textBoxX_pass1.Text.Trim().Length == 0 && textBoxX_pass1.Text.Trim().Length < 7)
                {
                    MessageBox.Show("رمز را وارد کنید");
                    textBoxX_pass1.Focus();
                }
                else
                {
                    Employee emp = new Employee();

                    emp.emName = textBoxX_name1.Text;
                    emp.emFamily = textBoxX_family1.Text;
                    emp.emPhone = textBoxX_tel1.Text;
                    emp.username = textBoxX_username1.Text;
                    emp.password = textBoxX_pass1.Text;
                    emp.emState = true;

                    if (ble.addEmployee(emp))
                    {
                        MessageBox.Show("مسئول با موفقیت ثبت شد", "ثبت نام",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
                        , MessageBoxOptions.RightAlign);

                        textBoxX_tel1.Clear();
                        textBoxX_name1.Clear();
                        textBoxX_family1.Clear();
                        textBoxX_username1.Clear();
                        textBoxX_pass1.Clear();

                        dataGridView_employee.DataSource = ble.showEmployees();
                    }
                    else
                    {
                        MessageBox.Show("ثبت نشد\n\nمسئولی با این مشخصات قبلا ثبت شده است", "ثبت نام",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                        , MessageBoxOptions.RightAlign);
                        textBoxX_username1.Focus();
                    }
                }

            }

            else                     // update
            {

                if (textBoxX_name1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("نام را وارد کنید");
                    textBoxX_name1.Focus();
                }
                else if (textBoxX_family1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("فامیلی را وارد کنید");
                    textBoxX_family1.Focus();
                }
                else if (textBoxX_tel1.Text.Trim().Length == 0 || textBoxX_tel1.Text.Trim().Length < 11)
                {
                    MessageBox.Show("شماره تماس را وارد کنید");
                    textBoxX_tel1.Focus();
                }
                else if (textBoxX_username1.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("نام کاربری را درست وارد کنید");
                    textBoxX_username1.Focus();
                }
                else if (textBoxX_pass1.Text.Trim().Length == 0 || textBoxX_pass1.Text.Trim().Length < 6)
                {
                    MessageBox.Show("رمز را وارد کنید");
                    textBoxX_pass1.Focus();
                }
                else
                {
                    Employee emp = new Employee();

                    emp.emName = textBoxX_name1.Text;
                    emp.emFamily = textBoxX_family1.Text;
                    emp.emPhone = textBoxX_tel1.Text;
                    emp.username = textBoxX_username1.Text;
                    emp.password = textBoxX_pass1.Text;
                    emp.emState = true;
                    emp.id = employee.id;

                    if (ble.update(emp))
                    {
                        MessageBox.Show("با موفقیت ثبت شد", "ویرایش",
                         MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
                         , MessageBoxOptions.RightAlign);

                        textBoxX_tel1.Clear();
                        textBoxX_name1.Clear();
                        textBoxX_family1.Clear();
                        textBoxX_username1.Clear();
                        textBoxX_pass1.Clear();

                        dataGridView_employee.DataSource = ble.showEmployees();
                        button1.Text = "افزودن مسئول جدید";
                    }
                    else
                    {
                        MessageBox.Show("ثبت نشد\n\nمسئولی با این مشخصات قبلا ثبت شده است", "ویرایش",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1
                        , MessageBoxOptions.RightAlign);
                        textBoxX_username1.Focus();
                    }

                    //button1.Text = "افزودن مسئول جدید";
                }

                

            }


        }

        private void textBoxX_tel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_employee.RowCount > 0 && ID != -1)
            {
                employee = ble.search(ID);
                button1.Text = "ویرایش";
                textBoxX_name1.Text = employee.emName;
                textBoxX_family1.Text = employee.emFamily;
                textBoxX_username1.Text = employee.username;
                textBoxX_tel1.Text = employee.emPhone;
                textBoxX_pass1.Text = employee.password;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_employee.RowCount > 0 && ID != -1)
            {
                var r = MessageBox.Show("ایا از حذف این مسئول اطمینان دارید ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (r == DialogResult.Yes)
                {
                    ble.delete(ID);
                    MessageBox.Show("با موفقیت حذف شد", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information
                            , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    dataGridView_employee.DataSource = ble.showEmployees();
                }
            }
        }

        void styleDataGrid()
        {
            dataGridView_employee.BorderStyle = BorderStyle.None;
            dataGridView_employee.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_employee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_employee.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_employee.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView_employee.BackgroundColor = Color.White;

            dataGridView_employee.EnableHeadersVisualStyles = false;
            dataGridView_employee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_employee.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dataGridView_employee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_employee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }








        //------------------------ Backup And Restore --------------------------


        private string BackUpConString = @"data source=(local);initial catalog=GameNet;integrated security=True;multipleactiveresultsets=True";//Connection String baraye Dastyabi be Data base Asli
        private string ReStoreConString = "Data Source=(local);Initial Catalog=master;Integrated Security=True";//Connection String baraye dastresi be data base Master

        private void button_backup_Click(object sender, EventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.Start();
            using (SqlConnection con = new SqlConnection(BackUpConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = "GameNet";//Bayad ham nam ba Data base barname tanzim shavad
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "BackUp File|*.araDB";
                        PersianDateTime persianDate = new PersianDateTime(DateTime.Now);
                        string todayDate = persianDate.Date.ToString("yyyy/MM/dd");
                        sfd.FileName = "BackUp_" + todayDate.Replace('/', '.');
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(sfd.FileName, DeviceType.File);
                            bkpDatabase.Devices.Add(bkpDevice);
                            bkpDatabase.SqlBackup(srvr);
                            MessageBox.Show("فایل پشتیبان با موفقیت ذخیره شده", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception s) { MessageBox.Show("لطفا فایل بک آپ را در درایوی غیر از درایو ویندوز ذخیره کنید"); }
                }
            }
            circularProgress1.Stop();
            circularProgress1.Visible = false;
        }




        private void button_restore_Click(object sender, EventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.Start();
            if (MessageBox.Show("ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند!!! \n اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "DataBase ReStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlConnection.ClearAllPools();
                using (SqlConnection con = new SqlConnection(ReStoreConString))
                {
                    ServerConnection srvConn = new ServerConnection(con);
                    Server srvr = new Server(srvConn);
                    srvr.KillAllProcesses("GameNet");
                    if (srvr != null)
                    {
                        try
                        {

                            Restore rstDatabase = new Restore();
                            rstDatabase.Action = RestoreActionType.Database;
                            rstDatabase.Database = "GameNet";//Bayad ham nam ba Data base barname tanzim shavad
                            OpenFileDialog opfd = new OpenFileDialog();
                            opfd.Filter = "BackUp File|*.araDB";
                            if (opfd.ShowDialog() == DialogResult.OK)
                            {

                                BackupDeviceItem bkpDevice = new BackupDeviceItem(opfd.FileName, DeviceType.File);
                                rstDatabase.Devices.Add(bkpDevice);

                                rstDatabase.ReplaceDatabase = true;
                                rstDatabase.SqlRestore(srvr);
                                MessageBox.Show("اطلاعات با موفقیت بازیابی شد", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            circularProgress1.Stop();
            circularProgress1.Visible = false;
        }



    }
}
