/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 29/10/2026
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tarea_2._
{
	partial class fmrDistancia2puntos
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.txtY2 = new System.Windows.Forms.TextBox();
			this.lblLogIn = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnOff = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblFinal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "X1:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y1:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(209, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "X2:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(209, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Y2:";
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(55, 45);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(100, 20);
			this.txtX1.TabIndex = 4;
			// 
			// txtY1
			// 
			this.txtY1.Location = new System.Drawing.Point(55, 71);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(100, 20);
			this.txtY1.TabIndex = 5;
			// 
			// txtX2
			// 
			this.txtX2.Location = new System.Drawing.Point(250, 46);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(100, 20);
			this.txtX2.TabIndex = 6;
			// 
			// txtY2
			// 
			this.txtY2.Location = new System.Drawing.Point(250, 71);
			this.txtY2.Name = "txtY2";
			this.txtY2.Size = new System.Drawing.Size(100, 20);
			this.txtY2.TabIndex = 7;
			// 
			// lblLogIn
			// 
			this.lblLogIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogIn.Location = new System.Drawing.Point(-2, 0);
			this.lblLogIn.Name = "lblLogIn";
			this.lblLogIn.Size = new System.Drawing.Size(367, 43);
			this.lblLogIn.TabIndex = 8;
			this.lblLogIn.Text = "Distancia entre 2 Puntos:";
			this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 164);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(85, 33);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnOff
			// 
			this.btnOff.Location = new System.Drawing.Point(261, 164);
			this.btnOff.Name = "btnOff";
			this.btnOff.Size = new System.Drawing.Size(89, 33);
			this.btnOff.TabIndex = 10;
			this.btnOff.Text = "Off";
			this.btnOff.UseVisualStyleBackColor = true;
			this.btnOff.Click += new System.EventHandler(this.BtnOffClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Distancia:";
			// 
			// lblFinal
			// 
			this.lblFinal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFinal.Location = new System.Drawing.Point(97, 106);
			this.lblFinal.Name = "lblFinal";
			this.lblFinal.Size = new System.Drawing.Size(253, 23);
			this.lblFinal.TabIndex = 12;
			// 
			// fmrDistancia2puntos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 207);
			this.Controls.Add(this.lblFinal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnOff);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblLogIn);
			this.Controls.Add(this.txtY2);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtY1);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "fmrDistancia2puntos";
			this.Text = "fmrDistancia2puntos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblFinal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnOff;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblLogIn;
		private System.Windows.Forms.TextBox txtY2;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
