
namespace Game_net
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX_name1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_pass1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(81, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_net.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(110, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(269, 419);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(101, 32);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "نمایش رمز";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(413, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Black;
            this.labelX2.Size = new System.Drawing.Size(34, 23);
            this.labelX2.Symbol = "57676";
            this.labelX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "labelX2";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            this.labelX2.MouseLeave += new System.EventHandler(this.labelX2_MouseLeave);
            this.labelX2.MouseHover += new System.EventHandler(this.labelX2_MouseHover);
            // 
            // textBoxX_name1
            // 
            // 
            // 
            // 
            this.textBoxX_name1.Border.Class = "TextBoxBorder";
            this.textBoxX_name1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_name1.Location = new System.Drawing.Point(81, 302);
            this.textBoxX_name1.Name = "textBoxX_name1";
            this.textBoxX_name1.PreventEnterBeep = true;
            this.textBoxX_name1.Size = new System.Drawing.Size(293, 41);
            this.textBoxX_name1.TabIndex = 0;
            this.textBoxX_name1.Text = "sajjad";
            this.textBoxX_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_name1.WatermarkText = "نام کاربری";
            // 
            // textBoxX_pass1
            // 
            // 
            // 
            // 
            this.textBoxX_pass1.Border.Class = "TextBoxBorder";
            this.textBoxX_pass1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_pass1.Location = new System.Drawing.Point(81, 364);
            this.textBoxX_pass1.MaxLength = 6;
            this.textBoxX_pass1.Name = "textBoxX_pass1";
            this.textBoxX_pass1.PasswordChar = '*';
            this.textBoxX_pass1.PreventEnterBeep = true;
            this.textBoxX_pass1.Size = new System.Drawing.Size(293, 41);
            this.textBoxX_pass1.TabIndex = 1;
            this.textBoxX_pass1.Text = "000000";
            this.textBoxX_pass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_pass1.WatermarkText = "رمز";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 608);
            this.Controls.Add(this.textBoxX_pass1);
            this.Controls.Add(this.textBoxX_name1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_name1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_pass1;
    }
}