namespace WefghDrawing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTBRak = new RichTextBox();
            btnCalculator = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label40 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTable_Rafd_7 = new Label();
            lblTable_Rak_4 = new Label();
            lblTable_Rak_5 = new Label();
            lblTable_Rafd_2 = new Label();
            lblTable_Rak_6 = new Label();
            lblTable_Rafd_1 = new Label();
            lblTable_Rafd_8 = new Label();
            lblTable_Rak_3 = new Label();
            lblTable_Rafd_4 = new Label();
            lblTable_Rak_7 = new Label();
            lblTable_Rak_2 = new Label();
            lblTable_Rafd_5 = new Label();
            lblTable_Rafd_6 = new Label();
            lblTable_Rafd_3 = new Label();
            lblTable_Rak_8 = new Label();
            lblTable_Rak_1 = new Label();
            label3 = new Label();
            lblResult_Sum_Col_Row = new Label();
            lblResult_RafdMeftah = new Label();
            lblResult_Rafd = new Label();
            lblResult_RakMeftah = new Label();
            lblResult_Rak = new Label();
            richTBRafd = new RichTextBox();
            tabPage2 = new TabPage();
            label22 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            btnConfigSave = new Button();
            label5 = new Label();
            label4 = new Label();
            numericRafd = new NumericUpDown();
            numericRak = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRafd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRak).BeginInit();
            SuspendLayout();
            // 
            // richTBRak
            // 
            richTBRak.BackColor = Color.Lime;
            richTBRak.Font = new Font("Vazirmatn RD FD", 12F);
            richTBRak.Location = new Point(371, 42);
            richTBRak.Margin = new Padding(3, 4, 3, 4);
            richTBRak.Name = "richTBRak";
            richTBRak.RightToLeft = RightToLeft.Yes;
            richTBRak.Size = new Size(699, 40);
            richTBRak.TabIndex = 0;
            richTBRak.Text = "رضا مهدیه";
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(8, 416);
            btnCalculator.Margin = new Padding(3, 4, 3, 4);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(199, 45);
            btnCalculator.TabIndex = 1;
            btnCalculator.Text = "محاسبه";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Vazirmatn RD", 9.75F);
            label1.Location = new Point(849, 7);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(221, 32);
            label1.TabIndex = 2;
            label1.Text = "متن مورد نظر یا (رک) نام طالب + نام مادر:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1094, 500);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label40);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(lblResult_Sum_Col_Row);
            tabPage1.Controls.Add(lblResult_RafdMeftah);
            tabPage1.Controls.Add(lblResult_Rafd);
            tabPage1.Controls.Add(lblResult_RakMeftah);
            tabPage1.Controls.Add(lblResult_Rak);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTBRafd);
            tabPage1.Controls.Add(richTBRak);
            tabPage1.Controls.Add(btnCalculator);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1086, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "محاسبه";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            label40.Font = new Font("Vazirmatn RD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.Location = new Point(102, 16);
            label40.Name = "label40";
            label40.RightToLeft = RightToLeft.Yes;
            label40.Size = new Size(159, 32);
            label40.TabIndex = 8;
            label40.Text = "روش اول (احزب وجده)";
            label40.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_7, 3, 3);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_4, 2, 3);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_5, 1, 3);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_2, 0, 3);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_6, 3, 2);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_1, 2, 2);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_8, 1, 2);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_3, 0, 2);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_4, 3, 1);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_7, 2, 1);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_2, 1, 1);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_5, 0, 1);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_6, 2, 0);
            tableLayoutPanel2.Controls.Add(lblTable_Rafd_3, 1, 0);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_8, 0, 0);
            tableLayoutPanel2.Controls.Add(lblTable_Rak_1, 3, 0);
            tableLayoutPanel2.Font = new Font("Vazirmatn RD FD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(8, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(350, 350);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // lblTable_Rafd_7
            // 
            lblTable_Rafd_7.AutoSize = true;
            lblTable_Rafd_7.BackColor = Color.Yellow;
            lblTable_Rafd_7.Dock = DockStyle.Fill;
            lblTable_Rafd_7.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_7.Location = new Point(264, 261);
            lblTable_Rafd_7.Name = "lblTable_Rafd_7";
            lblTable_Rafd_7.Size = new Size(80, 86);
            lblTable_Rafd_7.TabIndex = 21;
            lblTable_Rafd_7.Text = "15";
            lblTable_Rafd_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_4
            // 
            lblTable_Rak_4.AutoSize = true;
            lblTable_Rak_4.BackColor = Color.Lime;
            lblTable_Rak_4.Dock = DockStyle.Fill;
            lblTable_Rak_4.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_4.Location = new Point(178, 261);
            lblTable_Rak_4.Name = "lblTable_Rak_4";
            lblTable_Rak_4.Size = new Size(77, 86);
            lblTable_Rak_4.TabIndex = 20;
            lblTable_Rak_4.Text = "4";
            lblTable_Rak_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_5
            // 
            lblTable_Rak_5.AutoSize = true;
            lblTable_Rak_5.BackColor = Color.Lime;
            lblTable_Rak_5.Dock = DockStyle.Fill;
            lblTable_Rak_5.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_5.Location = new Point(92, 261);
            lblTable_Rak_5.Name = "lblTable_Rak_5";
            lblTable_Rak_5.Size = new Size(77, 86);
            lblTable_Rak_5.TabIndex = 19;
            lblTable_Rak_5.Text = "5";
            lblTable_Rak_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_2
            // 
            lblTable_Rafd_2.AutoSize = true;
            lblTable_Rafd_2.BackColor = Color.Yellow;
            lblTable_Rafd_2.Dock = DockStyle.Fill;
            lblTable_Rafd_2.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_2.Location = new Point(6, 261);
            lblTable_Rafd_2.Name = "lblTable_Rafd_2";
            lblTable_Rafd_2.Size = new Size(77, 86);
            lblTable_Rafd_2.TabIndex = 18;
            lblTable_Rafd_2.Text = "10";
            lblTable_Rafd_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_6
            // 
            lblTable_Rak_6.AutoSize = true;
            lblTable_Rak_6.BackColor = Color.Lime;
            lblTable_Rak_6.Dock = DockStyle.Fill;
            lblTable_Rak_6.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_6.Location = new Point(264, 175);
            lblTable_Rak_6.Name = "lblTable_Rak_6";
            lblTable_Rak_6.Size = new Size(80, 83);
            lblTable_Rak_6.TabIndex = 17;
            lblTable_Rak_6.Text = "6";
            lblTable_Rak_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_1
            // 
            lblTable_Rafd_1.AutoSize = true;
            lblTable_Rafd_1.BackColor = Color.Yellow;
            lblTable_Rafd_1.Dock = DockStyle.Fill;
            lblTable_Rafd_1.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_1.Location = new Point(178, 175);
            lblTable_Rafd_1.Name = "lblTable_Rafd_1";
            lblTable_Rafd_1.Size = new Size(77, 83);
            lblTable_Rafd_1.TabIndex = 16;
            lblTable_Rafd_1.Text = "9";
            lblTable_Rafd_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_8
            // 
            lblTable_Rafd_8.AutoSize = true;
            lblTable_Rafd_8.BackColor = Color.Yellow;
            lblTable_Rafd_8.Dock = DockStyle.Fill;
            lblTable_Rafd_8.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_8.Location = new Point(92, 175);
            lblTable_Rafd_8.Name = "lblTable_Rafd_8";
            lblTable_Rafd_8.Size = new Size(77, 83);
            lblTable_Rafd_8.TabIndex = 15;
            lblTable_Rafd_8.Text = "16";
            lblTable_Rafd_8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_3
            // 
            lblTable_Rak_3.AutoSize = true;
            lblTable_Rak_3.BackColor = Color.Lime;
            lblTable_Rak_3.Dock = DockStyle.Fill;
            lblTable_Rak_3.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_3.Location = new Point(6, 175);
            lblTable_Rak_3.Name = "lblTable_Rak_3";
            lblTable_Rak_3.Size = new Size(77, 83);
            lblTable_Rak_3.TabIndex = 14;
            lblTable_Rak_3.Text = "3";
            lblTable_Rak_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_4
            // 
            lblTable_Rafd_4.AutoSize = true;
            lblTable_Rafd_4.BackColor = Color.Yellow;
            lblTable_Rafd_4.Dock = DockStyle.Fill;
            lblTable_Rafd_4.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_4.Location = new Point(264, 89);
            lblTable_Rafd_4.Name = "lblTable_Rafd_4";
            lblTable_Rafd_4.Size = new Size(80, 83);
            lblTable_Rafd_4.TabIndex = 13;
            lblTable_Rafd_4.Text = "12";
            lblTable_Rafd_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_7
            // 
            lblTable_Rak_7.AutoSize = true;
            lblTable_Rak_7.BackColor = Color.Lime;
            lblTable_Rak_7.Dock = DockStyle.Fill;
            lblTable_Rak_7.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_7.Location = new Point(178, 89);
            lblTable_Rak_7.Name = "lblTable_Rak_7";
            lblTable_Rak_7.Size = new Size(77, 83);
            lblTable_Rak_7.TabIndex = 12;
            lblTable_Rak_7.Text = "7";
            lblTable_Rak_7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_2
            // 
            lblTable_Rak_2.AutoSize = true;
            lblTable_Rak_2.BackColor = Color.Lime;
            lblTable_Rak_2.Dock = DockStyle.Fill;
            lblTable_Rak_2.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_2.Location = new Point(92, 89);
            lblTable_Rak_2.Name = "lblTable_Rak_2";
            lblTable_Rak_2.Size = new Size(77, 83);
            lblTable_Rak_2.TabIndex = 11;
            lblTable_Rak_2.Text = "2";
            lblTable_Rak_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_5
            // 
            lblTable_Rafd_5.AutoSize = true;
            lblTable_Rafd_5.BackColor = Color.Yellow;
            lblTable_Rafd_5.Dock = DockStyle.Fill;
            lblTable_Rafd_5.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_5.Location = new Point(6, 89);
            lblTable_Rafd_5.Name = "lblTable_Rafd_5";
            lblTable_Rafd_5.Size = new Size(77, 83);
            lblTable_Rafd_5.TabIndex = 10;
            lblTable_Rafd_5.Text = "13";
            lblTable_Rafd_5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_6
            // 
            lblTable_Rafd_6.AutoSize = true;
            lblTable_Rafd_6.BackColor = Color.Yellow;
            lblTable_Rafd_6.Dock = DockStyle.Fill;
            lblTable_Rafd_6.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_6.Location = new Point(178, 3);
            lblTable_Rafd_6.Name = "lblTable_Rafd_6";
            lblTable_Rafd_6.Size = new Size(77, 83);
            lblTable_Rafd_6.TabIndex = 9;
            lblTable_Rafd_6.Text = "14";
            lblTable_Rafd_6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rafd_3
            // 
            lblTable_Rafd_3.AutoSize = true;
            lblTable_Rafd_3.BackColor = Color.Yellow;
            lblTable_Rafd_3.Dock = DockStyle.Fill;
            lblTable_Rafd_3.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rafd_3.Location = new Point(92, 3);
            lblTable_Rafd_3.Name = "lblTable_Rafd_3";
            lblTable_Rafd_3.Size = new Size(77, 83);
            lblTable_Rafd_3.TabIndex = 8;
            lblTable_Rafd_3.Text = "11";
            lblTable_Rafd_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_8
            // 
            lblTable_Rak_8.AutoSize = true;
            lblTable_Rak_8.BackColor = Color.Lime;
            lblTable_Rak_8.Dock = DockStyle.Fill;
            lblTable_Rak_8.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_8.Location = new Point(6, 3);
            lblTable_Rak_8.Name = "lblTable_Rak_8";
            lblTable_Rak_8.Size = new Size(77, 83);
            lblTable_Rak_8.TabIndex = 7;
            lblTable_Rak_8.Text = "8";
            lblTable_Rak_8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTable_Rak_1
            // 
            lblTable_Rak_1.AutoSize = true;
            lblTable_Rak_1.BackColor = Color.Lime;
            lblTable_Rak_1.Dock = DockStyle.Fill;
            lblTable_Rak_1.Font = new Font("Vazirmatn RD FD", 12F);
            lblTable_Rak_1.Location = new Point(264, 3);
            lblTable_Rak_1.Name = "lblTable_Rak_1";
            lblTable_Rak_1.Size = new Size(80, 83);
            lblTable_Rak_1.TabIndex = 6;
            lblTable_Rak_1.Text = "1";
            lblTable_Rak_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Vazirmatn RD", 9.75F);
            label3.Location = new Point(904, 89);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(166, 32);
            label3.TabIndex = 2;
            label3.Text = "متن مورد نظر یا مطلوب(رفد):";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResult_Sum_Col_Row
            // 
            lblResult_Sum_Col_Row.BackColor = Color.FromArgb(192, 255, 192);
            lblResult_Sum_Col_Row.Font = new Font("Vazirmatn RD FD", 11.25F);
            lblResult_Sum_Col_Row.Location = new Point(829, 344);
            lblResult_Sum_Col_Row.Name = "lblResult_Sum_Col_Row";
            lblResult_Sum_Col_Row.Size = new Size(241, 32);
            lblResult_Sum_Col_Row.TabIndex = 2;
            lblResult_Sum_Col_Row.Text = "۰";
            lblResult_Sum_Col_Row.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult_RafdMeftah
            // 
            lblResult_RafdMeftah.BackColor = Color.FromArgb(192, 255, 192);
            lblResult_RafdMeftah.Font = new Font("Vazirmatn RD FD", 11.25F);
            lblResult_RafdMeftah.Location = new Point(581, 302);
            lblResult_RafdMeftah.Name = "lblResult_RafdMeftah";
            lblResult_RafdMeftah.Size = new Size(241, 32);
            lblResult_RafdMeftah.TabIndex = 2;
            lblResult_RafdMeftah.Text = "۰";
            lblResult_RafdMeftah.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult_Rafd
            // 
            lblResult_Rafd.BackColor = Color.FromArgb(192, 255, 192);
            lblResult_Rafd.Font = new Font("Vazirmatn RD FD", 11.25F);
            lblResult_Rafd.Location = new Point(829, 302);
            lblResult_Rafd.Name = "lblResult_Rafd";
            lblResult_Rafd.Size = new Size(241, 32);
            lblResult_Rafd.TabIndex = 2;
            lblResult_Rafd.Text = "۰";
            lblResult_Rafd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult_RakMeftah
            // 
            lblResult_RakMeftah.BackColor = Color.FromArgb(192, 255, 192);
            lblResult_RakMeftah.Font = new Font("Vazirmatn RD FD", 11.25F);
            lblResult_RakMeftah.Location = new Point(581, 261);
            lblResult_RakMeftah.Name = "lblResult_RakMeftah";
            lblResult_RakMeftah.Size = new Size(241, 32);
            lblResult_RakMeftah.TabIndex = 2;
            lblResult_RakMeftah.Text = "۰";
            lblResult_RakMeftah.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult_Rak
            // 
            lblResult_Rak.BackColor = Color.FromArgb(192, 255, 192);
            lblResult_Rak.Font = new Font("Vazirmatn RD FD", 11.25F);
            lblResult_Rak.Location = new Point(829, 261);
            lblResult_Rak.Name = "lblResult_Rak";
            lblResult_Rak.Size = new Size(241, 32);
            lblResult_Rak.TabIndex = 2;
            lblResult_Rak.Text = "۰";
            lblResult_Rak.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTBRafd
            // 
            richTBRafd.BackColor = Color.Yellow;
            richTBRafd.Font = new Font("Vazirmatn RD FD", 12F);
            richTBRafd.Location = new Point(371, 126);
            richTBRafd.Margin = new Padding(3, 4, 3, 4);
            richTBRafd.Name = "richTBRafd";
            richTBRafd.RightToLeft = RightToLeft.Yes;
            richTBRafd.Size = new Size(699, 122);
            richTBRafd.TabIndex = 0;
            richTBRafd.Text = "جلب المال";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1224, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "الگو";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.Font = new Font("Vazir Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(364, 15);
            label22.Name = "label22";
            label22.RightToLeft = RightToLeft.Yes;
            label22.Size = new Size(613, 223);
            label22.TabIndex = 6;
            label22.Text = resources.GetString("label22.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Vazir", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 25);
            label2.Name = "label2";
            label2.Size = new Size(259, 24);
            label2.TabIndex = 5;
            label2.Text = "الگوی و ترتیب پر کردن به روش احزب وجده";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label21, 3, 3);
            tableLayoutPanel1.Controls.Add(label20, 2, 3);
            tableLayoutPanel1.Controls.Add(label19, 1, 3);
            tableLayoutPanel1.Controls.Add(label18, 0, 3);
            tableLayoutPanel1.Controls.Add(label17, 3, 2);
            tableLayoutPanel1.Controls.Add(label16, 2, 2);
            tableLayoutPanel1.Controls.Add(label15, 1, 2);
            tableLayoutPanel1.Controls.Add(label14, 0, 2);
            tableLayoutPanel1.Controls.Add(label13, 3, 1);
            tableLayoutPanel1.Controls.Add(label12, 2, 1);
            tableLayoutPanel1.Controls.Add(label11, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(label8, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Location = new Point(8, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(350, 350);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Yellow;
            label21.Dock = DockStyle.Fill;
            label21.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label21.Location = new Point(264, 261);
            label21.Name = "label21";
            label21.Size = new Size(80, 86);
            label21.TabIndex = 21;
            label21.Text = "15";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Lime;
            label20.Dock = DockStyle.Fill;
            label20.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label20.Location = new Point(178, 261);
            label20.Name = "label20";
            label20.Size = new Size(77, 86);
            label20.TabIndex = 20;
            label20.Text = "4";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Lime;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label19.Location = new Point(92, 261);
            label19.Name = "label19";
            label19.Size = new Size(77, 86);
            label19.TabIndex = 19;
            label19.Text = "5";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Yellow;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label18.Location = new Point(6, 261);
            label18.Name = "label18";
            label18.Size = new Size(77, 86);
            label18.TabIndex = 18;
            label18.Text = "10";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Lime;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label17.Location = new Point(264, 175);
            label17.Name = "label17";
            label17.Size = new Size(80, 83);
            label17.TabIndex = 17;
            label17.Text = "6";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Yellow;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label16.Location = new Point(178, 175);
            label16.Name = "label16";
            label16.Size = new Size(77, 83);
            label16.TabIndex = 16;
            label16.Text = "9";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Yellow;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label15.Location = new Point(92, 175);
            label15.Name = "label15";
            label15.Size = new Size(77, 83);
            label15.TabIndex = 15;
            label15.Text = "16";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Lime;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label14.Location = new Point(6, 175);
            label14.Name = "label14";
            label14.Size = new Size(77, 83);
            label14.TabIndex = 14;
            label14.Text = "3";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Yellow;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label13.Location = new Point(264, 89);
            label13.Name = "label13";
            label13.Size = new Size(80, 83);
            label13.TabIndex = 13;
            label13.Text = "12";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Lime;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label12.Location = new Point(178, 89);
            label12.Name = "label12";
            label12.Size = new Size(77, 83);
            label12.TabIndex = 12;
            label12.Text = "7";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Lime;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label11.Location = new Point(92, 89);
            label11.Name = "label11";
            label11.Size = new Size(77, 83);
            label11.TabIndex = 11;
            label11.Text = "2";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Yellow;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label10.Location = new Point(6, 89);
            label10.Name = "label10";
            label10.Size = new Size(77, 83);
            label10.TabIndex = 10;
            label10.Text = "13";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Yellow;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label9.Location = new Point(178, 3);
            label9.Name = "label9";
            label9.Size = new Size(77, 83);
            label9.TabIndex = 9;
            label9.Text = "14";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label8.Location = new Point(92, 3);
            label8.Name = "label8";
            label8.Size = new Size(77, 83);
            label8.TabIndex = 8;
            label8.Text = "11";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Lime;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(77, 83);
            label7.TabIndex = 7;
            label7.Text = "8";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Lime;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Vazir Medium", 14.25F, FontStyle.Bold);
            label6.Location = new Point(264, 3);
            label6.Name = "label6";
            label6.Size = new Size(80, 83);
            label6.TabIndex = 6;
            label6.Text = "1";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnConfigSave);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(numericRafd);
            tabPage3.Controls.Add(numericRak);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1224, 472);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "تنظیمات";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConfigSave
            // 
            btnConfigSave.Location = new Point(22, 400);
            btnConfigSave.Name = "btnConfigSave";
            btnConfigSave.Size = new Size(145, 41);
            btnConfigSave.TabIndex = 2;
            btnConfigSave.Text = "ذخیره";
            btnConfigSave.UseVisualStyleBackColor = true;
            btnConfigSave.Click += btnConfigSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(927, 42);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(48, 21);
            label5.TabIndex = 1;
            label5.Text = "عدد رفد:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(927, 10);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(48, 21);
            label4.TabIndex = 1;
            label4.Text = "عدد رک:";
            // 
            // numericRafd
            // 
            numericRafd.Location = new Point(797, 38);
            numericRafd.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericRafd.Name = "numericRafd";
            numericRafd.Size = new Size(120, 26);
            numericRafd.TabIndex = 0;
            numericRafd.Value = new decimal(new int[] { 284, 0, 0, 0 });
            // 
            // numericRak
            // 
            numericRak.Location = new Point(797, 6);
            numericRak.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericRak.Name = "numericRak";
            numericRak.Size = new Size(120, 26);
            numericRak.TabIndex = 0;
            numericRak.Value = new decimal(new int[] { 220, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 500);
            Controls.Add(tabControl1);
            Font = new Font("Vazirmatn RD FD", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "محاسبه وفق رک و رفد";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRafd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRak).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTBRak;
        private Button btnCalculator;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private RichTextBox richTBRafd;
        private Label label4;
        private NumericUpDown numericRak;
        private Label label5;
        private NumericUpDown numericRafd;
        private Button btnConfigSave;
        private Label lblResult_Rafd;
        private Label lblResult_Rak;
        private Label lblResult_Sum_Col_Row;
        private Label lblResult_RafdMeftah;
        private Label lblResult_RakMeftah;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTable_Rafd_7;
        private Label lblTable_Rak_4;
        private Label lblTable_Rak_5;
        private Label lblTable_Rafd_2;
        private Label lblTable_Rak_6;
        private Label lblTable_Rafd_1;
        private Label lblTable_Rafd_8;
        private Label lblTable_Rak_3;
        private Label lblTable_Rafd_4;
        private Label lblTable_Rak_7;
        private Label lblTable_Rak_2;
        private Label lblTable_Rafd_5;
        private Label lblTable_Rafd_6;
        private Label lblTable_Rafd_3;
        private Label lblTable_Rak_8;
        private Label lblTable_Rak_1;
        private Label label22;
        private Label label40;
    }
}
