using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerConfigDialog
{
	public partial class FormConfig : Form
	{
		public FormConfig()
		{
			InitializeComponent();
		}

		private void FormConfig_Load(object sender, EventArgs e)
		{
			tbServer.Text = m_server;
			tbUser.Text = m_user;
			tbPassword.Text = m_password;
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			m_server = tbServer.Text.Trim();
			m_user = tbUser.Text.Trim();
			m_password = tbPassword.Text.Trim();
			DialogResult = DialogResult.OK;
		}

		private string m_server;

		public string Server
		{
			get { return m_server; }
			set { m_server = value; }
		}

		private string m_user;

		public string User
		{
			get { return m_user; }
			set { m_user = value; }
		}

		private string m_password;

		public string Password
		{
			get { return m_password; }
			set { m_password = value; }
		}
	}
}
