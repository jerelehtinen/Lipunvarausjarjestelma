namespace TrainClient2.UserControls
{
    partial class scheduleUC
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.departureRadioB = new System.Windows.Forms.RadioButton();
            this.arrivalRadioB = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scheduleOkBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aikataulu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // departureRadioB
            // 
            this.departureRadioB.AutoSize = true;
            this.departureRadioB.Location = new System.Drawing.Point(81, 87);
            this.departureRadioB.Name = "departureRadioB";
            this.departureRadioB.Size = new System.Drawing.Size(91, 21);
            this.departureRadioB.TabIndex = 8;
            this.departureRadioB.TabStop = true;
            this.departureRadioB.Text = "Lähtöaika";
            this.departureRadioB.UseVisualStyleBackColor = true;
            // 
            // arrivalRadioB
            // 
            this.arrivalRadioB.AutoSize = true;
            this.arrivalRadioB.Location = new System.Drawing.Point(81, 114);
            this.arrivalRadioB.Name = "arrivalRadioB";
            this.arrivalRadioB.Size = new System.Drawing.Size(117, 21);
            this.arrivalRadioB.TabIndex = 9;
            this.arrivalRadioB.TabStop = true;
            this.arrivalRadioB.Text = "Saapumisaika";
            this.arrivalRadioB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "12:00";
            // 
            // scheduleOkBTN
            // 
            this.scheduleOkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleOkBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleOkBTN.Location = new System.Drawing.Point(81, 199);
            this.scheduleOkBTN.Name = "scheduleOkBTN";
            this.scheduleOkBTN.Size = new System.Drawing.Size(101, 35);
            this.scheduleOkBTN.TabIndex = 11;
            this.scheduleOkBTN.Text = "Valitse";
            this.scheduleOkBTN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 411);
            this.panel1.TabIndex = 12;
            // 
            // scheduleUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scheduleOkBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.arrivalRadioB);
            this.Controls.Add(this.departureRadioB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "scheduleUC";
            this.Size = new System.Drawing.Size(385, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton departureRadioB;
        private System.Windows.Forms.RadioButton arrivalRadioB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button scheduleOkBTN;
        private System.Windows.Forms.Panel panel1;
    }
}
