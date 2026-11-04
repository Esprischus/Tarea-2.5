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
	partial class fmrCoordenadas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCoordenadas));
			this.lblFinal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblLogIn = new System.Windows.Forms.Label();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOff = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFinal
			// 
			this.lblFinal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFinal.Location = new System.Drawing.Point(164, 80);
			this.lblFinal.Name = "lblFinal";
			this.lblFinal.Size = new System.Drawing.Size(186, 23);
			this.lblFinal.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(164, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Cuadrante:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
			this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCalcular.Location = new System.Drawing.Point(8, 172);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(85, 58);
			this.btnCalcular.TabIndex = 16;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblLogIn
			// 
			this.lblLogIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogIn.Location = new System.Drawing.Point(8, 8);
			this.lblLogIn.Name = "lblLogIn";
			this.lblLogIn.Size = new System.Drawing.Size(342, 43);
			this.lblLogIn.TabIndex = 15;
			this.lblLogIn.Text = "Coordenadas";
			this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtY1
			// 
			this.txtY1.Location = new System.Drawing.Point(49, 80);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(100, 20);
			this.txtY1.TabIndex = 14;
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(49, 54);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(100, 20);
			this.txtX1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Y1:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "X1:";
			// 
			// btnOff
			// 
			this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
			this.btnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOff.Location = new System.Drawing.Point(99, 196);
			this.btnOff.Name = "btnOff";
			this.btnOff.Size = new System.Drawing.Size(60, 34);
			this.btnOff.TabIndex = 21;
			this.btnOff.Text = "Off";
			this.btnOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOff.UseVisualStyleBackColor = true;
			this.btnOff.Click += new System.EventHandler(this.BtnOffClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(228, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(122, 110);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// fmrCoordenadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 232);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOff);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFinal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblLogIn);
			this.Controls.Add(this.txtY1);
			this.Controls.Add(this.txtX1);
			this.Name = "fmrCoordenadas";
			this.Text = "fmrCoordenadas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnOff;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.Label lblLogIn;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblFinal;
	}
}
