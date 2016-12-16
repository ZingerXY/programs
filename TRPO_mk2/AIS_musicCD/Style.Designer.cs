namespace AIS_musicCD
{
	partial class Style
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Style));
			this.AddNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddNew
			// 
			this.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNew.Location = new System.Drawing.Point(18, 323);
			this.AddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddNew.Name = "AddNew";
			this.AddNew.Size = new System.Drawing.Size(102, 33);
			this.AddNew.TabIndex = 41;
			this.AddNew.Text = "Добавить";
			this.AddNew.UseVisualStyleBackColor = true;
			this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(18, 18);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(315, 295);
			this.dataGridView1.TabIndex = 40;
			// 
			// Update
			// 
			this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Update.Location = new System.Drawing.Point(125, 323);
			this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(102, 33);
			this.Update.TabIndex = 42;
			this.Update.Text = "Изменить";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete.Location = new System.Drawing.Point(231, 323);
			this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(102, 33);
			this.Delete.TabIndex = 43;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Visible = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Style
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 372);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.AddNew);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Style";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Style";
			this.Load += new System.EventHandler(this.Style_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button AddNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
	}
}