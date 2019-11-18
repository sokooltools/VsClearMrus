﻿namespace SokoolTools.VsClearMrus
{
	partial class MainDialog
	{
		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Required designer variable.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private System.ComponentModel.IContainer components = null;

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		//------------------------------------------------------------------------------------------------------------------------
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//..................................................................................................................................

		#region Windows Form Designer generated code

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void InitializeComponent()
		{
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCaption = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(122, 70);
			this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(87, 30);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(216, 70);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(87, 30);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblCaption
			// 
			this.lblCaption.AutoSize = true;
			this.lblCaption.Location = new System.Drawing.Point(14, 21);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(215, 17);
			this.lblCaption.TabIndex = 1;
			this.lblCaption.Text = "OK to clear all Visual Studio MRUs?";
			// 
			// MainDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(425, 118);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clear All Visual Studio MRUs";
			this.Load += new System.EventHandler(this.MainDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblCaption;
	}
}

