namespace KartyaJatek
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownJatekosok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLapok = new System.Windows.Forms.NumericUpDown();
            this.buttonOsztas = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_jatekosok = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJatekosok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLapok)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.54067F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.45933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownJatekosok, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownLapok, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOsztas, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(571, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lapok száma / fő";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jatekosok szama";
            // 
            // numericUpDownJatekosok
            // 
            this.numericUpDownJatekosok.Location = new System.Drawing.Point(107, 3);
            this.numericUpDownJatekosok.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownJatekosok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJatekosok.Name = "numericUpDownJatekosok";
            this.numericUpDownJatekosok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownJatekosok.TabIndex = 2;
            this.numericUpDownJatekosok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLapok
            // 
            this.numericUpDownLapok.Location = new System.Drawing.Point(353, 3);
            this.numericUpDownLapok.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDownLapok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLapok.Name = "numericUpDownLapok";
            this.numericUpDownLapok.Size = new System.Drawing.Size(102, 23);
            this.numericUpDownLapok.TabIndex = 0;
            this.numericUpDownLapok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOsztas
            // 
            this.buttonOsztas.Location = new System.Drawing.Point(461, 3);
            this.buttonOsztas.Name = "buttonOsztas";
            this.buttonOsztas.Size = new System.Drawing.Size(75, 23);
            this.buttonOsztas.TabIndex = 3;
            this.buttonOsztas.Text = "Osztas";
            this.buttonOsztas.UseVisualStyleBackColor = true;
            this.buttonOsztas.Click += new System.EventHandler(this.buttonOsztas_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel_jatekosok, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(571, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel_jatekosok
            // 
            this.flowLayoutPanel_jatekosok.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_jatekosok.Name = "flowLayoutPanel_jatekosok";
            this.flowLayoutPanel_jatekosok.Size = new System.Drawing.Size(565, 354);
            this.flowLayoutPanel_jatekosok.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJatekosok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLapok)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownJatekosok;
        private NumericUpDown numericUpDownLapok;
        private Button buttonOsztas;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel_jatekosok;
    }
}