using System.Windows.Forms;

namespace TrainClient2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.startUC1 = new TrainClient2.UserControls.startUC();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.upPanel.Controls.Add(this.pictureBox2);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(1140, 42);
            this.upPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1090, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 549);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1140, 76);
            this.bottomPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 95);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Junaliput";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.startUC1);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatePanel.Location = new System.Drawing.Point(0, 137);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(1140, 412);
            this.updatePanel.TabIndex = 3;
            // 
            // startUC1
            // 
            this.startUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUC1.Location = new System.Drawing.Point(0, 0);
            this.startUC1.Name = "startUC1";
            this.startUC1.Size = new System.Drawing.Size(1140, 412);
            this.startUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.upPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.upPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private Panel updatePanel;
        private UserControls.startUC startUC1;
    }
}

