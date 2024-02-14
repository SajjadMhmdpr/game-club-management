
namespace Game_net
{
    partial class playerList
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
            this.dataGridPlayerList = new System.Windows.Forms.DataGridView();
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamkol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.شروعبازیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPlayerList
            // 
            this.dataGridPlayerList.AllowUserToAddRows = false;
            this.dataGridPlayerList.AllowUserToDeleteRows = false;
            this.dataGridPlayerList.AllowUserToResizeRows = false;
            this.dataGridPlayerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPlayerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlayerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plid,
            this.plCode,
            this.plState,
            this.name,
            this.plFamily,
            this.plPhone,
            this.bedehi,
            this.jamkol});
            this.dataGridPlayerList.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridPlayerList.Location = new System.Drawing.Point(12, 164);
            this.dataGridPlayerList.MultiSelect = false;
            this.dataGridPlayerList.Name = "dataGridPlayerList";
            this.dataGridPlayerList.ReadOnly = true;
            this.dataGridPlayerList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridPlayerList.RowHeadersWidth = 51;
            this.dataGridPlayerList.RowTemplate.Height = 24;
            this.dataGridPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPlayerList.Size = new System.Drawing.Size(1134, 524);
            this.dataGridPlayerList.TabIndex = 0;
            this.dataGridPlayerList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayerList_CellMouseEnter);
            this.dataGridPlayerList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayerList_CellMouseLeave_1);
            // 
            // plid
            // 
            this.plid.DataPropertyName = "id";
            this.plid.HeaderText = "id";
            this.plid.MinimumWidth = 6;
            this.plid.Name = "plid";
            this.plid.ReadOnly = true;
            this.plid.Visible = false;
            this.plid.Width = 125;
            // 
            // plCode
            // 
            this.plCode.DataPropertyName = "plCode";
            this.plCode.HeaderText = "کد";
            this.plCode.MinimumWidth = 6;
            this.plCode.Name = "plCode";
            this.plCode.ReadOnly = true;
            this.plCode.Width = 125;
            // 
            // plState
            // 
            this.plState.DataPropertyName = "plState";
            this.plState.HeaderText = "plState";
            this.plState.MinimumWidth = 6;
            this.plState.Name = "plState";
            this.plState.ReadOnly = true;
            this.plState.Visible = false;
            this.plState.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "plName";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // plFamily
            // 
            this.plFamily.DataPropertyName = "plFamily";
            this.plFamily.HeaderText = "فامیلی";
            this.plFamily.MinimumWidth = 6;
            this.plFamily.Name = "plFamily";
            this.plFamily.ReadOnly = true;
            this.plFamily.Width = 150;
            // 
            // plPhone
            // 
            this.plPhone.DataPropertyName = "plPhone";
            this.plPhone.HeaderText = "تلفن";
            this.plPhone.MinimumWidth = 6;
            this.plPhone.Name = "plPhone";
            this.plPhone.ReadOnly = true;
            this.plPhone.Width = 150;
            // 
            // bedehi
            // 
            this.bedehi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bedehi.DataPropertyName = "plHazineBedehi";
            this.bedehi.HeaderText = "بدهی";
            this.bedehi.MinimumWidth = 6;
            this.bedehi.Name = "bedehi";
            this.bedehi.ReadOnly = true;
            // 
            // jamkol
            // 
            this.jamkol.DataPropertyName = "jamKol";
            this.jamkol.HeaderText = "jamkol";
            this.jamkol.MinimumWidth = 6;
            this.jamkol.Name = "jamkol";
            this.jamkol.ReadOnly = true;
            this.jamkol.Visible = false;
            this.jamkol.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.شروعبازیToolStripMenuItem,
            this.فاکتورToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 52);
            // 
            // شروعبازیToolStripMenuItem
            // 
            this.شروعبازیToolStripMenuItem.Name = "شروعبازیToolStripMenuItem";
            this.شروعبازیToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.شروعبازیToolStripMenuItem.Text = "شروع بازی";
            this.شروعبازیToolStripMenuItem.Click += new System.EventHandler(this.شروعبازیToolStripMenuItem_Click);
            // 
            // فاکتورToolStripMenuItem
            // 
            this.فاکتورToolStripMenuItem.Name = "فاکتورToolStripMenuItem";
            this.فاکتورToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.فاکتورToolStripMenuItem.Text = "فاکتور";
            this.فاکتورToolStripMenuItem.Click += new System.EventHandler(this.فاکتورToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox1.Location = new System.Drawing.Point(1007, 129);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(139, 32);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "نمایش بدهی ها";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(360, 55);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(431, 41);
            this.textBoxX2.TabIndex = 15;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.WatermarkText = "جست و جو";
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // playerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridPlayerList);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "playerList";
            this.Text = "playerList";
            this.Load += new System.EventHandler(this.playerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPlayerList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem شروعبازیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فاکتورToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn plState;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn plFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn plPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamkol;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
    }
}