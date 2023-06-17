namespace CineGuest
{
    partial class ClienteForm
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
            this.cbCliente = new System.Windows.Forms.GroupBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnBilhetes = new System.Windows.Forms.Label();
            this.btnApagarCliente = new System.Windows.Forms.Button();
            this.cbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.Controls.Add(this.btnAddCliente);
            this.cbCliente.Controls.Add(this.tbNIF);
            this.cbCliente.Controls.Add(this.label2);
            this.cbCliente.Controls.Add(this.tbCodPostal);
            this.cbCliente.Controls.Add(this.label6);
            this.cbCliente.Controls.Add(this.tbMorada);
            this.cbCliente.Controls.Add(this.label5);
            this.cbCliente.Controls.Add(this.tbLocalidade);
            this.cbCliente.Controls.Add(this.label4);
            this.cbCliente.Controls.Add(this.tbNome);
            this.cbCliente.Controls.Add(this.label1);
            this.cbCliente.Location = new System.Drawing.Point(13, 13);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(286, 425);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.TabStop = false;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(102, 364);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(152, 23);
            this.btnAddCliente.TabIndex = 27;
            this.btnAddCliente.Text = "Adicionar Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(24, 113);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(230, 22);
            this.tbNIF.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Número de Identificação Fiscal";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(24, 313);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(230, 22);
            this.tbCodPostal.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Codigo Postal";
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(24, 178);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(230, 22);
            this.tbMorada.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Morada";
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(24, 245);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(230, 22);
            this.tbLocalidade.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Localidade";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(24, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(230, 22);
            this.tbNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do Cliente";
            // 
            // lbCliente
            // 
            this.lbCliente.FormattingEnabled = true;
            this.lbCliente.ItemHeight = 16;
            this.lbCliente.Location = new System.Drawing.Point(333, 60);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(545, 292);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.SelectedIndexChanged += new System.EventHandler(this.lbCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(908, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Bilhetes comprados";
            // 
            // lblnBilhetes
            // 
            this.lblnBilhetes.AutoSize = true;
            this.lblnBilhetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnBilhetes.Location = new System.Drawing.Point(1047, 102);
            this.lblnBilhetes.Name = "lblnBilhetes";
            this.lblnBilhetes.Size = new System.Drawing.Size(22, 22);
            this.lblnBilhetes.TabIndex = 3;
            this.lblnBilhetes.Text = "--";
            // 
            // btnApagarCliente
            // 
            this.btnApagarCliente.Location = new System.Drawing.Point(737, 377);
            this.btnApagarCliente.Name = "btnApagarCliente";
            this.btnApagarCliente.Size = new System.Drawing.Size(140, 23);
            this.btnApagarCliente.TabIndex = 4;
            this.btnApagarCliente.Text = "Apagar Cliente";
            this.btnApagarCliente.UseVisualStyleBackColor = true;
            this.btnApagarCliente.Click += new System.EventHandler(this.btnApagarCliente_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 494);
            this.Controls.Add(this.btnApagarCliente);
            this.Controls.Add(this.lblnBilhetes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.cbCliente);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.cbCliente.ResumeLayout(false);
            this.cbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cbCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnBilhetes;
        private System.Windows.Forms.Button btnApagarCliente;
    }
}