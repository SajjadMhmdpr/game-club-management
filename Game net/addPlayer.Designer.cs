
namespace Game_net
{
    partial class addPlayer
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
            this.button_tolidCode = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBoxX_family1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_name1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_code1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX_tel1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // button_tolidCode
            // 
            this.button_tolidCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_tolidCode.BackColor = System.Drawing.Color.Teal;
            this.button_tolidCode.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_tolidCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_tolidCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button_tolidCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tolidCode.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tolidCode.ForeColor = System.Drawing.Color.White;
            this.button_tolidCode.Location = new System.Drawing.Point(750, 299);
            this.button_tolidCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_tolidCode.Name = "button_tolidCode";
            this.button_tolidCode.Size = new System.Drawing.Size(104, 41);
            this.button_tolidCode.TabIndex = 2;
            this.button_tolidCode.Text = "تولید کد";
            this.button_tolidCode.UseVisualStyleBackColor = false;
            this.button_tolidCode.Click += new System.EventHandler(this.button_tolidCode_Click);
            // 
            // button_register
            // 
            this.button_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(526, 443);
            this.button_register.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(140, 41);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "ثبت نام";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBoxX_family1
            // 
            this.textBoxX_family1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_family1.Border.Class = "TextBoxBorder";
            this.textBoxX_family1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_family1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX_family1.Location = new System.Drawing.Point(308, 238);
            this.textBoxX_family1.Name = "textBoxX_family1";
            this.textBoxX_family1.PreventEnterBeep = true;
            this.textBoxX_family1.Size = new System.Drawing.Size(243, 41);
            this.textBoxX_family1.TabIndex = 1;
            this.textBoxX_family1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_family1.WatermarkText = "فامیلی";
            // 
            // textBoxX_name1
            // 
            this.textBoxX_name1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_name1.Border.Class = "TextBoxBorder";
            this.textBoxX_name1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_name1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX_name1.Location = new System.Drawing.Point(631, 238);
            this.textBoxX_name1.Name = "textBoxX_name1";
            this.textBoxX_name1.PreventEnterBeep = true;
            this.textBoxX_name1.Size = new System.Drawing.Size(243, 41);
            this.textBoxX_name1.TabIndex = 0;
            this.textBoxX_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_name1.WatermarkText = "نام";
            // 
            // textBoxX_code1
            // 
            this.textBoxX_code1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_code1.Border.Class = "TextBoxBorder";
            this.textBoxX_code1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_code1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX_code1.Location = new System.Drawing.Point(469, 301);
            this.textBoxX_code1.Name = "textBoxX_code1";
            this.textBoxX_code1.PreventEnterBeep = true;
            this.textBoxX_code1.Size = new System.Drawing.Size(243, 41);
            this.textBoxX_code1.TabIndex = 3;
            this.textBoxX_code1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_code1.WatermarkText = "کد";
            this.textBoxX_code1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_code1_KeyPress);
            this.textBoxX_code1.Leave += new System.EventHandler(this.textBoxX_code1_Leave);
            // 
            // textBoxX_tel1
            // 
            this.textBoxX_tel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.textBoxX_tel1.Border.Class = "TextBoxBorder";
            this.textBoxX_tel1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX_tel1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX_tel1.Location = new System.Drawing.Point(469, 368);
            this.textBoxX_tel1.MaxLength = 11;
            this.textBoxX_tel1.Name = "textBoxX_tel1";
            this.textBoxX_tel1.PreventEnterBeep = true;
            this.textBoxX_tel1.Size = new System.Drawing.Size(243, 41);
            this.textBoxX_tel1.TabIndex = 4;
            this.textBoxX_tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX_tel1.WatermarkText = "شماره تماس";
            this.textBoxX_tel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_tel1_KeyPress);
            // 
            // addPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1176, 747);
            this.Controls.Add(this.textBoxX_tel1);
            this.Controls.Add(this.textBoxX_code1);
            this.Controls.Add(this.textBoxX_name1);
            this.Controls.Add(this.textBoxX_family1);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_tolidCode);
            this.Font = new System.Drawing.Font("IRANSansWeb", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addPlayer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_tolidCode;
        private System.Windows.Forms.Button button_register;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_family1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_name1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_code1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX_tel1;
    }
}