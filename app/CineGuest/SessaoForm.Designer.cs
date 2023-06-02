namespace CineGuest
{
    partial class SessaoForm
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
            this.bgSessao = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtaInicioSessao = new System.Windows.Forms.DateTimePicker();
            this.tbPrecoSessao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hrSessao = new System.Windows.Forms.DateTimePicker();
            this.btnAddSessao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtaFimSessao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.bgSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgSessao
            // 
            this.bgSessao.Controls.Add(this.label7);
            this.bgSessao.Controls.Add(this.dtaInicioSessao);
            this.bgSessao.Controls.Add(this.tbPrecoSessao);
            this.bgSessao.Controls.Add(this.label6);
            this.bgSessao.Controls.Add(this.hrSessao);
            this.bgSessao.Controls.Add(this.btnAddSessao);
            this.bgSessao.Controls.Add(this.label5);
            this.bgSessao.Controls.Add(this.label4);
            this.bgSessao.Controls.Add(this.label3);
            this.bgSessao.Controls.Add(this.dtaFimSessao);
            this.bgSessao.Controls.Add(this.label2);
            this.bgSessao.Controls.Add(this.cbFilme);
            this.bgSessao.Controls.Add(this.label1);
            this.bgSessao.Controls.Add(this.cbSala);
            this.bgSessao.Location = new System.Drawing.Point(9, 57);
            this.bgSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgSessao.Name = "bgSessao";
            this.bgSessao.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bgSessao.Size = new System.Drawing.Size(318, 305);
            this.bgSessao.TabIndex = 0;
            this.bgSessao.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data de fim";
            // 
            // dtaInicioSessao
            // 
            this.dtaInicioSessao.CustomFormat = "dd/MM/yyyy";
            this.dtaInicioSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtaInicioSessao.Location = new System.Drawing.Point(15, 194);
            this.dtaInicioSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtaInicioSessao.Name = "dtaInicioSessao";
            this.dtaInicioSessao.Size = new System.Drawing.Size(120, 20);
            this.dtaInicioSessao.TabIndex = 9;
            // 
            // tbPrecoSessao
            // 
            this.tbPrecoSessao.Location = new System.Drawing.Point(15, 141);
            this.tbPrecoSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrecoSessao.Name = "tbPrecoSessao";
            this.tbPrecoSessao.Size = new System.Drawing.Size(251, 20);
            this.tbPrecoSessao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preço da Sessão";
            // 
            // hrSessao
            // 
            this.hrSessao.CustomFormat = "hh:mm";
            this.hrSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hrSessao.Location = new System.Drawing.Point(15, 243);
            this.hrSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hrSessao.Name = "hrSessao";
            this.hrSessao.Size = new System.Drawing.Size(251, 20);
            this.hrSessao.TabIndex = 6;
            // 
            // btnAddSessao
            // 
            this.btnAddSessao.Location = new System.Drawing.Point(104, 273);
            this.btnAddSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSessao.Name = "btnAddSessao";
            this.btnAddSessao.Size = new System.Drawing.Size(106, 19);
            this.btnAddSessao.TabIndex = 5;
            this.btnAddSessao.Text = "Adicionar Sessão";
            this.btnAddSessao.UseVisualStyleBackColor = true;
            this.btnAddSessao.Click += new System.EventHandler(this.btnAddSessao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hora da Sessão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filme da Sessão";
            // 
            // dtaFimSessao
            // 
            this.dtaFimSessao.CustomFormat = "dd/MM/yyyy";
            this.dtaFimSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtaFimSessao.Location = new System.Drawing.Point(146, 194);
            this.dtaFimSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtaFimSessao.Name = "dtaFimSessao";
            this.dtaFimSessao.Size = new System.Drawing.Size(120, 20);
            this.dtaFimSessao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filme da Sessão";
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(15, 90);
            this.cbFilme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(251, 21);
            this.cbFilme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala da Sessão";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(15, 38);
            this.cbSala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(251, 21);
            this.cbSala.TabIndex = 0;
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormatString = "g";
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(359, 80);
            this.lbSessoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(338, 199);
            this.lbSessoes.TabIndex = 1;
            // 
            // SessaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 436);
            this.Controls.Add(this.lbSessoes);
            this.Controls.Add(this.bgSessao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SessaoForm";
            this.Text = "SessaoForm";
            this.Load += new System.EventHandler(this.SessaoForm_Load);
            this.bgSessao.ResumeLayout(false);
            this.bgSessao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgSessao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.DateTimePicker dtaFimSessao;
        private System.Windows.Forms.Button btnAddSessao;
        private System.Windows.Forms.DateTimePicker hrSessao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecoSessao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtaInicioSessao;
    }
}