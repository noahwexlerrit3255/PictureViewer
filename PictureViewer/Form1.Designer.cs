namespace PictureViewer
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            closeButton = new Button();
            backgroundButton = new Button();
            clearButton = new Button();
            showButton = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.1583214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.84168F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.9565F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0434971F));
            tableLayoutPanel1.Size = new Size(851, 599);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(845, 532);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(closeButton);
            flowLayoutPanel1.Controls.Add(backgroundButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(showButton);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(183, 541);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(665, 55);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeButton.Enabled = false;
            closeButton.Location = new Point(6, 6);
            closeButton.Margin = new Padding(6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(65, 35);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.TextAlign = ContentAlignment.MiddleRight;
            closeButton.UseVisualStyleBackColor = true;
            // 
            // backgroundButton
            // 
            backgroundButton.AutoSize = true;
            backgroundButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backgroundButton.Location = new Point(83, 6);
            backgroundButton.Margin = new Padding(6);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(225, 35);
            backgroundButton.TabIndex = 1;
            backgroundButton.Text = "Set the Background Color";
            backgroundButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearButton.Location = new Point(320, 6);
            clearButton.Margin = new Padding(6);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(152, 35);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear The Picture";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showButton.Location = new Point(484, 6);
            showButton.Margin = new Padding(6);
            showButton.Name = "showButton";
            showButton.Size = new Size(138, 35);
            showButton.TabIndex = 4;
            showButton.Text = "Show a Picture";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(3, 50);
            button4.Name = "button4";
            button4.Size = new Size(152, 35);
            button4.TabIndex = 3;
            button4.Text = "Clear The Picture";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 541);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a picture file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 599);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "PictureViewer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button closeButton;
        private Button backgroundButton;
        private Button clearButton;
        private Button showButton;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private CheckBox checkBox1;
    }
}
