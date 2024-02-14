
namespace Game_net
{
    partial class nesfePardakht
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button1 = new System.Windows.Forms.Button();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX_mande = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(451, -2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 45);
            this.labelX1.Symbol = "57676";
            this.labelX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX1.TabIndex = 2;
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            this.labelX1.MouseLeave += new System.EventHandler(this.labelX1_MouseLeave);
            this.labelX1.MouseHover += new System.EventHandler(this.labelX1_MouseHover);
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(84, 150);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(328, 41);
            this.textBoxX2.TabIndex = 0;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(162, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(84, 87);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(328, 46);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "مقدار بدهی پرداختی را وارد کنید";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(288, 35);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 46);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = ": مانده";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX_mande
            // 
            this.labelX_mande.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX_mande.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX_mande.Enabled = false;
            this.labelX_mande.ForeColor = System.Drawing.Color.Black;
            this.labelX_mande.Location = new System.Drawing.Point(121, 35);
            this.labelX_mande.Name = "labelX_mande";
            this.labelX_mande.Size = new System.Drawing.Size(161, 46);
            this.labelX_mande.TabIndex = 8;
            this.labelX_mande.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // nesfePardakht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(492, 304);
            this.Controls.Add(this.labelX_mande);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "nesfePardakht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nesfePardakht";
            this.Load += new System.EventHandler(this.nesfePardakht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX_mande;
    }
}