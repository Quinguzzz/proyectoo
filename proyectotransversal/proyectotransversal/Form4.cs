/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 01:12 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
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
			Form3 Form3 = new Form3 ();
			Form3.Show();
			this.Hide();			
		}
		
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			Form5 Form5= new Form5 ();
			Form5.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form5 Form5= new Form5 ();
			Form5.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{	
			int cantidadFrutos = Convert.ToInt32(txtFs.Text);
            double costoFrutos = Convert.ToDouble(txtCFs.Text);

            Information.CostoTotalFrutos = cantidadFrutos * costoFrutos;
            
			Form5 Form5= new Form5 ();
			Form5.Show();
			this.Hide();
		}
		
		void TxtFsKeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtFs.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }	
		}
		
		void TxtCFsKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCFs.Text.Contains("."))
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
