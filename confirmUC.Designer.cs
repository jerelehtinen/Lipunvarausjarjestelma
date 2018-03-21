namespace TrainClient2.UserControls
{
    partial class confirmUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bookingOkBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hyväksy matka";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(81, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 189);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Matka maksetaan junassa\nmaksukortilla tai käteisellä. \n\nKlikkaamalla vahvista,\nma" +
    "tka varataan ja saat \nvarausvahvistuksen sähköpostiisi.";
            // 
            // bookingOkBTN
            // 
            this.bookingOkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingOkBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingOkBTN.Location = new System.Drawing.Point(81, 261);
            this.bookingOkBTN.Name = "bookingOkBTN";
            this.bookingOkBTN.Size = new System.Drawing.Size(101, 35);
            this.bookingOkBTN.TabIndex = 17;
            this.bookingOkBTN.Text = "Vahvista";
            this.bookingOkBTN.UseVisualStyleBackColor = true;
            // 
            // confirmUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingOkBTN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "confirmUC";
            this.Size = new System.Drawing.Size(385, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bookingOkBTN;
    }
}
