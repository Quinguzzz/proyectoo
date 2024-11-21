/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 05:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		public Form6()
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
		
		void Button3Click(object sender, EventArgs e)
		{
			Form7 Form7 = new Form7();
			Form7.Show();
			this.Hide();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Form5 Form5 = new Form5();
			Form5.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form7 Form7 = new Form7();
			Form7.Show();
			this.Hide();	
		}
		
		void Button4Click(object sender, EventArgs e)
		{	
			int cantidadParticipantes = Convert.ToInt32(txtParticipantes.Text);
            double costoBebida = Convert.ToDouble(txtCBebida.Text);
            double costoComida = Convert.ToDouble(txtCExtra.Text);
            double costoExtra = Convert.ToDouble(txtCComida.Text);
			
            Information.CostoTotalAlimentos = cantidadParticipantes * (costoBebida+costoComida+costoExtra);
            
			Form7 Form7 = new Form7();
			Form7.Show();
			this.Hide();
		}
		
		void TxtParticipantesKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtParticipantes.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }	
		}
		
		void TxtCExtraKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCBebida.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }	
		}
		
		void TxtCBebidaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCExtra.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }	
		}
		
		void TxtCComidaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCComida.Text.Contains("."))
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
