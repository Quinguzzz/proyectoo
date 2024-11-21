/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 17/11/2024
 * Time: 10:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 Form3 = new Form3();
			Form3.Show();
			this.Hide();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Form1 Form1 = new Form1 ();
			Form1.Show();
			this.Hide();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Form3 Form3 = new Form3();
			Form3.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int cantidadBultos = Convert.ToInt32(txtBultos.Text);
            double costoBulto = Convert.ToDouble(txtCBultos.Text);

            Information.CostoTotalAserrin = cantidadBultos * costoBulto;
            
			Form3 Form3 = new Form3();
			Form3.Show();
			this.Hide();
		
		}
		
		void TxtBultosKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtBultos.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }
		}
		
		void TxtCBultosKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCBultos.Text.Contains("."))
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
