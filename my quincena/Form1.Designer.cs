namespace my_quincena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnSiguiente = new Button();
            textBox2 = new TextBox();
            rbtEMAN = new RadioButton();
            rbtEMEN = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(522, 74);
            label1.TabIndex = 1;
            label1.Text = "fokas company";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(556, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 147);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 83);
            textBox1.TabIndex = 3;
            textBox1.Text = "ingresa el tipo de empleaado al cual se le debe calcular el sueldo";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(590, 401);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 29);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 234);
            textBox2.TabIndex = 6;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // rbtEMAN
            // 
            rbtEMAN.AutoSize = true;
            rbtEMAN.Location = new Point(72, 242);
            rbtEMAN.Name = "rbtEMAN";
            rbtEMAN.Size = new Size(164, 24);
            rbtEMAN.TabIndex = 7;
            rbtEMAN.Text = "Empleados mayores";
            rbtEMAN.UseVisualStyleBackColor = true;
            // 
            // rbtEMEN
            // 
            rbtEMEN.AutoSize = true;
            rbtEMEN.Checked = true;
            rbtEMEN.Location = new Point(72, 272);
            rbtEMEN.Name = "rbtEMEN";
            rbtEMEN.Size = new Size(165, 24);
            rbtEMEN.TabIndex = 8;
            rbtEMEN.TabStop = true;
            rbtEMEN.Text = "Empleados menores";
            rbtEMEN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtEMEN);
            Controls.Add(rbtEMAN);
            Controls.Add(textBox2);
            Controls.Add(btnSiguiente);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnSiguiente;
        private TextBox textBox2;
        private RadioButton rbtEMAN;
        private RadioButton rbtEMEN;
    }
}
