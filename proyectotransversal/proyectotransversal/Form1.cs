﻿/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 17/11/2024
 * Time: 08:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			MainForm MainForm = new MainForm ();
			MainForm.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form2 Form2 = new Form2 ();
			Form2.Show();
			this.Hide();
		}
		
		
		
		void Button6Click(object sender, EventArgs e)
		{
			Form2 Form2 = new Form2 ();
			Form2.Show();
			this.Hide();
		}
		
		
		
		
		void Button4Click(object sender, EventArgs e)
		{	
			double tamano = Convert.ToInt32(txtTamano.Text);

			Information.TotalTamano = tamano;
			Form2 Form2 = new Form2 ();
			Form2.Show();
			this.Hide();
		}
		
		void TxtTamanoKeyPress(object sender, KeyPressEventArgs  e)
		{
		  
			if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)8)
			    {
			        if (e.KeyChar == '.' && txtTamano.Text.Contains("."))
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
