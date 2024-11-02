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
            Label lbl_gridWrapping;
            Label lbl_gridHeight;
            NumericUpDown num_gridWidth;
            NumericUpDown num_gridHeight;
            Label lbl_gridWidth;
            CheckBox check_gridWrapping;
            GroupBox group_tiles;
            TableLayoutPanel layout_tiles;
            ComboBox combo_tileset;
            Label lbl_tileset;
            GroupBox group_simulation;
            TableLayoutPanel layout_simulationParams;
            FlowLayoutPanel layout_seed;
            NumericUpDown num_seed;
            CheckBox check_randomSeed;
            Label lbl_seed;
            NumericUpDown num_backtrackingDepth;
            Label lbl_backtrackingDepth;
            Label lbl_backtracking;
            CheckBox check_backtracking;
            FlowLayoutPanel layout_simulationButtons;
            binding_gridViewModel = new BindingSource(components);
            btn_newTileset = new Button();
            binding_simulationViewModel = new BindingSource(components);
            btn_resetSimulation = new Button();
            btn_nextStep = new Button();
            picture_imageDisplay = new PictureBox();
            layout_main = new TableLayoutPanel();
            layout_controls = new FlowLayoutPanel();
            group_grid = new GroupBox();
            layout_gridParams = new TableLayoutPanel();
            lbl_gridWrapping = new Label();
            lbl_gridHeight = new Label();
            num_gridWidth = new NumericUpDown();
            num_gridHeight = new NumericUpDown();
            lbl_gridWidth = new Label();
            check_gridWrapping = new CheckBox();
            group_tiles = new GroupBox();
            layout_tiles = new TableLayoutPanel();
            combo_tileset = new ComboBox();
            lbl_tileset = new Label();
            group_simulation = new GroupBox();
            layout_simulationParams = new TableLayoutPanel();
            layout_seed = new FlowLayoutPanel();
            num_seed = new NumericUpDown();
            check_randomSeed = new CheckBox();
            lbl_seed = new Label();
            num_backtrackingDepth = new NumericUpDown();
            lbl_backtrackingDepth = new Label();
            lbl_backtracking = new Label();
            check_backtracking = new CheckBox();
            layout_simulationButtons = new FlowLayoutPanel();
            layout_main.SuspendLayout();
            layout_controls.SuspendLayout();
            group_grid.SuspendLayout();
            layout_gridParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_gridWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binding_gridViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_gridHeight).BeginInit();
            group_tiles.SuspendLayout();
            layout_tiles.SuspendLayout();
            group_simulation.SuspendLayout();
            layout_simulationParams.SuspendLayout();
            layout_seed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_seed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_backtrackingDepth).BeginInit();
            layout_simulationButtons.SuspendLayout();
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
            layout_controls.Controls.Add(group_tiles);
            layout_controls.Controls.Add(group_simulation);
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
            layout_gridParams.Controls.Add(lbl_gridWrapping, 0, 2);
            layout_gridParams.Controls.Add(lbl_gridHeight, 0, 1);
            layout_gridParams.Controls.Add(num_gridWidth, 1, 0);
            layout_gridParams.Controls.Add(num_gridHeight, 1, 1);
            layout_gridParams.Controls.Add(lbl_gridWidth, 0, 0);
            layout_gridParams.Controls.Add(check_gridWrapping, 1, 2);
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
            num_gridWidth.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
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
            num_gridHeight.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
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
            check_gridWrapping.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
            check_gridWrapping.Location = new Point(217, 61);
            check_gridWrapping.Name = "check_gridWrapping";
            check_gridWrapping.Size = new Size(15, 14);
            check_gridWrapping.TabIndex = 4;
            check_gridWrapping.UseVisualStyleBackColor = true;
            // 
            // group_tiles
            // 
            group_tiles.Controls.Add(layout_tiles);
            group_tiles.Location = new Point(3, 319);
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
            // group_simulation
            // 
            group_simulation.Controls.Add(layout_simulationParams);
            group_simulation.Location = new Point(3, 425);
            group_simulation.Name = "group_simulation";
            group_simulation.Size = new Size(597, 166);
            group_simulation.TabIndex = 3;
            group_simulation.TabStop = false;
            group_simulation.Text = "Simulation";
            // 
            // layout_simulationParams
            // 
            layout_simulationParams.ColumnCount = 2;
            layout_simulationParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.23544F));
            layout_simulationParams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.76456F));
            layout_simulationParams.Controls.Add(layout_seed, 1, 2);
            layout_simulationParams.Controls.Add(lbl_seed, 0, 2);
            layout_simulationParams.Controls.Add(num_backtrackingDepth, 1, 1);
            layout_simulationParams.Controls.Add(lbl_backtrackingDepth, 0, 1);
            layout_simulationParams.Controls.Add(lbl_backtracking, 0, 0);
            layout_simulationParams.Controls.Add(check_backtracking, 1, 0);
            layout_simulationParams.Controls.Add(layout_simulationButtons, 0, 3);
            layout_simulationParams.Dock = DockStyle.Fill;
            layout_simulationParams.Location = new Point(3, 19);
            layout_simulationParams.Margin = new Padding(0);
            layout_simulationParams.Name = "layout_simulationParams";
            layout_simulationParams.RowCount = 4;
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.Size = new Size(591, 144);
            layout_simulationParams.TabIndex = 1;
            // 
            // layout_seed
            // 
            layout_seed.Controls.Add(num_seed);
            layout_seed.Controls.Add(check_randomSeed);
            layout_seed.Dock = DockStyle.Fill;
            layout_seed.Location = new Point(214, 72);
            layout_seed.Margin = new Padding(0);
            layout_seed.Name = "layout_seed";
            layout_seed.Size = new Size(377, 36);
            layout_seed.TabIndex = 9;
            // 
            // num_seed
            // 
            num_seed.BackColor = SystemColors.ControlLight;
            num_seed.DataBindings.Add(new Binding("Value", binding_simulationViewModel, "Seed", true));
            num_seed.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "UseSeed", true));
            num_seed.Location = new Point(3, 3);
            num_seed.Name = "num_seed";
            num_seed.Size = new Size(91, 23);
            num_seed.TabIndex = 12;
            // 
            // binding_simulationViewModel
            // 
            binding_simulationViewModel.DataSource = typeof(ViewModels.MainForm.SimulationViewModel);
            // 
            // check_randomSeed
            // 
            check_randomSeed.AutoSize = true;
            check_randomSeed.DataBindings.Add(new Binding("Checked", binding_simulationViewModel, "RandomizeSeed", true, DataSourceUpdateMode.OnPropertyChanged));
            check_randomSeed.Location = new Point(100, 3);
            check_randomSeed.Name = "check_randomSeed";
            check_randomSeed.Size = new Size(117, 19);
            check_randomSeed.TabIndex = 13;
            check_randomSeed.Text = "Use random seed";
            check_randomSeed.UseVisualStyleBackColor = true;
            // 
            // lbl_seed
            // 
            lbl_seed.AutoSize = true;
            lbl_seed.Location = new Point(3, 72);
            lbl_seed.Name = "lbl_seed";
            lbl_seed.Size = new Size(32, 15);
            lbl_seed.TabIndex = 11;
            lbl_seed.Text = "Seed";
            // 
            // num_backtrackingDepth
            // 
            num_backtrackingDepth.BackColor = SystemColors.ControlLight;
            num_backtrackingDepth.DataBindings.Add(new Binding("Value", binding_simulationViewModel, "BacktrackingDepth", true));
            num_backtrackingDepth.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "UseBacktracking", true));
            num_backtrackingDepth.Location = new Point(217, 39);
            num_backtrackingDepth.Name = "num_backtrackingDepth";
            num_backtrackingDepth.Size = new Size(91, 23);
            num_backtrackingDepth.TabIndex = 10;
            // 
            // lbl_backtrackingDepth
            // 
            lbl_backtrackingDepth.AutoSize = true;
            lbl_backtrackingDepth.Location = new Point(3, 36);
            lbl_backtrackingDepth.Name = "lbl_backtrackingDepth";
            lbl_backtrackingDepth.Size = new Size(109, 15);
            lbl_backtrackingDepth.TabIndex = 9;
            lbl_backtrackingDepth.Text = "Backtracking depth";
            // 
            // lbl_backtracking
            // 
            lbl_backtracking.AutoSize = true;
            lbl_backtracking.Location = new Point(3, 0);
            lbl_backtracking.Name = "lbl_backtracking";
            lbl_backtracking.Size = new Size(113, 15);
            lbl_backtracking.TabIndex = 7;
            lbl_backtracking.Text = "Enable backtracking";
            // 
            // check_backtracking
            // 
            check_backtracking.AutoSize = true;
            check_backtracking.DataBindings.Add(new Binding("Checked", binding_simulationViewModel, "UseBacktracking", true, DataSourceUpdateMode.OnPropertyChanged));
            check_backtracking.Location = new Point(217, 3);
            check_backtracking.Name = "check_backtracking";
            check_backtracking.Size = new Size(15, 14);
            check_backtracking.TabIndex = 6;
            check_backtracking.UseVisualStyleBackColor = true;
            // 
            // layout_simulationButtons
            // 
            layout_simulationParams.SetColumnSpan(layout_simulationButtons, 2);
            layout_simulationButtons.Controls.Add(btn_resetSimulation);
            layout_simulationButtons.Controls.Add(btn_nextStep);
            layout_simulationButtons.Dock = DockStyle.Fill;
            layout_simulationButtons.FlowDirection = FlowDirection.RightToLeft;
            layout_simulationButtons.Location = new Point(0, 108);
            layout_simulationButtons.Margin = new Padding(0);
            layout_simulationButtons.Name = "layout_simulationButtons";
            layout_simulationButtons.Size = new Size(591, 36);
            layout_simulationButtons.TabIndex = 8;
            // 
            // btn_resetSimulation
            // 
            btn_resetSimulation.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "ResetSimulationCommand", true));
            btn_resetSimulation.Location = new Point(513, 3);
            btn_resetSimulation.Name = "btn_resetSimulation";
            btn_resetSimulation.Size = new Size(75, 23);
            btn_resetSimulation.TabIndex = 1;
            btn_resetSimulation.Text = "Reset";
            btn_resetSimulation.UseVisualStyleBackColor = true;
            // 
            // btn_nextStep
            // 
            btn_nextStep.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "StepSimulationCommand", true));
            btn_nextStep.Location = new Point(432, 3);
            btn_nextStep.Name = "btn_nextStep";
            btn_nextStep.Size = new Size(75, 23);
            btn_nextStep.TabIndex = 0;
            btn_nextStep.Text = "Step";
            btn_nextStep.UseVisualStyleBackColor = true;
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
            group_tiles.ResumeLayout(false);
            layout_tiles.ResumeLayout(false);
            layout_tiles.PerformLayout();
            group_simulation.ResumeLayout(false);
            layout_simulationParams.ResumeLayout(false);
            layout_simulationParams.PerformLayout();
            layout_seed.ResumeLayout(false);
            layout_seed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_seed).EndInit();
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_backtrackingDepth).EndInit();
            layout_simulationButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_imageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_nextStep;
        private Button btn_resetSimulation;
        private Button btn_newTileset;
        private BindingSource binding_gridViewModel;
        private BindingSource binding_simulationViewModel;
        private PictureBox picture_imageDisplay;
    }
}
