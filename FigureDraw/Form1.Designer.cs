namespace FigureDraw
{
    partial class FigureDrawer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BColor = new System.Windows.Forms.Button();
            this.BLine = new System.Windows.Forms.Button();
            this.BTriangle = new System.Windows.Forms.Button();
            this.BRectangle = new System.Windows.Forms.Button();
            this.BSquare = new System.Windows.Forms.Button();
            this.BCircle = new System.Windows.Forms.Button();
            this.BEllipse = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.cdDraw = new System.Windows.Forms.ColorDialog();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BColor
            // 
            this.BColor.Location = new System.Drawing.Point(962, 10);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(154, 36);
            this.BColor.TabIndex = 1;
            this.BColor.Text = "Color";
            this.BColor.UseVisualStyleBackColor = true;
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // BLine
            // 
            this.BLine.Location = new System.Drawing.Point(961, 146);
            this.BLine.Name = "BLine";
            this.BLine.Size = new System.Drawing.Size(149, 40);
            this.BLine.TabIndex = 2;
            this.BLine.Text = "Line";
            this.BLine.UseVisualStyleBackColor = true;
            this.BLine.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BTriangle
            // 
            this.BTriangle.Location = new System.Drawing.Point(962, 192);
            this.BTriangle.Name = "BTriangle";
            this.BTriangle.Size = new System.Drawing.Size(149, 40);
            this.BTriangle.TabIndex = 2;
            this.BTriangle.Text = "Triangle";
            this.BTriangle.UseVisualStyleBackColor = true;
            this.BTriangle.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BRectangle
            // 
            this.BRectangle.Location = new System.Drawing.Point(962, 238);
            this.BRectangle.Name = "BRectangle";
            this.BRectangle.Size = new System.Drawing.Size(149, 40);
            this.BRectangle.TabIndex = 2;
            this.BRectangle.Text = "Rectangle";
            this.BRectangle.UseVisualStyleBackColor = true;
            this.BRectangle.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BSquare
            // 
            this.BSquare.Location = new System.Drawing.Point(962, 284);
            this.BSquare.Name = "BSquare";
            this.BSquare.Size = new System.Drawing.Size(149, 40);
            this.BSquare.TabIndex = 2;
            this.BSquare.Text = "Square";
            this.BSquare.UseVisualStyleBackColor = true;
            this.BSquare.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BCircle
            // 
            this.BCircle.Location = new System.Drawing.Point(962, 330);
            this.BCircle.Name = "BCircle";
            this.BCircle.Size = new System.Drawing.Size(149, 40);
            this.BCircle.TabIndex = 2;
            this.BCircle.Text = "Circle";
            this.BCircle.UseVisualStyleBackColor = true;
            this.BCircle.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BEllipse
            // 
            this.BEllipse.Location = new System.Drawing.Point(962, 376);
            this.BEllipse.Name = "BEllipse";
            this.BEllipse.Size = new System.Drawing.Size(149, 40);
            this.BEllipse.TabIndex = 2;
            this.BEllipse.Text = "Ellipse";
            this.BEllipse.UseVisualStyleBackColor = true;
            this.BEllipse.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(962, 451);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(149, 40);
            this.BClear.TabIndex = 2;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox.IntegralHeight = false;
            this.comboBox.Location = new System.Drawing.Point(12, 10);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(326, 24);
            this.comboBox.TabIndex = 3;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(962, 65);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(154, 22);
            this.numericUpDown.TabIndex = 4;
            this.numericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // FigureDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 700);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BEllipse);
            this.Controls.Add(this.BCircle);
            this.Controls.Add(this.BSquare);
            this.Controls.Add(this.BRectangle);
            this.Controls.Add(this.BTriangle);
            this.Controls.Add(this.BLine);
            this.Controls.Add(this.BColor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FigureDrawer";
            this.Text = "FigureDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.Button BLine;
        private System.Windows.Forms.Button BTriangle;
        private System.Windows.Forms.Button BRectangle;
        private System.Windows.Forms.Button BSquare;
        private System.Windows.Forms.Button BCircle;
        private System.Windows.Forms.Button BEllipse;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.ColorDialog cdDraw;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

