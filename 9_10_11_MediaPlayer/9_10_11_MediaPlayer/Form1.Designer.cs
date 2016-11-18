namespace _9_10_11_MediaPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CurrPos = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.StateBar = new System.Windows.Forms.TrackBar();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.collumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrPos
            // 
            this.CurrPos.AutoSize = true;
            this.CurrPos.Location = new System.Drawing.Point(418, 35);
            this.CurrPos.Name = "CurrPos";
            this.CurrPos.Size = new System.Drawing.Size(33, 13);
            this.CurrPos.TabIndex = 15;
            this.CurrPos.Text = "0 sec";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(12, 35);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(33, 13);
            this.Duration.TabIndex = 14;
            this.Duration.Text = "0 sec";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(468, 12);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 104);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Value = 25;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // StateBar
            // 
            this.StateBar.Location = new System.Drawing.Point(56, 24);
            this.StateBar.Name = "StateBar";
            this.StateBar.Size = new System.Drawing.Size(356, 45);
            this.StateBar.TabIndex = 12;
            this.StateBar.Scroll += new System.EventHandler(this.StateBar_Scroll);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(235, 75);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 11;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(316, 75);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 10;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(154, 75);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 9;
            this.Play.Text = "Пуск";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(73, 110);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 8;
            this.Open.Text = "Добавить";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "50";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.collumnHeader1,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 152);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // collumnHeader1
            // 
            this.collumnHeader1.Text = "Name";
            this.collumnHeader1.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Duration";
            this.columnHeader1.Width = 135;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(73, 75);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 19;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 308);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrPos);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.StateBar);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MediaPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrPos;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar StateBar;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader collumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Next;
    }
}

