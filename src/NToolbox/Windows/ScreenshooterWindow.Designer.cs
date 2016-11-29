﻿namespace NToolbox.Windows
{
	partial class ScreenshooterWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupPanel1 = new NCore.UI.GroupPanel();
			this.ScreenBordersPanel = new System.Windows.Forms.Panel();
			this.ScreenPictureBox = new System.Windows.Forms.PictureBox();
			this.groupPanel2 = new NCore.UI.GroupPanel();
			this.label46 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.PixelSizeUpDown = new System.Windows.Forms.NumericUpDown();
			this.TakeScreenshotBeforeSaveCheckBox = new System.Windows.Forms.CheckBox();
			this.BroadcastButton = new System.Windows.Forms.Button();
			this.SaveScreenshotButton = new System.Windows.Forms.Button();
			this.TakeScreenshotButton = new System.Windows.Forms.Button();
			this.groupPanel1.SuspendLayout();
			this.ScreenBordersPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ScreenPictureBox)).BeginInit();
			this.groupPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PixelSizeUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// groupPanel1
			// 
			this.groupPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.groupPanel1.Controls.Add(this.ScreenBordersPanel);
			this.groupPanel1.HeaderBackColor = System.Drawing.Color.White;
			this.groupPanel1.HeaderHeight = 30;
			this.groupPanel1.Location = new System.Drawing.Point(12, 12);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new System.Drawing.Size(80, 173);
			this.groupPanel1.TabIndex = 0;
			this.groupPanel1.TabStop = false;
			this.groupPanel1.Text = "Screen:";
			// 
			// ScreenBordersPanel
			// 
			this.ScreenBordersPanel.BackColor = System.Drawing.Color.Black;
			this.ScreenBordersPanel.Controls.Add(this.ScreenPictureBox);
			this.ScreenBordersPanel.Location = new System.Drawing.Point(5, 34);
			this.ScreenBordersPanel.Name = "ScreenBordersPanel";
			this.ScreenBordersPanel.Size = new System.Drawing.Size(70, 134);
			this.ScreenBordersPanel.TabIndex = 1;
			// 
			// ScreenPictureBox
			// 
			this.ScreenPictureBox.Location = new System.Drawing.Point(3, 3);
			this.ScreenPictureBox.Name = "ScreenPictureBox";
			this.ScreenPictureBox.Size = new System.Drawing.Size(64, 128);
			this.ScreenPictureBox.TabIndex = 0;
			this.ScreenPictureBox.TabStop = false;
			// 
			// groupPanel2
			// 
			this.groupPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.groupPanel2.Controls.Add(this.label46);
			this.groupPanel2.Controls.Add(this.label47);
			this.groupPanel2.Controls.Add(this.PixelSizeUpDown);
			this.groupPanel2.Controls.Add(this.TakeScreenshotBeforeSaveCheckBox);
			this.groupPanel2.Controls.Add(this.BroadcastButton);
			this.groupPanel2.Controls.Add(this.SaveScreenshotButton);
			this.groupPanel2.Controls.Add(this.TakeScreenshotButton);
			this.groupPanel2.HeaderBackColor = System.Drawing.Color.White;
			this.groupPanel2.HeaderHeight = 30;
			this.groupPanel2.Location = new System.Drawing.Point(98, 12);
			this.groupPanel2.Name = "groupPanel2";
			this.groupPanel2.Size = new System.Drawing.Size(224, 173);
			this.groupPanel2.TabIndex = 1;
			this.groupPanel2.TabStop = false;
			this.groupPanel2.Text = "Controls:";
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(5, 96);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(99, 13);
			this.label46.TabIndex = 69;
			this.label46.Text = "Pixel size multiplier:";
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Location = new System.Drawing.Point(5, 121);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(95, 13);
			this.label47.TabIndex = 70;
			this.label47.Text = "Take before save:";
			// 
			// PixelSizeUpDown
			// 
			this.PixelSizeUpDown.Location = new System.Drawing.Point(158, 94);
			this.PixelSizeUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.PixelSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.PixelSizeUpDown.Name = "PixelSizeUpDown";
			this.PixelSizeUpDown.Size = new System.Drawing.Size(60, 21);
			this.PixelSizeUpDown.TabIndex = 68;
			this.PixelSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// TakeScreenshotBeforeSaveCheckBox
			// 
			this.TakeScreenshotBeforeSaveCheckBox.AutoSize = true;
			this.TakeScreenshotBeforeSaveCheckBox.Location = new System.Drawing.Point(158, 121);
			this.TakeScreenshotBeforeSaveCheckBox.Name = "TakeScreenshotBeforeSaveCheckBox";
			this.TakeScreenshotBeforeSaveCheckBox.Size = new System.Drawing.Size(64, 17);
			this.TakeScreenshotBeforeSaveCheckBox.TabIndex = 71;
			this.TakeScreenshotBeforeSaveCheckBox.Text = "Enabled";
			this.TakeScreenshotBeforeSaveCheckBox.UseVisualStyleBackColor = true;
			// 
			// BroadcastButton
			// 
			this.BroadcastButton.Location = new System.Drawing.Point(5, 145);
			this.BroadcastButton.Name = "BroadcastButton";
			this.BroadcastButton.Size = new System.Drawing.Size(214, 23);
			this.BroadcastButton.TabIndex = 2;
			this.BroadcastButton.Text = "Start broadcast";
			this.BroadcastButton.UseVisualStyleBackColor = true;
			// 
			// SaveScreenshotButton
			// 
			this.SaveScreenshotButton.Location = new System.Drawing.Point(5, 63);
			this.SaveScreenshotButton.Name = "SaveScreenshotButton";
			this.SaveScreenshotButton.Size = new System.Drawing.Size(214, 23);
			this.SaveScreenshotButton.TabIndex = 1;
			this.SaveScreenshotButton.Text = "Save screenshot";
			this.SaveScreenshotButton.UseVisualStyleBackColor = true;
			// 
			// TakeScreenshotButton
			// 
			this.TakeScreenshotButton.Location = new System.Drawing.Point(5, 34);
			this.TakeScreenshotButton.Name = "TakeScreenshotButton";
			this.TakeScreenshotButton.Size = new System.Drawing.Size(214, 23);
			this.TakeScreenshotButton.TabIndex = 0;
			this.TakeScreenshotButton.Text = "Take screenshot";
			this.TakeScreenshotButton.UseVisualStyleBackColor = true;
			// 
			// ScreenshooterWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(334, 197);
			this.Controls.Add(this.groupPanel2);
			this.Controls.Add(this.groupPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScreenshooterWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NFE Toolbox - Screenshooter";
			this.groupPanel1.ResumeLayout(false);
			this.ScreenBordersPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ScreenPictureBox)).EndInit();
			this.groupPanel2.ResumeLayout(false);
			this.groupPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PixelSizeUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private NCore.UI.GroupPanel groupPanel1;
		private System.Windows.Forms.PictureBox ScreenPictureBox;
		private System.Windows.Forms.Panel ScreenBordersPanel;
		private NCore.UI.GroupPanel groupPanel2;
		private System.Windows.Forms.Button TakeScreenshotButton;
		private System.Windows.Forms.Button SaveScreenshotButton;
		private System.Windows.Forms.Button BroadcastButton;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.NumericUpDown PixelSizeUpDown;
		private System.Windows.Forms.CheckBox TakeScreenshotBeforeSaveCheckBox;
	}
}