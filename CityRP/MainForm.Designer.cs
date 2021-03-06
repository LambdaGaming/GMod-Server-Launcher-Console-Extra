﻿namespace CityRP_Server_Launcher_UI
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lancheck = new System.Windows.Forms.CheckBox();
			this.mapselect = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.maxplayers = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.consolecheck = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lancheck
			// 
			this.lancheck.AutoSize = true;
			this.lancheck.Cursor = System.Windows.Forms.Cursors.Default;
			this.lancheck.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lancheck.ForeColor = System.Drawing.Color.White;
			this.lancheck.Location = new System.Drawing.Point(12, 82);
			this.lancheck.Name = "lancheck";
			this.lancheck.Size = new System.Drawing.Size(78, 19);
			this.lancheck.TabIndex = 0;
			this.lancheck.Text = "LAN Server";
			this.lancheck.UseVisualStyleBackColor = true;
			this.lancheck.CheckedChanged += new System.EventHandler(this.LanCheck);
			// 
			// mapselect
			// 
			this.mapselect.Enabled = false;
			this.mapselect.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mapselect.FormattingEnabled = true;
			this.mapselect.Items.AddRange(new object[] {
            "rp_rockford_v2b",
            "rp_southside",
            "rp_riverden_v1a",
            "rp_florida_v2",
            "rp_truenorth_v1a",
            "rp_newexton2_v4h"});
			this.mapselect.Location = new System.Drawing.Point(12, 258);
			this.mapselect.Name = "mapselect";
			this.mapselect.Size = new System.Drawing.Size(132, 23);
			this.mapselect.TabIndex = 2;
			this.mapselect.SelectedIndexChanged += new System.EventHandler(this.MapChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Map:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 397);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(484, 64);
			this.button1.TabIndex = 4;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// maxplayers
			// 
			this.maxplayers.Location = new System.Drawing.Point(12, 170);
			this.maxplayers.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.maxplayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxplayers.Name = "maxplayers";
			this.maxplayers.Size = new System.Drawing.Size(61, 20);
			this.maxplayers.TabIndex = 6;
			this.maxplayers.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.maxplayers.ValueChanged += new System.EventHandler(this.MaxPlayersChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Max Players:";
			// 
			// consolecheck
			// 
			this.consolecheck.AutoSize = true;
			this.consolecheck.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consolecheck.ForeColor = System.Drawing.Color.White;
			this.consolecheck.Location = new System.Drawing.Point(12, 12);
			this.consolecheck.Name = "consolecheck";
			this.consolecheck.Size = new System.Drawing.Size(98, 19);
			this.consolecheck.TabIndex = 1;
			this.consolecheck.Text = "Enable Console";
			this.consolecheck.UseVisualStyleBackColor = true;
			this.consolecheck.CheckedChanged += new System.EventHandler(this.ConsoleCheck);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CityRP_Server_Launcher_UI.Properties.Resources.lambda_srcds_2020;
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.Location = new System.Drawing.Point(233, 102);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.consolecheck);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxplayers);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mapselect);
			this.Controls.Add(this.lancheck);
			this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CityRP Server Launcher";
			((System.ComponentModel.ISupportInitialize)(this.maxplayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox lancheck;
		private System.Windows.Forms.ComboBox mapselect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown maxplayers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox consolecheck;
	}
}

