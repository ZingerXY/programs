﻿namespace AIS_musicCD
{
	partial class Main
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.Audio = new System.Windows.Forms.Button();
			this.Authors = new System.Windows.Forms.Button();
			this.Style = new System.Windows.Forms.Button();
			this.Country = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Report = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Move = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Audio
			// 
			this.Audio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Audio.Location = new System.Drawing.Point(16, 155);
			this.Audio.Name = "Audio";
			this.Audio.Size = new System.Drawing.Size(136, 35);
			this.Audio.TabIndex = 0;
			this.Audio.Text = "CD - диски";
			this.Audio.UseVisualStyleBackColor = false;
			this.Audio.Click += new System.EventHandler(this.Audio_Click);
			// 
			// Authors
			// 
			this.Authors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Authors.Location = new System.Drawing.Point(16, 352);
			this.Authors.Name = "Authors";
			this.Authors.Size = new System.Drawing.Size(136, 35);
			this.Authors.TabIndex = 1;
			this.Authors.Text = "Исполнители";
			this.Authors.UseVisualStyleBackColor = false;
			this.Authors.Click += new System.EventHandler(this.Authors_Click);
			// 
			// Style
			// 
			this.Style.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Style.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Style.Location = new System.Drawing.Point(168, 352);
			this.Style.Name = "Style";
			this.Style.Size = new System.Drawing.Size(136, 35);
			this.Style.TabIndex = 2;
			this.Style.Text = "Стили";
			this.Style.UseVisualStyleBackColor = false;
			this.Style.Click += new System.EventHandler(this.Style_Click);
			// 
			// Country
			// 
			this.Country.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Country.Location = new System.Drawing.Point(319, 352);
			this.Country.Name = "Country";
			this.Country.Size = new System.Drawing.Size(136, 35);
			this.Country.TabIndex = 3;
			this.Country.Text = "Страны";
			this.Country.UseVisualStyleBackColor = false;
			this.Country.Click += new System.EventHandler(this.Country_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 315);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Справочники:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "???:";
			// 
			// Report
			// 
			this.Report.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Report.Location = new System.Drawing.Point(16, 267);
			this.Report.Name = "Report";
			this.Report.Size = new System.Drawing.Size(136, 35);
			this.Report.TabIndex = 6;
			this.Report.Text = "Отчет";
			this.Report.UseVisualStyleBackColor = false;
			this.Report.Click += new System.EventHandler(this.Report_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(469, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(22, 22);
			this.button1.TabIndex = 8;
			this.button1.Text = "X";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Move
			// 
			this.Move.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Move.Location = new System.Drawing.Point(16, 211);
			this.Move.Name = "Move";
			this.Move.Size = new System.Drawing.Size(136, 35);
			this.Move.TabIndex = 9;
			this.Move.Text = "Приход/Расход";
			this.Move.UseVisualStyleBackColor = false;
			this.Move.Click += new System.EventHandler(this.Move_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(446, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(22, 22);
			this.button2.TabIndex = 10;
			this.button2.Text = "—";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(494, 419);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Move);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Report);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Country);
			this.Controls.Add(this.Style);
			this.Controls.Add(this.Authors);
			this.Controls.Add(this.Audio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "АИС - учет музыкальных дисков";
			this.Load += new System.EventHandler(this.Main_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Audio;
		private System.Windows.Forms.Button Authors;
		private System.Windows.Forms.Button Style;
		private System.Windows.Forms.Button Country;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Report;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button button2;
    }
}

