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
	/// Description of fmrDistancia2puntos.
	/// </summary>
	public partial class fmrDistancia2puntos : Form
	{
		public fmrDistancia2puntos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOffClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double x1,x2,y1,y2,yrest,xrest,restd,hola;
			x1=Convert.ToDouble(txtX1.Text);
			x2=Convert.ToDouble(txtX2.Text);
			y1=Convert.ToDouble(txtY1.Text);
			y2=Convert.ToDouble(txtY2.Text);
			xrest=x2-x1;
			xrest=xrest*xrest;
			yrest=y2-y1;
			yrest=yrest*yrest;
			restd= xrest+yrest;
			hola=Math.Sqrt(restd);
			lblFinal.Text=Convert.ToString(hola);
		}
	}
}
