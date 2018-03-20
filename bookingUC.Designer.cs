namespace TrainClient2.UserControls
{
    partial class bookingUC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.passengerBTN = new System.Windows.Forms.Button();
            this.scheduleBTN = new System.Windows.Forms.Button();
            this.routeBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            bookingUC.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.routeUC1 = new TrainClient2.UserControls.routeUC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            bookingUC.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.confirmBTN);
            this.panel1.Controls.Add(this.passengerBTN);
            this.panel1.Controls.Add(this.scheduleBTN);
            this.panel1.Controls.Add(this.routeBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 412);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 75);
            this.SidePanel.TabIndex = 0;
            // 
            // confirmBTN
            // 
            this.confirmBTN.FlatAppearance.BorderSize = 0;
            this.confirmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBTN.ForeColor = System.Drawing.Color.White;
            this.confirmBTN.Location = new System.Drawing.Point(20, 225);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(124, 75);
            this.confirmBTN.TabIndex = 3;
            this.confirmBTN.Text = "Vahvista";
            this.confirmBTN.UseVisualStyleBackColor = true;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // passengerBTN
            // 
            this.passengerBTN.FlatAppearance.BorderSize = 0;
            this.passengerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passengerBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerBTN.ForeColor = System.Drawing.Color.White;
            this.passengerBTN.Location = new System.Drawing.Point(20, 75);
            this.passengerBTN.Name = "passengerBTN";
            this.passengerBTN.Size = new System.Drawing.Size(124, 75);
            this.passengerBTN.TabIndex = 2;
            this.passengerBTN.Text = "Matkustajat";
            this.passengerBTN.UseVisualStyleBackColor = true;
            this.passengerBTN.Click += new System.EventHandler(this.passengerBTN_Click);
            // 
            // scheduleBTN
            // 
            this.scheduleBTN.FlatAppearance.BorderSize = 0;
            this.scheduleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBTN.ForeColor = System.Drawing.Color.White;
            this.scheduleBTN.Location = new System.Drawing.Point(20, 150);
            this.scheduleBTN.Name = "scheduleBTN";
            this.scheduleBTN.Size = new System.Drawing.Size(124, 75);
            this.scheduleBTN.TabIndex = 1;
            this.scheduleBTN.Text = "Aikataulu";
            this.scheduleBTN.UseVisualStyleBackColor = true;
            this.scheduleBTN.Click += new System.EventHandler(this.scheduleBTN_Click);
            // 
            // routeBTN
            // 
            this.routeBTN.FlatAppearance.BorderSize = 0;
            this.routeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeBTN.ForeColor = System.Drawing.Color.White;
            this.routeBTN.Location = new System.Drawing.Point(20, 0);
            this.routeBTN.Name = "routeBTN";
            this.routeBTN.Size = new System.Drawing.Size(124, 75);
            this.routeBTN.TabIndex = 0;
            this.routeBTN.Text = "Reitti";
            this.routeBTN.UseVisualStyleBackColor = true;
            this.routeBTN.Click += new System.EventHandler(this.routeBTN_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            bookingUC.panel3.Controls.Add(this.routeUC1);
            bookingUC.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            bookingUC.panel3.Location = new System.Drawing.Point(144, 1);
            bookingUC.panel3.Name = "panel3";
            bookingUC.panel3.Size = new System.Drawing.Size(385, 411);
            bookingUC.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(529, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 411);
            this.panel4.TabIndex = 3;
            // 
            // routeUC1
            // 
            this.routeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routeUC1.Location = new System.Drawing.Point(0, 0);
            this.routeUC1.Name = "routeUC1";
            this.routeUC1.Size = new System.Drawing.Size(385, 411);
            this.routeUC1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matkan tiedot";
            // 
            // bookingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(bookingUC.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "bookingUC";
            this.Size = new System.Drawing.Size(1140, 412);
            this.panel1.ResumeLayout(false);
            bookingUC.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Button passengerBTN;
        private System.Windows.Forms.Button scheduleBTN;
        private System.Windows.Forms.Button routeBTN;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private static System.Windows.Forms.Panel panel3;
        private routeUC routeUC1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}
