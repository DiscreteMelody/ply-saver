namespace Plywood_Calculator
{
    partial class ShapesPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapesPane));
            this.newShapeGroupBox = new System.Windows.Forms.GroupBox();
            this.circleLabel = new System.Windows.Forms.Label();
            this.polygonLabel = new System.Windows.Forms.Label();
            this.editSidesGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newCircleButton = new Plywood_Calculator.RoundButton();
            this.newPolygonButton = new Plywood_Calculator.RoundButton();
            this.newShapeGroupBox.SuspendLayout();
            this.editSidesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newShapeGroupBox
            // 
            this.newShapeGroupBox.BackColor = System.Drawing.Color.White;
            this.newShapeGroupBox.Controls.Add(this.circleLabel);
            this.newShapeGroupBox.Controls.Add(this.newCircleButton);
            this.newShapeGroupBox.Controls.Add(this.polygonLabel);
            this.newShapeGroupBox.Controls.Add(this.newPolygonButton);
            this.newShapeGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShapeGroupBox.Location = new System.Drawing.Point(36, 41);
            this.newShapeGroupBox.Name = "newShapeGroupBox";
            this.newShapeGroupBox.Size = new System.Drawing.Size(203, 132);
            this.newShapeGroupBox.TabIndex = 0;
            this.newShapeGroupBox.TabStop = false;
            this.newShapeGroupBox.Text = "Add New";
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleLabel.Location = new System.Drawing.Point(122, 105);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(54, 19);
            this.circleLabel.TabIndex = 5;
            this.circleLabel.Text = "Circle";
            // 
            // polygonLabel
            // 
            this.polygonLabel.AutoSize = true;
            this.polygonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygonLabel.Location = new System.Drawing.Point(16, 105);
            this.polygonLabel.Name = "polygonLabel";
            this.polygonLabel.Size = new System.Drawing.Size(72, 19);
            this.polygonLabel.TabIndex = 3;
            this.polygonLabel.Text = "Polygon";
            // 
            // editSidesGroupBox
            // 
            this.editSidesGroupBox.BackColor = System.Drawing.Color.White;
            this.editSidesGroupBox.Controls.Add(this.textBox1);
            this.editSidesGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSidesGroupBox.ForeColor = System.Drawing.Color.Black;
            this.editSidesGroupBox.Location = new System.Drawing.Point(36, 180);
            this.editSidesGroupBox.Name = "editSidesGroupBox";
            this.editSidesGroupBox.Size = new System.Drawing.Size(200, 419);
            this.editSidesGroupBox.TabIndex = 1;
            this.editSidesGroupBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(7, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // newCircleButton
            // 
            this.newCircleButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newCircleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCircleButton.FlatAppearance.BorderSize = 0;
            this.newCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCircleButton.ForeColor = System.Drawing.Color.White;
            this.newCircleButton.Image = global::Plywood_Calculator.Properties.Resources.circle;
            this.newCircleButton.Location = new System.Drawing.Point(108, 23);
            this.newCircleButton.Margin = new System.Windows.Forms.Padding(0);
            this.newCircleButton.Name = "newCircleButton";
            this.newCircleButton.Size = new System.Drawing.Size(82, 82);
            this.newCircleButton.TabIndex = 4;
            this.newCircleButton.UseVisualStyleBackColor = false;
            // 
            // newPolygonButton
            // 
            this.newPolygonButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newPolygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPolygonButton.FlatAppearance.BorderSize = 0;
            this.newPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPolygonButton.ForeColor = System.Drawing.Color.White;
            this.newPolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("newPolygonButton.Image")));
            this.newPolygonButton.Location = new System.Drawing.Point(13, 23);
            this.newPolygonButton.Margin = new System.Windows.Forms.Padding(0);
            this.newPolygonButton.Name = "newPolygonButton";
            this.newPolygonButton.Size = new System.Drawing.Size(82, 82);
            this.newPolygonButton.TabIndex = 2;
            this.newPolygonButton.UseVisualStyleBackColor = false;
            // 
            // ShapesPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.editSidesGroupBox);
            this.Controls.Add(this.newShapeGroupBox);
            this.Name = "ShapesPane";
            this.Size = new System.Drawing.Size(969, 602);
            this.newShapeGroupBox.ResumeLayout(false);
            this.newShapeGroupBox.PerformLayout();
            this.editSidesGroupBox.ResumeLayout(false);
            this.editSidesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox newShapeGroupBox;
        private RoundButton newPolygonButton;
        private System.Windows.Forms.Label polygonLabel;
        private System.Windows.Forms.Label circleLabel;
        private RoundButton newCircleButton;
        private System.Windows.Forms.GroupBox editSidesGroupBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}
