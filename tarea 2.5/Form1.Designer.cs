/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tarea_2._
{
	partial class fmrMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblLogIn = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dolaresAPesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.distanciaEntre2PuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLogIn
			// 
			this.lblLogIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogIn.Location = new System.Drawing.Point(12, 24);
			this.lblLogIn.Name = "lblLogIn";
			this.lblLogIn.Size = new System.Drawing.Size(112, 43);
			this.lblLogIn.TabIndex = 1;
			this.lblLogIn.Text = "Menu:";
			this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.dolaresAPesosToolStripMenuItem,
									this.coordenadasToolStripMenuItem,
									this.distanciaEntre2PuntosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(408, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cerrarToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.cerrarToolStripMenuItem.Text = "&Cerrar";
			// 
			// dolaresAPesosToolStripMenuItem
			// 
			this.dolaresAPesosToolStripMenuItem.Name = "dolaresAPesosToolStripMenuItem";
			this.dolaresAPesosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.dolaresAPesosToolStripMenuItem.Text = "Dolares a Pesos";
			this.dolaresAPesosToolStripMenuItem.Click += new System.EventHandler(this.DolaresAPesosToolStripMenuItemClick);
			// 
			// coordenadasToolStripMenuItem
			// 
			this.coordenadasToolStripMenuItem.Name = "coordenadasToolStripMenuItem";
			this.coordenadasToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.coordenadasToolStripMenuItem.Text = "Coordenadas";
			this.coordenadasToolStripMenuItem.Click += new System.EventHandler(this.CoordenadasToolStripMenuItemClick);
			// 
			// distanciaEntre2PuntosToolStripMenuItem
			// 
			this.distanciaEntre2PuntosToolStripMenuItem.Name = "distanciaEntre2PuntosToolStripMenuItem";
			this.distanciaEntre2PuntosToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
			this.distanciaEntre2PuntosToolStripMenuItem.Text = "Distancia entre 2 puntos";
			this.distanciaEntre2PuntosToolStripMenuItem.Click += new System.EventHandler(this.DistanciaEntre2PuntosToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(403, 103);
			this.label1.TabIndex = 3;
			this.label1.Text = "Elije el programa que quieras iniciar en la parte superior de esta ventana, se ab" +
			"rira automaticamente la ventana para ejecutarse el programa";
			// 
			// fmrMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 169);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLogIn);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "fmrMenu";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem distanciaEntre2PuntosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coordenadasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dolaresAPesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblLogIn;
	}
}
