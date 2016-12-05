using TSPSimulatedAnnelaing.Recources.Language;

namespace TSPSimulatedAnnelaing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button ClearAll;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.VisualizationPanel = new System.Windows.Forms.Panel();
            this.GamiltonCheckBox = new System.Windows.Forms.CheckBox();
            this.ListBoxOfPoints = new System.Windows.Forms.ListBox();
            this.InputTypeControl = new System.Windows.Forms.TabControl();
            this.ManualInput = new System.Windows.Forms.TabPage();
            this.YInput = new System.Windows.Forms.MaskedTextBox();
            this.XInput = new System.Windows.Forms.MaskedTextBox();
            this.AddManualButton = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.EnterCoordinates = new System.Windows.Forms.Label();
            this.FileInput = new System.Windows.Forms.TabPage();
            this.RandomInput = new System.Windows.Forms.TabPage();
            this.Calculate = new System.Windows.Forms.Button();
            this.StopTemperetureLabel = new System.Windows.Forms.Label();
            this.CyclesNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTemperatureLabel = new System.Windows.Forms.Label();
            this.CyclesNumberLabel = new System.Windows.Forms.Label();
            this.StopTemperatureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTemperatureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ParametersInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RandomNumLabel = new System.Windows.Forms.Label();
            this.RandomNumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            ClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.InputTypeControl.SuspendLayout();
            this.ManualInput.SuspendLayout();
            this.RandomInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearAll
            // 
            ClearAll.Location = new System.Drawing.Point(305, 638);
            ClearAll.Name = "ClearAll";
            ClearAll.Size = new System.Drawing.Size(125, 44);
            ClearAll.TabIndex = 1;
            ClearAll.Text = "Clear all";
            ClearAll.UseVisualStyleBackColor = true;
            ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.VisualizationPanel);
            this.splitContainer1.Panel1.Controls.Add(ClearAll);
            this.splitContainer1.Panel1.Controls.Add(this.GamiltonCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.ListBoxOfPoints);
            this.splitContainer1.Panel1.Controls.Add(this.InputTypeControl);
            this.splitContainer1.Panel1.Controls.Add(this.Calculate);
            this.splitContainer1.Panel1.Controls.Add(this.StopTemperetureLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CyclesNumberMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.StartTemperatureLabel);
            this.splitContainer1.Panel1.Controls.Add(this.CyclesNumberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.StopTemperatureMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.StartTemperatureMaskedTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1274, 777);
            this.splitContainer1.SplitterDistance = 1226;
            this.splitContainer1.TabIndex = 0;
            // 
            // VisualizationPanel
            // 
            this.VisualizationPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisualizationPanel.Location = new System.Drawing.Point(479, 26);
            this.VisualizationPanel.Name = "VisualizationPanel";
            this.VisualizationPanel.Size = new System.Drawing.Size(720, 720);
            this.VisualizationPanel.TabIndex = 0;
            this.VisualizationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualizationPanel_Paint);
            // 
            // GamiltonCheckBox
            // 
            this.GamiltonCheckBox.AutoSize = true;
            this.GamiltonCheckBox.Location = new System.Drawing.Point(17, 329);
            this.GamiltonCheckBox.Name = "GamiltonCheckBox";
            this.GamiltonCheckBox.Size = new System.Drawing.Size(129, 29);
            this.GamiltonCheckBox.TabIndex = 11;
            this.GamiltonCheckBox.Text = "Gamilton";
            this.ParametersInfoToolTip.SetToolTip(this.GamiltonCheckBox, "Check this box if the starting point must be the ending point as well.");
            this.GamiltonCheckBox.UseVisualStyleBackColor = true;
            this.GamiltonCheckBox.CheckedChanged += new System.EventHandler(this.GamiltonCheckBox_CheckedChanged);
            // 
            // ListBoxOfPoints
            // 
            this.ListBoxOfPoints.FormattingEnabled = true;
            this.ListBoxOfPoints.ItemHeight = 25;
            this.ListBoxOfPoints.Location = new System.Drawing.Point(17, 380);
            this.ListBoxOfPoints.Name = "ListBoxOfPoints";
            this.ListBoxOfPoints.Size = new System.Drawing.Size(275, 354);
            this.ListBoxOfPoints.TabIndex = 0;
            // 
            // InputTypeControl
            // 
            this.InputTypeControl.Controls.Add(this.ManualInput);
            this.InputTypeControl.Controls.Add(this.FileInput);
            this.InputTypeControl.Controls.Add(this.RandomInput);
            this.InputTypeControl.Location = new System.Drawing.Point(3, 3);
            this.InputTypeControl.Name = "InputTypeControl";
            this.InputTypeControl.SelectedIndex = 0;
            this.InputTypeControl.Size = new System.Drawing.Size(453, 204);
            this.InputTypeControl.TabIndex = 0;
            this.InputTypeControl.TabStop = false;
            // 
            // ManualInput
            // 
            this.ManualInput.Controls.Add(this.YInput);
            this.ManualInput.Controls.Add(this.XInput);
            this.ManualInput.Controls.Add(this.AddManualButton);
            this.ManualInput.Controls.Add(this.Y);
            this.ManualInput.Controls.Add(this.X);
            this.ManualInput.Controls.Add(this.EnterCoordinates);
            this.ManualInput.Location = new System.Drawing.Point(8, 39);
            this.ManualInput.Name = "ManualInput";
            this.ManualInput.Padding = new System.Windows.Forms.Padding(3);
            this.ManualInput.Size = new System.Drawing.Size(437, 157);
            this.ManualInput.TabIndex = 0;
            this.ManualInput.Text = "Manual";
            this.ManualInput.UseVisualStyleBackColor = true;
            // 
            // YInput
            // 
            this.YInput.Location = new System.Drawing.Point(255, 54);
            this.YInput.Name = "YInput";
            this.YInput.Size = new System.Drawing.Size(100, 31);
            this.YInput.TabIndex = 7;
            // 
            // XInput
            // 
            this.XInput.Location = new System.Drawing.Point(104, 54);
            this.XInput.Name = "XInput";
            this.XInput.Size = new System.Drawing.Size(100, 31);
            this.XInput.TabIndex = 6;
            // 
            // AddManualButton
            // 
            this.AddManualButton.Location = new System.Drawing.Point(142, 107);
            this.AddManualButton.Name = "AddManualButton";
            this.AddManualButton.Size = new System.Drawing.Size(125, 44);
            this.AddManualButton.TabIndex = 5;
            this.AddManualButton.Text = "Add point";
            this.AddManualButton.UseVisualStyleBackColor = true;
            this.AddManualButton.Click += new System.EventHandler(this.AddManualButton_Click);
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(210, 57);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(39, 25);
            this.Y.TabIndex = 4;
            this.Y.Text = "Y=";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(60, 57);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(38, 25);
            this.X.TabIndex = 3;
            this.X.Text = "X=";
            // 
            // EnterCoordinates
            // 
            this.EnterCoordinates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterCoordinates.AutoSize = true;
            this.EnterCoordinates.Location = new System.Drawing.Point(122, 23);
            this.EnterCoordinates.Name = "EnterCoordinates";
            this.EnterCoordinates.Size = new System.Drawing.Size(169, 25);
            this.EnterCoordinates.TabIndex = 2;
            this.EnterCoordinates.Text = "Enter cordinates";
            this.EnterCoordinates.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileInput
            // 
            this.FileInput.Location = new System.Drawing.Point(8, 39);
            this.FileInput.Name = "FileInput";
            this.FileInput.Padding = new System.Windows.Forms.Padding(3);
            this.FileInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileInput.Size = new System.Drawing.Size(437, 157);
            this.FileInput.TabIndex = 1;
            this.FileInput.Text = "From file";
            this.FileInput.UseVisualStyleBackColor = true;
            // 
            // RandomInput
            // 
            this.RandomInput.Controls.Add(this.GenerateButton);
            this.RandomInput.Controls.Add(this.pointsLabel);
            this.RandomInput.Controls.Add(this.RandomNumTextBox);
            this.RandomInput.Controls.Add(this.RandomNumLabel);
            this.RandomInput.Location = new System.Drawing.Point(8, 39);
            this.RandomInput.Name = "RandomInput";
            this.RandomInput.Padding = new System.Windows.Forms.Padding(3);
            this.RandomInput.Size = new System.Drawing.Size(437, 157);
            this.RandomInput.TabIndex = 2;
            this.RandomInput.Text = "Random";
            this.RandomInput.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(305, 314);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(125, 44);
            this.Calculate.TabIndex = 1;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // StopTemperetureLabel
            // 
            this.StopTemperetureLabel.AutoSize = true;
            this.StopTemperetureLabel.Location = new System.Drawing.Point(12, 257);
            this.StopTemperetureLabel.Name = "StopTemperetureLabel";
            this.StopTemperetureLabel.Size = new System.Drawing.Size(75, 25);
            this.StopTemperetureLabel.TabIndex = 4;
            this.StopTemperetureLabel.Text = "Stop T";
            this.ParametersInfoToolTip.SetToolTip(this.StopTemperetureLabel, "Stop temperature of anneal process.");
            // 
            // CyclesNumberMaskedTextBox
            // 
            this.CyclesNumberMaskedTextBox.Location = new System.Drawing.Point(103, 286);
            this.CyclesNumberMaskedTextBox.Name = "CyclesNumberMaskedTextBox";
            this.CyclesNumberMaskedTextBox.Size = new System.Drawing.Size(100, 31);
            this.CyclesNumberMaskedTextBox.TabIndex = 10;
            this.ParametersInfoToolTip.SetToolTip(this.CyclesNumberMaskedTextBox, "Number of randomize cycles in one temperature reduction iteration.");
            // 
            // StartTemperatureLabel
            // 
            this.StartTemperatureLabel.AutoSize = true;
            this.StartTemperatureLabel.Location = new System.Drawing.Point(12, 220);
            this.StartTemperatureLabel.Name = "StartTemperatureLabel";
            this.StartTemperatureLabel.Size = new System.Drawing.Size(76, 25);
            this.StartTemperatureLabel.TabIndex = 3;
            this.StartTemperatureLabel.Text = "Start T";
            this.ParametersInfoToolTip.SetToolTip(this.StartTemperatureLabel, "Start temperature of anneal process.");
            // 
            // CyclesNumberLabel
            // 
            this.CyclesNumberLabel.AutoSize = true;
            this.CyclesNumberLabel.Location = new System.Drawing.Point(12, 292);
            this.CyclesNumberLabel.Name = "CyclesNumberLabel";
            this.CyclesNumberLabel.Size = new System.Drawing.Size(77, 25);
            this.CyclesNumberLabel.TabIndex = 5;
            this.CyclesNumberLabel.Text = "Cycles";
            this.ParametersInfoToolTip.SetToolTip(this.CyclesNumberLabel, "Number of cycles in one iteration.");
            this.CyclesNumberLabel.UseMnemonic = false;
            // 
            // StopTemperatureMaskedTextBox
            // 
            this.StopTemperatureMaskedTextBox.Location = new System.Drawing.Point(103, 251);
            this.StopTemperatureMaskedTextBox.Name = "StopTemperatureMaskedTextBox";
            this.StopTemperatureMaskedTextBox.Size = new System.Drawing.Size(100, 31);
            this.StopTemperatureMaskedTextBox.TabIndex = 8;
            this.ParametersInfoToolTip.SetToolTip(this.StopTemperatureMaskedTextBox, "The stop temperature of anneal process.");
            // 
            // StartTemperatureMaskedTextBox
            // 
            this.StartTemperatureMaskedTextBox.Location = new System.Drawing.Point(103, 217);
            this.StartTemperatureMaskedTextBox.Name = "StartTemperatureMaskedTextBox";
            this.StartTemperatureMaskedTextBox.Size = new System.Drawing.Size(100, 31);
            this.StartTemperatureMaskedTextBox.TabIndex = 6;
            this.ParametersInfoToolTip.SetToolTip(this.StartTemperatureMaskedTextBox, "The start temperature of anneal process.");
            // 
            // ParametersInfoToolTip
            // 
            this.ParametersInfoToolTip.AutoPopDelay = 5000;
            this.ParametersInfoToolTip.InitialDelay = 300;
            this.ParametersInfoToolTip.ReshowDelay = 100;
            this.ParametersInfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ParametersInfoToolTip.ToolTipTitle = "Parameter tip";
            // 
            // RandomNumLabel
            // 
            this.RandomNumLabel.AutoSize = true;
            this.RandomNumLabel.Location = new System.Drawing.Point(6, 23);
            this.RandomNumLabel.Name = "RandomNumLabel";
            this.RandomNumLabel.Size = new System.Drawing.Size(101, 25);
            this.RandomNumLabel.TabIndex = 0;
            this.RandomNumLabel.Text = "Generate";
            // 
            // RandomNumTextBox
            // 
            this.RandomNumTextBox.Location = new System.Drawing.Point(113, 20);
            this.RandomNumTextBox.Name = "RandomNumTextBox";
            this.RandomNumTextBox.Size = new System.Drawing.Size(100, 31);
            this.RandomNumTextBox.TabIndex = 1;
            this.RandomNumTextBox.Text = "50";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(219, 23);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(70, 25);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "points";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(113, 82);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(125, 44);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 777);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Travelling Salesman Simulated Anneal method";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.InputTypeControl.ResumeLayout(false);
            this.ManualInput.ResumeLayout(false);
            this.ManualInput.PerformLayout();
            this.RandomInput.ResumeLayout(false);
            this.RandomInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip ParametersInfoToolTip;
        private System.Windows.Forms.CheckBox GamiltonCheckBox;
        private System.Windows.Forms.ListBox ListBoxOfPoints;
        private System.Windows.Forms.MaskedTextBox CyclesNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox StopTemperatureMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox StartTemperatureMaskedTextBox;
        private System.Windows.Forms.Label CyclesNumberLabel;
        private System.Windows.Forms.Label StopTemperetureLabel;
        private System.Windows.Forms.Label StartTemperatureLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TabControl InputTypeControl;
        private System.Windows.Forms.TabPage ManualInput;
        private System.Windows.Forms.MaskedTextBox YInput;
        private System.Windows.Forms.MaskedTextBox XInput;
        private System.Windows.Forms.Button AddManualButton;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label EnterCoordinates;
        private System.Windows.Forms.TabPage FileInput;
        private System.Windows.Forms.TabPage RandomInput;
        private System.Windows.Forms.Panel VisualizationPanel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.MaskedTextBox RandomNumTextBox;
        private System.Windows.Forms.Label RandomNumLabel;
    }
}

