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
            this.arriveCB = new System.Windows.Forms.ComboBox();
            this.passengerNoCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startCB
            // 
            this.startCB.FormattingEnabled = true;
            this.startCB.Location = new System.Drawing.Point(81, 66);
            this.startCB.Name = "startCB";
            this.startCB.Size = new System.Drawing.Size(200, 24);
            this.startCB.TabIndex = 0;
            this.startCB.SelectedIndexChanged += new System.EventHandler(this.startCB_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 411);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mistä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minne";
            // 
            // arriveCB
            // 
            this.arriveCB.FormattingEnabled = true;
            this.arriveCB.Location = new System.Drawing.Point(81, 148);
            this.arriveCB.Name = "arriveCB";
            this.arriveCB.Size = new System.Drawing.Size(200, 24);
            this.arriveCB.TabIndex = 5;
            this.arriveCB.SelectedIndexChanged += new System.EventHandler(this.arriveCB_SelectedIndexChanged);
            // 
            // passengerNoCB
            // 
            this.passengerNoCB.FormattingEnabled = true;
            this.passengerNoCB.Location = new System.Drawing.Point(81, 231);
            this.passengerNoCB.Name = "passengerNoCB";
            this.passengerNoCB.Size = new System.Drawing.Size(98, 24);
            this.passengerNoCB.TabIndex = 17;
            this.passengerNoCB.SelectedIndexChanged += new System.EventHandler(this.passengerNoCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Matkustajat";
            // 
            // routeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.passengerNoCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arriveCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startCB);
            this.Name = "routeUC";
            this.Size = new System.Drawing.Size(385, 411);
            this.Load += new System.EventHandler(this.routeUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox arriveCB;
        private System.Windows.Forms.ComboBox passengerNoCB;
        private System.Windows.Forms.Label label3;
    }
}
