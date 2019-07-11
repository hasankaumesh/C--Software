namespace task1
{
    partial class Signup
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
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblCpw = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtCpw = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(247, 63);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(60, 13);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "User Name";
            this.lblUname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(247, 89);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(46, 13);
            this.lblPos.TabIndex = 1;
            this.lblPos.Text = "Posision";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(247, 115);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(53, 13);
            this.lblPw.TabIndex = 2;
            this.lblPw.Text = "Password";
            // 
            // lblCpw
            // 
            this.lblCpw.AutoSize = true;
            this.lblCpw.Location = new System.Drawing.Point(247, 141);
            this.lblCpw.Name = "lblCpw";
            this.lblCpw.Size = new System.Drawing.Size(91, 13);
            this.lblCpw.TabIndex = 3;
            this.lblCpw.Text = "Confirm Password";
            this.lblCpw.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(350, 82);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(100, 20);
            this.txtPos.TabIndex = 5;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(350, 108);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 20);
            this.txtPw.TabIndex = 6;
            // 
            // txtCpw
            // 
            this.txtCpw.Location = new System.Drawing.Point(350, 134);
            this.txtCpw.Name = "txtCpw";
            this.txtCpw.Size = new System.Drawing.Size(100, 20);
            this.txtCpw.TabIndex = 7;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(375, 172);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.BtnSignup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.MainToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(250, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCpw);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCpw);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Signup";
            this.Text = "Signup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Label lblCpw;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtCpw;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
    }
}