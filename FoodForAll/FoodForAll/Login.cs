using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodForAll
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Register new_register_window = new Register(this);
			new_register_window.Show();
			this.Hide();
		}

		private void SignInButton_Click(object sender, EventArgs e)
		{
			//TODO
		}
	}
}
