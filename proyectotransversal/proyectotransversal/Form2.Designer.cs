/*
 * Created by SharpDevelop.
 * User: quing
 * Date: 17/11/2024
 * Time: 10:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectotransversal
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(598, 486);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(155, 39);
			this.button3.TabIndex = 29;
			this.button3.Text = "AGREGAR";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(866, 366);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "M²";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBox1.Location = new System.Drawing.Point(528, 366);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(326, 20);
			this.textBox1.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(438, 366);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "ÁREA:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(397, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 36);
			this.label5.TabIndex = 25;
			this.label5.Text = "BULTOS DE ASERRÍN";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(793, 319);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 63);
			this.button2.TabIndex = 24;
			this.button2.Text = ">";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(39, 309);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 63);
			this.button1.TabIndex = 23;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(399, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 386);
			this.label4.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label2.Location = new System.Drawing.Point(-11, 502);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(937, 32);
			this.label2.TabIndex = 21;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(213, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 102);
			this.label1.TabIndex = 20;
			this.label1.Text = "COLOR AL COSTO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(937, 189);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label3.Location = new System.Drawing.Point(-301, 598);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1511, 42);
			this.label3.TabIndex = 18;
			this.label3.Text = "¡Da clic aquí para hacer tu calculo de costos!";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(866, 434);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 23);
			this.label8.TabIndex = 33;
			this.label8.Text = "M²";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBox2.Location = new System.Drawing.Point(528, 434);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(326, 20);
			this.textBox2.TabIndex = 32;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(438, 434);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 23);
			this.label9.TabIndex = 31;
			this.label9.Text = "ÁREA:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(892, 533);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
	}
}
