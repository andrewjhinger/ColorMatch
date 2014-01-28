using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Button[] _primaryButtons;                       // Array of primary color buttons
        private Button[] _complementaryButtons;                 // Array of complementary color buttons
        private Color[] _bothColorSets =                        // Array of primary and complementary colors for random color selection
            new Color[ColorTriangle.PrimaryColors().Length +
            ColorTriangle.ComplementaryColors().Length];

        // Track game mode
        private struct Splat
        {
            public static bool Single = false;                  // Single color game state
            public static Color FirstColor;                     // Single and two color game state color
            public static Color SecondColor;                    // Two color game state color
            public static int SingleMatches = 0;                // Number of single color game state matches
            public static int MixMatches = 0;                   // Number of two color game state matches
        }

        // Matching enum for StatusStrip updates
        private enum Match
        {
            Match,            // User selected correct matching color
            Mismatch,         // User selected incorrect matching color 
            Ignore,           // Ignore a color selection
            Reset             // Reset the StatusStrip
        };


        private void createButtons()
        {
            // Create primary and complementary buttons
            _primaryButtons = new Button[ColorTriangle.PrimaryColors().Length];
            for (int i = 0; i < ColorTriangle.PrimaryColors().Length; i++)
            {
                // Create and assign new Button
                Button button = new Button()
                {
                    Text = "",
                    BackColor = ColorTriangle.PrimaryColors()[i],
                    FlatStyle = FlatStyle.Popup,
                    Cursor = Cursors.Hand
                };
                // Add Click event handler for all buttons, and add button to PictureBox
                button.Click += new EventHandler(buttonClickHandler);
                _primaryButtons[i] = button;
                primaryColorsPanel.Controls.Add(button);
            }

            // Create complementary buttons
            _complementaryButtons = new Button[ColorTriangle.ComplementaryColors().Length];
            for (int i = 0; i < ColorTriangle.ComplementaryColors().Length; i++)
            {
                // Create and assign new Button
                Button button = new Button()
                {
                    Text = "",
                    BackColor = ColorTriangle.ComplementaryColors()[i],
                    FlatStyle = FlatStyle.Popup,
                    Cursor = Cursors.Hand
                };
                // Add Click event handler for all buttons, and add button to PictureBox
                button.Click += new EventHandler(buttonClickHandler);
                _complementaryButtons[i] = button;
                complementaryColorsPanel.Controls.Add(button);
            }
        }

        private void buttonClickHandler(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Splat.Single)
            {
                // Single-color game state - test if user selection is correct
                if (button.BackColor == ColorTriangle.GetComplement(Splat.FirstColor))
                    updateStatusStrip(Match.Match, Match.Ignore);
                else
                    updateStatusStrip(Match.Mismatch, Match.Ignore);
            }
            else
            {
                // Two-color game state - test if user selection is correct
                if (button.BackColor == ColorTriangle.GetMixResult(Splat.FirstColor, Splat.SecondColor))
                    updateStatusStrip(Match.Ignore, Match.Match);
                else
                    updateStatusStrip(Match.Ignore, Match.Mismatch);
            }
            // Next game state and colors, then update display
            setColors();
            updateDisplay();
        }

        private void updateDisplay()
        {
            // Primary panel buttons
            int buttonWidth = primaryColorsPanel.ClientRectangle.Width;
            int buttonHeight = primaryColorsPanel.ClientRectangle.Height / _primaryButtons.Length;
            for (int i = 0; i < _primaryButtons.Length; i++)
                _primaryButtons[i].SetBounds(0, buttonHeight * i, buttonWidth, buttonHeight);

            // Complementary panel buttons
            buttonWidth = complementaryColorsPanel.ClientRectangle.Width;
            buttonHeight = complementaryColorsPanel.ClientRectangle.Height / _complementaryButtons.Length;
            for (int i = 0; i < _complementaryButtons.Length; i++)
                _complementaryButtons[i].SetBounds(0, buttonHeight * i, buttonWidth, buttonHeight);

            // Color panel - note PictureBox drawing done in Paint event
            // Should never use CreateGraphics() with PictureBox
            colorsPictureBox.Invalidate();
        }

        private void setColors()
        {
            // Switch game state, and create our random generator
            Splat.Single = !Splat.Single;
            Random random = new Random();
            if (Splat.Single)
            {
                // Single color game state - select random color
                Splat.FirstColor = _bothColorSets[random.Next(_bothColorSets.Length)];
            }
            else
            {
                // Two color game state - select primary or complementary row, then
                // two random colors in that row
                Color[] workingSet = ColorTriangle.PrimaryColors();
                int row = random.Next(2);
                if (row == 1)
                    workingSet = ColorTriangle.ComplementaryColors();
                int max = workingSet.Length;
                int firstIndex = random.Next(max);
                Splat.FirstColor = workingSet[firstIndex];

                // Create an array containing allowed columns, then randomly select array
                // element and use value in allowed array as index into colors
                int[] allowedIndices = new int[workingSet.Length - 1];
                int index = 0;
                for (int i = 0; i < workingSet.Length; i++)
                {
                    if (i != firstIndex) allowedIndices[index++] = i;
                }
                int secondIndex = random.Next(allowedIndices.Length);
                Splat.SecondColor = workingSet[allowedIndices[secondIndex]];
            }
        }

        private void updateStatusStrip(Match singleMatch, Match mixMatch)
        {
            // Default state of status strip
            int singleMatches = 0;
            int mixMatches = 0;
            string match = "";
            Color matchColor = this.BackColor;

            if (singleMatch != Match.Reset && mixMatch != Match.Reset)
            {
                // Not resetting, update based on enum values
                singleMatches = Splat.SingleMatches;
                mixMatches = Splat.MixMatches;
                if (singleMatch == Match.Match)
                    singleMatches++;
                if (mixMatch == Match.Match)
                    mixMatches++;
                if (singleMatch == Match.Match || mixMatch == Match.Match)
                {
                    match = "Match!";
                    matchColor = Color.Green;
                }
                else
                {
                    match = "Mismatch!";
                    matchColor = Color.Red;
                }
            }

            // Update status strip and Splat 
            matchToolStripStatusLabel.Text = match;
            matchToolStripStatusLabel.BackColor = matchColor;
            Splat.SingleMatches = singleMatches;
            Splat.MixMatches = mixMatches;
            singleMatchesToolStripStatusLabel.Text = "Single Matches: " + Splat.SingleMatches.ToString();
            mixMatchesToolStripStatusLabel.Text = "Mix Matches: " + Splat.MixMatches.ToString();
        }

        private void resetGame()
        {
            // Reset the game
            updateStatusStrip(Match.Reset, Match.Reset);
            setColors();
            updateDisplay();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load both color sets array
            Array.Copy(ColorTriangle.PrimaryColors(), 0, _bothColorSets, 0, ColorTriangle.PrimaryColors().Length);
            Array.Copy(ColorTriangle.ComplementaryColors(), 0, _bothColorSets, ColorTriangle.PrimaryColors().Length, ColorTriangle.ComplementaryColors().Length);

            // Create buttons
            createButtons();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            resetGame();
        }

        private void colorPictureBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorsPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Draw color splats on color panel
            if (Splat.Single)
            {
                // Single color game state, calculate maximum diameter and position and draw
                int diameter = Math.Min(colorsPictureBox.ClientRectangle.Width, colorsPictureBox.ClientRectangle.Height);
                int x = (colorsPictureBox.ClientRectangle.Width / 2) - (diameter / 2);
                int y = (colorsPictureBox.ClientRectangle.Height / 2) - (diameter / 2);
                e.Graphics.FillEllipse(new SolidBrush(Splat.FirstColor), x, y, diameter, diameter);
            }
            else
            {
                // Two color game state, calculate maximum diameter and position and draw
                int diameter = Math.Min(colorsPictureBox.ClientRectangle.Width, colorsPictureBox.ClientRectangle.Height / 2);
                int x = (colorsPictureBox.ClientRectangle.Width / 2) - (diameter / 2);
                int y = (colorsPictureBox.ClientRectangle.Height / 4) - (diameter / 2);
                e.Graphics.FillEllipse(new SolidBrush(Splat.FirstColor), x, y, diameter, diameter);
                y = colorsPictureBox.ClientRectangle.Height / 2;
                e.Graphics.FillEllipse(new SolidBrush(Splat.SecondColor), x, y, diameter, diameter);
            }
        }
    }
}
