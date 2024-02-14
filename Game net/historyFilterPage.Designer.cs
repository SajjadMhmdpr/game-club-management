
namespace Game_net
{
    partial class historyFilterPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_factor = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrlNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plfamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iidd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1_game = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2_desk = new System.Windows.Forms.CheckedListBox();
            this.persianDatePicker_start = new System.Windows.Forms.PersianDatePicker();
            this.persianDatePicker2_end = new System.Windows.Forms.PersianDatePicker();
            this.button_filter = new System.Windows.Forms.Button();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_dramad1 = new System.Windows.Forms.TextBox();
            this.textBoxX_bedehi1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_factor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.date,
            this.game,
            this.dask,
            this.cntrlNum,
            this.st,
            this.et,
            this.activeTime,
            this.hazine,
            this.paid,
            this.plcode,
            this.plname,
            this.plfamily,
            this.emp,
            this.iidd});
            this.dataGridView_factor.Location = new System.Drawing.Point(10, 311);
            this.dataGridView_factor.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView_factor.MultiSelect = false;
            this.dataGridView_factor.Name = "dataGridView_factor";
            this.dataGridView_factor.ReadOnly = true;
            this.dataGridView_factor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_factor.RowHeadersWidth = 51;
            this.dataGridView_factor.RowTemplate.Height = 24;
            this.dataGridView_factor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_factor.Size = new System.Drawing.Size(1138, 379);
            this.dataGridView_factor.TabIndex = 30;
            this.dataGridView_factor.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_factor_CellMouseEnter);
            this.dataGridView_factor.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_factor_CellMouseLeave);
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
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
            this.game.Width = 101;
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
            this.st.Width = 102;
            // 
            // et
            // 
            this.et.DataPropertyName = "endTime";
            this.et.HeaderText = "پایان";
            this.et.MinimumWidth = 6;
            this.et.Name = "et";
            this.et.ReadOnly = true;
            this.et.Width = 103;
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
            // paid
            // 
            this.paid.DataPropertyName = "Paid";
            this.paid.HeaderText = "دریافتی";
            this.paid.MinimumWidth = 6;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.Width = 90;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.checkedListBox1_game);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(549, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(171, 256);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بازی";
            // 
            // checkedListBox1_game
            // 
            this.checkedListBox1_game.CheckOnClick = true;
            this.checkedListBox1_game.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBox1_game.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1_game.FormattingEnabled = true;
            this.checkedListBox1_game.Location = new System.Drawing.Point(2, 36);
            this.checkedListBox1_game.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox1_game.Name = "checkedListBox1_game";
            this.checkedListBox1_game.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1_game.Size = new System.Drawing.Size(167, 218);
            this.checkedListBox1_game.TabIndex = 41;
            this.checkedListBox1_game.ThreeDCheckBoxes = true;
            this.checkedListBox1_game.UseCompatibleTextRendering = true;
            this.checkedListBox1_game.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_game_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.checkedListBox2_desk);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(419, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(124, 256);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "میز";
            // 
            // checkedListBox2_desk
            // 
            this.checkedListBox2_desk.CheckOnClick = true;
            this.checkedListBox2_desk.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBox2_desk.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2_desk.FormattingEnabled = true;
            this.checkedListBox2_desk.Location = new System.Drawing.Point(4, 36);
            this.checkedListBox2_desk.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox2_desk.Name = "checkedListBox2_desk";
            this.checkedListBox2_desk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox2_desk.Size = new System.Drawing.Size(118, 218);
            this.checkedListBox2_desk.TabIndex = 42;
            this.checkedListBox2_desk.ThreeDCheckBoxes = true;
            this.checkedListBox2_desk.UseCompatibleTextRendering = true;
            // 
            // persianDatePicker_start
            // 
            this.persianDatePicker_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.persianDatePicker_start.AutoSize = true;
            this.persianDatePicker_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker_start.BackColor = System.Drawing.Color.White;
            this.persianDatePicker_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianDatePicker_start.ForeColor = System.Drawing.Color.Black;
            this.persianDatePicker_start.GeorgianDate = null;
            this.persianDatePicker_start.Location = new System.Drawing.Point(738, 100);
            this.persianDatePicker_start.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker_start.Name = "persianDatePicker_start";
            this.persianDatePicker_start.PersianDate.Day = 0;
            this.persianDatePicker_start.PersianDate.Month = 0;
            this.persianDatePicker_start.PersianDate.Year = 0;
            this.persianDatePicker_start.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker_start.Size = new System.Drawing.Size(408, 31);
            this.persianDatePicker_start.TabIndex = 50;
            // 
            // persianDatePicker2_end
            // 
            this.persianDatePicker2_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.persianDatePicker2_end.AutoSize = true;
            this.persianDatePicker2_end.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.persianDatePicker2_end.BackColor = System.Drawing.Color.White;
            this.persianDatePicker2_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianDatePicker2_end.ForeColor = System.Drawing.Color.Black;
            this.persianDatePicker2_end.GeorgianDate = null;
            this.persianDatePicker2_end.Location = new System.Drawing.Point(738, 215);
            this.persianDatePicker2_end.Margin = new System.Windows.Forms.Padding(0);
            this.persianDatePicker2_end.Name = "persianDatePicker2_end";
            this.persianDatePicker2_end.PersianDate.Day = 0;
            this.persianDatePicker2_end.PersianDate.Month = 0;
            this.persianDatePicker2_end.PersianDate.Year = 0;
            this.persianDatePicker2_end.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.persianDatePicker2_end.Size = new System.Drawing.Size(408, 31);
            this.persianDatePicker2_end.TabIndex = 51;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.button_filter.FlatAppearance.BorderSize = 0;
            this.button_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.button_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Location = new System.Drawing.Point(73, 60);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(221, 46);
            this.button_filter.TabIndex = 58;
            this.button_filter.Text = "اعمال فیلتر";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(1071, 60);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 38);
            this.labelX5.TabIndex = 59;
            this.labelX5.Text = ": از تاریخ";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(1071, 174);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 38);
            this.labelX6.TabIndex = 60;
            this.labelX6.Text = ": تا تاریخ";
            // 
            // textBoxX_dramad1
            // 
            this.textBoxX_dramad1.Location = new System.Drawing.Point(41, 163);
            this.textBoxX_dramad1.Name = "textBoxX_dramad1";
            this.textBoxX_dramad1.ReadOnly = true;
            this.textBoxX_dramad1.Size = new System.Drawing.Size(267, 41);
            this.textBoxX_dramad1.TabIndex = 61;
            this.textBoxX_dramad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxX_bedehi1
            // 
            this.textBoxX_bedehi1.Location = new System.Drawing.Point(41, 210);
            this.textBoxX_bedehi1.Name = "textBoxX_bedehi1";
            this.textBoxX_bedehi1.ReadOnly = true;
            this.textBoxX_bedehi1.Size = new System.Drawing.Size(267, 41);
            this.textBoxX_bedehi1.TabIndex = 62;
            this.textBoxX_bedehi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(314, 166);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 38);
            this.labelX1.TabIndex = 63;
            this.labelX1.Text = ": درآمد";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(314, 213);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 38);
            this.labelX2.TabIndex = 64;
            this.labelX2.Text = ": بدهی";
            // 
            // historyFilterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX_bedehi1);
            this.Controls.Add(this.textBoxX_dramad1);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.persianDatePicker2_end);
            this.Controls.Add(this.persianDatePicker_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_factor);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "historyFilterPage";
            this.Text = "historyPage";
            this.Load += new System.EventHandler(this.historyPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_factor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_factor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1_game;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox2_desk;
        private System.Windows.Forms.PersianDatePicker persianDatePicker_start;
        private System.Windows.Forms.PersianDatePicker persianDatePicker2_end;
        private System.Windows.Forms.Button button_filter;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.TextBox textBoxX_dramad1;
        private System.Windows.Forms.TextBox textBoxX_bedehi1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn game;
        private System.Windows.Forms.DataGridViewTextBoxColumn dask;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrlNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.DataGridViewTextBoxColumn et;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazine;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn plname;
        private System.Windows.Forms.DataGridViewTextBoxColumn plfamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iidd;
    }
}