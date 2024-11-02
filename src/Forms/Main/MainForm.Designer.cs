namespace WaveFunctionCollapseImageGenerator
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            TableLayoutPanel layout_main;
            FlowLayoutPanel layout_controls;
            GroupBox group_grid;
            TableLayoutPanel layout_gridParams;
            Label lbl_gridBacktracking;
            Label lbl_gridWrapping;
            Label lbl_gridHeight;
            NumericUpDown num_gridWidth;
            NumericUpDown num_gridHeight;
            Label lbl_gridWidth;
            CheckBox check_gridWrapping;
            CheckBox check_gridBacktracking;
            GroupBox group_simulation;
            TableLayoutPanel layout_simulationParams;
            GroupBox group_tiles;
            TableLayoutPanel layout_tiles;
            ComboBox combo_tileset;
            Label lbl_tileset;
            binding_gridViewModel = new BindingSource(components);
            btn_nextStep = new Button();
            binding_simulationViewModel = new BindingSource(components);
            btn_resetSimulation = new Button();
            btn_newTileset = new Button();
            picture_imageDisplay = new PictureBox();
            layout_main = new TableLayoutPanel();
            layout_controls = new FlowLayoutPanel();
            group_grid = new GroupBox();
            layout_gridParams = new TableLayoutPanel();
            lbl_gridBacktracking = new Label();
            lbl_gridWrapping = new Label();
            lbl_gridHeight = new Label();
            num_gridWidth = new NumericUpDown();
            num_gridHeight = new NumericUpDown();
            lbl_gridWidth = new Label();
            check_gridWrapping = new CheckBox();
            check_gridBacktracking = new CheckBox();
            group_simulation = new GroupBox();
            layout_simulationParams = new TableLayoutPanel();
            group_tiles = new GroupBox();
            layout_tiles = new TableLayoutPanel();
            combo_tileset = new ComboBox();
            lbl_tileset = new Label();
            layout_main.SuspendLayout();
            layout_controls.SuspendLayout();
            group_grid.SuspendLayout();
            layout_gridParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_gridWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binding_gridViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_gridHeight).BeginInit();
            group_simulation.SuspendLayout();
            layout_simulationParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).BeginInit();
            group_tiles.SuspendLayout();
            layout_tiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageDisplay).BeginInit();
            SuspendLayout();
            // 
            // layout_main
            // 
            layout_main.ColumnCount = 2;
            layout_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout_main.Controls.Add(layout_controls, 0, 0);
            layout_main.Controls.Add(picture_imageDisplay, 1, 0);
            layout_main.Dock = DockStyle.Fill;
            layout_main.Location = new Point(0, 0);
            layout_main.Margin = new Padding(0);
            layout_main.Name = "layout_main";
            layout_main.RowCount = 1;
            layout_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_main.Size = new Size(1200, 675);
            layout_main.TabIndex = 0;
            // 
            // layout_controls
            // 
            layout_controls.Controls.Add(group_grid);
            layout_controls.Controls.Add(group_simulation);
            layout_controls.Controls.Add(group_tiles);
            layout_controls.Dock = DockStyle.Fill;
            layout_controls.FlowDirection = FlowDirection.TopDown;
            layout_controls.Location = new Point(0, 0);
            layout_controls.Margin = new Padding(0);
            layout_controls.Name = "layout_controls";
            layout_controls.Size = new Size(600, 675);
            layout_controls.TabIndex = 0;
            // 
            // group_grid
            // 
            group_grid.Controls.Add(layout_gridParams);
            group_grid.Location = new Point(3, 3);
            group_grid.Name = "group_grid";
            group_grid.Size = new Size(597, 310);
            group_grid.TabIndex = 2;
            group_grid.TabStop = false;
            group_grid.Text = "Grid";
            // 
            // layout_gridParams
            // 
            layout_gridParams.ColumnCount = 2;
            layout_gridParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.23544F));
            layout_gridParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.76456F));
            layout_gridParams.Controls.Add(lbl_gridBacktracking, 0, 3);
            layout_gridParams.Controls.Add(lbl_gridWrapping, 0, 2);
            layout_gridParams.Controls.Add(lbl_gridHeight, 0, 1);
            layout_gridParams.Controls.Add(num_gridWidth, 1, 0);
            layout_gridParams.Controls.Add(num_gridHeight, 1, 1);
            layout_gridParams.Controls.Add(lbl_gridWidth, 0, 0);
            layout_gridParams.Controls.Add(check_gridWrapping, 1, 2);
            layout_gridParams.Controls.Add(check_gridBacktracking, 1, 3);
            layout_gridParams.Dock = DockStyle.Fill;
            layout_gridParams.Location = new Point(3, 19);
            layout_gridParams.Margin = new Padding(0);
            layout_gridParams.Name = "layout_gridParams";
            layout_gridParams.RowCount = 4;
            layout_gridParams.RowStyles.Add(new RowStyle());
            layout_gridParams.RowStyles.Add(new RowStyle());
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_gridParams.Size = new Size(591, 288);
            layout_gridParams.TabIndex = 0;
            // 
            // lbl_gridBacktracking
            // 
            lbl_gridBacktracking.AutoSize = true;
            lbl_gridBacktracking.Location = new Point(3, 78);
            lbl_gridBacktracking.Name = "lbl_gridBacktracking";
            lbl_gridBacktracking.Size = new Size(113, 15);
            lbl_gridBacktracking.TabIndex = 7;
            lbl_gridBacktracking.Text = "Enable backtracking";
            // 
            // lbl_gridWrapping
            // 
            lbl_gridWrapping.AutoSize = true;
            lbl_gridWrapping.Location = new Point(3, 58);
            lbl_gridWrapping.Name = "lbl_gridWrapping";
            lbl_gridWrapping.Size = new Size(124, 15);
            lbl_gridWrapping.TabIndex = 5;
            lbl_gridWrapping.Text = "Enable edge wrapping";
            // 
            // lbl_gridHeight
            // 
            lbl_gridHeight.AutoSize = true;
            lbl_gridHeight.Location = new Point(3, 29);
            lbl_gridHeight.Name = "lbl_gridHeight";
            lbl_gridHeight.Size = new Size(43, 15);
            lbl_gridHeight.TabIndex = 3;
            lbl_gridHeight.Text = "Height";
            // 
            // num_gridWidth
            // 
            num_gridWidth.BackColor = SystemColors.ControlLight;
            num_gridWidth.DataBindings.Add(new Binding("Value", binding_gridViewModel, "Width", true));
            num_gridWidth.Location = new Point(217, 3);
            num_gridWidth.Name = "num_gridWidth";
            num_gridWidth.Size = new Size(91, 23);
            num_gridWidth.TabIndex = 0;
            // 
            // binding_gridViewModel
            // 
            binding_gridViewModel.DataSource = typeof(ViewModels.MainForm.GridViewModel);
            // 
            // num_gridHeight
            // 
            num_gridHeight.BackColor = SystemColors.ControlLight;
            num_gridHeight.DataBindings.Add(new Binding("Value", binding_gridViewModel, "Height", true));
            num_gridHeight.Location = new Point(217, 32);
            num_gridHeight.Name = "num_gridHeight";
            num_gridHeight.Size = new Size(91, 23);
            num_gridHeight.TabIndex = 1;
            // 
            // lbl_gridWidth
            // 
            lbl_gridWidth.AutoSize = true;
            lbl_gridWidth.Location = new Point(3, 0);
            lbl_gridWidth.Name = "lbl_gridWidth";
            lbl_gridWidth.Size = new Size(39, 15);
            lbl_gridWidth.TabIndex = 2;
            lbl_gridWidth.Text = "Width";
            // 
            // check_gridWrapping
            // 
            check_gridWrapping.AutoSize = true;
            check_gridWrapping.DataBindings.Add(new Binding("Checked", binding_gridViewModel, "UseEdgeWrapping", true));
            check_gridWrapping.Location = new Point(217, 61);
            check_gridWrapping.Name = "check_gridWrapping";
            check_gridWrapping.Size = new Size(15, 14);
            check_gridWrapping.TabIndex = 4;
            check_gridWrapping.UseVisualStyleBackColor = true;
            // 
            // check_gridBacktracking
            // 
            check_gridBacktracking.AutoSize = true;
            check_gridBacktracking.DataBindings.Add(new Binding("Checked", binding_gridViewModel, "UseBacktracking", true));
            check_gridBacktracking.Location = new Point(217, 81);
            check_gridBacktracking.Name = "check_gridBacktracking";
            check_gridBacktracking.Size = new Size(15, 14);
            check_gridBacktracking.TabIndex = 6;
            check_gridBacktracking.UseVisualStyleBackColor = true;
            // 
            // group_simulation
            // 
            group_simulation.Controls.Add(layout_simulationParams);
            group_simulation.Location = new Point(3, 319);
            group_simulation.Name = "group_simulation";
            group_simulation.Size = new Size(597, 100);
            group_simulation.TabIndex = 3;
            group_simulation.TabStop = false;
            group_simulation.Text = "Simulation";
            // 
            // layout_simulationParams
            // 
            layout_simulationParams.ColumnCount = 2;
            layout_simulationParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.23544F));
            layout_simulationParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.76456F));
            layout_simulationParams.Controls.Add(btn_nextStep, 1, 1);
            layout_simulationParams.Controls.Add(btn_resetSimulation, 1, 2);
            layout_simulationParams.Dock = DockStyle.Fill;
            layout_simulationParams.Location = new Point(3, 19);
            layout_simulationParams.Margin = new Padding(0);
            layout_simulationParams.Name = "layout_simulationParams";
            layout_simulationParams.RowCount = 3;
            layout_simulationParams.RowStyles.Add(new RowStyle());
            layout_simulationParams.RowStyles.Add(new RowStyle());
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_simulationParams.Size = new Size(591, 78);
            layout_simulationParams.TabIndex = 1;
            // 
            // btn_nextStep
            // 
            btn_nextStep.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "StepSimulationCommand", true));
            btn_nextStep.Location = new Point(217, 3);
            btn_nextStep.Name = "btn_nextStep";
            btn_nextStep.Size = new Size(75, 23);
            btn_nextStep.TabIndex = 0;
            btn_nextStep.Text = "Step";
            btn_nextStep.UseVisualStyleBackColor = true;
            // 
            // binding_simulationViewModel
            // 
            binding_simulationViewModel.DataSource = typeof(ViewModels.MainForm.SimulationViewModel);
            // 
            // btn_resetSimulation
            // 
            btn_resetSimulation.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "ResetSimulationCommand", true));
            btn_resetSimulation.Location = new Point(217, 32);
            btn_resetSimulation.Name = "btn_resetSimulation";
            btn_resetSimulation.Size = new Size(75, 23);
            btn_resetSimulation.TabIndex = 1;
            btn_resetSimulation.Text = "Reset";
            btn_resetSimulation.UseVisualStyleBackColor = true;
            // 
            // group_tiles
            // 
            group_tiles.Controls.Add(layout_tiles);
            group_tiles.Location = new Point(3, 425);
            group_tiles.Name = "group_tiles";
            group_tiles.Size = new Size(597, 100);
            group_tiles.TabIndex = 4;
            group_tiles.TabStop = false;
            group_tiles.Text = "Tiles";
            // 
            // layout_tiles
            // 
            layout_tiles.ColumnCount = 2;
            layout_tiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.23544F));
            layout_tiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.76456F));
            layout_tiles.Controls.Add(combo_tileset, 1, 1);
            layout_tiles.Controls.Add(lbl_tileset, 0, 1);
            layout_tiles.Controls.Add(btn_newTileset, 1, 2);
            layout_tiles.Dock = DockStyle.Fill;
            layout_tiles.Location = new Point(3, 19);
            layout_tiles.Margin = new Padding(0);
            layout_tiles.Name = "layout_tiles";
            layout_tiles.RowCount = 3;
            layout_tiles.RowStyles.Add(new RowStyle());
            layout_tiles.RowStyles.Add(new RowStyle());
            layout_tiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_tiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout_tiles.Size = new Size(591, 78);
            layout_tiles.TabIndex = 1;
            // 
            // combo_tileset
            // 
            combo_tileset.BackColor = SystemColors.ControlLight;
            combo_tileset.FormattingEnabled = true;
            combo_tileset.Location = new Point(217, 3);
            combo_tileset.Name = "combo_tileset";
            combo_tileset.Size = new Size(121, 23);
            combo_tileset.TabIndex = 0;
            // 
            // lbl_tileset
            // 
            lbl_tileset.AutoSize = true;
            lbl_tileset.Location = new Point(3, 0);
            lbl_tileset.Name = "lbl_tileset";
            lbl_tileset.Size = new Size(85, 15);
            lbl_tileset.TabIndex = 8;
            lbl_tileset.Text = "Selected tileset";
            // 
            // btn_newTileset
            // 
            btn_newTileset.Location = new Point(217, 32);
            btn_newTileset.Name = "btn_newTileset";
            btn_newTileset.Size = new Size(75, 23);
            btn_newTileset.TabIndex = 9;
            btn_newTileset.Text = "Add tileset";
            btn_newTileset.UseVisualStyleBackColor = true;
            // 
            // picture_imageDisplay
            // 
            picture_imageDisplay.DataBindings.Add(new Binding("Image", binding_simulationViewModel, "DisplayImage", true));
            picture_imageDisplay.DataBindings.Add(new Binding("Size", binding_simulationViewModel, "DisplayImageSize", true));
            picture_imageDisplay.Location = new Point(603, 3);
            picture_imageDisplay.Name = "picture_imageDisplay";
            picture_imageDisplay.Size = new Size(200, 200);
            picture_imageDisplay.TabIndex = 1;
            picture_imageDisplay.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1200, 675);
            Controls.Add(layout_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Wave Function Collapse Image Generator";
            layout_main.ResumeLayout(false);
            layout_controls.ResumeLayout(false);
            group_grid.ResumeLayout(false);
            layout_gridParams.ResumeLayout(false);
            layout_gridParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_gridWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)binding_gridViewModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_gridHeight).EndInit();
            group_simulation.ResumeLayout(false);
            layout_simulationParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).EndInit();
            group_tiles.ResumeLayout(false);
            layout_tiles.ResumeLayout(false);
            layout_tiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown num_gridWidth;
        private Button btn_nextStep;
        private Button btn_resetSimulation;
        private Button btn_newTileset;
        private BindingSource binding_gridViewModel;
        private BindingSource binding_simulationViewModel;
        private PictureBox picture_imageDisplay;
    }
}
