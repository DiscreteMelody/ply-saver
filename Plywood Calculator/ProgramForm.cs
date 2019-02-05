using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plywood_Calculator
{
    public partial class plysaverForm : Form
    {
        private Color primaryColor = Color.FromArgb(3, 169, 244);
        private Color lightPrimaryColor = Color.FromArgb(0, 191, 255);
        private Color darkPrimaryColor = Color.FromArgb(2, 136, 209);
        private Color accentColor = Color.FromArgb(96, 125, 139);
        private Color dividerColor = Color.FromArgb(189, 189, 189);
        private Color lightTextColor = Color.FromArgb(255, 255, 255);
        private Color darkTextColor = Color.FromArgb(33, 33, 33);
        private Color buttonBorderColor = Color.FromArgb(117, 117, 117);

        List<Control> controlsList = new List<Control>();
        List <TextBox> dimensionTextBoxes = new List<TextBox>();
        List<CheckBox> obtuseCheckBoxes = new List<CheckBox>();
        List<Label> sideCountLabels = new List<Label>();
        
        private int shapeSideCount = 0;

        public plysaverForm()
        {
            InitializeComponent();
        }

        private void plywoodForm_Load(object sender, EventArgs e)
        {
            populateControlList();

            //color and styling
            colorButtons();
            colorPanels();
            drawEmptyBackground(shapePreviewPicBox);

            //program defaults to the shapes pane
            shapesButton.PerformClick();
            
        }

        private void populateControlList()
        {
            getControls(this);
        }

        //recursive function that gets a list of all controls on the form
        private void getControls(Control control)
        {
            foreach(Control item in control.Controls)
            {
                if (item.HasChildren)
                {
                    getControls(item);
                }
                else
                {
                    controlsList.Add(item);
                }
            }
        }

        //recursive function that finds all children buttons and sets their backcolor, mouseover, and mousedown colors
        private void colorButtons()
        {
            foreach(Control item in controlsList)
            {
                if(item.GetType() == typeof(Button) || item.GetType() == typeof(RoundButton))
                {
                    Button button = (Button)item;
                    button.FlatAppearance.MouseDownBackColor = darkPrimaryColor;
                    button.FlatAppearance.MouseOverBackColor = lightPrimaryColor;
                    button.BackColor = primaryColor;
                }
            }
        }

        private void colorPanels()
        {
            sidePanel.BackColor = primaryColor;
            headerPanel.BackColor = lightPrimaryColor;
        }

        private void shapesButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            highlightButton(shapesButton);
            headerLabel.Text = "Shapes";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            highlightButton(calculateButton);
            headerLabel.Text = "Calculate Diagram";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            highlightButton(helpButton);
            headerLabel.Text = "Help With Ply-Saver";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButtonColors()
        {
            shapesButton.BackColor = primaryColor;
            calculateButton.BackColor = primaryColor;
            helpButton.BackColor = primaryColor;
        }

        //moves the (currently) white panel to either the Shapes, Help, or Calculate button
        private void highlightButton(Button button_name)
        {
            selectedPanel.Enabled = true;
            selectedPanel.Visible = true;

            button_name.BackColor = darkPrimaryColor;
            selectedPanel.Top = button_name.Top;
        }

        //draws borders around each of the buttons in the newShape group box
        private void newShapeGroupBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(dividerColor);
            Pen pen = new Pen(brush);
            pen.Width = 18;

            e.Graphics.DrawEllipse(pen, newPolygonButton.Location.X - 1, newPolygonButton.Location.Y - 1, newPolygonButton.Width + 1, newPolygonButton.Height + 1);
            e.Graphics.DrawEllipse(pen, newCircleButton.Location.X - 1, newCircleButton.Location.Y - 1, newCircleButton.Width + 1, newCircleButton.Height + 1);
        }

        //adds a new label, textbox, and checkbox to shape dimensions panel
        private void addNewShapeDimensionInputs()
        {
            Label newLabel = new Label();
            TextBox newTextBox = new TextBox();
            CheckBox newCheckBox = new CheckBox();
            int controlSpacing = 40;

            shapeSideCount++;
            dimensionsPanel.Invalidate();

            newLabel.Font = sideCountLabel.Font;
            newLabel.Location = new Point(sideCountLabel.Location.X, sideCountLabel.Location.Y + (controlSpacing * shapeSideCount));
            newLabel.Text = (shapeSideCount + 1).ToString();
            newLabel.BackColor = sideCountLabel.BackColor;
            newLabel.AutoSize = true;

            newTextBox.Font = dimensionTextBox.Font;
            newTextBox.Location = new Point(dimensionTextBox.Location.X, dimensionTextBox.Location.Y + (controlSpacing * shapeSideCount));
            newTextBox.Size = dimensionTextBox.Size;
            newTextBox.BorderStyle = BorderStyle.None;

            newCheckBox.Location = new Point(obtuseCheckBox.Location.X, obtuseCheckBox.Location.Y + (controlSpacing * shapeSideCount));
            newCheckBox.Text = "";
            newCheckBox.Size = obtuseCheckBox.Size;

            sideCountLabels.Add(newLabel);
            dimensionTextBoxes.Add(newTextBox);
            obtuseCheckBoxes.Add(newCheckBox);
            
            dimensionsPanel.Controls.Add(newLabel);
            dimensionsPanel.Controls.Add(newTextBox);
            dimensionsPanel.Controls.Add(newCheckBox);
        }

        //paints boxes around the textbox controls in the dimensionsPanel
        private void dimensionsPanel_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(primaryColor);
            Pen pen = new Pen(brush);
            pen.Width = 6;

            for (int i = 0; i < dimensionTextBoxes.Count; i++)
            {
                if (dimensionTextBoxes[i].Visible)
                    e.Graphics.DrawRectangle(pen, dimensionTextBoxes[i].Location.X, dimensionTextBoxes[i].Location.Y, dimensionTextBoxes[i].Width, dimensionTextBoxes[i].Height);
            }

            e.Graphics.DrawRectangle(pen, dimensionTextBox.Location.X, dimensionTextBox.Location.Y, dimensionTextBox.Width, dimensionTextBox.Height);
            e.Graphics.DrawRectangle(pen, shapeQuantityTextBox.Location.X, shapeQuantityTextBox.Location.Y, shapeQuantityTextBox.Width, shapeQuantityTextBox.Height);
            e.Graphics.DrawRectangle(pen, dimensionTextBox.Location.X, dimensionTextBox.Location.Y, dimensionTextBox.Width, dimensionTextBox.Height);
        }

        private void addSideButton_Click(object sender, EventArgs e)
        {
            addNewShapeDimensionInputs();
        }

        private void newCircleButton_Click(object sender, EventArgs e)
        {
            displayShapeDimensions();
            obtuseLabel.Visible = false;
            dimensionLabel.Text = "Radius";
            addSideButton.Enabled = false;
            sideCountLabel.Visible = false;
            obtuseCheckBox.Visible = false;
        }

        private void newPolygonButton_Click(object sender, EventArgs e)
        {
            obtuseLabel.Visible = true;
            dimensionLabel.Text = "Length of Side";
            addSideButton.Enabled = true;
            sideCountLabel.Visible = true;
            obtuseCheckBox.Visible = true;
            displayShapeDimensions();

            //the minimum sides for a polygon is 3
            addSideButton.PerformClick();
            addSideButton.PerformClick();
        }

        private void displayShapeDimensions()
        {
            newShapeGroupBox.Visible = false;
            dimensionsGroupBox.Visible = true;
        }

        private void addShapeButton_Click(object sender, EventArgs e)
        {
            createSides();
            resetShapeControls();
        }

        //hide shape dimension controls and reset the counter back to 0
        private void resetShapeControls()
        {
            dimensionsGroupBox.Visible = false;
            newShapeGroupBox.Visible = true;
            clearExtraDimensionControls();
            shapeSideCount = 0;
        }

        private void createSides()
        {
            List<Side> sides = new List<Side>();

            try
            {
                Side newSide = new Side(float.Parse(dimensionTextBox.Text), obtuseCheckBox.Checked);
                sides.Add(newSide);

                for(int i = 0; i < dimensionTextBoxes.Count; i++)
                {
                    newSide = new Side(float.Parse(dimensionTextBoxes[i].Text), obtuseCheckBoxes[i].Checked);
                    sides.Add(newSide);
                }
            }
            catch
            {
                sides.Clear();
                MessageBox.Show("Only integers and decimals can be entered.");
            }
        }

        //TODO add this to shape manager class
        private bool validateShape()
        {
            for (int i = 0; i < dimensionTextBoxes.Count; i++)
            {

            }

            return true;
        }

        private void clearExtraDimensionControls()
        {
            for(int i = 0; i < dimensionTextBoxes.Count; i++)
            {
                sideCountLabels[i].Dispose();
                dimensionTextBoxes[i].Dispose();
                obtuseCheckBoxes[i].Dispose();
            }

            sideCountLabels.Clear();
            dimensionTextBoxes.Clear();
            obtuseCheckBoxes.Clear();
        }

        //draws a rectangle around the textboxes in the dimensions groupbox
        private void dimensionsGroupBox_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(primaryColor);
            Pen pen = new Pen(brush);
            pen.Width = 6;

            e.Graphics.DrawRectangle(pen, shapeQuantityTextBox.Location.X, shapeQuantityTextBox.Location.Y, shapeQuantityTextBox.Width, shapeQuantityTextBox.Height);
            e.Graphics.DrawRectangle(pen, thicknessTextBox.Location.X, thicknessTextBox.Location.Y, thicknessTextBox.Width, thicknessTextBox.Height);
        }

        //creates a transparent image in a picture box
        private void drawEmptyBackground(PictureBox pic_box)
        {
            Bitmap bmp = new Bitmap(pic_box.Width, pic_box.Height);
            SolidBrush opaqueBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle imageSize = new Rectangle(0, 0, pic_box.Width, pic_box.Height);
                graph.FillRectangle(opaqueBrush, imageSize);
            }

            pic_box.Image = bmp;
        }
    }
}
