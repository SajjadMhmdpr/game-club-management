
namespace Game_net
{
    partial class updateGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(137, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "ویرایش";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Location = new System.Drawing.Point(101, 104);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(233, 41);
            this.textBoxX3.TabIndex = 2;
            this.textBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX3.WatermarkText = "قیمت";
            this.textBoxX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX3_KeyPress);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(101, 150);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(233, 41);
            this.textBoxX1.TabIndex = 3;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.WatermarkText = "قیمت هر دسته";
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(101, 57);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(233, 41);
            this.textBoxX2.TabIndex = 1;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.WatermarkText = "نام بازی";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(399, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Black;
            this.labelX2.Size = new System.Drawing.Size(34, 23);
            this.labelX2.Symbol = "57676";
            this.labelX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX2.TabIndex = 15;
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            this.labelX2.MouseLeave += new System.EventHandler(this.labelX2_MouseLeave);
            this.labelX2.MouseHover += new System.EventHandler(this.labelX2_MouseHover);
            // 
            // updateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(436, 282);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "updateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateGame";
            this.Load += new System.EventHandler(this.updateGame_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}