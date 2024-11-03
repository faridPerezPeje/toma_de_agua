namespace my_quincena
{
    partial class frmMayores
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
            label1 = new Label();
            btnCalcular = new Button();
            rbtnGerente = new RadioButton();
            rbtnDirector = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            txtTotalMay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtsueldobruto = new TextBox();
            label6 = new Label();
            btnRegresar = new Button();
            lblISR = new Label();
            Dechambitas = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(427, 40);
            label1.TabIndex = 0;
            label1.Text = "Zona de Empleados Mayores";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(454, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbtnGerente
            // 
            rbtnGerente.AutoSize = true;
            rbtnGerente.Location = new Point(66, 198);
            rbtnGerente.Name = "rbtnGerente";
            rbtnGerente.Size = new Size(82, 24);
            rbtnGerente.TabIndex = 7;
            rbtnGerente.TabStop = true;
            rbtnGerente.Text = "Gerente";
            rbtnGerente.UseVisualStyleBackColor = true;
            rbtnGerente.CheckedChanged += rbtnGerente_CheckedChanged;
            // 
            // rbtnDirector
            // 
            rbtnDirector.AutoSize = true;
            rbtnDirector.Location = new Point(66, 168);
            rbtnDirector.Name = "rbtnDirector";
            rbtnDirector.Size = new Size(84, 24);
            rbtnDirector.TabIndex = 8;
            rbtnDirector.TabStop = true;
            rbtnDirector.Text = "Director";
            rbtnDirector.UseVisualStyleBackColor = true;
            rbtnDirector.CheckedChanged += rbtnDirector_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 144);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Faltas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 260);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 13;
            label3.Text = "Descuento ISR";
            // 
            // txtTotalMay
            // 
            txtTotalMay.Location = new Point(218, 336);
            txtTotalMay.Name = "txtTotalMay";
            txtTotalMay.Size = new Size(125, 27);
            txtTotalMay.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 313);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 16;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 175);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 17;
            label4.Text = "Horas Extras";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(408, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 18;
            textBox1.Text = "NO SE ACUMULAN HORAS EXTRAS";
            // 
            // txtsueldobruto
            // 
            txtsueldobruto.Location = new Point(66, 260);
            txtsueldobruto.Name = "txtsueldobruto";
            txtsueldobruto.Size = new Size(125, 27);
            txtsueldobruto.TabIndex = 20;
            txtsueldobruto.TextChanged += txtsueldobruto_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 233);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 21;
            label6.Text = "sueldo bruto";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(28, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblISR
            // 
            lblISR.AutoSize = true;
            lblISR.Location = new Point(223, 290);
            lblISR.Name = "lblISR";
            lblISR.Size = new Size(79, 20);
            lblISR.TabIndex = 23;
            lblISR.Text = "Descuento";
            lblISR.Click += lblISR_Click;
            // 
            // Dechambitas
            // 
            Dechambitas.DropDownStyle = ComboBoxStyle.DropDownList;
            Dechambitas.FormattingEnabled = true;
            Dechambitas.Items.AddRange(new object[] { "0", "1", "2", "3" });
            Dechambitas.Location = new Point(209, 175);
            Dechambitas.Name = "Dechambitas";
            Dechambitas.Size = new Size(151, 28);
            Dechambitas.TabIndex = 24;
            // 
            // frmMayores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dechambitas);
            Controls.Add(lblISR);
            Controls.Add(btnRegresar);
            Controls.Add(label6);
            Controls.Add(txtsueldobruto);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtTotalMay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rbtnDirector);
            Controls.Add(rbtnGerente);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "frmMayores";
            Text = "frmEM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private RadioButton rbtnGerente;
        private RadioButton rbtnDirector;
        private Label label2;
        private TextBox txtSueldoNeto;
        private TextBox txtDescuentoMay;
        private Label label3;
        private TextBox txtTotalMay;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtsueldobruto;
        private Label label6;
        private Button btnRegresar;
        private Label lblISR;
        private ComboBox Dechambitas;
    }
}