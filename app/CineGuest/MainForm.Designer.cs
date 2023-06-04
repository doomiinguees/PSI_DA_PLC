namespace CineGuest
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.dtpDiadeSessao = new System.Windows.Forms.DateTimePicker();
            this.lbSessoesMain = new System.Windows.Forms.ListBox();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemaToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.sessõesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(594, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cinemaToolStripMenuItem.Text = "Cinema";
            this.cinemaToolStripMenuItem.Click += new System.EventHandler(this.cinemaToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            this.sessõesToolStripMenuItem.Click += new System.EventHandler(this.sesõesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(446, 3);
            this.cbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(140, 21);
            this.cbUser.TabIndex = 1;
            this.cbUser.Text = "<Selecionar Funcionário>";
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // dtpDiadeSessao
            // 
            this.dtpDiadeSessao.CustomFormat = "dd/MM/yyyy";
            this.dtpDiadeSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDiadeSessao.Location = new System.Drawing.Point(204, 67);
            this.dtpDiadeSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDiadeSessao.MinDate = new System.DateTime(2023, 6, 4, 0, 0, 0, 0);
            this.dtpDiadeSessao.Name = "dtpDiadeSessao";
            this.dtpDiadeSessao.Size = new System.Drawing.Size(186, 20);
            this.dtpDiadeSessao.TabIndex = 2;
            this.dtpDiadeSessao.ValueChanged += new System.EventHandler(this.dtpDiadeSessao_ValueChanged);
            // 
            // lbSessoesMain
            // 
            this.lbSessoesMain.FormattingEnabled = true;
            this.lbSessoesMain.Location = new System.Drawing.Point(82, 89);
            this.lbSessoesMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSessoesMain.Name = "lbSessoesMain";
            this.lbSessoesMain.Size = new System.Drawing.Size(422, 225);
            this.lbSessoesMain.TabIndex = 3;
            this.lbSessoesMain.DoubleClick += new System.EventHandler(this.lbSessoesMain_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 346);
            this.Controls.Add(this.lbSessoesMain);
            this.Controls.Add(this.dtpDiadeSessao);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGuest";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.DateTimePicker dtpDiadeSessao;
        private System.Windows.Forms.ListBox lbSessoesMain;
    }
}

