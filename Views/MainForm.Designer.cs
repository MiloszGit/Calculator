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
            buttonSum = new Button();
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
            tableLayoutPanel2.Controls.Add(buttonSum, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006218F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.998127F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(900, 602);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(453, 3);
            button3.Name = "button3";
            button3.Size = new Size(219, 144);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(228, 3);
            button2.Name = "button2";
            button2.Size = new Size(219, 144);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(219, 144);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(3, 153);
            button4.Name = "button4";
            button4.Size = new Size(219, 144);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.Location = new Point(228, 153);
            button5.Name = "button5";
            button5.Size = new Size(219, 144);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button6.Location = new Point(453, 153);
            button6.Name = "button6";
            button6.Size = new Size(219, 144);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button7.Location = new Point(3, 303);
            button7.Name = "button7";
            button7.Size = new Size(219, 144);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button8.Location = new Point(228, 303);
            button8.Name = "button8";
            button8.Size = new Size(219, 144);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button9.Location = new Point(453, 303);
            button9.Name = "button9";
            button9.Size = new Size(219, 144);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button0.Location = new Point(228, 453);
            button0.Name = "button0";
            button0.Size = new Size(219, 146);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LawnGreen;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdd.Location = new Point(678, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(219, 144);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.IndianRed;
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMinus.Location = new Point(678, 153);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(219, 144);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMno
            // 
            buttonMno.BackColor = Color.PaleTurquoise;
            buttonMno.Dock = DockStyle.Fill;
            buttonMno.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonMno.Location = new Point(678, 303);
            buttonMno.Name = "buttonMno";
            buttonMno.Size = new Size(219, 144);
            buttonMno.TabIndex = 12;
            buttonMno.Text = "*";
            buttonMno.UseVisualStyleBackColor = false;
            buttonMno.Click += buttonMno_Click;
            // 
            // buttonDzi
            // 
            buttonDzi.BackColor = SystemColors.ControlDarkDark;
            buttonDzi.Dock = DockStyle.Fill;
            buttonDzi.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonDzi.Location = new Point(678, 453);
            buttonDzi.Name = "buttonDzi";
            buttonDzi.Size = new Size(219, 146);
            buttonDzi.TabIndex = 13;
            buttonDzi.Text = "/";
            buttonDzi.UseVisualStyleBackColor = false;
            buttonDzi.Click += buttonDzi_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Red;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Location = new Point(3, 453);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(219, 146);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "x";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.PeachPuff;
            buttonSum.Dock = DockStyle.Fill;
            buttonSum.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSum.Location = new Point(453, 453);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(219, 146);
            buttonSum.TabIndex = 14;
            buttonSum.Text = "=";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
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
    }
}