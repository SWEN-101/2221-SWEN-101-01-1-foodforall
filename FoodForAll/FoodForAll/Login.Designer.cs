namespace FoodForAll
{
	partial class Login
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
			this.LogoText = new System.Windows.Forms.Label();
			this.RegisterText = new System.Windows.Forms.Label();
			this.UsernameText = new System.Windows.Forms.Label();
			this.UsernameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordBox = new System.Windows.Forms.TextBox();
			this.DontHaveAccountText = new System.Windows.Forms.Label();
			this.RegisterLink = new System.Windows.Forms.LinkLabel();
			this.SignInButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LogoText
			// 
			this.LogoText.AutoSize = true;
			this.LogoText.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogoText.ForeColor = System.Drawing.Color.DarkOrange;
			this.LogoText.Location = new System.Drawing.Point(12, 9);
			this.LogoText.Name = "LogoText";
			this.LogoText.Size = new System.Drawing.Size(221, 49);
			this.LogoText.TabIndex = 0;
			this.LogoText.Text = "Food For All";
			// 
			// RegisterText
			// 
			this.RegisterText.AutoSize = true;
			this.RegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterText.ForeColor = System.Drawing.SystemColors.Control;
			this.RegisterText.Location = new System.Drawing.Point(247, 107);
			this.RegisterText.Name = "RegisterText";
			this.RegisterText.Size = new System.Drawing.Size(254, 20);
			this.RegisterText.TabIndex = 1;
			this.RegisterText.Text = "Sign in as a Producer or Consumer";
			// 
			// UsernameText
			// 
			this.UsernameText.AutoSize = true;
			this.UsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameText.ForeColor = System.Drawing.SystemColors.Control;
			this.UsernameText.Location = new System.Drawing.Point(216, 157);
			this.UsernameText.Name = "UsernameText";
			this.UsernameText.Size = new System.Drawing.Size(102, 24);
			this.UsernameText.TabIndex = 2;
			this.UsernameText.Text = "Username:";
			// 
			// UsernameBox
			// 
			this.UsernameBox.Location = new System.Drawing.Point(324, 161);
			this.UsernameBox.Name = "UsernameBox";
			this.UsernameBox.Size = new System.Drawing.Size(211, 20);
			this.UsernameBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(216, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Password:";
			// 
			// PasswordBox
			// 
			this.PasswordBox.Location = new System.Drawing.Point(324, 200);
			this.PasswordBox.Name = "PasswordBox";
			this.PasswordBox.Size = new System.Drawing.Size(211, 20);
			this.PasswordBox.TabIndex = 5;
			this.PasswordBox.UseSystemPasswordChar = true;
			// 
			// DontHaveAccountText
			// 
			this.DontHaveAccountText.AutoSize = true;
			this.DontHaveAccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DontHaveAccountText.ForeColor = System.Drawing.SystemColors.Control;
			this.DontHaveAccountText.Location = new System.Drawing.Point(175, 263);
			this.DontHaveAccountText.Name = "DontHaveAccountText";
			this.DontHaveAccountText.Size = new System.Drawing.Size(177, 20);
			this.DontHaveAccountText.TabIndex = 6;
			this.DontHaveAccountText.Text = "Don\'t have an account?";
			// 
			// RegisterLink
			// 
			this.RegisterLink.AutoSize = true;
			this.RegisterLink.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RegisterLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.RegisterLink.LinkColor = System.Drawing.Color.DarkTurquoise;
			this.RegisterLink.Location = new System.Drawing.Point(358, 260);
			this.RegisterLink.Name = "RegisterLink";
			this.RegisterLink.Size = new System.Drawing.Size(79, 24);
			this.RegisterLink.TabIndex = 7;
			this.RegisterLink.TabStop = true;
			this.RegisterLink.Text = "Register";
			this.RegisterLink.VisitedLinkColor = System.Drawing.Color.DarkTurquoise;
			this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
			// 
			// SignInButton
			// 
			this.SignInButton.BackColor = System.Drawing.Color.DodgerBlue;
			this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SignInButton.Location = new System.Drawing.Point(473, 252);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(95, 39);
			this.SignInButton.TabIndex = 8;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.UseVisualStyleBackColor = false;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.SignInButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(784, 451);
			this.Controls.Add(this.SignInButton);
			this.Controls.Add(this.RegisterLink);
			this.Controls.Add(this.DontHaveAccountText);
			this.Controls.Add(this.PasswordBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UsernameBox);
			this.Controls.Add(this.UsernameText);
			this.Controls.Add(this.RegisterText);
			this.Controls.Add(this.LogoText);
			this.MaximumSize = new System.Drawing.Size(800, 490);
			this.MinimumSize = new System.Drawing.Size(800, 490);
			this.Name = "Login";
			this.Text = "FoodForAll Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LogoText;
		private System.Windows.Forms.Label RegisterText;
		private System.Windows.Forms.Label UsernameText;
		private System.Windows.Forms.TextBox UsernameBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PasswordBox;
		private System.Windows.Forms.Label DontHaveAccountText;
		private System.Windows.Forms.LinkLabel RegisterLink;
		private System.Windows.Forms.Button SignInButton;
	}
}

