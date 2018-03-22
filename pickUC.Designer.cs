namespace TrainClient2.UserControls
{
    partial class pickUC
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pickOkBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valitse matka ja paikat";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // pickOkBTN
            // 
            this.pickOkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickOkBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickOkBTN.Location = new System.Drawing.Point(51, 150);
            this.pickOkBTN.Name = "pickOkBTN";
            this.pickOkBTN.Size = new System.Drawing.Size(101, 35);
            this.pickOkBTN.TabIndex = 16;
            this.pickOkBTN.Text = "Valitse";
            this.pickOkBTN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 411);
            this.panel1.TabIndex = 17;
            // 
            // pickUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pickOkBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "pickUC";
            this.Size = new System.Drawing.Size(385, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button pickOkBTN;
        private System.Windows.Forms.Panel panel1;
    }
}
