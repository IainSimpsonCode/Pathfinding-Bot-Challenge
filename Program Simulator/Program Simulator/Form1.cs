using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Simulator
{     
    public partial class Form1 : Form
    {
        // Current bot being tested by the system
        Bot currentBot;       

        // Bools to control the state of the system
        bool simulationRunning = false;
        bool isGenerated = false;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Board.mBoardSize = sizeOfBoardSlider.Value;
            sizeOfBoardLabel.Text = Board.mBoardSize.ToString() + " x " + Board.mBoardSize.ToString();

            panel1.Width = Board.mBoardWidth;
            panel1.Height = Board.mBoardHeight;
        }

        private void sizeOfBoardSlider_Scroll(object sender, EventArgs e)
        {
            Board.mBoardSize = sizeOfBoardSlider.Value;
            sizeOfBoardLabel.Text = Board.mBoardSize.ToString() + " x " + Board.mBoardSize.ToString();
        }
        private void weightingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void generateBoardButton_Click(object sender, EventArgs e)
        {
            // Set isGenerated to false, causing the board to regenerate and set new weightings/blocked spaces/target/start
            isGenerated = false;
            panel1.Refresh();        
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            if (currentBot != null)
            {
                // Start communication between the simulator and the bot's console
                currentBot.Start();
                // Show the bots name on screen
                currentBotLabel.Text = currentBot.mBotName;
                // Send starting instructions to the bot
                currentBot.SendConsoleMessages(Board.mBoardSize.ToString());
                
                currentBot.SendConsoleMessages("Start");
                currentBot.mCoordinates = Board.start;
                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(Board.start));
                simulationRunning = true;

                while (simulationRunning)
                {
                    foreach (string message in currentBot.ReadNewConsoleMessages())
                    {
                        if (message[0] == '#')
                        {
                            consoleLabel.Text = SimulationConsole.WriteLine(message);
                        }
                        else if (message == "Up")
                        {
                            if (Board.isSquareValid(new Vector2(currentBot.mCoordinates.X, currentBot.mCoordinates.Y - 1)))
                            {
                                currentBot.mCoordinates = new Vector2(currentBot.mCoordinates.X, currentBot.mCoordinates.Y - 1);

                                currentBot.SendConsoleMessages("Confirm");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                            else
                            {
                                currentBot.SendConsoleMessages("Invalid");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                        }
                        else if (message == "Down")
                        {
                            if (Board.isSquareValid(new Vector2(currentBot.mCoordinates.X, currentBot.mCoordinates.Y + 1)))
                            {
                                currentBot.mCoordinates = new Vector2(currentBot.mCoordinates.X, currentBot.mCoordinates.Y + 1);

                                currentBot.SendConsoleMessages("Confirm");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                            else
                            {
                                currentBot.SendConsoleMessages("Invalid");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                        }
                        else if (message == "Right")
                        {
                            if (Board.isSquareValid(new Vector2(currentBot.mCoordinates.X + 1, currentBot.mCoordinates.Y)))
                            {
                                currentBot.mCoordinates = new Vector2(currentBot.mCoordinates.X + 1, currentBot.mCoordinates.Y);

                                currentBot.SendConsoleMessages("Confirm");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                            else
                            {
                                currentBot.SendConsoleMessages("Invalid");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                        }
                        else if (message == "Left")
                        {
                            if (Board.isSquareValid(new Vector2(currentBot.mCoordinates.X - 1, currentBot.mCoordinates.Y)))
                            {
                                currentBot.mCoordinates = new Vector2(currentBot.mCoordinates.X - 1, currentBot.mCoordinates.Y);

                                currentBot.SendConsoleMessages("Confirm");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                            else
                            {
                                currentBot.SendConsoleMessages("Invalid");
                                currentBot.SendConsoleMessages(Board.GetSquareSurroundingsString(currentBot.mCoordinates));
                            }
                        }

                        if (currentBot.mCoordinates.X == Board.target.X && currentBot.mCoordinates.Y == Board.target.Y)
                        {
                            consoleLabel.Text = SimulationConsole.WriteLine("################");
                            consoleLabel.Text = SimulationConsole.WriteLine("Target Reached!!");
                            consoleLabel.Text = SimulationConsole.WriteLine("################");

                            currentBot.SendConsoleMessages("End");
                            currentBot.End();

                            simulationRunning = false;

                            break;
                        }

                        totalStepsLabel.Text = currentBot.traversedSpaces.Count.ToString();
                        pathCostLabel.Text = currentBot.mPathCost.ToString();

                        this.Refresh();
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.FromArgb(255, 255, 255, 255));

            List<int> xLines = new List<int>();
            List<int> yLines = new List<int>();

            int xSquareSize = panel1.Width / Board.mBoardSize;
            int ySquareSize = panel1.Height / Board.mBoardSize;

            int y = 0;
            int x = 0;

            // Horizontal Lines
            // Iterate Y value to move down the board
            // Draw from Y value to the max X width
            y = 0;
            x = 0;
            for (int i = 0; i < (Board.mBoardSize + 1); i++)
            {
                xLines.Add(y);

                e.Graphics.DrawLine(
                    pen,
                    x,
                    y,
                    panel1.Width,
                    y
                );
                y += ySquareSize;
            }

            // Vertical Lines
            // Iterate X value to move across the board
            // Draw from X value to the max Y height
            y = 0;
            x = 0;
            for (int j = 0; j < (Board.mBoardSize + 1); j++)
            {
                yLines.Add(x);

                e.Graphics.DrawLine(
                    pen,
                    x,
                    y,
                    x,
                    panel1.Height
                );
                x += xSquareSize;
            }

            // Generate a new board
            if (!isGenerated)
            {
                Board.squares.Clear();
                Board.blockedSpaces.Clear();

                // Create square objects
                for (int k = 0; k < xLines.Count - 1; k++)
                {
                    // For each horizontal line
                    y = xLines[k];
                    int height = xLines[k + 1] - xLines[k];

                    for (int z = 0; z < yLines.Count - 1; z++)
                    {
                        // For each vertical line
                        x = yLines[z];
                        int width = yLines[z + 1] - yLines[z];

                        Board.squares.Add(new Square(new Vector2(z, k), new Vector2(x, y), width, height));
                    }
                }

                // Give each square a weighting
                Random random = new Random();
                foreach (Square square in Board.squares)
                {
                    int randomWeight = random.Next(0, 255);
                    square.Weight = randomWeight;
                    if (randomWeight >= 200)
                    {
                        Board.blockedSpaces.Add(square.Coordinates);
                    }
                }

                // Create a target and a start position
                // NOTE: Target must be placed before the start
                Board.PlaceTarget();
                Board.PlaceStart();

                isGenerated = true;
            }

            // Fill each square based on weighting
            SolidBrush brush = new SolidBrush(Color.Red);
            foreach (Square square in Board.squares)
            {
                if (weightingCheckBox.Checked)
                {
                    brush = new SolidBrush(Color.FromArgb(100, 0 + square.Weight, 255 - square.Weight, 0));
                    e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                }

                foreach (Vector2 adjacentSpace in Board.adjacentTargetSquares)
                {
                    if (adjacentSpace.X == square.Coordinates.X && adjacentSpace.Y == square.Coordinates.Y)
                    {
                        brush = new SolidBrush(Color.Blue);
                        e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                    }
                }
                foreach (Vector2 adjacentSpace in Board.adjacentStartSquares)
                {
                    if (adjacentSpace.X == square.Coordinates.X && adjacentSpace.Y == square.Coordinates.Y)
                    {
                        brush = new SolidBrush(Color.Yellow);
                        e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                    }
                }

                if (square.Coordinates.X == Board.target.X && square.Coordinates.Y == Board.target.Y)
                {
                    brush = new SolidBrush(Color.Purple);
                    e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                }
                if (square.Coordinates.X == Board.start.X && square.Coordinates.Y == Board.start.Y)
                {
                    brush = new SolidBrush(Color.Green);
                    e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                }

                if (Board.blockedSpaces.Contains(square.Coordinates))
                {
                    brush = new SolidBrush(Color.Gray);
                    e.Graphics.FillRectangle(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                }

                if (simulationRunning)
                {
                    foreach (Vector2 traversedSpace in currentBot.traversedSpaces)
                    {
                        if (square.Coordinates.X == traversedSpace.X && square.Coordinates.Y == traversedSpace.Y)
                        {
                            brush = new SolidBrush(Color.Red);
                            e.Graphics.FillEllipse(brush, new Rectangle((int)square.Position.X, (int)square.Position.Y, square.Width, square.Height));
                        }
                    }
                }
            }
        }

        private void botButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                consoleLabel.Text = SimulationConsole.WriteLine(choofdlog.FileName);

                currentBot = new Bot(choofdlog.FileName);
            }
        }

        private void removePathButton_Click(object sender, EventArgs e)
        {
            if (!simulationRunning && currentBot != null)
            {
                currentBot.Clear();
                panel1.Refresh();
            }
        }
    }
}
