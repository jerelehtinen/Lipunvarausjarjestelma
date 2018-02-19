using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace TrainClient
{
    public class RegisterPanel : Form
    {
    
        public RegisterPanel()
    {
        InitializeComponent();
    }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            //Piilotetaan rekisteröitymispaneeli
            Program.openedRegisterPanel.Visible = false;
            //...ja tuodaan kirjautumispaneeli takaisin näkyviin
            Program.openedBasePanel.Visible = true;

            Program.openedRegisterPanel.Close();
        }



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
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.registerBtn = new System.Windows.Forms.Button();
        this.nameTB = new System.Windows.Forms.TextBox();
        this.usernameTB = new System.Windows.Forms.TextBox();
        this.pw1TB = new System.Windows.Forms.TextBox();
        this.pw2TB = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(150, 137);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(39, 17);
        this.label1.TabIndex = 0;
        this.label1.Text = "Nimi:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(83, 171);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(106, 17);
        this.label2.TabIndex = 1;
        this.label2.Text = "Käyttäjätunnus:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(118, 208);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(71, 17);
        this.label3.TabIndex = 2;
        this.label3.Text = "Salasana:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(52, 240);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(137, 17);
        this.label4.TabIndex = 3;
        this.label4.Text = "Salasana uudelleen:";
        // 
        // registerBtn
        // 
        this.registerBtn.Location = new System.Drawing.Point(278, 327);
        this.registerBtn.Name = "registerBtn";
        this.registerBtn.Size = new System.Drawing.Size(114, 32);
        this.registerBtn.TabIndex = 4;
        this.registerBtn.Text = "Rekisteröidy";
        this.registerBtn.UseVisualStyleBackColor = true;
        this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(225, 134);
        this.nameTB.Name = "textBox1";
        this.nameTB.Size = new System.Drawing.Size(208, 22);
        this.nameTB.TabIndex = 5;
        // 
        // usernameTB
        //
        this.usernameTB.Location = new System.Drawing.Point(225, 168);
        this.usernameTB.Name = "textBox2";
        this.usernameTB.Size = new System.Drawing.Size(208, 22);
        this.usernameTB.TabIndex = 6;
        // 
        // pw1TB
        // 
        this.pw1TB.Location = new System.Drawing.Point(225, 203);
        this.pw1TB.Name = "textBox3";
        this.pw1TB.Size = new System.Drawing.Size(208, 22);
        this.pw1TB.TabIndex = 7;
        this.pw1TB.PasswordChar = '*';
        // 
        // pw2TB
        // 
        this.pw2TB.Location = new System.Drawing.Point(225, 235);
        this.pw2TB.Name = "textBox4";
        this.pw2TB.Size = new System.Drawing.Size(208, 22);
        this.pw2TB.TabIndex = 8;
        this.pw2TB.PasswordChar = '*';
        // 
        // RegisterPanel
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(564, 394);
        this.Controls.Add(this.pw2TB);
        this.Controls.Add(this.pw1TB);
        this.Controls.Add(this.usernameTB);
        this.Controls.Add(this.nameTB);
        this.Controls.Add(this.registerBtn);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "RegisterPanel";
        this.Text = "Rekisteröidy käyttäjäksi";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button registerBtn;
    private System.Windows.Forms.TextBox nameTB;
    private System.Windows.Forms.TextBox usernameTB;
    private System.Windows.Forms.TextBox pw1TB;
    private System.Windows.Forms.TextBox pw2TB;
}
}
