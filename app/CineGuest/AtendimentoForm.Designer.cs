namespace CineGuest
{
    partial class AtendimentoForm
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
            this.lblSessao = new System.Windows.Forms.Label();
            this.gbSessao = new System.Windows.Forms.GroupBox();
            this.tabSala = new System.Windows.Forms.TableLayoutPanel();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnFinCompra = new System.Windows.Forms.Button();
            this.lbBancos = new System.Windows.Forms.ListBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbSessao.SuspendLayout();
            this.gbSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSessao
            // 
            this.lblSessao.AutoSize = true;
            this.lblSessao.Location = new System.Drawing.Point(27, 18);
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Size = new System.Drawing.Size(96, 16);
            this.lblSessao.TabIndex = 0;
            this.lblSessao.Text = "Dados sessão";
            // 
            // gbSessao
            // 
            this.gbSessao.Controls.Add(this.lblSessao);
            this.gbSessao.Location = new System.Drawing.Point(29, 31);
            this.gbSessao.Name = "gbSessao";
            this.gbSessao.Size = new System.Drawing.Size(200, 100);
            this.gbSessao.TabIndex = 1;
            this.gbSessao.TabStop = false;
            // 
            // tabSala
            // 
            this.tabSala.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabSala.ColumnCount = 1;
            this.tabSala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabSala.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tabSala.Location = new System.Drawing.Point(6, 21);
            this.tabSala.Name = "tabSala";
            this.tabSala.RowCount = 1;
            this.tabSala.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabSala.Size = new System.Drawing.Size(915, 624);
            this.tabSala.TabIndex = 0;
            // 
            // gbSala
            // 
            this.gbSala.Controls.Add(this.tabSala);
            this.gbSala.Location = new System.Drawing.Point(235, 31);
            this.gbSala.Name = "gbSala";
            this.gbSala.Size = new System.Drawing.Size(927, 651);
            this.gbSala.TabIndex = 1;
            this.gbSala.TabStop = false;
            this.gbSala.Text = "Sala";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(29, 659);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 23);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Voltar ao Menu Principal";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnFinCompra
            // 
            this.btnFinCompra.Location = new System.Drawing.Point(29, 390);
            this.btnFinCompra.Name = "btnFinCompra";
            this.btnFinCompra.Size = new System.Drawing.Size(200, 23);
            this.btnFinCompra.TabIndex = 3;
            this.btnFinCompra.Text = "Finalizar compra";
            this.btnFinCompra.UseVisualStyleBackColor = true;
            this.btnFinCompra.Click += new System.EventHandler(this.btnFinCompra_Click);
            // 
            // lbBancos
            // 
            this.lbBancos.FormattingEnabled = true;
            this.lbBancos.ItemHeight = 16;
            this.lbBancos.Location = new System.Drawing.Point(29, 264);
            this.lbBancos.Name = "lbBancos";
            this.lbBancos.Size = new System.Drawing.Size(200, 100);
            this.lbBancos.TabIndex = 4;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(29, 220);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 24);
            this.cbCliente.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(181, 371);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(25, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "-- €";
            // 
            // AtendimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 694);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lbBancos);
            this.Controls.Add(this.btnFinCompra);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.gbSala);
            this.Controls.Add(this.gbSessao);
            this.Name = "AtendimentoForm";
            this.Text = "AtendimentoForm";
            this.Load += new System.EventHandler(this.AtendimentoForm_Load);
            this.gbSessao.ResumeLayout(false);
            this.gbSessao.PerformLayout();
            this.gbSala.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessao;
        private System.Windows.Forms.GroupBox gbSessao;
        private System.Windows.Forms.TableLayoutPanel tabSala;
        private System.Windows.Forms.GroupBox gbSala;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnFinCompra;
        private System.Windows.Forms.ListBox lbBancos;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblPrice;
    }
}