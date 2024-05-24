namespace Program_Simulator
{
    partial class Form1
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
            this.currentBotTitleLabel = new System.Windows.Forms.Label();
            this.currentBotLabel = new System.Windows.Forms.Label();
            this.sizeOfBoardTitleLabel = new System.Windows.Forms.Label();
            this.sizeOfBoardLabel = new System.Windows.Forms.Label();
            this.consoleOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.sizeOfBoardSlider = new System.Windows.Forms.TrackBar();
            this.generateBoardButton = new System.Windows.Forms.Button();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weightingCheckBox = new System.Windows.Forms.CheckBox();
            this.botButton = new System.Windows.Forms.Button();
            this.removePathButton = new System.Windows.Forms.Button();
            this.totalStepsTitleLabel = new System.Windows.Forms.Label();
            this.pathCostTitleLabel = new System.Windows.Forms.Label();
            this.totalStepsLabel = new System.Windows.Forms.Label();
            this.pathCostLabel = new System.Windows.Forms.Label();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.randomSeedingCheckBox = new System.Windows.Forms.CheckBox();
            this.consoleOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfBoardSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // currentBotTitleLabel
            // 
            this.currentBotTitleLabel.AutoSize = true;
            this.currentBotTitleLabel.BackColor = System.Drawing.Color.Black;
            this.currentBotTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBotTitleLabel.ForeColor = System.Drawing.Color.White;
            this.currentBotTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.currentBotTitleLabel.Name = "currentBotTitleLabel";
            this.currentBotTitleLabel.Size = new System.Drawing.Size(135, 25);
            this.currentBotTitleLabel.TabIndex = 0;
            this.currentBotTitleLabel.Text = "Current Bot: ";
            // 
            // currentBotLabel
            // 
            this.currentBotLabel.AutoSize = true;
            this.currentBotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBotLabel.ForeColor = System.Drawing.Color.Green;
            this.currentBotLabel.Location = new System.Drawing.Point(167, 9);
            this.currentBotLabel.Name = "currentBotLabel";
            this.currentBotLabel.Size = new System.Drawing.Size(158, 25);
            this.currentBotLabel.TabIndex = 1;
            this.currentBotLabel.Text = "Jacob\'s Bot V1";
            // 
            // sizeOfBoardTitleLabel
            // 
            this.sizeOfBoardTitleLabel.AutoSize = true;
            this.sizeOfBoardTitleLabel.BackColor = System.Drawing.Color.Black;
            this.sizeOfBoardTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeOfBoardTitleLabel.ForeColor = System.Drawing.Color.White;
            this.sizeOfBoardTitleLabel.Location = new System.Drawing.Point(12, 34);
            this.sizeOfBoardTitleLabel.Name = "sizeOfBoardTitleLabel";
            this.sizeOfBoardTitleLabel.Size = new System.Drawing.Size(149, 25);
            this.sizeOfBoardTitleLabel.TabIndex = 2;
            this.sizeOfBoardTitleLabel.Text = "Size of Board:";
            // 
            // sizeOfBoardLabel
            // 
            this.sizeOfBoardLabel.AutoSize = true;
            this.sizeOfBoardLabel.BackColor = System.Drawing.Color.Black;
            this.sizeOfBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeOfBoardLabel.ForeColor = System.Drawing.Color.White;
            this.sizeOfBoardLabel.Location = new System.Drawing.Point(167, 34);
            this.sizeOfBoardLabel.Name = "sizeOfBoardLabel";
            this.sizeOfBoardLabel.Size = new System.Drawing.Size(76, 25);
            this.sizeOfBoardLabel.TabIndex = 3;
            this.sizeOfBoardLabel.Text = "64 x 64";
            // 
            // consoleOutputGroupBox
            // 
            this.consoleOutputGroupBox.BackColor = System.Drawing.Color.DimGray;
            this.consoleOutputGroupBox.Controls.Add(this.consoleLabel);
            this.consoleOutputGroupBox.Location = new System.Drawing.Point(15, 237);
            this.consoleOutputGroupBox.Name = "consoleOutputGroupBox";
            this.consoleOutputGroupBox.Size = new System.Drawing.Size(449, 773);
            this.consoleOutputGroupBox.TabIndex = 4;
            this.consoleOutputGroupBox.TabStop = false;
            this.consoleOutputGroupBox.Text = "Console Output";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(7, 22);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(17, 16);
            this.consoleLabel.TabIndex = 0;
            this.consoleLabel.Text = "> ";
            // 
            // sizeOfBoardSlider
            // 
            this.sizeOfBoardSlider.Location = new System.Drawing.Point(12, 62);
            this.sizeOfBoardSlider.Maximum = 100;
            this.sizeOfBoardSlider.Minimum = 8;
            this.sizeOfBoardSlider.Name = "sizeOfBoardSlider";
            this.sizeOfBoardSlider.Size = new System.Drawing.Size(447, 56);
            this.sizeOfBoardSlider.TabIndex = 6;
            this.sizeOfBoardSlider.Value = 8;
            this.sizeOfBoardSlider.Scroll += new System.EventHandler(this.sizeOfBoardSlider_Scroll);
            // 
            // generateBoardButton
            // 
            this.generateBoardButton.ForeColor = System.Drawing.Color.Gray;
            this.generateBoardButton.Location = new System.Drawing.Point(259, 141);
            this.generateBoardButton.Name = "generateBoardButton";
            this.generateBoardButton.Size = new System.Drawing.Size(205, 26);
            this.generateBoardButton.TabIndex = 7;
            this.generateBoardButton.Text = "Generate Board";
            this.generateBoardButton.UseVisualStyleBackColor = true;
            this.generateBoardButton.Click += new System.EventHandler(this.generateBoardButton_Click);
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.ForeColor = System.Drawing.Color.Gray;
            this.startSimulationButton.Location = new System.Drawing.Point(259, 205);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(205, 26);
            this.startSimulationButton.TabIndex = 8;
            this.startSimulationButton.Text = "Start Simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(491, 9);
            this.panel1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.panel1.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 1000);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // weightingCheckBox
            // 
            this.weightingCheckBox.AutoSize = true;
            this.weightingCheckBox.Location = new System.Drawing.Point(12, 149);
            this.weightingCheckBox.Name = "weightingCheckBox";
            this.weightingCheckBox.Size = new System.Drawing.Size(125, 20);
            this.weightingCheckBox.TabIndex = 10;
            this.weightingCheckBox.Text = "Show Weighting";
            this.weightingCheckBox.UseVisualStyleBackColor = true;
            this.weightingCheckBox.CheckedChanged += new System.EventHandler(this.weightingCheckBox_CheckedChanged);
            // 
            // botButton
            // 
            this.botButton.ForeColor = System.Drawing.Color.Gray;
            this.botButton.Location = new System.Drawing.Point(259, 173);
            this.botButton.Name = "botButton";
            this.botButton.Size = new System.Drawing.Size(205, 26);
            this.botButton.TabIndex = 11;
            this.botButton.Text = "Open Bot";
            this.botButton.UseVisualStyleBackColor = true;
            this.botButton.Click += new System.EventHandler(this.botButton_Click);
            // 
            // removePathButton
            // 
            this.removePathButton.ForeColor = System.Drawing.Color.Gray;
            this.removePathButton.Location = new System.Drawing.Point(259, 109);
            this.removePathButton.Name = "removePathButton";
            this.removePathButton.Size = new System.Drawing.Size(205, 26);
            this.removePathButton.TabIndex = 12;
            this.removePathButton.Text = "Remove Old Path";
            this.removePathButton.UseVisualStyleBackColor = true;
            this.removePathButton.Click += new System.EventHandler(this.removePathButton_Click);
            // 
            // totalStepsTitleLabel
            // 
            this.totalStepsTitleLabel.AutoSize = true;
            this.totalStepsTitleLabel.Location = new System.Drawing.Point(9, 114);
            this.totalStepsTitleLabel.Name = "totalStepsTitleLabel";
            this.totalStepsTitleLabel.Size = new System.Drawing.Size(79, 16);
            this.totalStepsTitleLabel.TabIndex = 13;
            this.totalStepsTitleLabel.Text = "Total Steps:";
            // 
            // pathCostTitleLabel
            // 
            this.pathCostTitleLabel.AutoSize = true;
            this.pathCostTitleLabel.Location = new System.Drawing.Point(12, 130);
            this.pathCostTitleLabel.Name = "pathCostTitleLabel";
            this.pathCostTitleLabel.Size = new System.Drawing.Size(67, 16);
            this.pathCostTitleLabel.TabIndex = 14;
            this.pathCostTitleLabel.Text = "Path Cost:";
            // 
            // totalStepsLabel
            // 
            this.totalStepsLabel.AutoSize = true;
            this.totalStepsLabel.Location = new System.Drawing.Point(99, 114);
            this.totalStepsLabel.Name = "totalStepsLabel";
            this.totalStepsLabel.Size = new System.Drawing.Size(14, 16);
            this.totalStepsLabel.TabIndex = 15;
            this.totalStepsLabel.Text = "0";
            // 
            // pathCostLabel
            // 
            this.pathCostLabel.AutoSize = true;
            this.pathCostLabel.Location = new System.Drawing.Point(99, 130);
            this.pathCostLabel.Name = "pathCostLabel";
            this.pathCostLabel.Size = new System.Drawing.Size(14, 16);
            this.pathCostLabel.TabIndex = 16;
            this.pathCostLabel.Text = "0";
            // 
            // seedUpDown
            // 
            this.seedUpDown.Location = new System.Drawing.Point(12, 205);
            this.seedUpDown.Name = "seedUpDown";
            this.seedUpDown.Size = new System.Drawing.Size(120, 22);
            this.seedUpDown.TabIndex = 17;
            this.seedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seedUpDown.ValueChanged += new System.EventHandler(this.seedUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seed:";
            // 
            // randomSeedingCheckBox
            // 
            this.randomSeedingCheckBox.AutoSize = true;
            this.randomSeedingCheckBox.Location = new System.Drawing.Point(12, 168);
            this.randomSeedingCheckBox.Name = "randomSeedingCheckBox";
            this.randomSeedingCheckBox.Size = new System.Drawing.Size(163, 20);
            this.randomSeedingCheckBox.TabIndex = 19;
            this.randomSeedingCheckBox.Text = "Use Random Seeding";
            this.randomSeedingCheckBox.UseVisualStyleBackColor = true;
            this.randomSeedingCheckBox.CheckedChanged += new System.EventHandler(this.randomSeedingCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1503, 1022);
            this.Controls.Add(this.randomSeedingCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedUpDown);
            this.Controls.Add(this.pathCostLabel);
            this.Controls.Add(this.totalStepsLabel);
            this.Controls.Add(this.pathCostTitleLabel);
            this.Controls.Add(this.totalStepsTitleLabel);
            this.Controls.Add(this.removePathButton);
            this.Controls.Add(this.botButton);
            this.Controls.Add(this.weightingCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startSimulationButton);
            this.Controls.Add(this.generateBoardButton);
            this.Controls.Add(this.sizeOfBoardSlider);
            this.Controls.Add(this.consoleOutputGroupBox);
            this.Controls.Add(this.sizeOfBoardLabel);
            this.Controls.Add(this.sizeOfBoardTitleLabel);
            this.Controls.Add(this.currentBotLabel);
            this.Controls.Add(this.currentBotTitleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consoleOutputGroupBox.ResumeLayout(false);
            this.consoleOutputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfBoardSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentBotTitleLabel;
        private System.Windows.Forms.Label currentBotLabel;
        private System.Windows.Forms.Label sizeOfBoardTitleLabel;
        private System.Windows.Forms.Label sizeOfBoardLabel;
        private System.Windows.Forms.GroupBox consoleOutputGroupBox;
        private System.Windows.Forms.TrackBar sizeOfBoardSlider;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Button generateBoardButton;
        private System.Windows.Forms.Button startSimulationButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox weightingCheckBox;
        private System.Windows.Forms.Button botButton;
        private System.Windows.Forms.Button removePathButton;
        private System.Windows.Forms.Label totalStepsTitleLabel;
        private System.Windows.Forms.Label pathCostTitleLabel;
        private System.Windows.Forms.Label totalStepsLabel;
        private System.Windows.Forms.Label pathCostLabel;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox randomSeedingCheckBox;
    }
}

