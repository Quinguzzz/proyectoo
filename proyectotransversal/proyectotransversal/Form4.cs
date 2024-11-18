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
	}
}
