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
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pickBTN = new System.Windows.Forms.Button();
            this.scheduleBTN = new System.Windows.Forms.Button();
            this.routeBTN = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.priceLBL = new System.Windows.Forms.Label();
            this.arrivalTimeLBL = new System.Windows.Forms.Label();
            this.departureTimeLBL = new System.Windows.Forms.Label();
            this.passengerNoLBL = new System.Windows.Forms.Label();
            this.arriveLBL = new System.Windows.Forms.Label();
            this.departureLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.routeUC1 = new TrainClient2.UserControls.routeUC();
            this.logOutBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.confirmBTN);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.pickBTN);
            this.panel1.Controls.Add(this.scheduleBTN);
            this.panel1.Controls.Add(this.routeBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 412);
            this.panel1.TabIndex = 0;
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
            this.confirmBTN.TabIndex = 4;
            this.confirmBTN.Text = "Vahvista";
            this.confirmBTN.UseVisualStyleBackColor = true;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 75);
            this.SidePanel.TabIndex = 0;
            // 
            // pickBTN
            // 
            this.pickBTN.FlatAppearance.BorderSize = 0;
            this.pickBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickBTN.ForeColor = System.Drawing.Color.White;
            this.pickBTN.Location = new System.Drawing.Point(20, 150);
            this.pickBTN.Name = "pickBTN";
            this.pickBTN.Size = new System.Drawing.Size(124, 75);
            this.pickBTN.TabIndex = 3;
            this.pickBTN.Text = "Matka ja paikat";
            this.pickBTN.UseVisualStyleBackColor = true;
            this.pickBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // scheduleBTN
            // 
            this.scheduleBTN.FlatAppearance.BorderSize = 0;
            this.scheduleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBTN.ForeColor = System.Drawing.Color.White;
            this.scheduleBTN.Location = new System.Drawing.Point(20, 75);
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
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(144, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(996, 1);
            this.upPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.routeUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(144, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 411);
            this.panel2.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.logOutBTN);
            this.infoPanel.Controls.Add(this.priceLBL);
            this.infoPanel.Controls.Add(this.arrivalTimeLBL);
            this.infoPanel.Controls.Add(this.departureTimeLBL);
            this.infoPanel.Controls.Add(this.passengerNoLBL);
            this.infoPanel.Controls.Add(this.arriveLBL);
            this.infoPanel.Controls.Add(this.departureLBL);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(529, 1);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(611, 411);
            this.infoPanel.TabIndex = 3;
            // 
            // priceLBL
            // 
            this.priceLBL.AutoSize = true;
            this.priceLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLBL.Location = new System.Drawing.Point(7, 338);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(149, 23);
            this.priceLBL.TabIndex = 6;
            this.priceLBL.Text = "Matkan hinta: ";
            // 
            // arrivalTimeLBL
            // 
            this.arrivalTimeLBL.AutoSize = true;
            this.arrivalTimeLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTimeLBL.Location = new System.Drawing.Point(7, 246);
            this.arrivalTimeLBL.Name = "arrivalTimeLBL";
            this.arrivalTimeLBL.Size = new System.Drawing.Size(156, 23);
            this.arrivalTimeLBL.TabIndex = 5;
            this.arrivalTimeLBL.Text = "Saapumisaika: ";
            // 
            // departureTimeLBL
            // 
            this.departureTimeLBL.AutoSize = true;
            this.departureTimeLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTimeLBL.Location = new System.Drawing.Point(7, 203);
            this.departureTimeLBL.Name = "departureTimeLBL";
            this.departureTimeLBL.Size = new System.Drawing.Size(117, 23);
            this.departureTimeLBL.TabIndex = 4;
            this.departureTimeLBL.Text = "Lähtöaika: ";
            // 
            // passengerNoLBL
            // 
            this.passengerNoLBL.AutoSize = true;
            this.passengerNoLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerNoLBL.Location = new System.Drawing.Point(7, 160);
            this.passengerNoLBL.Name = "passengerNoLBL";
            this.passengerNoLBL.Size = new System.Drawing.Size(253, 23);
            this.passengerNoLBL.TabIndex = 3;
            this.passengerNoLBL.Text = "Matkustajien lukumäärä: ";
            // 
            // arriveLBL
            // 
            this.arriveLBL.AutoSize = true;
            this.arriveLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveLBL.Location = new System.Drawing.Point(7, 117);
            this.arriveLBL.Name = "arriveLBL";
            this.arriveLBL.Size = new System.Drawing.Size(149, 23);
            this.arriveLBL.TabIndex = 2;
            this.arriveLBL.Text = "Pääteasema: ";
            // 
            // departureLBL
            // 
            this.departureLBL.AutoSize = true;
            this.departureLBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLBL.Location = new System.Drawing.Point(7, 74);
            this.departureLBL.Name = "departureLBL";
            this.departureLBL.Size = new System.Drawing.Size(144, 23);
            this.departureLBL.TabIndex = 1;
            this.departureLBL.Text = "Lähtöasema: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkan tiedot";
            // 
            // routeUC1
            // 
            this.routeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routeUC1.Location = new System.Drawing.Point(0, 0);
            this.routeUC1.Name = "routeUC1";
            this.routeUC1.Size = new System.Drawing.Size(385, 411);
            this.routeUC1.TabIndex = 0;
            // 
            // logOutBTN
            // 
            this.logOutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBTN.Location = new System.Drawing.Point(460, 364);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(137, 35);
            this.logOutBTN.TabIndex = 7;
            this.logOutBTN.Text = "Kirjaudu ulos";
            this.logOutBTN.UseVisualStyleBackColor = true;
            // 
            // bookingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.panel1);
            this.Name = "bookingUC";
            this.Size = new System.Drawing.Size(1140, 412);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pickBTN;
        private System.Windows.Forms.Button scheduleBTN;
        private System.Windows.Forms.Button routeBTN;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label priceLBL;
        private System.Windows.Forms.Label arrivalTimeLBL;
        private System.Windows.Forms.Label departureTimeLBL;
        private System.Windows.Forms.Label passengerNoLBL;
        private System.Windows.Forms.Label arriveLBL;
        private System.Windows.Forms.Label departureLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBTN;
        private routeUC routeUC1;
        private System.Windows.Forms.Button logOutBTN;
    }
}
