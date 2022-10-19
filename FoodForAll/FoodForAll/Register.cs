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
	public partial class Register : Form
	{
		Login CreatedFromLoginForm;

		public Register(Login createdFromLoginForm)
		{
			InitializeComponent();
			CreatedFromLoginForm = createdFromLoginForm;
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			//TODO
			this.Close();
		}

		private void Register_FormClosed(object sender, FormClosedEventArgs e)
		{
			CreatedFromLoginForm.Show();
		}
	}
}
