
namespace Game_net
{
    partial class dailyHistoryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_factor = new System.Windows.Forms.DataGridView();
            this.plcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plfamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrlNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iidd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBox1_pardakhtNashod = new System.Windows.Forms.CheckBox();
            this.checkBox2_pardakhtSHod = new System.Windows.Forms.CheckBox();
            this.checkBox_darhalEjra = new System.Windows.Forms.CheckBox();
            this.cms_darhalEjra = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.اتمامبازیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییربازیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییربازیکنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_pardakhtNashod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییربازیکنToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.پایانبازیوپرداختToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_factor)).BeginInit();
            this.cms_darhalEjra.SuspendLayout();
            this.cms_pardakhtNashod.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_factor
            // 
            this.dataGridView_factor.AllowUserToAddRows = false;
            this.dataGridView_factor.AllowUserToDeleteRows = false;
            this.dataGridView_factor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_factor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_factor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_factor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plcode,
            this.plname,
            this.plfamily,
            this.date,
            this.game,
            this.dask,
            this.cntrlNum,
            this.st,
            this.et,
            this.activeTime,
            this.hazine,
            this.mande,
            this.emp,
            this.iidd});
            this.dataGridView_factor.Location = new System.Drawing.Point(10, 151);
            this.dataGridView_factor.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView_factor.MultiSelect = false;
            this.dataGridView_factor.Name = "dataGridView_factor";
            this.dataGridView_factor.ReadOnly = true;
            this.dataGridView_factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_factor.RowHeadersWidth = 51;
            this.dataGridView_factor.RowTemplate.Height = 24;
            this.dataGridView_factor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_factor.Size = new System.Drawing.Size(1138, 539);
            this.dataGridView_factor.TabIndex = 31;
            this.dataGridView_factor.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_factor_CellMouseEnter);
            this.dataGridView_factor.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_factor_CellMouseLeave);
            // 
            // plcode
            // 
            this.plcode.DataPropertyName = "plCode";
            this.plcode.HeaderText = "کد";
            this.plcode.MinimumWidth = 6;
            this.plcode.Name = "plcode";
            this.plcode.ReadOnly = true;
            this.plcode.Width = 80;
            // 
            // plname
            // 
            this.plname.DataPropertyName = "plName";
            this.plname.HeaderText = "نام";
            this.plname.MinimumWidth = 6;
            this.plname.Name = "plname";
            this.plname.ReadOnly = true;
            this.plname.Width = 90;
            // 
            // plfamily
            // 
            this.plfamily.DataPropertyName = "plFamily";
            this.plfamily.HeaderText = "فامیلی";
            this.plfamily.MinimumWidth = 6;
            this.plfamily.Name = "plfamily";
            this.plfamily.ReadOnly = true;
            this.plfamily.Width = 104;
            // 
            // date
            // 
            this.date.DataPropertyName = "plPhone";
            this.date.HeaderText = "تلفن";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // game
            // 
            this.game.DataPropertyName = "acName";
            this.game.HeaderText = "فعالیت";
            this.game.MinimumWidth = 6;
            this.game.Name = "game";
            this.game.ReadOnly = true;
            this.game.Width = 90;
            // 
            // dask
            // 
            this.dask.DataPropertyName = "deskCode";
            this.dask.HeaderText = "میز";
            this.dask.MinimumWidth = 6;
            this.dask.Name = "dask";
            this.dask.ReadOnly = true;
            this.dask.Width = 60;
            // 
            // cntrlNum
            // 
            this.cntrlNum.DataPropertyName = "controlNum";
            this.cntrlNum.HeaderText = "دسته";
            this.cntrlNum.MinimumWidth = 6;
            this.cntrlNum.Name = "cntrlNum";
            this.cntrlNum.ReadOnly = true;
            this.cntrlNum.Width = 60;
            // 
            // st
            // 
            this.st.DataPropertyName = "startTime";
            this.st.HeaderText = "شروع";
            this.st.MinimumWidth = 6;
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Width = 90;
            // 
            // et
            // 
            this.et.DataPropertyName = "endTime";
            this.et.HeaderText = "پایان";
            this.et.MinimumWidth = 6;
            this.et.Name = "et";
            this.et.ReadOnly = true;
            this.et.Width = 90;
            // 
            // activeTime
            // 
            this.activeTime.DataPropertyName = "activityTime";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.activeTime.HeaderText = "مدت";
            this.activeTime.MinimumWidth = 6;
            this.activeTime.Name = "activeTime";
            this.activeTime.ReadOnly = true;
            this.activeTime.Width = 80;
            // 
            // hazine
            // 
            this.hazine.DataPropertyName = "hiHazineKol";
            this.hazine.HeaderText = "هزینه";
            this.hazine.MinimumWidth = 6;
            this.hazine.Name = "hazine";
            this.hazine.ReadOnly = true;
            this.hazine.Width = 90;
            // 
            // mande
            // 
            this.mande.DataPropertyName = "Paid";
            this.mande.HeaderText = "دریافتی";
            this.mande.MinimumWidth = 6;
            this.mande.Name = "mande";
            this.mande.ReadOnly = true;
            this.mande.Width = 80;
            // 
            // emp
            // 
            this.emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emp.DataPropertyName = "emName";
            this.emp.HeaderText = "مسئول";
            this.emp.MinimumWidth = 6;
            this.emp.Name = "emp";
            this.emp.ReadOnly = true;
            // 
            // iidd
            // 
            this.iidd.DataPropertyName = "id";
            this.iidd.HeaderText = "id";
            this.iidd.MinimumWidth = 6;
            this.iidd.Name = "iidd";
            this.iidd.ReadOnly = true;
            this.iidd.Visible = false;
            this.iidd.Width = 125;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(365, 41);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(374, 41);
            this.textBoxX1.TabIndex = 32;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.WatermarkText = "جست و جو";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // checkBox1_pardakhtNashod
            // 
            this.checkBox1_pardakhtNashod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1_pardakhtNashod.AutoSize = true;
            this.checkBox1_pardakhtNashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1_pardakhtNashod.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_pardakhtNashod.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox1_pardakhtNashod.Location = new System.Drawing.Point(899, 118);
            this.checkBox1_pardakhtNashod.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1_pardakhtNashod.Name = "checkBox1_pardakhtNashod";
            this.checkBox1_pardakhtNashod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1_pardakhtNashod.Size = new System.Drawing.Size(122, 32);
            this.checkBox1_pardakhtNashod.TabIndex = 33;
            this.checkBox1_pardakhtNashod.Text = "پرداخت نشده";
            this.checkBox1_pardakhtNashod.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1_pardakhtNashod.UseVisualStyleBackColor = true;
            this.checkBox1_pardakhtNashod.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2_pardakhtSHod
            // 
            this.checkBox2_pardakhtSHod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2_pardakhtSHod.AutoSize = true;
            this.checkBox2_pardakhtSHod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2_pardakhtSHod.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2_pardakhtSHod.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox2_pardakhtSHod.Location = new System.Drawing.Point(1032, 118);
            this.checkBox2_pardakhtSHod.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2_pardakhtSHod.Name = "checkBox2_pardakhtSHod";
            this.checkBox2_pardakhtSHod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2_pardakhtSHod.Size = new System.Drawing.Size(115, 32);
            this.checkBox2_pardakhtSHod.TabIndex = 34;
            this.checkBox2_pardakhtSHod.Text = "پرداخت شده";
            this.checkBox2_pardakhtSHod.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox2_pardakhtSHod.UseVisualStyleBackColor = true;
            this.checkBox2_pardakhtSHod.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox_darhalEjra
            // 
            this.checkBox_darhalEjra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_darhalEjra.AutoSize = true;
            this.checkBox_darhalEjra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_darhalEjra.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_darhalEjra.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_darhalEjra.Location = new System.Drawing.Point(792, 118);
            this.checkBox_darhalEjra.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_darhalEjra.Name = "checkBox_darhalEjra";
            this.checkBox_darhalEjra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_darhalEjra.Size = new System.Drawing.Size(101, 32);
            this.checkBox_darhalEjra.TabIndex = 35;
            this.checkBox_darhalEjra.Text = "درحال اجرا";
            this.checkBox_darhalEjra.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox_darhalEjra.UseVisualStyleBackColor = true;
            this.checkBox_darhalEjra.CheckedChanged += new System.EventHandler(this.checkBox_darhalEjra_CheckedChanged);
            // 
            // cms_darhalEjra
            // 
            this.cms_darhalEjra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_darhalEjra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اتمامبازیToolStripMenuItem,
            this.تغییربازیToolStripMenuItem,
            this.پایانبازیوپرداختToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.تغییربازیکنToolStripMenuItem});
            this.cms_darhalEjra.Name = "contextMenuStrip1";
            this.cms_darhalEjra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cms_darhalEjra.Size = new System.Drawing.Size(211, 152);
            // 
            // اتمامبازیToolStripMenuItem
            // 
            this.اتمامبازیToolStripMenuItem.Name = "اتمامبازیToolStripMenuItem";
            this.اتمامبازیToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.اتمامبازیToolStripMenuItem.Text = "پایان بازی";
            this.اتمامبازیToolStripMenuItem.Click += new System.EventHandler(this.اتمامبازیToolStripMenuItem_Click);
            // 
            // تغییربازیToolStripMenuItem
            // 
            this.تغییربازیToolStripMenuItem.Name = "تغییربازیToolStripMenuItem";
            this.تغییربازیToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.تغییربازیToolStripMenuItem.Text = "تغییر بازی";
            this.تغییربازیToolStripMenuItem.Click += new System.EventHandler(this.تغییربازیToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // تغییربازیکنToolStripMenuItem
            // 
            this.تغییربازیکنToolStripMenuItem.Name = "تغییربازیکنToolStripMenuItem";
            this.تغییربازیکنToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.تغییربازیکنToolStripMenuItem.Text = "تغییر بازیکن";
            this.تغییربازیکنToolStripMenuItem.Click += new System.EventHandler(this.تغییربازیکنToolStripMenuItem_Click);
            // 
            // cms_pardakhtNashod
            // 
            this.cms_pardakhtNashod.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_pardakhtNashod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.تغییربازیکنToolStripMenuItem1});
            this.cms_pardakhtNashod.Name = "contextMenuStrip1";
            this.cms_pardakhtNashod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cms_pardakhtNashod.Size = new System.Drawing.Size(152, 52);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem3.Text = "پرداخت";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // تغییربازیکنToolStripMenuItem1
            // 
            this.تغییربازیکنToolStripMenuItem1.Name = "تغییربازیکنToolStripMenuItem1";
            this.تغییربازیکنToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.تغییربازیکنToolStripMenuItem1.Text = "تغییر بازیکن";
            this.تغییربازیکنToolStripMenuItem1.Click += new System.EventHandler(this.تغییربازیکنToolStripMenuItem1_Click);
            // 
            // پایانبازیوپرداختToolStripMenuItem
            // 
            this.پایانبازیوپرداختToolStripMenuItem.Name = "پایانبازیوپرداختToolStripMenuItem";
            this.پایانبازیوپرداختToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.پایانبازیوپرداختToolStripMenuItem.Text = "پایان بازی و پرداخت";
            this.پایانبازیوپرداختToolStripMenuItem.Click += new System.EventHandler(this.پایانبازیوپرداختToolStripMenuItem_Click);
            // 
            // dailyHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.checkBox_darhalEjra);
            this.Controls.Add(this.checkBox2_pardakhtSHod);
            this.Controls.Add(this.checkBox1_pardakhtNashod);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.dataGridView_factor);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "dailyHistoryPage";
            this.Load += new System.EventHandler(this.dailyHistoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_factor)).EndInit();
            this.cms_darhalEjra.ResumeLayout(false);
            this.cms_pardakhtNashod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_factor;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.CheckBox checkBox1_pardakhtNashod;
        private System.Windows.Forms.CheckBox checkBox2_pardakhtSHod;
        private System.Windows.Forms.CheckBox checkBox_darhalEjra;
        private System.Windows.Forms.ContextMenuStrip cms_darhalEjra;
        private System.Windows.Forms.ToolStripMenuItem اتمامبازیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییربازیToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_pardakhtNashod;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem تغییربازیکنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییربازیکنToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn plname;
        private System.Windows.Forms.DataGridViewTextBoxColumn plfamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn game;
        private System.Windows.Forms.DataGridViewTextBoxColumn dask;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrlNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.DataGridViewTextBoxColumn et;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazine;
        private System.Windows.Forms.DataGridViewTextBoxColumn mande;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iidd;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پایانبازیوپرداختToolStripMenuItem;
    }
}