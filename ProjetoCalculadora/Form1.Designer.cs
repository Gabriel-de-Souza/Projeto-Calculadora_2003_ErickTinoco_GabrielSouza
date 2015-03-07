namespace ProjetoCalculadora
{
    partial class Form1
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
            this.enterValue = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bMais = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.bMenos = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bRaiz = new System.Windows.Forms.Button();
            this.bPorC = new System.Windows.Forms.Button();
            this.bResto = new System.Windows.Forms.Button();
            this.bTg = new System.Windows.Forms.Button();
            this.bCos = new System.Windows.Forms.Button();
            this.bSin = new System.Windows.Forms.Button();
            this.bPot = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.countView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterValue
            // 
            this.enterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterValue.Location = new System.Drawing.Point(12, 56);
            this.enterValue.Name = "enterValue";
            this.enterValue.ReadOnly = true;
            this.enterValue.Size = new System.Drawing.Size(359, 30);
            this.enterValue.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 252);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(42, 34);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Digitou);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(84, 252);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(42, 34);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Digitou);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(165, 252);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(42, 34);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Digitou);
            // 
            // bMais
            // 
            this.bMais.Location = new System.Drawing.Point(243, 292);
            this.bMais.Name = "bMais";
            this.bMais.Size = new System.Drawing.Size(42, 34);
            this.bMais.TabIndex = 4;
            this.bMais.Text = "+";
            this.bMais.UseVisualStyleBackColor = true;
            this.bMais.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // bIgual
            // 
            this.bIgual.Location = new System.Drawing.Point(315, 252);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(42, 74);
            this.bIgual.TabIndex = 5;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = true;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // bMenos
            // 
            this.bMenos.Location = new System.Drawing.Point(243, 252);
            this.bMenos.Name = "bMenos";
            this.bMenos.Size = new System.Drawing.Size(42, 34);
            this.bMenos.TabIndex = 9;
            this.bMenos.Text = "-";
            this.bMenos.UseVisualStyleBackColor = true;
            this.bMenos.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(165, 212);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(42, 34);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.Digitou);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(84, 212);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(42, 34);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.Digitou);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 212);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(42, 34);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.Digitou);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 292);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(114, 34);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.Digitou);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(165, 292);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(42, 34);
            this.bDot.TabIndex = 11;
            this.bDot.Text = ",";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.Digitou);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(165, 172);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(42, 34);
            this.b9.TabIndex = 14;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.Digitou);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(84, 172);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(42, 34);
            this.b8.TabIndex = 13;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.Digitou);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 172);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(42, 34);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.Digitou);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(243, 172);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(42, 34);
            this.bDiv.TabIndex = 16;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(243, 212);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(42, 34);
            this.bMulti.TabIndex = 15;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // bRaiz
            // 
            this.bRaiz.Location = new System.Drawing.Point(315, 172);
            this.bRaiz.Name = "bRaiz";
            this.bRaiz.Size = new System.Drawing.Size(42, 34);
            this.bRaiz.TabIndex = 18;
            this.bRaiz.Text = "√";
            this.bRaiz.UseVisualStyleBackColor = true;
            this.bRaiz.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // bPorC
            // 
            this.bPorC.Location = new System.Drawing.Point(315, 212);
            this.bPorC.Name = "bPorC";
            this.bPorC.Size = new System.Drawing.Size(42, 34);
            this.bPorC.TabIndex = 17;
            this.bPorC.Text = "%";
            this.bPorC.UseVisualStyleBackColor = true;
            this.bPorC.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // bResto
            // 
            this.bResto.Location = new System.Drawing.Point(278, 132);
            this.bResto.Name = "bResto";
            this.bResto.Size = new System.Drawing.Size(93, 34);
            this.bResto.TabIndex = 22;
            this.bResto.Text = "RESTO";
            this.bResto.UseVisualStyleBackColor = true;
            this.bResto.Click += new System.EventHandler(this.operacaoBasica);
            // 
            // bTg
            // 
            this.bTg.Location = new System.Drawing.Point(165, 132);
            this.bTg.Name = "bTg";
            this.bTg.Size = new System.Drawing.Size(57, 34);
            this.bTg.TabIndex = 21;
            this.bTg.Text = "tg";
            this.bTg.UseVisualStyleBackColor = true;
            this.bTg.Click += new System.EventHandler(this.tg_Click);
            // 
            // bCos
            // 
            this.bCos.Location = new System.Drawing.Point(84, 132);
            this.bCos.Name = "bCos";
            this.bCos.Size = new System.Drawing.Size(58, 34);
            this.bCos.TabIndex = 20;
            this.bCos.Text = "cos";
            this.bCos.UseVisualStyleBackColor = true;
            this.bCos.Click += new System.EventHandler(this.cos_Click);
            // 
            // bSin
            // 
            this.bSin.Location = new System.Drawing.Point(12, 132);
            this.bSin.Name = "bSin";
            this.bSin.Size = new System.Drawing.Size(52, 34);
            this.bSin.TabIndex = 19;
            this.bSin.Text = "sin";
            this.bSin.UseVisualStyleBackColor = true;
            this.bSin.Click += new System.EventHandler(this.sin_Click);
            // 
            // bPot
            // 
            this.bPot.Location = new System.Drawing.Point(278, 92);
            this.bPot.Name = "bPot";
            this.bPot.Size = new System.Drawing.Size(52, 34);
            this.bPot.TabIndex = 25;
            this.bPot.Text = "X²";
            this.bPot.UseVisualStyleBackColor = true;
            this.bPot.Click += new System.EventHandler(this.pot_Click);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(155, 92);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(52, 34);
            this.bCE.TabIndex = 24;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(65, 92);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(52, 34);
            this.bC.TabIndex = 23;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // countView
            // 
            this.countView.AutoSize = true;
            this.countView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.countView.Location = new System.Drawing.Point(7, 28);
            this.countView.Name = "countView";
            this.countView.Size = new System.Drawing.Size(0, 25);
            this.countView.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 365);
            this.Controls.Add(this.countView);
            this.Controls.Add(this.bPot);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bResto);
            this.Controls.Add(this.bTg);
            this.Controls.Add(this.bCos);
            this.Controls.Add(this.bSin);
            this.Controls.Add(this.bRaiz);
            this.Controls.Add(this.bPorC);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bMenos);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bMais);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.enterValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculadora do Gabriel e do Erick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterValue;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bMais;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button bMenos;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bRaiz;
        private System.Windows.Forms.Button bPorC;
        private System.Windows.Forms.Button bResto;
        private System.Windows.Forms.Button bTg;
        private System.Windows.Forms.Button bCos;
        private System.Windows.Forms.Button bSin;
        private System.Windows.Forms.Button bPot;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Label countView;
    }
}

