namespace KartyaJatek
{
    partial class UserControl_Jatekos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_lapok = new System.Windows.Forms.RichTextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_lapok, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_username, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_user, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox_lapok
            // 
            this.richTextBox_lapok.Location = new System.Drawing.Point(3, 95);
            this.richTextBox_lapok.Name = "richTextBox_lapok";
            this.richTextBox_lapok.Size = new System.Drawing.Size(90, 249);
            this.richTextBox_lapok.TabIndex = 1;
            this.richTextBox_lapok.Text = "";
            // 
            // label_username
            // 
            this.label_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(25, 75);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(45, 15);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Jatekos";
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_user.Image = global::KartyaJatek.Properties.Resources.tuktukdesign170500019;
            this.pictureBox_user.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(90, 67);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 2;
            this.pictureBox_user.TabStop = false;
            // 
            // UserControl_Jatekos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl_Jatekos";
            this.Size = new System.Drawing.Size(124, 409);
            this.Load += new System.EventHandler(this.UserControl_Jatekos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox richTextBox_lapok;
        private Label label_username;
        private PictureBox pictureBox_user;
    }
}
