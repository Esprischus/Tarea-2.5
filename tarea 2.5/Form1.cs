/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea_2._
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class fmrMenu : Form
	{
		public fmrMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DolaresAPesosToolStripMenuItemClick(object sender, EventArgs e)
		{
			fmrDolaraPeso dolares= new fmrDolaraPeso();
			dolares.Show();
			this.Hide();
		}
		
		void CoordenadasToolStripMenuItemClick(object sender, EventArgs e)
		{
			fmrCoordenadas coor = new fmrCoordenadas();
			coor.Show();
			this.Hide();
		}
		
		void DistanciaEntre2PuntosToolStripMenuItemClick(object sender, EventArgs e)
		{
			fmrDistancia2puntos dospuntos= new fmrDistancia2puntos();
			dospuntos.Show();
			this.Hide();
		}
	}
}
