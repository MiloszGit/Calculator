namespace kalkulator.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button13 = new Button();
            button11 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            buttonMno = new Button();
            buttonDzi = new Button();
            buttonClear = new Button();
            button10 = new Button();
            buttonSum = new Button();
            button12 = new Button();
            textBoxResult = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxResult, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(906, 708);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button13, 0, 4);
            tableLayoutPanel2.Controls.Add(button11, 2, 3);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button4, 0, 1);
            tableLayoutPanel2.Controls.Add(button5, 1, 1);
            tableLayoutPanel2.Controls.Add(button6, 2, 1);
            tableLayoutPanel2.Controls.Add(button7, 0, 2);
            tableLayoutPanel2.Controls.Add(button8, 1, 2);
            tableLayoutPanel2.Controls.Add(button9, 2, 2);
            tableLayoutPanel2.Controls.Add(button0, 1, 3);
            tableLayoutPanel2.Controls.Add(buttonAdd, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonMinus, 3, 1);
            tableLayoutPanel2.Controls.Add(buttonMno, 3, 2);
            tableLayoutPanel2.Controls.Add(buttonDzi, 3, 3);
            tableLayoutPanel2.Controls.Add(buttonClear, 0, 3);
            tableLayoutPanel2.Controls.Add(button10, 3, 4);
            tableLayoutPanel2.Controls.Add(buttonSum, 2, 4);
            tableLayoutPanel2.Controls.Add(button12, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0004959F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0005016F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0004978F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9985027F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(900, 602);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkRed;
            button13.Dock = DockStyle.Fill;
            button13.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button13.Location = new Point(3, 483);
            button13.Name = "button13";
            button13.Size = new Size(219, 116);
            button13.TabIndex = 21;
            button13.Text = "CLOSE APP";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.Dock = DockStyle.Fill;
            button11.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button11.Location = new Point(453, 363);
            button11.Name = "button11";
            button11.Size = new Size(219, 114);
            button11.TabIndex = 19;
            button11.Text = "00";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(453, 3);
            button3.Name = "button3";
            button3.Size = new Size(219, 114);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(228, 3);
            button2.Name = "button2";
            button2.Size = new Size(219, 114);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(219, 114);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(3, 123);
            button4.Name = "button4";
            button4.Size = new Size(219, 114);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.Location = new Point(228, 123);
            button5.Name = "button5";
            button5.Size = new Size(219, 114);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button6.Location = new Point(453, 123);
            button6.Name = "button6";
            button6.Size = new Size(219, 114);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button7.Location = new Point(3, 243);
            button7.Name = "button7";
            button7.Size = new Size(219, 114);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button8.Location = new Point(228, 243);
            button8.Name = "button8";
            button8.Size = new Size(219, 114);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button9.Location = new Point(453, 243);
            button9.Name = "button9";
            button9.Size = new Size(219, 114);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Cursor = Cursors.Hand;
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button0.Location = new Point(228, 363);
            button0.Name = "button0";
            button0.Size = new Size(219, 114);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LawnGreen;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdd.Location = new Point(678, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(219, 114);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.IndianRed;
            buttonMinus.Cursor = Cursors.Hand;
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMinus.Location = new Point(678, 123);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(219, 114);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMno
            // 
            buttonMno.BackColor = Color.PaleTurquoise;
            buttonMno.Cursor = Cursors.Hand;
            buttonMno.Dock = DockStyle.Fill;
            buttonMno.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMno.Location = new Point(678, 243);
            buttonMno.Name = "buttonMno";
            buttonMno.Size = new Size(219, 114);
            buttonMno.TabIndex = 12;
            buttonMno.Text = "*";
            buttonMno.UseVisualStyleBackColor = false;
            buttonMno.Click += buttonMno_Click;
            // 
            // buttonDzi
            // 
            buttonDzi.BackColor = SystemColors.ControlDarkDark;
            buttonDzi.Cursor = Cursors.Hand;
            buttonDzi.Dock = DockStyle.Fill;
            buttonDzi.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonDzi.Location = new Point(678, 363);
            buttonDzi.Name = "buttonDzi";
            buttonDzi.Size = new Size(219, 114);
            buttonDzi.TabIndex = 13;
            buttonDzi.Text = "/";
            buttonDzi.UseVisualStyleBackColor = false;
            buttonDzi.Click += buttonDzi_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Red;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Location = new Point(3, 363);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(219, 114);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "x";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.Cursor = Cursors.Hand;
            button10.Dock = DockStyle.Fill;
            button10.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button10.Location = new Point(678, 483);
            button10.Name = "button10";
            button10.Size = new Size(219, 116);
            button10.TabIndex = 14;
            button10.Text = ",";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.PeachPuff;
            buttonSum.Cursor = Cursors.Hand;
            buttonSum.Dock = DockStyle.Fill;
            buttonSum.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSum.Location = new Point(453, 483);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(219, 116);
            buttonSum.TabIndex = 14;
            buttonSum.Text = "=";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.AppWorkspace;
            button12.Dock = DockStyle.Fill;
            button12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button12.Location = new Point(228, 483);
            button12.Name = "button12";
            button12.Size = new Size(219, 116);
            button12.TabIndex = 20;
            button12.Text = "VIEW ON GITHUB";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.HighlightText;
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxResult.Location = new Point(3, 3);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(900, 93);
            textBoxResult.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(906, 708);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Kalkulator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonAdd;
        private Button buttonMinus;
        private Button buttonMno;
        private Button buttonDzi;
        private Button buttonSum;
        private TextBox textBoxResult;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button buttonClear;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button12;
    }
}