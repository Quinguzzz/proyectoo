﻿/*
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
			Form7 frm7 = new Form7();
			frm7.Show();
			this.Close();
		}
	}
}