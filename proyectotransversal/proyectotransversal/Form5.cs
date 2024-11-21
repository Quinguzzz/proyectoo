/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 02:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
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
			Form4 Form4= new Form4();
			Form4.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form6 Form6= new Form6();
			Form6.Show();
			this.Hide();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form6 Form6= new Form6();
			Form6.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{	
			int cantidadFlores = Convert.ToInt32(txtDocena.Text);
            double costoFlores = Convert.ToDouble(txtCDocena.Text);

            Information.CostoTotalFlores = cantidadFlores * costoFlores;
            
			Form6 Form6= new Form6();
			Form6.Show();
			this.Hide();	
		}
		
		void TxtDocenaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtDocena.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }	
		}
		
		void TxtCDocenaKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCDocena.Text.Contains("."))
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
