/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 18/11/2024
 * Time: 07:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of reporte.
	/// </summary>
	public partial class reporte : Form
	{
		public reporte(double costoTotal)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			lblAserrin.Text = costoTotal.ToString("F2");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			MainForm MainForm = new MainForm();
			MainForm.Show();
			this.Hide();			
		}
	}
}
