namespace CineGuest
{
    partial class FilmeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.duracaoFilme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbNomeFilme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFilme = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.duracaoFilme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddMovie);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.tbNomeFilme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // duracaoFilme
            // 
            this.duracaoFilme.CustomFormat = "hh:mm:ss";
            this.duracaoFilme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.duracaoFilme.Location = new System.Drawing.Point(18, 173);
            this.duracaoFilme.Name = "duracaoFilme";
            this.duracaoFilme.ShowUpDown = true;
            this.duracaoFilme.Size = new System.Drawing.Size(232, 22);
            this.duracaoFilme.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Duração";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(103, 276);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(145, 23);
            this.btnAddMovie.TabIndex = 21;
            this.btnAddMovie.Text = "Adicionar filme";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(17, 230);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(232, 24);
            this.cbStatus.TabIndex = 20;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(18, 110);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(232, 24);
            this.cbCategoria.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(18, 90);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(66, 16);
            this.lbl5.TabIndex = 15;
            this.lbl5.Text = "Categoria";
            // 
            // tbNomeFilme
            // 
            this.tbNomeFilme.Location = new System.Drawing.Point(18, 49);
            this.tbNomeFilme.Name = "tbNomeFilme";
            this.tbNomeFilme.Size = new System.Drawing.Size(232, 22);
            this.tbNomeFilme.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome";
            // 
            // lbFilme
            // 
            this.lbFilme.FormattingEnabled = true;
            this.lbFilme.ItemHeight = 16;
            this.lbFilme.Location = new System.Drawing.Point(286, 103);
            this.lbFilme.Name = "lbFilme";
            this.lbFilme.Size = new System.Drawing.Size(502, 244);
            this.lbFilme.TabIndex = 1;
            this.lbFilme.SelectedIndexChanged += new System.EventHandler(this.lbNomeFilme_SelectedIndexChanged);
            // 
            // FilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFilme);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilmeForm";
            this.Text = "FilmeForm";
            this.Load += new System.EventHandler(this.FilmeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbNomeFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ListBox lbFilme;
        private System.Windows.Forms.DateTimePicker duracaoFilme;
        private System.Windows.Forms.Label label1;
    }
}