/*
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
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm MainForm = new MainForm ();
			MainForm.Show();
			this.Hide();			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form2 Form2 = new Form2 ();
			Form2.Show();
			this.Hide();				
		}
	}
}
