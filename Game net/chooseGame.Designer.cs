
namespace Game_net
{
    partial class chooseGame
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
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.comboBoxDesk = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_start1 = new System.Windows.Forms.Button();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(674, -1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(36, 38);
            this.labelX1.Symbol = "58829";
            this.labelX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX1.SymbolSize = 15F;
            this.labelX1.TabIndex = 1;
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            this.labelX1.MouseLeave += new System.EventHandler(this.labelX1_MouseLeave);
            this.labelX1.MouseHover += new System.EventHandler(this.labelX1_MouseHover);
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(393, 79);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(164, 41);
            this.comboBoxGame.TabIndex = 5;
            this.comboBoxGame.SelectedIndexChanged += new System.EventHandler(this.comboBoxGame_SelectedIndexChanged);
            // 
            // comboBoxDesk
            // 
            this.comboBoxDesk.FormattingEnabled = true;
            this.comboBoxDesk.Location = new System.Drawing.Point(81, 80);
            this.comboBoxDesk.Name = "comboBoxDesk";
            this.comboBoxDesk.Size = new System.Drawing.Size(164, 41);
            this.comboBoxDesk.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(286, 179);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 41);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_start1
            // 
            this.button_start1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.button_start1.FlatAppearance.BorderSize = 0;
            this.button_start1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.button_start1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.button_start1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start1.Location = new System.Drawing.Point(232, 278);
            this.button_start1.Name = "button_start1";
            this.button_start1.Size = new System.Drawing.Size(221, 46);
            this.button_start1.TabIndex = 59;
            this.button_start1.Text = "شروع بازی";
            this.button_start1.UseVisualStyleBackColor = false;
            this.button_start1.Click += new System.EventHandler(this.button_start1_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(563, 83);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 38);
            this.labelX5.TabIndex = 60;
            this.labelX5.Text = ": بازی";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(412, 182);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(107, 38);
            this.labelX6.TabIndex = 61;
            this.labelX6.Text = ": تعداد دسته";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(251, 80);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(69, 38);
            this.labelX7.TabIndex = 62;
            this.labelX7.Text = ": میز";
            // 
            // chooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(706, 380);
            this.ControlBox = false;
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.button_start1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxDesk);
            this.Controls.Add(this.comboBoxGame);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "chooseGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chooseGame";
            this.Load += new System.EventHandler(this.chooseGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGame;
        private System.Windows.Forms.ComboBox comboBoxDesk;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button_start1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
    }
}