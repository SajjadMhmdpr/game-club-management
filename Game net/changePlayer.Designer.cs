
namespace Game_net
{
    partial class changePlayer
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
            this.dataGridPlayerList = new System.Windows.Forms.DataGridView();
            this.plid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamkol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerList)).BeginInit();
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
            this.dataGridPlayerList.Location = new System.Drawing.Point(12, 91);
            this.dataGridPlayerList.MultiSelect = false;
            this.dataGridPlayerList.Name = "dataGridPlayerList";
            this.dataGridPlayerList.ReadOnly = true;
            this.dataGridPlayerList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridPlayerList.RowHeadersWidth = 51;
            this.dataGridPlayerList.RowTemplate.Height = 24;
            this.dataGridPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPlayerList.Size = new System.Drawing.Size(793, 378);
            this.dataGridPlayerList.TabIndex = 1;
            this.dataGridPlayerList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPlayerList_CellMouseDoubleClick);
            this.dataGridPlayerList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayerList_CellMouseEnter);
            this.dataGridPlayerList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlayerList_CellMouseLeave);
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
            // textBoxX2
            // 
            this.textBoxX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(218, 20);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(364, 41);
            this.textBoxX2.TabIndex = 16;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.WatermarkText = "جست و جو";
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(778, 3);
            this.labelX2.Margin = new System.Windows.Forms.Padding(0);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Black;
            this.labelX2.Size = new System.Drawing.Size(34, 23);
            this.labelX2.Symbol = "57676";
            this.labelX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX2.TabIndex = 65;
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            this.labelX2.MouseLeave += new System.EventHandler(this.labelX2_MouseLeave);
            this.labelX2.MouseHover += new System.EventHandler(this.labelX2_MouseHover);
            // 
            // changePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(817, 481);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.dataGridPlayerList);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "changePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changePlayer";
            this.Load += new System.EventHandler(this.changePlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlayerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPlayerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn plid;
        private System.Windows.Forms.DataGridViewTextBoxColumn plCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn plState;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn plFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn plPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamkol;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}