namespace Lab3Net6.ClientWinForms;

partial class LoginForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.mainButton = new System.Windows.Forms.Button();
			this.isRegisteredLabel = new System.Windows.Forms.Label();
			this.mainLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.usernameTextBox.Location = new System.Drawing.Point(121, 132);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(125, 38);
			this.usernameTextBox.TabIndex = 0;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordTextBox.Location = new System.Drawing.Point(121, 176);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(125, 38);
			this.passwordTextBox.TabIndex = 1;
			// 
			// mainButton
			// 
			this.mainButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mainButton.Location = new System.Drawing.Point(121, 220);
			this.mainButton.Name = "mainButton";
			this.mainButton.Size = new System.Drawing.Size(125, 49);
			this.mainButton.TabIndex = 2;
			this.mainButton.Text = "Войти";
			this.mainButton.UseVisualStyleBackColor = true;
			this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
			// 
			// isRegisteredLabel
			// 
			this.isRegisteredLabel.AutoSize = true;
			this.isRegisteredLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.isRegisteredLabel.Location = new System.Drawing.Point(110, 288);
			this.isRegisteredLabel.Name = "isRegisteredLabel";
			this.isRegisteredLabel.Size = new System.Drawing.Size(151, 20);
			this.isRegisteredLabel.TabIndex = 3;
			this.isRegisteredLabel.Text = "Зарегистрироваться";
			this.isRegisteredLabel.Click += new System.EventHandler(this.isRegisteredLabel_Click);
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mainLabel.Location = new System.Drawing.Point(145, 71);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(83, 41);
			this.mainLabel.TabIndex = 4;
			this.mainLabel.Text = "Вход";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 450);
			this.Controls.Add(this.mainLabel);
			this.Controls.Add(this.isRegisteredLabel);
			this.Controls.Add(this.mainButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Name = "LoginForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private TextBox usernameTextBox;
	private TextBox passwordTextBox;
	private Button mainButton;
	private Label isRegisteredLabel;
	private Label mainLabel;
}
