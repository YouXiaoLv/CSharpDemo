namespace ServerConfigDialog
{
	partial class FormMain
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
			this.btnConfig = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConfig
			// 
			this.btnConfig.Location = new System.Drawing.Point(85, 70);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(129, 49);
			this.btnConfig.TabIndex = 0;
			this.btnConfig.Text = "配置";
			this.btnConfig.UseVisualStyleBackColor = true;
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnConfig);
			this.Name = "FormMain";
			this.Text = "主界面";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConfig;
	}
}

