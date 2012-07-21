namespace ServerConfigDialog
{
	partial class FormConfig
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器地址:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "用户名:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(107, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "密码:";
			// 
			// tbServer
			// 
			this.tbServer.Location = new System.Drawing.Point(158, 72);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(189, 21);
			this.tbServer.TabIndex = 0;
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(158, 119);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(189, 21);
			this.tbUser.TabIndex = 1;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(158, 164);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(189, 21);
			this.tbPassword.TabIndex = 2;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(103, 278);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "确定";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(272, 278);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// FormConfig
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(422, 324);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "配置";
			this.Load += new System.EventHandler(this.FormConfig_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btnCancel;
	}
}