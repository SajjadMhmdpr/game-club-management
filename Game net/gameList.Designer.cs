
namespace Game_net
{
    partial class gameList
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
            this.dataGridView_games = new System.Windows.Forms.DataGridView();
            this.acName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acState11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acState22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_game = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.افزودنمیزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.جذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_desks = new System.Windows.Forms.DataGridView();
            this.deskCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deState11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deState22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_desk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_games)).BeginInit();
            this.contextMenuStrip_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_desks)).BeginInit();
            this.contextMenuStrip_desk.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_games
            // 
            this.dataGridView_games.AllowUserToAddRows = false;
            this.dataGridView_games.AllowUserToDeleteRows = false;
            this.dataGridView_games.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_games.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acName,
            this.acPrice,
            this.cntrl,
            this.acState11,
            this.acState22,
            this.id});
            this.dataGridView_games.ContextMenuStrip = this.contextMenuStrip_game;
            this.dataGridView_games.Location = new System.Drawing.Point(660, 12);
            this.dataGridView_games.Name = "dataGridView_games";
            this.dataGridView_games.ReadOnly = true;
            this.dataGridView_games.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_games.RowHeadersWidth = 51;
            this.dataGridView_games.RowTemplate.Height = 24;
            this.dataGridView_games.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_games.Size = new System.Drawing.Size(486, 676);
            this.dataGridView_games.TabIndex = 0;
            this.dataGridView_games.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_games_CellMouseEnter);
            this.dataGridView_games.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_games_CellMouseLeave);
            this.dataGridView_games.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_games_MouseClick);
            // 
            // acName
            // 
            this.acName.DataPropertyName = "acName";
            this.acName.HeaderText = "بازی";
            this.acName.MinimumWidth = 6;
            this.acName.Name = "acName";
            this.acName.ReadOnly = true;
            this.acName.Width = 125;
            // 
            // acPrice
            // 
            this.acPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acPrice.DataPropertyName = "acPrice";
            this.acPrice.HeaderText = "قیمت";
            this.acPrice.MinimumWidth = 6;
            this.acPrice.Name = "acPrice";
            this.acPrice.ReadOnly = true;
            // 
            // cntrl
            // 
            this.cntrl.DataPropertyName = "acControllerPrice";
            this.cntrl.HeaderText = "ق دسته";
            this.cntrl.MinimumWidth = 6;
            this.cntrl.Name = "cntrl";
            this.cntrl.ReadOnly = true;
            this.cntrl.Width = 125;
            // 
            // acState11
            // 
            this.acState11.DataPropertyName = "acState";
            this.acState11.HeaderText = "acState";
            this.acState11.MinimumWidth = 6;
            this.acState11.Name = "acState11";
            this.acState11.ReadOnly = true;
            this.acState11.Visible = false;
            this.acState11.Width = 125;
            // 
            // acState22
            // 
            this.acState22.DataPropertyName = "acState2";
            this.acState22.HeaderText = "acState2";
            this.acState22.MinimumWidth = 6;
            this.acState22.Name = "acState22";
            this.acState22.ReadOnly = true;
            this.acState22.Visible = false;
            this.acState22.Width = 125;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // contextMenuStrip_game
            // 
            this.contextMenuStrip_game.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_game.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.افزودنمیزToolStripMenuItem,
            this.ویرایشToolStripMenuItem1,
            this.جذفToolStripMenuItem});
            this.contextMenuStrip_game.Name = "contextMenuStrip_game";
            this.contextMenuStrip_game.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_game.Size = new System.Drawing.Size(146, 76);
            // 
            // افزودنمیزToolStripMenuItem
            // 
            this.افزودنمیزToolStripMenuItem.Name = "افزودنمیزToolStripMenuItem";
            this.افزودنمیزToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.افزودنمیزToolStripMenuItem.Text = "افزودن میز";
            this.افزودنمیزToolStripMenuItem.Click += new System.EventHandler(this.افزودنمیزToolStripMenuItem_Click);
            // 
            // ویرایشToolStripMenuItem1
            // 
            this.ویرایشToolStripMenuItem1.Name = "ویرایشToolStripMenuItem1";
            this.ویرایشToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.ویرایشToolStripMenuItem1.Text = "ویرایش";
            this.ویرایشToolStripMenuItem1.Click += new System.EventHandler(this.ویرایشToolStripMenuItem1_Click);
            // 
            // جذفToolStripMenuItem
            // 
            this.جذفToolStripMenuItem.Name = "جذفToolStripMenuItem";
            this.جذفToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.جذفToolStripMenuItem.Text = "حذف";
            this.جذفToolStripMenuItem.Click += new System.EventHandler(this.جذفToolStripMenuItem_Click);
            // 
            // dataGridView_desks
            // 
            this.dataGridView_desks.AllowUserToAddRows = false;
            this.dataGridView_desks.AllowUserToDeleteRows = false;
            this.dataGridView_desks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_desks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_desks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deskCode,
            this.deState11,
            this.deState22,
            this.deGame,
            this.dPrice,
            this.iddd});
            this.dataGridView_desks.ContextMenuStrip = this.contextMenuStrip_desk;
            this.dataGridView_desks.Location = new System.Drawing.Point(452, 12);
            this.dataGridView_desks.Name = "dataGridView_desks";
            this.dataGridView_desks.ReadOnly = true;
            this.dataGridView_desks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_desks.RowHeadersWidth = 51;
            this.dataGridView_desks.RowTemplate.Height = 24;
            this.dataGridView_desks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_desks.Size = new System.Drawing.Size(180, 676);
            this.dataGridView_desks.TabIndex = 1;
            this.dataGridView_desks.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_desks_CellMouseEnter);
            this.dataGridView_desks.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_desks_CellMouseLeave);
            // 
            // deskCode
            // 
            this.deskCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deskCode.DataPropertyName = "deskCode";
            this.deskCode.HeaderText = "میز";
            this.deskCode.MinimumWidth = 6;
            this.deskCode.Name = "deskCode";
            this.deskCode.ReadOnly = true;
            // 
            // deState11
            // 
            this.deState11.DataPropertyName = "deState";
            this.deState11.HeaderText = "deState";
            this.deState11.MinimumWidth = 6;
            this.deState11.Name = "deState11";
            this.deState11.ReadOnly = true;
            this.deState11.Visible = false;
            this.deState11.Width = 125;
            // 
            // deState22
            // 
            this.deState22.DataPropertyName = "deState2";
            this.deState22.HeaderText = "deState2";
            this.deState22.MinimumWidth = 6;
            this.deState22.Name = "deState22";
            this.deState22.ReadOnly = true;
            this.deState22.Visible = false;
            this.deState22.Width = 125;
            // 
            // deGame
            // 
            this.deGame.DataPropertyName = "deGame";
            this.deGame.HeaderText = "deActivity";
            this.deGame.MinimumWidth = 6;
            this.deGame.Name = "deGame";
            this.deGame.ReadOnly = true;
            this.deGame.Visible = false;
            this.deGame.Width = 125;
            // 
            // dPrice
            // 
            this.dPrice.DataPropertyName = "dePrice";
            this.dPrice.HeaderText = "dPrice";
            this.dPrice.MinimumWidth = 6;
            this.dPrice.Name = "dPrice";
            this.dPrice.ReadOnly = true;
            this.dPrice.Visible = false;
            this.dPrice.Width = 125;
            // 
            // iddd
            // 
            this.iddd.DataPropertyName = "id";
            this.iddd.HeaderText = "iddd";
            this.iddd.MinimumWidth = 6;
            this.iddd.Name = "iddd";
            this.iddd.ReadOnly = true;
            this.iddd.Visible = false;
            this.iddd.Width = 125;
            // 
            // contextMenuStrip_desk
            // 
            this.contextMenuStrip_desk.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_desk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem});
            this.contextMenuStrip_desk.Name = "contextMenuStrip_desk";
            this.contextMenuStrip_desk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip_desk.Size = new System.Drawing.Size(111, 28);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(226)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(171)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(93, 317);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(221, 46);
            this.button_add.TabIndex = 60;
            this.button_add.Text = "افزودن بازی";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // gameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_desks);
            this.Controls.Add(this.dataGridView_games);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "gameList";
            this.Text = "gameList";
            this.Load += new System.EventHandler(this.gameList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_games)).EndInit();
            this.contextMenuStrip_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_desks)).EndInit();
            this.contextMenuStrip_desk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_games;
        private System.Windows.Forms.DataGridView dataGridView_desks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_game;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem جذفToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_desk;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem افزودنمیزToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn acName;
        private System.Windows.Forms.DataGridViewTextBoxColumn acPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn acState11;
        private System.Windows.Forms.DataGridViewTextBoxColumn acState22;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn deState11;
        private System.Windows.Forms.DataGridViewTextBoxColumn deState22;
        private System.Windows.Forms.DataGridViewTextBoxColumn deGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddd;
        private System.Windows.Forms.Button button_add;
    }
}