/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 17/11/2024
 * Time: 06:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyectotransversal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
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
		
		void Label3Click(object sender, EventArgs e)
		{
			Form1 Form1 = new Form1 ();
			Form1.Show();
			this.Hide();
		}
	}
	public static class Information {
			 public static double TotalTamano=0;
	         public static double CostoTotalAserrin=0;
	         public static double CostoTotalPintura=0;
	         public static double CostoTotalFrutos=0;
	         public static double CostoTotalFlores=0;
	         public static double CostoTotalAlimentos=0;
	         public static double CostoTotalAgua=0;
	         public static double CostoTotalDiseño=0;
	         public static double CostoTotalObra=0;
	}
	
	}
		
	
		
	

