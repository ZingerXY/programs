namespace AIS_musicCD
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
            this.AddRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Audio
            // 
            this.Audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Audio.Location = new System.Drawing.Point(128, 162);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(128, 35);
            this.Audio.TabIndex = 0;
            this.Audio.Text = "CD - диски";
            this.Audio.UseVisualStyleBackColor = true;
            this.Audio.Click += new System.EventHandler(this.Audio_Click);
            // 
            // Authors
            // 
            this.Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authors.Location = new System.Drawing.Point(274, 162);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(128, 35);
            this.Authors.TabIndex = 1;
            this.Authors.Text = "Исполнители";
            this.Authors.UseVisualStyleBackColor = true;
            this.Authors.Click += new System.EventHandler(this.Authors_Click);
            // 
            // Style
            // 
            this.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Style.Location = new System.Drawing.Point(128, 250);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(128, 35);
            this.Style.TabIndex = 2;
            this.Style.Text = "Стили";
            this.Style.UseVisualStyleBackColor = true;
            this.Style.Click += new System.EventHandler(this.Style_Click);
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country.Location = new System.Drawing.Point(274, 250);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(128, 35);
            this.Country.TabIndex = 3;
            this.Country.Text = "Страны";
            this.Country.UseVisualStyleBackColor = true;
            this.Country.Click += new System.EventHandler(this.Country_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(205, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Справочники:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(205, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "???:";
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(274, 331);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(128, 35);
            this.Report.TabIndex = 6;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // AddRecord
            // 
            this.AddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecord.Location = new System.Drawing.Point(128, 331);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(128, 35);
            this.AddRecord.TabIndex = 7;
            this.AddRecord.Text = "Добавить";
            this.AddRecord.UseVisualStyleBackColor = true;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 419);
            this.Controls.Add(this.AddRecord);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Style);
            this.Controls.Add(this.Authors);
            this.Controls.Add(this.Audio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС - учет музыкальных дисков";
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
		private System.Windows.Forms.Button AddRecord;
	}
}

