namespace miDolar
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
            groupBox1 = new GroupBox();
            cbDolar = new ComboBox();
            tbMonto = new TextBox();
            lbPrec = new ListBox();
            label1 = new Label();
            btConvert = new Button();
            label2 = new Label();
            rbEstado = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDolar);
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(lbPrec);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btConvert);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cotiza a pesos";
            // 
            // cbDolar
            // 
            cbDolar.FormattingEnabled = true;
            cbDolar.Items.AddRange(new object[] { "Dolar Blue", "Dolar Bolsa", "Dolar Tarjeta" });
            cbDolar.Location = new Point(16, 102);
            cbDolar.Name = "cbDolar";
            cbDolar.Size = new Size(158, 23);
            cbDolar.TabIndex = 5;
            cbDolar.SelectedIndexChanged += cbDolar_SelectedIndexChanged;
            // 
            // tbMonto
            // 
            tbMonto.Enabled = false;
            tbMonto.Location = new Point(16, 61);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(158, 23);
            tbMonto.TabIndex = 2;
            // 
            // lbPrec
            // 
            lbPrec.FormattingEnabled = true;
            lbPrec.ItemHeight = 15;
            lbPrec.Location = new Point(273, 22);
            lbPrec.Name = "lbPrec";
            lbPrec.Size = new Size(202, 199);
            lbPrec.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresa el monto a convertir:";
            // 
            // btConvert
            // 
            btConvert.Location = new Point(16, 131);
            btConvert.Name = "btConvert";
            btConvert.Size = new Size(158, 52);
            btConvert.TabIndex = 0;
            btConvert.Text = "Convertir";
            btConvert.UseVisualStyleBackColor = true;
            btConvert.Click += btConvert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 261);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Estado:";
            // 
            // rbEstado
            // 
            rbEstado.AutoSize = true;
            rbEstado.BackColor = SystemColors.Control;
            rbEstado.FlatAppearance.CheckedBackColor = Color.Lime;
            rbEstado.Location = new Point(85, 262);
            rbEstado.Name = "rbEstado";
            rbEstado.Size = new Size(14, 13);
            rbEstado.TabIndex = 3;
            rbEstado.TabStop = true;
            rbEstado.UseVisualStyleBackColor = false;
            rbEstado.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 315);
            Controls.Add(groupBox1);
            Controls.Add(rbEstado);
            Controls.Add(label2);
            Name = "Form1";
            Text = "DolarizaTE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btConvert;
        public TextBox tbMonto;
        private RadioButton rbEstado;
        private Label label2;
        public ListBox lbPrec;
        public ComboBox cbDolar;
    }
}
