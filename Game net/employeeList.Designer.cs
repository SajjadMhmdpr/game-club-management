
namespace Game_net
{
    partial class employeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX_name1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_family1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_tel1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_username1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_pass1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.button_restore = new System.Windows.Forms.Button();
            this.button_backup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.AllowUserToAddRows = false;
            this.dataGridView_employee.AllowUserToDeleteRows = false;
            this.dataGridView_employee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.state,
            this.manager,
            this.emid,
            this.name,
            this.family,
            this.username,
            this.password,
            this.phone});
            this.dataGridView_employee.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_employee.Location = new System.Drawing.Point(562, 12);
            this.dataGridView_employee.MultiSelect = false;
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.ReadOnly = true;
            this.dataGridView_employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_employee.RowHeadersWidth = 51;
            this.dataGridView_employee.RowTemplate.Height = 24;
            this.dataGridView_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employee.Size = new System.Drawing.Size(584, 676);
            this.dataGridView_employee.TabIndex = 8;
            this.dataGridView_employee.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employee_CellMouseEnter);
            this.dataGridView_employee.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employee_CellMouseLeave);
            // 
            // state
            // 
            this.state.DataPropertyName = "emState";
            this.state.HeaderText = "state";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Visible = false;
            this.state.Width = 125;
            // 
            // manager
            // 
            this.manager.DataPropertyName = "manager";
            this.manager.HeaderText = "manager";
            this.manager.MinimumWidth = 6;
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Visible = false;
            this.manager.Width = 125;
            // 
            // emid
            // 
            this.emid.DataPropertyName = "id";
            this.emid.HeaderText = "emid";
            this.emid.MinimumWidth = 6;
            this.emid.Name = "emid";
            this.emid.ReadOnly = true;
            this.emid.Visible = false;
            this.emid.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "emName";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // family
            // 
            this.family.DataPropertyName = "emFamily";
            this.family.HeaderText = "فامیلی";
            this.family.MinimumWidth = 6;
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Width = 150;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "نام کاربری";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            this.username.Width = 125;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            this.password.Width = 125;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "emPhone";
            this.phone.HeaderText = "تلفن";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 52);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(171, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "افزودن مسئول جدید";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX_name1
            // 
            this.textBoxX_name1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_name1.Border.Class = "TextBoxBorder";
            this.textBoxX_name1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_name1.Location = new System.Drawing.Point(280, 98);
            this.textBoxX_name1.Name = "textBoxX_name1";
            this.textBoxX_name1.PreventEnterBeep = true;
            this.textBoxX_name1.Size = new System.Drawing.Size(261, 41);
            this.textBoxX_name1.TabIndex = 1;
            this.textBoxX_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_name1.WatermarkText = "نام";
            // 
            // textBoxX_family1
            // 
            this.textBoxX_family1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_family1.Border.Class = "TextBoxBorder";
            this.textBoxX_family1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_family1.Location = new System.Drawing.Point(13, 98);
            this.textBoxX_family1.Name = "textBoxX_family1";
            this.textBoxX_family1.PreventEnterBeep = true;
            this.textBoxX_family1.Size = new System.Drawing.Size(261, 41);
            this.textBoxX_family1.TabIndex = 2;
            this.textBoxX_family1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_family1.WatermarkText = "فامیلی";
            // 
            // textBoxX_tel1
            // 
            this.textBoxX_tel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_tel1.Border.Class = "TextBoxBorder";
            this.textBoxX_tel1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_tel1.Location = new System.Drawing.Point(149, 151);
            this.textBoxX_tel1.MaxLength = 11;
            this.textBoxX_tel1.Name = "textBoxX_tel1";
            this.textBoxX_tel1.PreventEnterBeep = true;
            this.textBoxX_tel1.Size = new System.Drawing.Size(261, 41);
            this.textBoxX_tel1.TabIndex = 3;
            this.textBoxX_tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_tel1.WatermarkText = "شماره تماس";
            this.textBoxX_tel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_tel1_KeyPress);
            // 
            // textBoxX_username1
            // 
            this.textBoxX_username1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_username1.Border.Class = "TextBoxBorder";
            this.textBoxX_username1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_username1.Location = new System.Drawing.Point(149, 201);
            this.textBoxX_username1.Name = "textBoxX_username1";
            this.textBoxX_username1.PreventEnterBeep = true;
            this.textBoxX_username1.Size = new System.Drawing.Size(261, 41);
            this.textBoxX_username1.TabIndex = 4;
            this.textBoxX_username1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_username1.WatermarkText = "نام کاربری";
            // 
            // textBoxX_pass1
            // 
            this.textBoxX_pass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_pass1.Border.Class = "TextBoxBorder";
            this.textBoxX_pass1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_pass1.Location = new System.Drawing.Point(149, 251);
            this.textBoxX_pass1.MaxLength = 6;
            this.textBoxX_pass1.Name = "textBoxX_pass1";
            this.textBoxX_pass1.PreventEnterBeep = true;
            this.textBoxX_pass1.Size = new System.Drawing.Size(261, 41);
            this.textBoxX_pass1.TabIndex = 5;
            this.textBoxX_pass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_pass1.WatermarkText = "رمز";
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(512, 494);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.Size = new System.Drawing.Size(126, 95);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 15;
            this.circularProgress1.Visible = false;
            // 
            // button_restore
            // 
            this.button_restore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_restore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_restore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_restore.Image = global::Game_net.Properties.Resources._3209276_backup_cloud_data_download_storage_icon;
            this.button_restore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_restore.Location = new System.Drawing.Point(149, 641);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(261, 44);
            this.button_restore.TabIndex = 17;
            this.button_restore.Text = "بازیابی اطلاعات";
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // button_backup
            // 
            this.button_backup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_backup.Image = global::Game_net.Properties.Resources._3209375_backup_cloud_data_storage_upload_icon;
            this.button_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_backup.Location = new System.Drawing.Point(149, 587);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(261, 44);
            this.button_backup.TabIndex = 16;
            this.button_backup.Text = "تهیه فایل پشتیبان";
            this.button_backup.UseVisualStyleBackColor = true;
            this.button_backup.Click += new System.EventHandler(this.button_backup_Click);
            // 
            // employeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.button_restore);
            this.Controls.Add(this.button_backup);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.textBoxX_pass1);
            this.Controls.Add(this.textBoxX_username1);
            this.Controls.Add(this.textBoxX_tel1);
            this.Controls.Add(this.textBoxX_family1);
            this.Controls.Add(this.textBoxX_name1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_employee);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "employeeList";
            this.Text = "employeeList";
            this.Load += new System.EventHandler(this.employeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_employee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_name1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_family1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_tel1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_username1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_pass1;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn emid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.Button button_restore;
    }
}