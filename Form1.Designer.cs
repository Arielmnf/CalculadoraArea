namespace Atv_triangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbntitulo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblbase = new System.Windows.Forms.Label();
            this.txbaltura = new System.Windows.Forms.TextBox();
            this.txbbase = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbntitulo
            // 
            this.lbntitulo.AutoSize = true;
            this.lbntitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbntitulo.Location = new System.Drawing.Point(38, 9);
            this.lbntitulo.Name = "lbntitulo";
            this.lbntitulo.Size = new System.Drawing.Size(295, 41);
            this.lbntitulo.TabIndex = 0;
            this.lbntitulo.Text = "ÁREA TRIANGULO";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(40, 98);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(100, 29);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura:";
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbase.Location = new System.Drawing.Point(40, 138);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(76, 29);
            this.lblbase.TabIndex = 2;
            this.lblbase.Text = "Base:";
            // 
            // txbaltura
            // 
            this.txbaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbaltura.Location = new System.Drawing.Point(151, 103);
            this.txbaltura.Name = "txbaltura";
            this.txbaltura.Size = new System.Drawing.Size(100, 24);
            this.txbaltura.TabIndex = 3;
            this.txbaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbbase
            // 
            this.txbbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbase.Location = new System.Drawing.Point(151, 143);
            this.txbbase.Name = "txbbase";
            this.txbbase.Size = new System.Drawing.Size(100, 24);
            this.txbbase.TabIndex = 4;
            this.txbbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(45, 184);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(246, 85);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(46, 284);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(193, 48);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 355);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txbbase);
            this.Controls.Add(this.txbaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lbntitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbntitulo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.TextBox txbaltura;
        private System.Windows.Forms.TextBox txbbase;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresultado;
    }
}

