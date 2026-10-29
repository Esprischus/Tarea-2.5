/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tarea_2._
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnChecar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblLogIn
			// 
			this.lblLogIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogIn.Location = new System.Drawing.Point(128, -17);
			this.lblLogIn.Name = "lblLogIn";
			this.lblLogIn.Size = new System.Drawing.Size(152, 77);
			this.lblLogIn.TabIndex = 0;
			this.lblLogIn.Text = "Login";
			this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(158, 76);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(227, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(158, 102);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(227, 20);
			this.txtContraseña.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña:";
			// 
			// btnChecar
			// 
			this.btnChecar.Location = new System.Drawing.Point(158, 170);
			this.btnChecar.Name = "btnChecar";
			this.btnChecar.Size = new System.Drawing.Size(92, 36);
			this.btnChecar.TabIndex = 5;
			this.btnChecar.Text = "Entrar";
			this.btnChecar.UseVisualStyleBackColor = true;
			this.btnChecar.Click += new System.EventHandler(this.BtnChecarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 218);
			this.Controls.Add(this.btnChecar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLogIn);
			this.Name = "MainForm";
			this.Text = "tarea 2.5";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnChecar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLogIn;
	}
}
