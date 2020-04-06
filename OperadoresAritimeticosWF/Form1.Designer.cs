namespace OperadoresAritimeticosWF
{
    partial class frmCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(72, 10);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(94, 20);
            this.txbN1.TabIndex = 2;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(72, 36);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(94, 20);
            this.txbN2.TabIndex = 3;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(72, 75);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(428, 20);
            this.txbResultado.TabIndex = 4;
            this.txbResultado.TextChanged += new System.EventHandler(this.txbResultado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(209, 10);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(29, 23);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.Location = new System.Drawing.Point(244, 10);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(29, 23);
            this.btnSubt.TabIndex = 7;
            this.btnSubt.Text = "-";
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.btnSubt_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(209, 38);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(29, 23);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(244, 38);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(29, 23);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 335);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
    }
}

