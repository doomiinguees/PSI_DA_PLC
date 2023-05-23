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
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddSessao = new System.Windows.Forms.Button();
            this.bgSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgSessao
            // 
            this.bgSessao.Controls.Add(this.btnAddSessao);
            this.bgSessao.Controls.Add(this.dateTimePicker1);
            this.bgSessao.Controls.Add(this.label2);
            this.bgSessao.Controls.Add(this.cbFilme);
            this.bgSessao.Controls.Add(this.label1);
            this.bgSessao.Controls.Add(this.cbSala);
            this.bgSessao.Location = new System.Drawing.Point(12, 70);
            this.bgSessao.Name = "bgSessao";
            this.bgSessao.Size = new System.Drawing.Size(307, 301);
            this.bgSessao.TabIndex = 0;
            this.bgSessao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filme da Sessão";
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Location = new System.Drawing.Point(20, 111);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(246, 24);
            this.cbFilme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala da Sessão";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(20, 47);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(246, 24);
            this.cbSala.TabIndex = 0;
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.ItemHeight = 16;
            this.lbSessoes.Location = new System.Drawing.Point(338, 99);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(450, 244);
            this.lbSessoes.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnAddSessao
            // 
            this.btnAddSessao.Location = new System.Drawing.Point(123, 250);
            this.btnAddSessao.Name = "btnAddSessao";
            this.btnAddSessao.Size = new System.Drawing.Size(142, 23);
            this.btnAddSessao.TabIndex = 5;
            this.btnAddSessao.Text = "Adicionar Sessão";
            this.btnAddSessao.UseVisualStyleBackColor = true;
            this.btnAddSessao.Click += new System.EventHandler(this.btnAddSessao_Click);
            // 
            // SessaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSessoes);
            this.Controls.Add(this.bgSessao);
            this.Name = "SessaoForm";
            this.Text = "SessaoForm";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddSessao;
    }
}