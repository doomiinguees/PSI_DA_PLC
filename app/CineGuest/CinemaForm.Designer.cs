namespace CineGuest
{
    partial class CinemaForm
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
            this.gbDadosCinema = new System.Windows.Forms.GroupBox();
            this.btnUpdateCinema = new System.Windows.Forms.Button();
            this.tbEmailCinema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMoradalCinema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeCinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAdicionarSala = new System.Windows.Forms.GroupBox();
            this.btnAddSala = new System.Windows.Forms.Button();
            this.tbLinhasSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColunasSala = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbNomeSala = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSala = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDadosCinema.SuspendLayout();
            this.gbAdicionarSala.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosCinema
            // 
            this.gbDadosCinema.Controls.Add(this.btnUpdateCinema);
            this.gbDadosCinema.Controls.Add(this.tbEmailCinema);
            this.gbDadosCinema.Controls.Add(this.label3);
            this.gbDadosCinema.Controls.Add(this.tbMoradalCinema);
            this.gbDadosCinema.Controls.Add(this.label2);
            this.gbDadosCinema.Controls.Add(this.tbNomeCinema);
            this.gbDadosCinema.Controls.Add(this.label1);
            this.gbDadosCinema.Location = new System.Drawing.Point(12, 144);
            this.gbDadosCinema.Name = "gbDadosCinema";
            this.gbDadosCinema.Size = new System.Drawing.Size(271, 245);
            this.gbDadosCinema.TabIndex = 0;
            this.gbDadosCinema.TabStop = false;
            this.gbDadosCinema.Text = "Dados do cinema";
            // 
            // btnUpdateCinema
            // 
            this.btnUpdateCinema.Location = new System.Drawing.Point(106, 214);
            this.btnUpdateCinema.Name = "btnUpdateCinema";
            this.btnUpdateCinema.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateCinema.TabIndex = 7;
            this.btnUpdateCinema.Text = "Atualizar";
            this.btnUpdateCinema.UseVisualStyleBackColor = true;
            this.btnUpdateCinema.Click += new System.EventHandler(this.btnUpdateCinema_Click);
            // 
            // tbEmailCinema
            // 
            this.tbEmailCinema.Location = new System.Drawing.Point(22, 181);
            this.tbEmailCinema.Name = "tbEmailCinema";
            this.tbEmailCinema.Size = new System.Drawing.Size(215, 22);
            this.tbEmailCinema.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // tbMoradalCinema
            // 
            this.tbMoradalCinema.Location = new System.Drawing.Point(25, 112);
            this.tbMoradalCinema.Name = "tbMoradalCinema";
            this.tbMoradalCinema.Size = new System.Drawing.Size(215, 22);
            this.tbMoradalCinema.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morada";
            // 
            // tbNomeCinema
            // 
            this.tbNomeCinema.Location = new System.Drawing.Point(22, 52);
            this.tbNomeCinema.Name = "tbNomeCinema";
            this.tbNomeCinema.Size = new System.Drawing.Size(215, 22);
            this.tbNomeCinema.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // gbAdicionarSala
            // 
            this.gbAdicionarSala.Controls.Add(this.btnAddSala);
            this.gbAdicionarSala.Controls.Add(this.tbLinhasSala);
            this.gbAdicionarSala.Controls.Add(this.label4);
            this.gbAdicionarSala.Controls.Add(this.tbColunasSala);
            this.gbAdicionarSala.Controls.Add(this.lbl5);
            this.gbAdicionarSala.Controls.Add(this.tbNomeSala);
            this.gbAdicionarSala.Controls.Add(this.label6);
            this.gbAdicionarSala.Location = new System.Drawing.Point(294, 144);
            this.gbAdicionarSala.Name = "gbAdicionarSala";
            this.gbAdicionarSala.Size = new System.Drawing.Size(287, 245);
            this.gbAdicionarSala.TabIndex = 1;
            this.gbAdicionarSala.TabStop = false;
            this.gbAdicionarSala.Text = "Adicionar Sala";
            // 
            // btnAddSala
            // 
            this.btnAddSala.Location = new System.Drawing.Point(169, 214);
            this.btnAddSala.Name = "btnAddSala";
            this.btnAddSala.Size = new System.Drawing.Size(86, 23);
            this.btnAddSala.TabIndex = 8;
            this.btnAddSala.Text = "Adicionar";
            this.btnAddSala.UseVisualStyleBackColor = true;
            this.btnAddSala.Click += new System.EventHandler(this.btnAddSala_Click);
            // 
            // tbLinhasSala
            // 
            this.tbLinhasSala.Location = new System.Drawing.Point(23, 181);
            this.tbLinhasSala.Name = "tbLinhasSala";
            this.tbLinhasSala.Size = new System.Drawing.Size(232, 22);
            this.tbLinhasSala.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Linhas";
            // 
            // tbColunasSala
            // 
            this.tbColunasSala.Location = new System.Drawing.Point(23, 112);
            this.tbColunasSala.Name = "tbColunasSala";
            this.tbColunasSala.Size = new System.Drawing.Size(232, 22);
            this.tbColunasSala.TabIndex = 10;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(23, 93);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(56, 16);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Colunas";
            // 
            // tbNomeSala
            // 
            this.tbNomeSala.Location = new System.Drawing.Point(23, 52);
            this.tbNomeSala.Name = "tbNomeSala";
            this.tbNomeSala.Size = new System.Drawing.Size(232, 22);
            this.tbNomeSala.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome";
            // 
            // lbSala
            // 
            this.lbSala.FormattingEnabled = true;
            this.lbSala.ItemHeight = 16;
            this.lbSala.Location = new System.Drawing.Point(6, 21);
            this.lbSala.Name = "lbSala";
            this.lbSala.Size = new System.Drawing.Size(302, 180);
            this.lbSala.TabIndex = 13;
            this.lbSala.SelectedIndexChanged += new System.EventHandler(this.lbNome_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSala);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(587, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 245);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salas";
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 521);
            this.Controls.Add(this.gbAdicionarSala);
            this.Controls.Add(this.gbDadosCinema);
            this.Controls.Add(this.groupBox1);
            this.Name = "CinemaForm";
            this.Text = "CinemaForm";
            this.gbDadosCinema.ResumeLayout(false);
            this.gbDadosCinema.PerformLayout();
            this.gbAdicionarSala.ResumeLayout(false);
            this.gbAdicionarSala.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosCinema;
        private System.Windows.Forms.TextBox tbEmailCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMoradalCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAdicionarSala;
        private System.Windows.Forms.TextBox tbLinhasSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbColunasSala;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbNomeSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateCinema;
        private System.Windows.Forms.Button btnAddSala;
        private System.Windows.Forms.ListBox lbSala;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}