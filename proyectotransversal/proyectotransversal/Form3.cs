﻿/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 12:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
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
			Form4 Form4 = new Form4 ();
			Form4.Show();
			this.Hide();			
		}
		
		
		void Button7Click(object sender, EventArgs e)
		{
			Form2 Form2 = new Form2 ();
			Form2.Show();
			this.Hide();			
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Form4 Form4 = new Form4 ();
			Form4.Show();
			this.Hide();			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			double cantidadLitrosP = Convert.ToInt32(txtLitrosP.Text);
            double costoLitroP = Convert.ToDouble(txtCLitrosP.Text);
            
            Information.CostoTotalPintura= cantidadLitrosP * costoLitroP;
			Form4 Form4 = new Form4 ();
			Form4.Show();
			this.Hide();			
		}
		
		void TxtLitrosPKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtLitrosP.Text.Contains("."))
			        {
			            e.Handled = true; 
			        }
			    }
			    else
			    {
			        e.Handled = true;
			    }
		}
		
		void TxtCLitrosPKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtCLitrosP.Text.Contains("."))
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
