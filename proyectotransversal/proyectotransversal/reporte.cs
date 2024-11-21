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
		public reporte()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			lblAserrin.Text = Information.CostoTotalAserrin.ToString("F2");
			lblPintura.Text = Information.CostoTotalPintura.ToString("F2");
			lblTamano.Text = Information.TotalTamano.ToString("F2") + " M²";
			lblFrutos.Text = Information.CostoTotalFrutos.ToString("F2");
			lblFlores.Text = Information.CostoTotalFlores.ToString("F2");
			lblAlimentos.Text = Information.CostoTotalAlimentos.ToString("F2");
			lblAgua.Text = Information.CostoTotalAgua.ToString("F2");
			lblDiseno.Text = Information.CostoTotalDiseño.ToString("F2");
			lblManodeobra.Text = Information.CostoTotalObra.ToString("F2");
			
			double totalCostos = Information.CostoTotalAserrin 
                    + Information.CostoTotalPintura
                    + Information.CostoTotalFrutos
                    + Information.CostoTotalFlores
                    + Information.CostoTotalAlimentos
                    + Information.CostoTotalAgua
                    + Information.CostoTotalDiseño
                    + Information.CostoTotalObra;

			lblTotal.Text = totalCostos.ToString("F2");
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