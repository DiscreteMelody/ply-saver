namespace Plywood_Calculator
{
    partial class plysaverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plysaverForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.selectedPanel = new System.Windows.Forms.Panel();
            this.shapesButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.shapesPanel = new System.Windows.Forms.Panel();
            this.addedShapesGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapePreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.fillerlabel1 = new System.Windows.Forms.Label();
            this.shapePreviewPicBox = new System.Windows.Forms.PictureBox();
            this.dimensionsGroupBox = new System.Windows.Forms.GroupBox();
            this.thicknessTextBox = new System.Windows.Forms.TextBox();
            this.addSideButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.obtuseLabel = new System.Windows.Forms.Label();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.dimensionLabel = new System.Windows.Forms.Label();
            this.shapeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.dimensionsPanel = new System.Windows.Forms.Panel();
            this.sideCountLabel = new System.Windows.Forms.Label();
            this.obtuseCheckBox = new System.Windows.Forms.CheckBox();
            this.dimensionTextBox = new System.Windows.Forms.TextBox();
            this.newShapeGroupBox = new System.Windows.Forms.GroupBox();
            this.circleLabel = new System.Windows.Forms.Label();
            this.newCircleButton = new Plywood_Calculator.RoundButton();
            this.polygonLabel = new System.Windows.Forms.Label();
            this.newPolygonButton = new Plywood_Calculator.RoundButton();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.shapesPanel.SuspendLayout();
            this.addedShapesGroupBox.SuspendLayout();
            this.shapePreviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePreviewPicBox)).BeginInit();
            this.dimensionsGroupBox.SuspendLayout();
            this.dimensionsPanel.SuspendLayout();
            this.newShapeGroupBox.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.sidePanel.Controls.Add(this.selectedPanel);
            this.sidePanel.Controls.Add(this.shapesButton);
            this.sidePanel.Controls.Add(this.calculateButton);
            this.sidePanel.Controls.Add(this.helpButton);
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(169, 667);
            this.sidePanel.TabIndex = 0;
            // 
            // selectedPanel
            // 
            this.selectedPanel.BackColor = System.Drawing.Color.White;
            this.selectedPanel.Enabled = false;
            this.selectedPanel.Location = new System.Drawing.Point(0, 66);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.Size = new System.Drawing.Size(20, 120);
            this.selectedPanel.TabIndex = 2;
            this.selectedPanel.Visible = false;
            // 
            // shapesButton
            // 
            this.shapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shapesButton.FlatAppearance.BorderSize = 0;
            this.shapesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapesButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapesButton.ForeColor = System.Drawing.Color.White;
            this.shapesButton.Image = global::Plywood_Calculator.Properties.Resources.shapes;
            this.shapesButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shapesButton.Location = new System.Drawing.Point(0, 66);
            this.shapesButton.Name = "shapesButton";
            this.shapesButton.Size = new System.Drawing.Size(169, 120);
            this.shapesButton.TabIndex = 0;
            this.shapesButton.Text = "Shapes";
            this.shapesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shapesButton.UseVisualStyleBackColor = true;
            this.shapesButton.Click += new System.EventHandler(this.shapesButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Image = ((System.Drawing.Image)(resources.GetObject("calculateButton.Image")));
            this.calculateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calculateButton.Location = new System.Drawing.Point(0, 186);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(169, 120);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = global::Plywood_Calculator.Properties.Resources.help;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.Location = new System.Drawing.Point(0, 306);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(169, 120);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "Help";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(0, 547);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(169, 120);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.shapesPanel.Controls.Add(this.addedShapesGroupBox);
            this.shapesPanel.Controls.Add(this.shapePreviewGroupBox);
            this.shapesPanel.Controls.Add(this.dimensionsGroupBox);
            this.shapesPanel.Controls.Add(this.newShapeGroupBox);
            this.shapesPanel.Location = new System.Drawing.Point(169, 66);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(969, 601);
            this.shapesPanel.TabIndex = 2;
            // 
            // addedShapesGroupBox
            // 
            this.addedShapesGroupBox.BackColor = System.Drawing.Color.White;
            this.addedShapesGroupBox.Controls.Add(this.label1);
            this.addedShapesGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedShapesGroupBox.Location = new System.Drawing.Point(6, 388);
            this.addedShapesGroupBox.Name = "addedShapesGroupBox";
            this.addedShapesGroupBox.Size = new System.Drawing.Size(701, 210);
            this.addedShapesGroupBox.TabIndex = 6;
            this.addedShapesGroupBox.TabStop = false;
            this.addedShapesGroupBox.Text = "Current List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "brief info about each shape added will go here";
            // 
            // shapePreviewGroupBox
            // 
            this.shapePreviewGroupBox.BackColor = System.Drawing.Color.White;
            this.shapePreviewGroupBox.Controls.Add(this.fillerlabel1);
            this.shapePreviewGroupBox.Controls.Add(this.shapePreviewPicBox);
            this.shapePreviewGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapePreviewGroupBox.Location = new System.Drawing.Point(6, 8);
            this.shapePreviewGroupBox.Name = "shapePreviewGroupBox";
            this.shapePreviewGroupBox.Size = new System.Drawing.Size(701, 374);
            this.shapePreviewGroupBox.TabIndex = 5;
            this.shapePreviewGroupBox.TabStop = false;
            this.shapePreviewGroupBox.Text = "Preview";
            // 
            // fillerlabel1
            // 
            this.fillerlabel1.AutoSize = true;
            this.fillerlabel1.Location = new System.Drawing.Point(214, 178);
            this.fillerlabel1.Name = "fillerlabel1";
            this.fillerlabel1.Size = new System.Drawing.Size(216, 19);
            this.fillerlabel1.TabIndex = 1;
            this.fillerlabel1.Text = "shape preview will go here";
            // 
            // shapePreviewPicBox
            // 
            this.shapePreviewPicBox.Location = new System.Drawing.Point(14, 26);
            this.shapePreviewPicBox.Name = "shapePreviewPicBox";
            this.shapePreviewPicBox.Size = new System.Drawing.Size(672, 336);
            this.shapePreviewPicBox.TabIndex = 0;
            this.shapePreviewPicBox.TabStop = false;
            // 
            // dimensionsGroupBox
            // 
            this.dimensionsGroupBox.Controls.Add(this.thicknessTextBox);
            this.dimensionsGroupBox.Controls.Add(this.addSideButton);
            this.dimensionsGroupBox.Controls.Add(this.quantityLabel);
            this.dimensionsGroupBox.Controls.Add(this.addShapeButton);
            this.dimensionsGroupBox.Controls.Add(this.obtuseLabel);
            this.dimensionsGroupBox.Controls.Add(this.thicknessLabel);
            this.dimensionsGroupBox.Controls.Add(this.dimensionLabel);
            this.dimensionsGroupBox.Controls.Add(this.shapeQuantityTextBox);
            this.dimensionsGroupBox.Controls.Add(this.dimensionsPanel);
            this.dimensionsGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionsGroupBox.Location = new System.Drawing.Point(714, 8);
            this.dimensionsGroupBox.Name = "dimensionsGroupBox";
            this.dimensionsGroupBox.Size = new System.Drawing.Size(252, 590);
            this.dimensionsGroupBox.TabIndex = 4;
            this.dimensionsGroupBox.TabStop = false;
            this.dimensionsGroupBox.Text = "Dimensions";
            this.dimensionsGroupBox.Visible = false;
            this.dimensionsGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dimensionsGroupBox_Paint);
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thicknessTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thicknessTextBox.Location = new System.Drawing.Point(159, 455);
            this.thicknessTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(70, 20);
            this.thicknessTextBox.TabIndex = 11;
            this.thicknessTextBox.Text = ".5";
            this.thicknessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addSideButton
            // 
            this.addSideButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addSideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSideButton.FlatAppearance.BorderSize = 0;
            this.addSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSideButton.ForeColor = System.Drawing.Color.White;
            this.addSideButton.Location = new System.Drawing.Point(68, 26);
            this.addSideButton.Name = "addSideButton";
            this.addSideButton.Size = new System.Drawing.Size(117, 48);
            this.addSideButton.TabIndex = 6;
            this.addSideButton.Text = "Add Side";
            this.addSideButton.UseVisualStyleBackColor = false;
            this.addSideButton.Click += new System.EventHandler(this.addSideButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Location = new System.Drawing.Point(23, 389);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(134, 19);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity to Add:";
            // 
            // addShapeButton
            // 
            this.addShapeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addShapeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addShapeButton.FlatAppearance.BorderSize = 0;
            this.addShapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addShapeButton.ForeColor = System.Drawing.Color.White;
            this.addShapeButton.Location = new System.Drawing.Point(51, 522);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(155, 59);
            this.addShapeButton.TabIndex = 10;
            this.addShapeButton.Text = "Add Shape";
            this.addShapeButton.UseVisualStyleBackColor = false;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // obtuseLabel
            // 
            this.obtuseLabel.AutoSize = true;
            this.obtuseLabel.Location = new System.Drawing.Point(172, 87);
            this.obtuseLabel.Name = "obtuseLabel";
            this.obtuseLabel.Size = new System.Drawing.Size(65, 38);
            this.obtuseLabel.TabIndex = 5;
            this.obtuseLabel.Text = "Obtuse\r\nAngle?";
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.BackColor = System.Drawing.Color.Transparent;
            this.thicknessLabel.Location = new System.Drawing.Point(26, 456);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(131, 19);
            this.thicknessLabel.TabIndex = 12;
            this.thicknessLabel.Text = "Sheet Thickness:";
            // 
            // dimensionLabel
            // 
            this.dimensionLabel.AutoSize = true;
            this.dimensionLabel.Location = new System.Drawing.Point(42, 106);
            this.dimensionLabel.Name = "dimensionLabel";
            this.dimensionLabel.Size = new System.Drawing.Size(116, 19);
            this.dimensionLabel.TabIndex = 4;
            this.dimensionLabel.Text = "Length of Side";
            // 
            // shapeQuantityTextBox
            // 
            this.shapeQuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeQuantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeQuantityTextBox.Location = new System.Drawing.Point(159, 388);
            this.shapeQuantityTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.shapeQuantityTextBox.Name = "shapeQuantityTextBox";
            this.shapeQuantityTextBox.Size = new System.Drawing.Size(70, 20);
            this.shapeQuantityTextBox.TabIndex = 8;
            this.shapeQuantityTextBox.Text = "1";
            this.shapeQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dimensionsPanel
            // 
            this.dimensionsPanel.AutoScroll = true;
            this.dimensionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.dimensionsPanel.Controls.Add(this.sideCountLabel);
            this.dimensionsPanel.Controls.Add(this.obtuseCheckBox);
            this.dimensionsPanel.Controls.Add(this.dimensionTextBox);
            this.dimensionsPanel.Location = new System.Drawing.Point(6, 129);
            this.dimensionsPanel.Name = "dimensionsPanel";
            this.dimensionsPanel.Size = new System.Drawing.Size(240, 203);
            this.dimensionsPanel.TabIndex = 3;
            this.dimensionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dimensionsPanel_Paint);
            // 
            // sideCountLabel
            // 
            this.sideCountLabel.AutoSize = true;
            this.sideCountLabel.Location = new System.Drawing.Point(4, 6);
            this.sideCountLabel.Name = "sideCountLabel";
            this.sideCountLabel.Size = new System.Drawing.Size(18, 19);
            this.sideCountLabel.TabIndex = 5;
            this.sideCountLabel.Text = "1";
            // 
            // obtuseCheckBox
            // 
            this.obtuseCheckBox.AutoSize = true;
            this.obtuseCheckBox.Location = new System.Drawing.Point(189, 12);
            this.obtuseCheckBox.Name = "obtuseCheckBox";
            this.obtuseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.obtuseCheckBox.TabIndex = 1;
            this.obtuseCheckBox.UseVisualStyleBackColor = true;
            // 
            // dimensionTextBox
            // 
            this.dimensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dimensionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionTextBox.Location = new System.Drawing.Point(38, 6);
            this.dimensionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.dimensionTextBox.Name = "dimensionTextBox";
            this.dimensionTextBox.Size = new System.Drawing.Size(112, 20);
            this.dimensionTextBox.TabIndex = 0;
            // 
            // newShapeGroupBox
            // 
            this.newShapeGroupBox.BackColor = System.Drawing.Color.White;
            this.newShapeGroupBox.Controls.Add(this.circleLabel);
            this.newShapeGroupBox.Controls.Add(this.newCircleButton);
            this.newShapeGroupBox.Controls.Add(this.polygonLabel);
            this.newShapeGroupBox.Controls.Add(this.newPolygonButton);
            this.newShapeGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShapeGroupBox.Location = new System.Drawing.Point(713, 8);
            this.newShapeGroupBox.Name = "newShapeGroupBox";
            this.newShapeGroupBox.Size = new System.Drawing.Size(253, 171);
            this.newShapeGroupBox.TabIndex = 2;
            this.newShapeGroupBox.TabStop = false;
            this.newShapeGroupBox.Text = "Create New";
            this.newShapeGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.newShapeGroupBox_Paint);
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.BackColor = System.Drawing.Color.Transparent;
            this.circleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circleLabel.Location = new System.Drawing.Point(154, 129);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(54, 19);
            this.circleLabel.TabIndex = 5;
            this.circleLabel.Text = "Circle";
            this.circleLabel.Click += new System.EventHandler(this.newCircleButton_Click);
            // 
            // newCircleButton
            // 
            this.newCircleButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newCircleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCircleButton.FlatAppearance.BorderSize = 0;
            this.newCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCircleButton.ForeColor = System.Drawing.Color.White;
            this.newCircleButton.Image = global::Plywood_Calculator.Properties.Resources.circle;
            this.newCircleButton.Location = new System.Drawing.Point(140, 36);
            this.newCircleButton.Margin = new System.Windows.Forms.Padding(0);
            this.newCircleButton.Name = "newCircleButton";
            this.newCircleButton.Size = new System.Drawing.Size(82, 82);
            this.newCircleButton.TabIndex = 4;
            this.newCircleButton.UseVisualStyleBackColor = false;
            this.newCircleButton.Click += new System.EventHandler(this.newCircleButton_Click);
            // 
            // polygonLabel
            // 
            this.polygonLabel.AutoSize = true;
            this.polygonLabel.BackColor = System.Drawing.Color.Transparent;
            this.polygonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygonLabel.Location = new System.Drawing.Point(30, 129);
            this.polygonLabel.Name = "polygonLabel";
            this.polygonLabel.Size = new System.Drawing.Size(72, 19);
            this.polygonLabel.TabIndex = 3;
            this.polygonLabel.Text = "Polygon";
            // 
            // newPolygonButton
            // 
            this.newPolygonButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newPolygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPolygonButton.FlatAppearance.BorderSize = 0;
            this.newPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPolygonButton.ForeColor = System.Drawing.Color.White;
            this.newPolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("newPolygonButton.Image")));
            this.newPolygonButton.Location = new System.Drawing.Point(27, 36);
            this.newPolygonButton.Margin = new System.Windows.Forms.Padding(0);
            this.newPolygonButton.Name = "newPolygonButton";
            this.newPolygonButton.Size = new System.Drawing.Size(82, 82);
            this.newPolygonButton.TabIndex = 2;
            this.newPolygonButton.UseVisualStyleBackColor = false;
            this.newPolygonButton.Click += new System.EventHandler(this.newPolygonButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(7, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(161, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Ply-Saver";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(169, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(969, 68);
            this.headerPanel.TabIndex = 1;
            // 
            // plysaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 667);
            this.Controls.Add(this.shapesPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "plysaverForm";
            this.Text = "Ply-Saver";
            this.Load += new System.EventHandler(this.plywoodForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.shapesPanel.ResumeLayout(false);
            this.addedShapesGroupBox.ResumeLayout(false);
            this.addedShapesGroupBox.PerformLayout();
            this.shapePreviewGroupBox.ResumeLayout(false);
            this.shapePreviewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePreviewPicBox)).EndInit();
            this.dimensionsGroupBox.ResumeLayout(false);
            this.dimensionsGroupBox.PerformLayout();
            this.dimensionsPanel.ResumeLayout(false);
            this.dimensionsPanel.PerformLayout();
            this.newShapeGroupBox.ResumeLayout(false);
            this.newShapeGroupBox.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button shapesButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel selectedPanel;
        private System.Windows.Forms.Panel shapesPanel;
        private System.Windows.Forms.GroupBox newShapeGroupBox;
        private System.Windows.Forms.Label circleLabel;
        private RoundButton newCircleButton;
        private System.Windows.Forms.Label polygonLabel;
        private RoundButton newPolygonButton;
        private System.Windows.Forms.Panel dimensionsPanel;
        private System.Windows.Forms.TextBox dimensionTextBox;
        private System.Windows.Forms.GroupBox dimensionsGroupBox;
        private System.Windows.Forms.Label obtuseLabel;
        private System.Windows.Forms.Label dimensionLabel;
        private System.Windows.Forms.CheckBox obtuseCheckBox;
        private System.Windows.Forms.Label sideCountLabel;
        private System.Windows.Forms.Button addSideButton;
        private System.Windows.Forms.TextBox shapeQuantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addShapeButton;
        private System.Windows.Forms.GroupBox shapePreviewGroupBox;
        private System.Windows.Forms.TextBox thicknessTextBox;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.PictureBox shapePreviewPicBox;
        private System.Windows.Forms.GroupBox addedShapesGroupBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fillerlabel1;
    }
}

