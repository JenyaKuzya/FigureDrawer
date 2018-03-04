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
            this.BLine = new System.Windows.Forms.Button();
            this.BSquare = new System.Windows.Forms.Button();
            this.BTriangle = new System.Windows.Forms.Button();
            this.BRectangle = new System.Windows.Forms.Button();
            this.BEllipse = new System.Windows.Forms.Button();
            this.BCircle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 487);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BLine
            // 
            this.BLine.Location = new System.Drawing.Point(628, 120);
            this.BLine.Name = "BLine";
            this.BLine.Size = new System.Drawing.Size(157, 33);
            this.BLine.TabIndex = 1;
            this.BLine.Text = "Line";
            this.BLine.UseVisualStyleBackColor = true;
            this.BLine.Click += new System.EventHandler(this.BLine_Click);
            // 
            // BSquare
            // 
            this.BSquare.Location = new System.Drawing.Point(628, 198);
            this.BSquare.Name = "BSquare";
            this.BSquare.Size = new System.Drawing.Size(157, 33);
            this.BSquare.TabIndex = 1;
            this.BSquare.Text = "Square";
            this.BSquare.UseVisualStyleBackColor = true;
            this.BSquare.Click += new System.EventHandler(this.BSquare_Click);
            // 
            // BTriangle
            // 
            this.BTriangle.Location = new System.Drawing.Point(628, 159);
            this.BTriangle.Name = "BTriangle";
            this.BTriangle.Size = new System.Drawing.Size(157, 33);
            this.BTriangle.TabIndex = 1;
            this.BTriangle.Text = "Triangle";
            this.BTriangle.UseVisualStyleBackColor = true;
            this.BTriangle.Click += new System.EventHandler(this.BTriangle_Click);
            // 
            // BRectangle
            // 
            this.BRectangle.Location = new System.Drawing.Point(628, 237);
            this.BRectangle.Name = "BRectangle";
            this.BRectangle.Size = new System.Drawing.Size(157, 33);
            this.BRectangle.TabIndex = 1;
            this.BRectangle.Text = "Rectangle";
            this.BRectangle.UseVisualStyleBackColor = true;
            this.BRectangle.Click += new System.EventHandler(this.BRectangle_Click);
            // 
            // BEllipse
            // 
            this.BEllipse.Location = new System.Drawing.Point(628, 315);
            this.BEllipse.Name = "BEllipse";
            this.BEllipse.Size = new System.Drawing.Size(157, 33);
            this.BEllipse.TabIndex = 1;
            this.BEllipse.Text = "Ellipse";
            this.BEllipse.UseVisualStyleBackColor = true;
            this.BEllipse.Click += new System.EventHandler(this.BEllipse_Click);
            // 
            // BCircle
            // 
            this.BCircle.Location = new System.Drawing.Point(628, 276);
            this.BCircle.Name = "BCircle";
            this.BCircle.Size = new System.Drawing.Size(157, 33);
            this.BCircle.TabIndex = 1;
            this.BCircle.Text = "Circle";
            this.BCircle.UseVisualStyleBackColor = true;
            this.BCircle.Click += new System.EventHandler(this.BCircle_Click);
            // 
            // FigureDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.BCircle);
            this.Controls.Add(this.BEllipse);
            this.Controls.Add(this.BRectangle);
            this.Controls.Add(this.BTriangle);
            this.Controls.Add(this.BSquare);
            this.Controls.Add(this.BLine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FigureDrawer";
            this.Text = "FigureDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BLine;
        private System.Windows.Forms.Button BSquare;
        private System.Windows.Forms.Button BTriangle;
        private System.Windows.Forms.Button BRectangle;
        private System.Windows.Forms.Button BEllipse;
        private System.Windows.Forms.Button BCircle;
    }
}

