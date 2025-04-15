namespace Projeto_Previsao_do_Tempo
{
    partial class Form1
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(96, 195);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(412, 30);
            this.txtCidade.TabIndex = 0;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCidade_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(556, 181);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(216, 57);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Clima";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Gold;
            this.lblResultado.Location = new System.Drawing.Point(208, 293);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(300, 100);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "\"\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o nome da cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Busca Previsão do Tempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

