namespace AIS_musicCD
{
	partial class AddAudio
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
			this.change = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.AddAuthor = new System.Windows.Forms.Button();
			this.NewAuthor = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// change
			// 
			this.change.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.change.Location = new System.Drawing.Point(452, 265);
			this.change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.change.Name = "change";
			this.change.Size = new System.Drawing.Size(248, 35);
			this.change.TabIndex = 64;
			this.change.Text = "Выбрать изображение";
			this.change.UseVisualStyleBackColor = false;
			this.change.Click += new System.EventHandler(this.change_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(452, 18);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(246, 236);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 63;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.Location = new System.Drawing.Point(238, 212);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 24);
			this.checkBox1.TabIndex = 62;
			this.checkBox1.Text = "Сольный";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(26, 177);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 20);
			this.label4.TabIndex = 61;
			this.label4.Text = "Время звучания";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(26, 137);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 20);
			this.label3.TabIndex = 60;
			this.label3.Text = "Кол-во треков";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(27, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 20);
			this.label2.TabIndex = 59;
			this.label2.Text = "Год";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(26, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 20);
			this.label1.TabIndex = 58;
			this.label1.Text = "Название альбома";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(190, 172);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(228, 26);
			this.textBox4.TabIndex = 57;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(189, 132);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(229, 26);
			this.textBox3.TabIndex = 56;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(190, 92);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(228, 26);
			this.textBox2.TabIndex = 55;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(190, 52);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(228, 26);
			this.textBox1.TabIndex = 54;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add.Location = new System.Drawing.Point(238, 420);
			this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(248, 35);
			this.Add.TabIndex = 65;
			this.Add.Text = "Добавить запись";
			this.Add.UseVisualStyleBackColor = false;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(18, 272);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(178, 124);
			this.listBox1.TabIndex = 66;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(20, 243);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 20);
			this.label5.TabIndex = 67;
			this.label5.Text = "Авторы:";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(238, 272);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(180, 28);
			this.comboBox1.TabIndex = 68;
			// 
			// AddAuthor
			// 
			this.AddAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddAuthor.Location = new System.Drawing.Point(238, 315);
			this.AddAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddAuthor.Name = "AddAuthor";
			this.AddAuthor.Size = new System.Drawing.Size(182, 35);
			this.AddAuthor.TabIndex = 69;
			this.AddAuthor.Text = "Добавить автора";
			this.AddAuthor.UseVisualStyleBackColor = false;
			this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
			// 
			// NewAuthor
			// 
			this.NewAuthor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.NewAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NewAuthor.Location = new System.Drawing.Point(238, 360);
			this.NewAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NewAuthor.Name = "NewAuthor";
			this.NewAuthor.Size = new System.Drawing.Size(182, 35);
			this.NewAuthor.TabIndex = 70;
			this.NewAuthor.Text = "Новый автор";
			this.NewAuthor.UseVisualStyleBackColor = false;
			this.NewAuthor.Click += new System.EventHandler(this.NewAuthor_Click);
			// 
			// AddAudio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 474);
			this.Controls.Add(this.NewAuthor);
			this.Controls.Add(this.AddAuthor);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.change);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddAudio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddAudio";
			this.Activated += new System.EventHandler(this.AddAudio_Activated);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button change;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button AddAuthor;
		private System.Windows.Forms.Button NewAuthor;
	}
}