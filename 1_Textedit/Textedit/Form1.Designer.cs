namespace Textedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискИЗаменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.новыйToolStripMenuItem.Text = "Создать";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.New_Doc);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.Open_Doc);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save_Doc);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.Save_As_Doc);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Doc);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.поискИЗаменаToolStripMenuItem,
            this.toolStripSeparator2,
            this.цветToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.Find_Doc);
            // 
            // поискИЗаменаToolStripMenuItem
            // 
            this.поискИЗаменаToolStripMenuItem.Name = "поискИЗаменаToolStripMenuItem";
            this.поискИЗаменаToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.поискИЗаменаToolStripMenuItem.Text = "Поиск и замена";
            this.поискИЗаменаToolStripMenuItem.Click += new System.EventHandler(this.Replace_Doc);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.Font_Color);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.Font_Change);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrap});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // WordWrap
            // 
            this.WordWrap.Checked = true;
            this.WordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrap.Name = "WordWrap";
            this.WordWrap.Size = new System.Drawing.Size(183, 22);
            this.WordWrap.Text = "Перенос по словам";
            this.WordWrap.Click += new System.EventHandler(this.Word_Wrap);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton6,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(470, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Textedit.Properties.Resources.Document;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Создать";
            this.toolStripButton3.Click += new System.EventHandler(this.New_Doc);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Textedit.Properties.Resources.OpenFolder;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Открыть";
            this.toolStripButton1.Click += new System.EventHandler(this.Open_Doc);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Textedit.Properties.Resources.Save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Сохранить";
            this.toolStripButton2.Click += new System.EventHandler(this.Save_Doc);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Textedit.Properties.Resources.FontDialog;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Шрифт";
            this.toolStripButton4.Click += new System.EventHandler(this.Font_Change);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Textedit.Properties.Resources.Color_font;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Цвет";
            this.toolStripButton5.Click += new System.EventHandler(this.Font_Color);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Textedit.Properties.Resources.Find;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Поиск";
            this.toolStripButton6.Click += new System.EventHandler(this.Find_Doc);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Textedit.Properties.Resources.CompareVersions;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Замена";
            this.toolStripButton7.Click += new System.EventHandler(this.Replace_Doc);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ActualSize.bmp");
            this.imageList1.Images.SetKeyName(1, "AddTable.bmp");
            this.imageList1.Images.SetKeyName(2, "AddToFavorites.bmp");
            this.imageList1.Images.SetKeyName(3, "Alerts.bmp");
            this.imageList1.Images.SetKeyName(4, "AlignObjectsBottom.bmp");
            this.imageList1.Images.SetKeyName(5, "AlignObjectsCenteredHorizontalHS.bmp");
            this.imageList1.Images.SetKeyName(6, "AlignObjectsCenteredVerticalHS.bmp");
            this.imageList1.Images.SetKeyName(7, "AlignObjectsLeft.bmp");
            this.imageList1.Images.SetKeyName(8, "AlignObjectsRight.bmp");
            this.imageList1.Images.SetKeyName(9, "AlignObjectsTop.bmp");
            this.imageList1.Images.SetKeyName(10, "AlignTableCellMiddleCenter.bmp");
            this.imageList1.Images.SetKeyName(11, "AlignTableCellMiddleLeftJust.bmp");
            this.imageList1.Images.SetKeyName(12, "AlignTableCellMiddleRight.bmp");
            this.imageList1.Images.SetKeyName(13, "AlignToGrid.bmp");
            this.imageList1.Images.SetKeyName(14, "Animate.bmp");
            this.imageList1.Images.SetKeyName(15, "AppWindow.bmp");
            this.imageList1.Images.SetKeyName(16, "ArrangeSideBySide.bmp");
            this.imageList1.Images.SetKeyName(17, "ArrangeWindows.bmp");
            this.imageList1.Images.SetKeyName(18, "Attachment.bmp");
            this.imageList1.Images.SetKeyName(19, "Audio.bmp");
            this.imageList1.Images.SetKeyName(20, "BackgroundSound.bmp");
            this.imageList1.Images.SetKeyName(21, "BarCode.bmp");
            this.imageList1.Images.SetKeyName(22, "BehindText.bmp");
            this.imageList1.Images.SetKeyName(23, "Bold.bmp");
            this.imageList1.Images.SetKeyName(24, "book_active_directory.bmp");
            this.imageList1.Images.SetKeyName(25, "book_address.bmp");
            this.imageList1.Images.SetKeyName(26, "book_angle.bmp");
            this.imageList1.Images.SetKeyName(27, "book_hardcvr.bmp");
            this.imageList1.Images.SetKeyName(28, "book_open.bmp");
            this.imageList1.Images.SetKeyName(29, "book_report.bmp");
            this.imageList1.Images.SetKeyName(30, "Book_StackOfReports.bmp");
            this.imageList1.Images.SetKeyName(31, "Breakpoint.bmp");
            this.imageList1.Images.SetKeyName(32, "BringForward.bmp");
            this.imageList1.Images.SetKeyName(33, "BringToFront.bmp");
            this.imageList1.Images.SetKeyName(34, "Calculator.bmp");
            this.imageList1.Images.SetKeyName(35, "Calendar_schedule.bmp");
            this.imageList1.Images.SetKeyName(36, "CanvasScale.bmp");
            this.imageList1.Images.SetKeyName(37, "CascadeWindows.bmp");
            this.imageList1.Images.SetKeyName(38, "CenterAcross.bmp");
            this.imageList1.Images.SetKeyName(39, "Checkbox.bmp");
            this.imageList1.Images.SetKeyName(40, "CheckGrammar.bmp");
            this.imageList1.Images.SetKeyName(41, "CheckSpelling.bmp");
            this.imageList1.Images.SetKeyName(42, "ChooseColor.bmp");
            this.imageList1.Images.SetKeyName(43, "Color.bmp");
            this.imageList1.Images.SetKeyName(44, "Color_eyedropper.bmp");
            this.imageList1.Images.SetKeyName(45, "Color_fill.bmp");
            this.imageList1.Images.SetKeyName(46, "Color_font.bmp");
            this.imageList1.Images.SetKeyName(47, "Color_linecolor.bmp");
            this.imageList1.Images.SetKeyName(48, "Comment.bmp");
            this.imageList1.Images.SetKeyName(49, "CompareVersions.bmp");
            this.imageList1.Images.SetKeyName(50, "Conflict.bmp");
            this.imageList1.Images.SetKeyName(51, "Copy.bmp");
            this.imageList1.Images.SetKeyName(52, "CopyFolder.bmp");
            this.imageList1.Images.SetKeyName(53, "Cut.bmp");
            this.imageList1.Images.SetKeyName(54, "DataContainer_MoveFirst.bmp");
            this.imageList1.Images.SetKeyName(55, "DataContainer_MoveLast.bmp");
            this.imageList1.Images.SetKeyName(56, "DataContainer_MoveNext.bmp");
            this.imageList1.Images.SetKeyName(57, "DataContainer_MovePrevious.bmp");
            this.imageList1.Images.SetKeyName(58, "Delete.bmp");
            this.imageList1.Images.SetKeyName(59, "DeleteFolder.bmp");
            this.imageList1.Images.SetKeyName(60, "DeleteTable.bmp");
            this.imageList1.Images.SetKeyName(61, "Dial.bmp");
            this.imageList1.Images.SetKeyName(62, "DisplayInColor.bmp");
            this.imageList1.Images.SetKeyName(63, "Document.bmp");
            this.imageList1.Images.SetKeyName(64, "DoubleLeftArrow.bmp");
            this.imageList1.Images.SetKeyName(65, "DoubleRightArrow.bmp");
            this.imageList1.Images.SetKeyName(66, "DownloadDocument.bmp");
            this.imageList1.Images.SetKeyName(67, "Edit_Redo.bmp");
            this.imageList1.Images.SetKeyName(68, "Edit_Undo.bmp");
            this.imageList1.Images.SetKeyName(69, "EditBrightContrast.bmp");
            this.imageList1.Images.SetKeyName(70, "EditCode.bmp");
            this.imageList1.Images.SetKeyName(71, "EditInformation.bmp");
            this.imageList1.Images.SetKeyName(72, "EditTable.bmp");
            this.imageList1.Images.SetKeyName(73, "Envelope.bmp");
            this.imageList1.Images.SetKeyName(74, "eps_closed.bmp");
            this.imageList1.Images.SetKeyName(75, "eps_open.bmp");
            this.imageList1.Images.SetKeyName(76, "eps_open_large.bmp");
            this.imageList1.Images.SetKeyName(77, "ExpandSpace.bmp");
            this.imageList1.Images.SetKeyName(78, "Expiration.bmp");
            this.imageList1.Images.SetKeyName(79, "Fax.bmp");
            this.imageList1.Images.SetKeyName(80, "FillDown.bmp");
            this.imageList1.Images.SetKeyName(81, "FillLeft.bmp");
            this.imageList1.Images.SetKeyName(82, "FillRight.bmp");
            this.imageList1.Images.SetKeyName(83, "FillUp.bmp");
            this.imageList1.Images.SetKeyName(84, "Filter2.bmp");
            this.imageList1.Images.SetKeyName(85, "Find.bmp");
            this.imageList1.Images.SetKeyName(86, "Find24_VS.bmp");
            this.imageList1.Images.SetKeyName(87, "FindNext.bmp");
            this.imageList1.Images.SetKeyName(88, "FindNext_VS.bmp");
            this.imageList1.Images.SetKeyName(89, "FindPrevious_VS.bmp");
            this.imageList1.Images.SetKeyName(90, "Flag_blue.bmp");
            this.imageList1.Images.SetKeyName(91, "Flag_green.bmp");
            this.imageList1.Images.SetKeyName(92, "Flag_red.bmp");
            this.imageList1.Images.SetKeyName(93, "FlipHorizontal.bmp");
            this.imageList1.Images.SetKeyName(94, "FlipVertical.bmp");
            this.imageList1.Images.SetKeyName(95, "Font.bmp");
            this.imageList1.Images.SetKeyName(96, "FontDialog.bmp");
            this.imageList1.Images.SetKeyName(97, "Forecolor.bmp");
            this.imageList1.Images.SetKeyName(98, "FormRun.bmp");
            this.imageList1.Images.SetKeyName(99, "FormulaEvaluator.bmp");
            this.imageList1.Images.SetKeyName(100, "FullScreen.bmp");
            this.imageList1.Images.SetKeyName(101, "Function.bmp");
            this.imageList1.Images.SetKeyName(102, "GetLatestVersion.bmp");
            this.imageList1.Images.SetKeyName(103, "GoLtr.bmp");
            this.imageList1.Images.SetKeyName(104, "GoRtl.bmp");
            this.imageList1.Images.SetKeyName(105, "GoToNext.bmp");
            this.imageList1.Images.SetKeyName(106, "GoToNextRecord.bmp");
            this.imageList1.Images.SetKeyName(107, "GoToParentFolder.bmp");
            this.imageList1.Images.SetKeyName(108, "GoToPrevious.bmp");
            this.imageList1.Images.SetKeyName(109, "GoToPreviousMessage.bmp");
            this.imageList1.Images.SetKeyName(110, "GoToPreviousRecord.bmp");
            this.imageList1.Images.SetKeyName(111, "GotoShortcuts.bmp");
            this.imageList1.Images.SetKeyName(112, "Graph.bmp");
            this.imageList1.Images.SetKeyName(113, "Help.bmp");
            this.imageList1.Images.SetKeyName(114, "Highlight.bmp");
            this.imageList1.Images.SetKeyName(115, "History.bmp");
            this.imageList1.Images.SetKeyName(116, "Home.bmp");
            this.imageList1.Images.SetKeyName(117, "HtmlBalanceBraces.bmp");
            this.imageList1.Images.SetKeyName(118, "HTMLPage.bmp");
            this.imageList1.Images.SetKeyName(119, "HTMLPassword.bmp");
            this.imageList1.Images.SetKeyName(120, "HTMLSubmit.bmp");
            this.imageList1.Images.SetKeyName(121, "ImagerScan.bmp");
            this.imageList1.Images.SetKeyName(122, "ImportXML.bmp");
            this.imageList1.Images.SetKeyName(123, "Indent.bmp");
            this.imageList1.Images.SetKeyName(124, "IndentRTL.bmp");
            this.imageList1.Images.SetKeyName(125, "InsertHyperlink.bmp");
            this.imageList1.Images.SetKeyName(126, "InsertPage.bmp");
            this.imageList1.Images.SetKeyName(127, "InsertPhotos.bmp");
            this.imageList1.Images.SetKeyName(128, "InsertPicture.bmp");
            this.imageList1.Images.SetKeyName(129, "InsertTabControl.bmp");
            this.imageList1.Images.SetKeyName(130, "Italic.bmp");
            this.imageList1.Images.SetKeyName(131, "Legend.bmp");
            this.imageList1.Images.SetKeyName(132, "LineColor.bmp");
            this.imageList1.Images.SetKeyName(133, "Link.bmp");
            this.imageList1.Images.SetKeyName(134, "LinkLabel.bmp");
            this.imageList1.Images.SetKeyName(135, "List_Bullets.bmp");
            this.imageList1.Images.SetKeyName(136, "List_Numbered.bmp");
            this.imageList1.Images.SetKeyName(137, "List_NumberedRTL.bmp");
            this.imageList1.Images.SetKeyName(138, "List_NumberedVertT.bmp");
            this.imageList1.Images.SetKeyName(139, "List_NumberedVertTB.bmp");
            this.imageList1.Images.SetKeyName(140, "MonthlyView.bmp");
            this.imageList1.Images.SetKeyName(141, "moveFolder.bmp");
            this.imageList1.Images.SetKeyName(142, "MoveToFolder.bmp");
            this.imageList1.Images.SetKeyName(143, "MultiplePages.bmp");
            this.imageList1.Images.SetKeyName(144, "MultiSelect.bmp");
            this.imageList1.Images.SetKeyName(145, "NavBack.bmp");
            this.imageList1.Images.SetKeyName(146, "NavForward.bmp");
            this.imageList1.Images.SetKeyName(147, "NewCard.bmp");
            this.imageList1.Images.SetKeyName(148, "NewDocument.bmp");
            this.imageList1.Images.SetKeyName(149, "NewFolder.bmp");
            this.imageList1.Images.SetKeyName(150, "NewMessage.bmp");
            this.imageList1.Images.SetKeyName(151, "NewReport.bmp");
            this.imageList1.Images.SetKeyName(152, "NewWebsite.bmp");
            this.imageList1.Images.SetKeyName(153, "NewWindow.bmp");
            this.imageList1.Images.SetKeyName(154, "NextPage.bmp");
            this.imageList1.Images.SetKeyName(155, "Note.bmp");
            this.imageList1.Images.SetKeyName(156, "Open.bmp");
            this.imageList1.Images.SetKeyName(157, "OpenFile.bmp");
            this.imageList1.Images.SetKeyName(158, "OpenFolder.bmp");
            this.imageList1.Images.SetKeyName(159, "openfolder_24.bmp");
            this.imageList1.Images.SetKeyName(160, "OpenSelectedItem.bmp");
            this.imageList1.Images.SetKeyName(161, "Options.bmp");
            this.imageList1.Images.SetKeyName(162, "Organizer.bmp");
            this.imageList1.Images.SetKeyName(163, "OrgChart.bmp");
            this.imageList1.Images.SetKeyName(164, "Outdent.bmp");
            this.imageList1.Images.SetKeyName(165, "PageNumber.bmp");
            this.imageList1.Images.SetKeyName(166, "PageUp.bmp");
            this.imageList1.Images.SetKeyName(167, "PageWidth.bmp");
            this.imageList1.Images.SetKeyName(168, "Paste.bmp");
            this.imageList1.Images.SetKeyName(169, "Pause.bmp");
            this.imageList1.Images.SetKeyName(170, "PauseRecorder.bmp");
            this.imageList1.Images.SetKeyName(171, "PieChart.bmp");
            this.imageList1.Images.SetKeyName(172, "PieChart3D.bmp");
            this.imageList1.Images.SetKeyName(173, "Play.bmp");
            this.imageList1.Images.SetKeyName(174, "Pointer.bmp");
            this.imageList1.Images.SetKeyName(175, "Portrait.bmp");
            this.imageList1.Images.SetKeyName(176, "PortraitToLandscapeView.bmp");
            this.imageList1.Images.SetKeyName(177, "PreviousPage.bmp");
            this.imageList1.Images.SetKeyName(178, "PrimaryKey.bmp");
            this.imageList1.Images.SetKeyName(179, "Print.bmp");
            this.imageList1.Images.SetKeyName(180, "PrintPreview.bmp");
            this.imageList1.Images.SetKeyName(181, "PrintPreviewDialog.bmp");
            this.imageList1.Images.SetKeyName(182, "PrintSetup.bmp");
            this.imageList1.Images.SetKeyName(183, "Properties.bmp");
            this.imageList1.Images.SetKeyName(184, "ProtectForm.bmp");
            this.imageList1.Images.SetKeyName(185, "ProtectSubdocument.bmp");
            this.imageList1.Images.SetKeyName(186, "PublishPlan.bmp");
            this.imageList1.Images.SetKeyName(187, "PublishToWeb.bmp");
            this.imageList1.Images.SetKeyName(188, "Pushpin.bmp");
            this.imageList1.Images.SetKeyName(189, "RadialChart.bmp");
            this.imageList1.Images.SetKeyName(190, "RecolorPicture.bmp");
            this.imageList1.Images.SetKeyName(191, "Record.bmp");
            this.imageList1.Images.SetKeyName(192, "Refresh.bmp");
            this.imageList1.Images.SetKeyName(193, "Refresh_Cancel.bmp");
            this.imageList1.Images.SetKeyName(194, "RefreshDocView.bmp");
            this.imageList1.Images.SetKeyName(195, "Relationships.bmp");
            this.imageList1.Images.SetKeyName(196, "Rename.bmp");
            this.imageList1.Images.SetKeyName(197, "Repeat.bmp");
            this.imageList1.Images.SetKeyName(198, "Resize.bmp");
            this.imageList1.Images.SetKeyName(199, "Restart.bmp");
            this.imageList1.Images.SetKeyName(200, "RightArrow.bmp");
            this.imageList1.Images.SetKeyName(201, "RightArrow2.bmp");
            this.imageList1.Images.SetKeyName(202, "RightsRestricted.bmp");
            this.imageList1.Images.SetKeyName(203, "RightToLeftDoucment.bmp");
            this.imageList1.Images.SetKeyName(204, "RoutingSlip.bmp");
            this.imageList1.Images.SetKeyName(205, "Save.bmp");
            this.imageList1.Images.SetKeyName(206, "SaveAll.bmp");
            this.imageList1.Images.SetKeyName(207, "SaveAsWebPage.bmp");
            this.imageList1.Images.SetKeyName(208, "SaveFormDesign.bmp");
            this.imageList1.Images.SetKeyName(209, "Search.bmp");
            this.imageList1.Images.SetKeyName(210, "SearchFolder.bmp");
            this.imageList1.Images.SetKeyName(211, "SearchInFolder.bmp");
            this.imageList1.Images.SetKeyName(212, "SearchWeb.bmp");
            this.imageList1.Images.SetKeyName(213, "Send.bmp");
            this.imageList1.Images.SetKeyName(214, "SendBackward.bmp");
            this.imageList1.Images.SetKeyName(215, "ShowAllComments.bmp");
            this.imageList1.Images.SetKeyName(216, "ShowGridlines.bmp");
            this.imageList1.Images.SetKeyName(217, "ShowGridlines2.bmp");
            this.imageList1.Images.SetKeyName(218, "ShowRulelines.bmp");
            this.imageList1.Images.SetKeyName(219, "ShowRuler.bmp");
            this.imageList1.Images.SetKeyName(220, "SortAscending_24.bmp");
            this.imageList1.Images.SetKeyName(221, "SortDescending_24.bmp");
            this.imageList1.Images.SetKeyName(222, "SpeechMic.bmp");
            this.imageList1.Images.SetKeyName(223, "SplitSubdocument.bmp");
            this.imageList1.Images.SetKeyName(224, "Stop.bmp");
            this.imageList1.Images.SetKeyName(225, "SychronizeList.bmp");
            this.imageList1.Images.SetKeyName(226, "Symbol.bmp");
            this.imageList1.Images.SetKeyName(227, "Table.bmp");
            this.imageList1.Images.SetKeyName(228, "Task.bmp");
            this.imageList1.Images.SetKeyName(229, "Textbox.bmp");
            this.imageList1.Images.SetKeyName(230, "ThumbnailLoading.bmp");
            this.imageList1.Images.SetKeyName(231, "ThumbnailView.bmp");
            this.imageList1.Images.SetKeyName(232, "TurnAhead.bmp");
            this.imageList1.Images.SetKeyName(233, "ViewThumbnails.bmp");
            this.imageList1.Images.SetKeyName(234, "Warning.bmp");
            this.imageList1.Images.SetKeyName(235, "Web.bmp");
            this.imageList1.Images.SetKeyName(236, "Windows.bmp");
            this.imageList1.Images.SetKeyName(237, "XMLFile.bmp");
            this.imageList1.Images.SetKeyName(238, "Zoom.bmp");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 297);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.rtf";
            this.openFileDialog1.FileName = "NewCoolDoc.rtf";
            this.openFileDialog1.Filter = "RTF files|*.rtf|TXT files|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.Filter = "RTF files|*.rtf|TXT files|*.txt";
            this.saveFileDialog1.Tag = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel1.Text = "text";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 369);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyTextEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискИЗаменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

