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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			m_iniFile = new YXL.IniFile(Application.StartupPath + "\\config.ini");
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnConfig_Click(object sender, EventArgs e)
		{
			FormConfig frm = new FormConfig();
			string server = m_iniFile.ReadValue(SECTION_NAME, "Server", "(localhost)");
			string user = m_iniFile.ReadValue(SECTION_NAME, "User", "sa");
			string password = m_iniFile.ReadValue(SECTION_NAME, "Password", "123");
			frm.Server = server;
			frm.User = user;
			frm.Password = password;
			if (frm.ShowDialog() == DialogResult.OK)
			{
				server = frm.Server;
				user = frm.User;
				password = frm.Password;
				m_iniFile.WriteValue(SECTION_NAME, "Server", server);
				m_iniFile.WriteValue(SECTION_NAME, "User", user);
				m_iniFile.WriteValue(SECTION_NAME, "Password", password);
			}
		}

		private YXL.IniFile m_iniFile;
		private const string SECTION_NAME = "ServerConfig"; 
	}
}
