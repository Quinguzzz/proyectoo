/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 06:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form8.
	/// </summary>
	public partial class Form8 : Form
	{
		public Form8()
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
		
		void Button7Click(object sender, EventArgs e)
		{
			Form7 Form7 = new Form7();
			Form7.Show();
			this.Hide();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form9 Form9 = new Form9();
			Form9.Show();
			this.Hide();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form9 Form9 = new Form9();
			Form9.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int cantidadDiseño = Convert.ToInt32(txtDiseno.Text);
			int cantidadHoras = Convert.ToInt32(txtHoras.Text);
            double costoDiseño = Convert.ToDouble(txtCDiseno.Text);

            Information.CostoTotalDiseño = costoDiseño * (cantidadDiseño * cantidadHoras);
			Form9 Form9 = new Form9();
			Form9.Show();
			this.Hide();		
		}
		
		void TxtDisenoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtDiseno.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }
		}
		
		void TxtCDisenoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCDiseno.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }		
		}
		
		void TxtHorasKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtHoras.Text.Contains("."))
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
