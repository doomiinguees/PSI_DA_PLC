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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.gbSala = new System.Windows.Forms.GroupBox();
            this.gbSessao.SuspendLayout();
            this.tabSala.SuspendLayout();
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
            this.tabSala.Controls.Add(this.vScrollBar1, 0, 0);
            this.tabSala.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tabSala.Location = new System.Drawing.Point(6, 21);
            this.tabSala.Name = "tabSala";
            this.tabSala.RowCount = 1;
            this.tabSala.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabSala.Size = new System.Drawing.Size(915, 624);
            this.tabSala.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(36, 611);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
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
            // AtendimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 694);
            this.Controls.Add(this.gbSala);
            this.Controls.Add(this.gbSessao);
            this.Name = "AtendimentoForm";
            this.Text = "AtendimentoForm";
            this.Load += new System.EventHandler(this.AtendimentoForm_Load);
            this.gbSessao.ResumeLayout(false);
            this.gbSessao.PerformLayout();
            this.tabSala.ResumeLayout(false);
            this.gbSala.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSessao;
        private System.Windows.Forms.GroupBox gbSessao;
        private System.Windows.Forms.TableLayoutPanel tabSala;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox gbSala;
    }
}