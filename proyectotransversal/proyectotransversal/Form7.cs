/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 05:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form7.
	/// </summary>
	public partial class Form7 : Form
	{
		public Form7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.WindowState =FormWindowState.Maximized;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Form6 Form6 = new Form6();
			Form6.Show();
			this.Hide();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int cantidadLitrosA = Convert.ToInt32(txtLitrosA.Text);
            double costoLitrosA = Convert.ToDouble(txtCLitrosA.Text);

            Information.CostoTotalAgua = cantidadLitrosA * costoLitrosA;
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();	
		}
		
		void TxtLitrosAKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtLitrosA.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }
		}
		
		void TxtCLitrosAKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCLitrosA.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }
		}
	}
}
