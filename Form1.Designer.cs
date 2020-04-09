namespace ProjetoEmpresa_WF
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAssalariado = new System.Windows.Forms.Button();
            this.btnComissionado = new System.Windows.Forms.Button();
            this.btnHorista = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAnotacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssalariado
            // 
            this.btnAssalariado.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAssalariado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssalariado.Location = new System.Drawing.Point(3, 6);
            this.btnAssalariado.Name = "btnAssalariado";
            this.btnAssalariado.Size = new System.Drawing.Size(215, 57);
            this.btnAssalariado.TabIndex = 0;
            this.btnAssalariado.Text = "Assalariado";
            this.btnAssalariado.UseVisualStyleBackColor = false;
            this.btnAssalariado.Click += new System.EventHandler(this.btnAssalariado_Click);
            // 
            // btnComissionado
            // 
            this.btnComissionado.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnComissionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComissionado.Location = new System.Drawing.Point(3, 69);
            this.btnComissionado.Name = "btnComissionado";
            this.btnComissionado.Size = new System.Drawing.Size(215, 57);
            this.btnComissionado.TabIndex = 1;
            this.btnComissionado.Text = "Comissionado";
            this.btnComissionado.UseVisualStyleBackColor = false;
            this.btnComissionado.Click += new System.EventHandler(this.btnComissionado_Click);
            // 
            // btnHorista
            // 
            this.btnHorista.BackColor = System.Drawing.Color.PeachPuff;
            this.btnHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorista.Location = new System.Drawing.Point(3, 133);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(215, 57);
            this.btnHorista.TabIndex = 2;
            this.btnHorista.Text = "Horista";
            this.btnHorista.UseVisualStyleBackColor = false;
            this.btnHorista.Click += new System.EventHandler(this.btnHorista_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Salmon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(232, 133);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(215, 57);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAnotacao
            // 
            this.lblAnotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotacao.Location = new System.Drawing.Point(271, 18);
            this.lblAnotacao.Name = "lblAnotacao";
            this.lblAnotacao.Size = new System.Drawing.Size(155, 98);
            this.lblAnotacao.TabIndex = 4;
            this.lblAnotacao.Text = "Exemplo de implementação";
            this.lblAnotacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 195);
            this.Controls.Add(this.lblAnotacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHorista);
            this.Controls.Add(this.btnComissionado);
            this.Controls.Add(this.btnAssalariado);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Empregados :.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssalariado;
        private System.Windows.Forms.Button btnComissionado;
        private System.Windows.Forms.Button btnHorista;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAnotacao;
    }
}

