/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tarea_2._
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnChecarClick(object sender, EventArgs e)
		{
			if (txtContraseña.Text== "hola"&& txtNombre.Text=="Sans"){
				fmrMenu xd= new fmrMenu();
				this.Close();
				xd.Show();
			}
			else{
				MessageBox.Show("Nombre y/o Contraseña equivocados!", "Error");
			}
		}
	}
}
