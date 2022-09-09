namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnElevado = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPorcent = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnElevado
            // 
            this.btnElevado.BackColor = System.Drawing.Color.White;
            this.btnElevado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElevado.Location = new System.Drawing.Point(327, 143);
            this.btnElevado.Name = "btnElevado";
            this.btnElevado.Size = new System.Drawing.Size(67, 51);
            this.btnElevado.TabIndex = 46;
            this.btnElevado.Text = "x²";
            this.btnElevado.UseVisualStyleBackColor = false;
            this.btnElevado.Click += new System.EventHandler(this.btnElevado_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(255, 144);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(66, 51);
            this.btnDiv.TabIndex = 45;
            this.btnDiv.Text = "1/x";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPorcent
            // 
            this.btnPorcent.BackColor = System.Drawing.Color.White;
            this.btnPorcent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPorcent.Location = new System.Drawing.Point(255, 86);
            this.btnPorcent.Name = "btnPorcent";
            this.btnPorcent.Size = new System.Drawing.Size(66, 51);
            this.btnPorcent.TabIndex = 44;
            this.btnPorcent.Text = "%";
            this.btnPorcent.UseVisualStyleBackColor = false;
            this.btnPorcent.Click += new System.EventHandler(this.btnPorcent_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.White;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCE.Location = new System.Drawing.Point(327, 86);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(67, 51);
            this.btnCE.TabIndex = 43;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(400, 86);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 51);
            this.btnC.TabIndex = 42;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.White;
            this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.Location = new System.Drawing.Point(400, 143);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(67, 51);
            this.btnRaiz.TabIndex = 41;
            this.btnRaiz.Text = "²√x";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.White;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.Location = new System.Drawing.Point(473, 87);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(64, 51);
            this.btnApagar.TabIndex = 40;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.White;
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.Location = new System.Drawing.Point(473, 144);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(64, 51);
            this.btnDivisao.TabIndex = 39;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPonto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPonto.Location = new System.Drawing.Point(400, 371);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(67, 51);
            this.btnPonto.TabIndex = 38;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(327, 371);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 51);
            this.btn0.TabIndex = 37;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(400, 314);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 51);
            this.btn9.TabIndex = 36;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(327, 314);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 51);
            this.btn8.TabIndex = 35;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(255, 314);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(66, 51);
            this.btn7.TabIndex = 34;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(400, 257);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 51);
            this.btn6.TabIndex = 33;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(327, 257);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 51);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(255, 257);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(66, 51);
            this.btn4.TabIndex = 31;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(255, 200);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 51);
            this.btn1.TabIndex = 30;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(327, 200);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 51);
            this.btn2.TabIndex = 29;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(400, 200);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 51);
            this.btn3.TabIndex = 28;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.White;
            this.btnVezes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVezes.Location = new System.Drawing.Point(473, 200);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(64, 51);
            this.btnVezes.TabIndex = 27;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(473, 257);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(64, 51);
            this.btnMenos.TabIndex = 26;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.White;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMais.Location = new System.Drawing.Point(473, 314);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(64, 51);
            this.btnMais.TabIndex = 25;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.White;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(473, 371);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(64, 51);
            this.btnResult.TabIndex = 24;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaisMenos.Enabled = false;
            this.btnMaisMenos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaisMenos.Location = new System.Drawing.Point(255, 371);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(66, 51);
            this.btnMaisMenos.TabIndex = 47;
            this.btnMaisMenos.Text = "+/-";
            this.btnMaisMenos.UseVisualStyleBackColor = false;
            // 
            // txbResult
            // 
            this.txbResult.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbResult.Location = new System.Drawing.Point(255, 30);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(282, 51);
            this.txbResult.TabIndex = 48;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacao.Location = new System.Drawing.Point(255, 9);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 15);
            this.lblOperacao.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnElevado);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPorcent);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnElevado;
        private Button btnDiv;
        private Button btnPorcent;
        private Button btnCE;
        private Button btnC;
        private Button btnRaiz;
        private Button btnApagar;
        private Button btnDivisao;
        private Button btnPonto;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnVezes;
        private Button btnMenos;
        private Button btnMais;
        private Button btnResult;
        private Button btnMaisMenos;
        private TextBox txbResult;
        private Label lblOperacao;
    }
}