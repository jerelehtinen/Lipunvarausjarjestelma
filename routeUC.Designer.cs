namespace TrainClient2.UserControls
{
    partial class routeUC
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
            this.startCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.arriveCB = new System.Windows.Forms.ComboBox();
            this.arriveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startCB
            // 
            this.startCB.FormattingEnabled = true;
            this.startCB.Location = new System.Drawing.Point(81, 90);
            this.startCB.Name = "startCB";
            this.startCB.Size = new System.Drawing.Size(200, 24);
            this.startCB.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 385);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mistä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minne";
            // 
            // startBTN
            // 
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(180, 120);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(101, 35);
            this.startBTN.TabIndex = 4;
            this.startBTN.Text = "Valitse";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // arriveCB
            // 
            this.arriveCB.FormattingEnabled = true;
            this.arriveCB.Location = new System.Drawing.Point(81, 215);
            this.arriveCB.Name = "arriveCB";
            this.arriveCB.Size = new System.Drawing.Size(200, 24);
            this.arriveCB.TabIndex = 5;
            // 
            // arriveBTN
            // 
            this.arriveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arriveBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveBTN.Location = new System.Drawing.Point(180, 245);
            this.arriveBTN.Name = "arriveBTN";
            this.arriveBTN.Size = new System.Drawing.Size(101, 35);
            this.arriveBTN.TabIndex = 6;
            this.arriveBTN.Text = "Valitse";
            this.arriveBTN.UseVisualStyleBackColor = true;
            // 
            // routeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.arriveBTN);
            this.Controls.Add(this.arriveCB);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startCB);
            this.Name = "routeUC";
            this.Size = new System.Drawing.Size(385, 385);
            this.Load += new System.EventHandler(this.routeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.ComboBox arriveCB;
        private System.Windows.Forms.Button arriveBTN;
    }
}
