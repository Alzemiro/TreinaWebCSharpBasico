namespace Aula14Exercicios
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
            this.lblIMC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultadoIMC = new System.Windows.Forms.Label();
            this.btnIMC = new System.Windows.Forms.Button();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.lblRetanguloArea = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbRetLargura = new System.Windows.Forms.TextBox();
            this.txbRetComprimento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRetanguloPerimetro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenacao = new System.Windows.Forms.Button();
            this.txbOrdenacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultadoOrdencao = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbElemVetor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(93, 18);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(81, 47);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 2;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(82, 84);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // lblResultadoIMC
            // 
            this.lblResultadoIMC.AutoSize = true;
            this.lblResultadoIMC.Location = new System.Drawing.Point(106, 123);
            this.lblResultadoIMC.Name = "lblResultadoIMC";
            this.lblResultadoIMC.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoIMC.TabIndex = 6;
            this.lblResultadoIMC.Text = "label5";
            this.lblResultadoIMC.Visible = false;
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(106, 155);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(75, 23);
            this.btnIMC.TabIndex = 7;
            this.btnIMC.Text = "Calcular";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(106, 363);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRetangulo.TabIndex = 15;
            this.btnRetangulo.Text = "Calcular";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRetanguloArea
            // 
            this.lblRetanguloArea.AutoSize = true;
            this.lblRetanguloArea.Location = new System.Drawing.Point(79, 306);
            this.lblRetanguloArea.Name = "lblRetanguloArea";
            this.lblRetanguloArea.Size = new System.Drawing.Size(35, 13);
            this.lblRetanguloArea.TabIndex = 14;
            this.lblRetanguloArea.Text = "label6";
            this.lblRetanguloArea.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Area:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Largura";
            // 
            // txbRetLargura
            // 
            this.txbRetLargura.Location = new System.Drawing.Point(82, 267);
            this.txbRetLargura.Name = "txbRetLargura";
            this.txbRetLargura.Size = new System.Drawing.Size(100, 20);
            this.txbRetLargura.TabIndex = 11;
            // 
            // txbRetComprimento
            // 
            this.txbRetComprimento.Location = new System.Drawing.Point(81, 230);
            this.txbRetComprimento.Name = "txbRetComprimento";
            this.txbRetComprimento.Size = new System.Drawing.Size(100, 20);
            this.txbRetComprimento.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Comprimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Retângulo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Perimetro:";
            // 
            // lblRetanguloPerimetro
            // 
            this.lblRetanguloPerimetro.AutoSize = true;
            this.lblRetanguloPerimetro.Location = new System.Drawing.Point(78, 337);
            this.lblRetanguloPerimetro.Name = "lblRetanguloPerimetro";
            this.lblRetanguloPerimetro.Size = new System.Drawing.Size(41, 13);
            this.lblRetanguloPerimetro.TabIndex = 17;
            this.lblRetanguloPerimetro.Text = "label12";
            this.lblRetanguloPerimetro.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ordenação";
            // 
            // btnOrdenacao
            // 
            this.btnOrdenacao.Location = new System.Drawing.Point(271, 142);
            this.btnOrdenacao.Name = "btnOrdenacao";
            this.btnOrdenacao.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenacao.TabIndex = 19;
            this.btnOrdenacao.Text = "Ordenar";
            this.btnOrdenacao.UseVisualStyleBackColor = true;
            this.btnOrdenacao.Click += new System.EventHandler(this.btnOrdenacao_Click);
            // 
            // txbOrdenacao
            // 
            this.txbOrdenacao.Location = new System.Drawing.Point(271, 60);
            this.txbOrdenacao.Name = "txbOrdenacao";
            this.txbOrdenacao.Size = new System.Drawing.Size(168, 20);
            this.txbOrdenacao.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valores dividivos por virgula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Resultado";
            // 
            // lblResultadoOrdencao
            // 
            this.lblResultadoOrdencao.AutoSize = true;
            this.lblResultadoOrdencao.Location = new System.Drawing.Point(329, 174);
            this.lblResultadoOrdencao.Name = "lblResultadoOrdencao";
            this.lblResultadoOrdencao.Size = new System.Drawing.Size(41, 13);
            this.lblResultadoOrdencao.TabIndex = 23;
            this.lblResultadoOrdencao.Text = "label12";
            this.lblResultadoOrdencao.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Quantidade de elementos no vetor";
            //this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txbElemVetor
            // 
            this.txbElemVetor.Location = new System.Drawing.Point(271, 107);
            this.txbElemVetor.Name = "txbElemVetor";
            this.txbElemVetor.Size = new System.Drawing.Size(57, 20);
            this.txbElemVetor.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.txbElemVetor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblResultadoOrdencao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbOrdenacao);
            this.Controls.Add(this.btnOrdenacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRetanguloPerimetro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRetangulo);
            this.Controls.Add(this.lblRetanguloArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbRetLargura);
            this.Controls.Add(this.txbRetComprimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.lblResultadoIMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIMC);
            this.Name = "Form1";
            this.Text = "Exercicio14 IMC/Triangulo/Ordenacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultadoIMC;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Label lblRetanguloArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbRetLargura;
        private System.Windows.Forms.TextBox txbRetComprimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRetanguloPerimetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenacao;
        private System.Windows.Forms.TextBox txbOrdenacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultadoOrdencao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbElemVetor;
    }
}

