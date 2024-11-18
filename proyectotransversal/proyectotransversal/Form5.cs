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
	}
}
