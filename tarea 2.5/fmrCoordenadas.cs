/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tarea_2._
{
	/// <summary>
	/// Description of fmrCoordenadas.
	/// </summary>
	public partial class fmrCoordenadas : Form
	{
		public fmrCoordenadas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double x,y;
			x=Convert.ToDouble(txtX1.Text);
			y=Convert.ToDouble(txtY1.Text);
			
			if(x>0 && y>0){
				lblFinal.Text="Cuadrante Primero I";
			}
			if(x>0 && y<0){
				lblFinal.Text="Cuadrante Cuarto IV";
			}
			if(x<0 && y>0){
				lblFinal.Text="Cuadrante Segundo II";
			}
			if (x<0 && y<0){
				lblFinal.Text="Cuadrante Tercero III";
			}
			if (x==0 || y==0){
				lblFinal.Text="En Ningun Cuadrante! (0,0)";
			}
		}
		
		void BtnOffClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Er er e eeee ee e e e");
		}
	}
}
