/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 05:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of Form7.
	/// </summary>
	public partial class Form7 : Form
	{
		public Form7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.WindowState =FormWindowState.Maximized;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Form6 Form6 = new Form6();
			Form6.Show();
			this.Hide();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Form8 Form8 = new Form8();
			Form8.Show();
			this.Hide();
		}
	}
}
