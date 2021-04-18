namespace MiBanco
{
    partial class FrmCalculadoraPrestamoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadoraPrestamoo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdCalcular = new System.Windows.Forms.Button();
            this.NudCuotas = new System.Windows.Forms.NumericUpDown();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstCapitalRestante = new System.Windows.Forms.ListBox();
            this.LstCapitalPagado = new System.Windows.Forms.ListBox();
            this.LstMontoCuota = new System.Windows.Forms.ListBox();
            this.LstInteresCuota = new System.Windows.Forms.ListBox();
            this.LstCapitalCuota = new System.Windows.Forms.ListBox();
            this.LstNumCuota = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCuotas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CmdCalcular);
            this.panel1.Controls.Add(this.NudCuotas);
            this.panel1.Controls.Add(this.txtTasaInteres);
            this.panel1.Controls.Add(this.txtMontoPrestamo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 149);
            this.panel1.TabIndex = 0;
            // 
            // CmdCalcular
            // 
            this.CmdCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdCalcular.BackgroundImage")));
            this.CmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdCalcular.Location = new System.Drawing.Point(335, 16);
            this.CmdCalcular.Name = "CmdCalcular";
            this.CmdCalcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmdCalcular.Size = new System.Drawing.Size(112, 107);
            this.CmdCalcular.TabIndex = 7;
            this.CmdCalcular.UseVisualStyleBackColor = true;
            this.CmdCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // NudCuotas
            // 
            this.NudCuotas.Location = new System.Drawing.Point(142, 99);
            this.NudCuotas.Name = "NudCuotas";
            this.NudCuotas.Size = new System.Drawing.Size(134, 22);
            this.NudCuotas.TabIndex = 6;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(142, 58);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(134, 22);
            this.txtTasaInteres.TabIndex = 5;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(142, 15);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(134, 22);
            this.txtMontoPrestamo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "# Cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa Interes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto Prestamo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LstCapitalRestante);
            this.panel2.Controls.Add(this.LstCapitalPagado);
            this.panel2.Controls.Add(this.LstMontoCuota);
            this.panel2.Controls.Add(this.LstInteresCuota);
            this.panel2.Controls.Add(this.LstCapitalCuota);
            this.panel2.Controls.Add(this.LstNumCuota);
            this.panel2.Location = new System.Drawing.Point(25, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 312);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Capital Restante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Capital Pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Monto Cuota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Interes Cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capital Cuota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "No. Cuota";
            // 
            // LstCapitalRestante
            // 
            this.LstCapitalRestante.FormattingEnabled = true;
            this.LstCapitalRestante.ItemHeight = 16;
            this.LstCapitalRestante.Location = new System.Drawing.Point(636, 56);
            this.LstCapitalRestante.Name = "LstCapitalRestante";
            this.LstCapitalRestante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalRestante.Size = new System.Drawing.Size(115, 228);
            this.LstCapitalRestante.TabIndex = 5;
            // 
            // LstCapitalPagado
            // 
            this.LstCapitalPagado.FormattingEnabled = true;
            this.LstCapitalPagado.ItemHeight = 16;
            this.LstCapitalPagado.Location = new System.Drawing.Point(515, 56);
            this.LstCapitalPagado.Name = "LstCapitalPagado";
            this.LstCapitalPagado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalPagado.Size = new System.Drawing.Size(115, 228);
            this.LstCapitalPagado.TabIndex = 4;
            // 
            // LstMontoCuota
            // 
            this.LstMontoCuota.FormattingEnabled = true;
            this.LstMontoCuota.ItemHeight = 16;
            this.LstMontoCuota.Location = new System.Drawing.Point(394, 56);
            this.LstMontoCuota.Name = "LstMontoCuota";
            this.LstMontoCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstMontoCuota.Size = new System.Drawing.Size(115, 228);
            this.LstMontoCuota.TabIndex = 3;
            // 
            // LstInteresCuota
            // 
            this.LstInteresCuota.FormattingEnabled = true;
            this.LstInteresCuota.ItemHeight = 16;
            this.LstInteresCuota.Location = new System.Drawing.Point(273, 56);
            this.LstInteresCuota.Name = "LstInteresCuota";
            this.LstInteresCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstInteresCuota.Size = new System.Drawing.Size(115, 228);
            this.LstInteresCuota.TabIndex = 2;
            // 
            // LstCapitalCuota
            // 
            this.LstCapitalCuota.FormattingEnabled = true;
            this.LstCapitalCuota.ItemHeight = 16;
            this.LstCapitalCuota.Location = new System.Drawing.Point(152, 56);
            this.LstCapitalCuota.Name = "LstCapitalCuota";
            this.LstCapitalCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstCapitalCuota.Size = new System.Drawing.Size(115, 228);
            this.LstCapitalCuota.TabIndex = 1;
            // 
            // LstNumCuota
            // 
            this.LstNumCuota.FormattingEnabled = true;
            this.LstNumCuota.ItemHeight = 16;
            this.LstNumCuota.Location = new System.Drawing.Point(31, 56);
            this.LstNumCuota.Name = "LstNumCuota";
            this.LstNumCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LstNumCuota.Size = new System.Drawing.Size(115, 228);
            this.LstNumCuota.TabIndex = 0;
            // 
            // FrmCalculadoraPrestamoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculadoraPrestamoo";
            this.Text = "Calculadora de Prestamos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCuotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdCalcular;
        private System.Windows.Forms.NumericUpDown NudCuotas;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstCapitalRestante;
        private System.Windows.Forms.ListBox LstCapitalPagado;
        private System.Windows.Forms.ListBox LstMontoCuota;
        private System.Windows.Forms.ListBox LstInteresCuota;
        private System.Windows.Forms.ListBox LstCapitalCuota;
        private System.Windows.Forms.ListBox LstNumCuota;
    }
}

