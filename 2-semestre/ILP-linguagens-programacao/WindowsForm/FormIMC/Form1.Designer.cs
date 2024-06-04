namespace WinForm_1
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
            lbPeso = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lbAltura = new Label();
            btnCalcularIMC = new Button();
            lbResultado = new Label();
            lbIMC = new Label();
            lbClassificacao = new Label();
            SuspendLayout();
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPeso.Location = new Point(17, 49);
            lbPeso.Margin = new Padding(4, 0, 4, 0);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(53, 23);
            lbPeso.TabIndex = 0;
            lbPeso.Text = "Peso:";
            lbPeso.Click += label1_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(90, 49);
            txtPeso.Margin = new Padding(4, 5, 4, 5);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(161, 31);
            txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(90, 104);
            txtAltura.Margin = new Padding(4, 5, 4, 5);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(161, 31);
            txtAltura.TabIndex = 3;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAltura.Location = new Point(17, 107);
            lbAltura.Margin = new Padding(4, 0, 4, 0);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(65, 23);
            lbAltura.TabIndex = 2;
            lbAltura.Text = "Altura:";
            // 
            // btnCalcularIMC
            // 
            btnCalcularIMC.Location = new Point(105, 161);
            btnCalcularIMC.Margin = new Padding(4, 5, 4, 5);
            btnCalcularIMC.Name = "btnCalcularIMC";
            btnCalcularIMC.Size = new Size(166, 46);
            btnCalcularIMC.TabIndex = 4;
            btnCalcularIMC.Text = "Calcular IMC";
            btnCalcularIMC.UseVisualStyleBackColor = true;
            btnCalcularIMC.Click += btnCalcularIMC_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(17, 226);
            lbResultado.Margin = new Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(95, 23);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado:";
            // 
            // lbIMC
            // 
            lbIMC.AutoSize = true;
            lbIMC.Location = new Point(17, 249);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(42, 23);
            lbIMC.TabIndex = 6;
            lbIMC.Text = "IMC";
            lbIMC.Visible = false;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(17, 272);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(107, 23);
            lbClassificacao.TabIndex = 7;
            lbClassificacao.Text = "Classificação";
            lbClassificacao.Visible = false;
            lbClassificacao.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(362, 466);
            Controls.Add(lbClassificacao);
            Controls.Add(lbIMC);
            Controls.Add(lbResultado);
            Controls.Add(btnCalcularIMC);
            Controls.Add(txtAltura);
            Controls.Add(lbAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Calculadora de IMC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeso;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lbAltura;
        private Button btnCalcularIMC;
        private Label lbResultado;
        private Label lbIMC;
        private Label lbClassificacao;
    }
}
