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
            TableLayoutPanel layout_right;
            FlowLayoutPanel layout_rightConsoleButtons;
            binding_gridViewModel = new BindingSource(components);
            binding_tilesetViewModel = new BindingSource(components);
            data_availableTilesets = new BindingSource(components);
            btn_newTileset = new Button();
            binding_simulationViewModel = new BindingSource(components);
            btn_resetSimulation = new Button();
            btn_nextStep = new Button();
            btn_pause = new Button();
            btn_run = new Button();
            btn_saveImage = new Button();
            binding_imageViewModel = new BindingSource(components);
            btn_clearConsole = new Button();
            text_console = new TextBox();
            layout_pictureBoxContainer = new TableLayoutPanel();
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
            layout_right = new TableLayoutPanel();
            layout_rightConsoleButtons = new FlowLayoutPanel();
            layout_main.SuspendLayout();
            layout_controls.SuspendLayout();
            group_grid.SuspendLayout();
            layout_gridParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_gridWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binding_gridViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_gridHeight).BeginInit();
            group_tiles.SuspendLayout();
            layout_tiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)binding_tilesetViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_availableTilesets).BeginInit();
            group_simulation.SuspendLayout();
            layout_simulationParams.SuspendLayout();
            layout_seed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_seed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_backtrackingDepth).BeginInit();
            layout_simulationButtons.SuspendLayout();
            layout_right.SuspendLayout();
            layout_rightConsoleButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)binding_imageViewModel).BeginInit();
            layout_pictureBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_imageDisplay).BeginInit();
            SuspendLayout();
            // 
            // layout_main
            // 
            layout_main.ColumnCount = 2;
            layout_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.2815475F));
            layout_main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.71845F));
            layout_main.Controls.Add(layout_controls, 0, 0);
            layout_main.Controls.Add(layout_right, 1, 0);
            layout_main.Dock = DockStyle.Fill;
            layout_main.Location = new Point(0, 0);
            layout_main.Margin = new Padding(0);
            layout_main.Name = "layout_main";
            layout_main.RowCount = 1;
            layout_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_main.Size = new Size(1371, 900);
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
            layout_controls.Size = new Size(470, 900);
            layout_controls.TabIndex = 0;
            // 
            // group_grid
            // 
            group_grid.Controls.Add(layout_gridParams);
            group_grid.Location = new Point(3, 4);
            group_grid.Margin = new Padding(3, 4, 3, 4);
            group_grid.Name = "group_grid";
            group_grid.Padding = new Padding(3, 4, 3, 4);
            group_grid.Size = new Size(461, 413);
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
            layout_gridParams.Location = new Point(3, 24);
            layout_gridParams.Margin = new Padding(0);
            layout_gridParams.Name = "layout_gridParams";
            layout_gridParams.RowCount = 4;
            layout_gridParams.RowStyles.Add(new RowStyle());
            layout_gridParams.RowStyles.Add(new RowStyle());
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            layout_gridParams.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            layout_gridParams.Size = new Size(455, 385);
            layout_gridParams.TabIndex = 0;
            // 
            // lbl_gridWrapping
            // 
            lbl_gridWrapping.AutoSize = true;
            lbl_gridWrapping.Location = new Point(3, 70);
            lbl_gridWrapping.Name = "lbl_gridWrapping";
            lbl_gridWrapping.Size = new Size(96, 27);
            lbl_gridWrapping.TabIndex = 5;
            lbl_gridWrapping.Text = "Enable edge wrapping";
            // 
            // lbl_gridHeight
            // 
            lbl_gridHeight.AutoSize = true;
            lbl_gridHeight.Location = new Point(3, 35);
            lbl_gridHeight.Name = "lbl_gridHeight";
            lbl_gridHeight.Size = new Size(54, 20);
            lbl_gridHeight.TabIndex = 3;
            lbl_gridHeight.Text = "Height";
            // 
            // num_gridWidth
            // 
            num_gridWidth.BackColor = SystemColors.ControlLight;
            num_gridWidth.DataBindings.Add(new Binding("Value", binding_gridViewModel, "Width", true, DataSourceUpdateMode.OnPropertyChanged));
            num_gridWidth.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
            num_gridWidth.Location = new Point(167, 4);
            num_gridWidth.Margin = new Padding(3, 4, 3, 4);
            num_gridWidth.Name = "num_gridWidth";
            num_gridWidth.Size = new Size(104, 27);
            num_gridWidth.TabIndex = 0;
            // 
            // binding_gridViewModel
            // 
            binding_gridViewModel.DataSource = typeof(ViewModels.MainForm.GridViewModel);
            // 
            // num_gridHeight
            // 
            num_gridHeight.BackColor = SystemColors.ControlLight;
            num_gridHeight.DataBindings.Add(new Binding("Value", binding_gridViewModel, "Height", true, DataSourceUpdateMode.OnPropertyChanged));
            num_gridHeight.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
            num_gridHeight.Location = new Point(167, 39);
            num_gridHeight.Margin = new Padding(3, 4, 3, 4);
            num_gridHeight.Name = "num_gridHeight";
            num_gridHeight.Size = new Size(104, 27);
            num_gridHeight.TabIndex = 1;
            // 
            // lbl_gridWidth
            // 
            lbl_gridWidth.AutoSize = true;
            lbl_gridWidth.Location = new Point(3, 0);
            lbl_gridWidth.Name = "lbl_gridWidth";
            lbl_gridWidth.Size = new Size(49, 20);
            lbl_gridWidth.TabIndex = 2;
            lbl_gridWidth.Text = "Width";
            // 
            // check_gridWrapping
            // 
            check_gridWrapping.AutoSize = true;
            check_gridWrapping.DataBindings.Add(new Binding("Checked", binding_gridViewModel, "UseEdgeWrapping", true));
            check_gridWrapping.DataBindings.Add(new Binding("Enabled", binding_gridViewModel, "AllowEditing", true));
            check_gridWrapping.Location = new Point(167, 74);
            check_gridWrapping.Margin = new Padding(3, 4, 3, 4);
            check_gridWrapping.Name = "check_gridWrapping";
            check_gridWrapping.Size = new Size(18, 17);
            check_gridWrapping.TabIndex = 4;
            check_gridWrapping.UseVisualStyleBackColor = true;
            // 
            // group_tiles
            // 
            group_tiles.Controls.Add(layout_tiles);
            group_tiles.Location = new Point(3, 425);
            group_tiles.Margin = new Padding(3, 4, 3, 4);
            group_tiles.Name = "group_tiles";
            group_tiles.Padding = new Padding(3, 4, 3, 4);
            group_tiles.Size = new Size(461, 133);
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
            layout_tiles.Location = new Point(3, 24);
            layout_tiles.Margin = new Padding(0);
            layout_tiles.Name = "layout_tiles";
            layout_tiles.RowCount = 3;
            layout_tiles.RowStyles.Add(new RowStyle());
            layout_tiles.RowStyles.Add(new RowStyle());
            layout_tiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            layout_tiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            layout_tiles.Size = new Size(455, 105);
            layout_tiles.TabIndex = 1;
            // 
            // combo_tileset
            // 
            combo_tileset.BackColor = SystemColors.ControlLight;
            combo_tileset.DataBindings.Add(new Binding("SelectedItem", binding_tilesetViewModel, "SelectedTileset", true));
            combo_tileset.DataSource = data_availableTilesets;
            combo_tileset.DisplayMember = "Name";
            combo_tileset.FormattingEnabled = true;
            combo_tileset.Location = new Point(167, 4);
            combo_tileset.Margin = new Padding(3, 4, 3, 4);
            combo_tileset.Name = "combo_tileset";
            combo_tileset.Size = new Size(138, 28);
            combo_tileset.TabIndex = 0;
            // 
            // binding_tilesetViewModel
            // 
            binding_tilesetViewModel.AllowNew = false;
            binding_tilesetViewModel.DataSource = typeof(ViewModels.MainForm.Components.TilesetViewModel);
            // 
            // data_availableTilesets
            // 
            data_availableTilesets.DataMember = "AvailableTilesets";
            data_availableTilesets.DataSource = binding_tilesetViewModel;
            // 
            // lbl_tileset
            // 
            lbl_tileset.AutoSize = true;
            lbl_tileset.Location = new Point(3, 0);
            lbl_tileset.Name = "lbl_tileset";
            lbl_tileset.Size = new Size(110, 20);
            lbl_tileset.TabIndex = 8;
            lbl_tileset.Text = "Selected tileset";
            // 
            // btn_newTileset
            // 
            btn_newTileset.Location = new Point(167, 40);
            btn_newTileset.Margin = new Padding(3, 4, 3, 4);
            btn_newTileset.Name = "btn_newTileset";
            btn_newTileset.Size = new Size(86, 31);
            btn_newTileset.TabIndex = 9;
            btn_newTileset.Text = "Add tileset";
            btn_newTileset.UseVisualStyleBackColor = true;
            // 
            // group_simulation
            // 
            group_simulation.Controls.Add(layout_simulationParams);
            group_simulation.Location = new Point(3, 566);
            group_simulation.Margin = new Padding(3, 4, 3, 4);
            group_simulation.Name = "group_simulation";
            group_simulation.Padding = new Padding(3, 4, 3, 4);
            group_simulation.Size = new Size(461, 221);
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
            layout_simulationParams.Location = new Point(3, 24);
            layout_simulationParams.Margin = new Padding(0);
            layout_simulationParams.Name = "layout_simulationParams";
            layout_simulationParams.RowCount = 4;
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout_simulationParams.Size = new Size(455, 193);
            layout_simulationParams.TabIndex = 1;
            // 
            // layout_seed
            // 
            layout_seed.Controls.Add(num_seed);
            layout_seed.Controls.Add(check_randomSeed);
            layout_seed.Dock = DockStyle.Fill;
            layout_seed.Location = new Point(164, 96);
            layout_seed.Margin = new Padding(0);
            layout_seed.Name = "layout_seed";
            layout_seed.Size = new Size(291, 48);
            layout_seed.TabIndex = 9;
            // 
            // num_seed
            // 
            num_seed.BackColor = SystemColors.ControlLight;
            num_seed.DataBindings.Add(new Binding("Value", binding_simulationViewModel, "Seed", true));
            num_seed.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "UseSeed", true));
            num_seed.Location = new Point(3, 4);
            num_seed.Margin = new Padding(3, 4, 3, 4);
            num_seed.Name = "num_seed";
            num_seed.Size = new Size(104, 27);
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
            check_randomSeed.Location = new Point(113, 4);
            check_randomSeed.Margin = new Padding(3, 4, 3, 4);
            check_randomSeed.Name = "check_randomSeed";
            check_randomSeed.Size = new Size(146, 24);
            check_randomSeed.TabIndex = 13;
            check_randomSeed.Text = "Use random seed";
            check_randomSeed.UseVisualStyleBackColor = true;
            // 
            // lbl_seed
            // 
            lbl_seed.AutoSize = true;
            lbl_seed.Location = new Point(3, 96);
            lbl_seed.Name = "lbl_seed";
            lbl_seed.Size = new Size(42, 20);
            lbl_seed.TabIndex = 11;
            lbl_seed.Text = "Seed";
            // 
            // num_backtrackingDepth
            // 
            num_backtrackingDepth.BackColor = SystemColors.ControlLight;
            num_backtrackingDepth.DataBindings.Add(new Binding("Value", binding_simulationViewModel, "BacktrackingDepth", true));
            num_backtrackingDepth.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "UseBacktracking", true));
            num_backtrackingDepth.Location = new Point(167, 52);
            num_backtrackingDepth.Margin = new Padding(3, 4, 3, 4);
            num_backtrackingDepth.Name = "num_backtrackingDepth";
            num_backtrackingDepth.Size = new Size(104, 27);
            num_backtrackingDepth.TabIndex = 10;
            // 
            // lbl_backtrackingDepth
            // 
            lbl_backtrackingDepth.AutoSize = true;
            lbl_backtrackingDepth.Location = new Point(3, 48);
            lbl_backtrackingDepth.Name = "lbl_backtrackingDepth";
            lbl_backtrackingDepth.Size = new Size(136, 20);
            lbl_backtrackingDepth.TabIndex = 9;
            lbl_backtrackingDepth.Text = "Backtracking depth";
            // 
            // lbl_backtracking
            // 
            lbl_backtracking.AutoSize = true;
            lbl_backtracking.Location = new Point(3, 0);
            lbl_backtracking.Name = "lbl_backtracking";
            lbl_backtracking.Size = new Size(142, 20);
            lbl_backtracking.TabIndex = 7;
            lbl_backtracking.Text = "Enable backtracking";
            // 
            // check_backtracking
            // 
            check_backtracking.AutoSize = true;
            check_backtracking.DataBindings.Add(new Binding("Checked", binding_simulationViewModel, "UseBacktracking", true, DataSourceUpdateMode.OnPropertyChanged));
            check_backtracking.Location = new Point(167, 4);
            check_backtracking.Margin = new Padding(3, 4, 3, 4);
            check_backtracking.Name = "check_backtracking";
            check_backtracking.Size = new Size(18, 17);
            check_backtracking.TabIndex = 6;
            check_backtracking.UseVisualStyleBackColor = true;
            // 
            // layout_simulationButtons
            // 
            layout_simulationParams.SetColumnSpan(layout_simulationButtons, 2);
            layout_simulationButtons.Controls.Add(btn_resetSimulation);
            layout_simulationButtons.Controls.Add(btn_nextStep);
            layout_simulationButtons.Controls.Add(btn_pause);
            layout_simulationButtons.Controls.Add(btn_run);
            layout_simulationButtons.Dock = DockStyle.Fill;
            layout_simulationButtons.FlowDirection = FlowDirection.RightToLeft;
            layout_simulationButtons.Location = new Point(0, 144);
            layout_simulationButtons.Margin = new Padding(0);
            layout_simulationButtons.Name = "layout_simulationButtons";
            layout_simulationButtons.Size = new Size(455, 49);
            layout_simulationButtons.TabIndex = 8;
            // 
            // btn_resetSimulation
            // 
            btn_resetSimulation.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "ResetSimulationCommand", true));
            btn_resetSimulation.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "EnableResetButton", true));
            btn_resetSimulation.Location = new Point(366, 4);
            btn_resetSimulation.Margin = new Padding(3, 4, 3, 4);
            btn_resetSimulation.Name = "btn_resetSimulation";
            btn_resetSimulation.Size = new Size(86, 31);
            btn_resetSimulation.TabIndex = 1;
            btn_resetSimulation.Text = "Reset";
            btn_resetSimulation.UseVisualStyleBackColor = true;
            // 
            // btn_nextStep
            // 
            btn_nextStep.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "StepSimulationCommand", true));
            btn_nextStep.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "EnableStepButton", true));
            btn_nextStep.Location = new Point(274, 4);
            btn_nextStep.Margin = new Padding(3, 4, 3, 4);
            btn_nextStep.Name = "btn_nextStep";
            btn_nextStep.Size = new Size(86, 31);
            btn_nextStep.TabIndex = 0;
            btn_nextStep.Text = "Step";
            btn_nextStep.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            btn_pause.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "PauseSimulationCommand", true));
            btn_pause.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "EnablePauseButton", true));
            btn_pause.Location = new Point(182, 4);
            btn_pause.Margin = new Padding(3, 4, 3, 4);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(86, 31);
            btn_pause.TabIndex = 2;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            btn_run.DataBindings.Add(new Binding("Command", binding_simulationViewModel, "RunSimulationCommand", true));
            btn_run.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "EnableRunButton", true));
            btn_run.Location = new Point(90, 4);
            btn_run.Margin = new Padding(3, 4, 3, 4);
            btn_run.Name = "btn_run";
            btn_run.Size = new Size(86, 31);
            btn_run.TabIndex = 3;
            btn_run.Text = "Run";
            btn_run.UseVisualStyleBackColor = true;
            // 
            // layout_right
            // 
            layout_right.ColumnCount = 1;
            layout_right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout_right.Controls.Add(layout_rightConsoleButtons, 0, 2);
            layout_right.Controls.Add(text_console, 0, 1);
            layout_right.Controls.Add(layout_pictureBoxContainer, 0, 0);
            layout_right.Dock = DockStyle.Fill;
            layout_right.Location = new Point(470, 0);
            layout_right.Margin = new Padding(0);
            layout_right.Name = "layout_right";
            layout_right.RowCount = 3;
            layout_right.RowStyles.Add(new RowStyle(SizeType.Percent, 78.3333359F));
            layout_right.RowStyles.Add(new RowStyle(SizeType.Percent, 21.6666641F));
            layout_right.RowStyles.Add(new RowStyle());
            layout_right.Size = new Size(901, 900);
            layout_right.TabIndex = 6;
            // 
            // layout_rightConsoleButtons
            // 
            layout_rightConsoleButtons.Controls.Add(btn_saveImage);
            layout_rightConsoleButtons.Controls.Add(btn_clearConsole);
            layout_rightConsoleButtons.Dock = DockStyle.Fill;
            layout_rightConsoleButtons.FlowDirection = FlowDirection.RightToLeft;
            layout_rightConsoleButtons.Location = new Point(0, 857);
            layout_rightConsoleButtons.Margin = new Padding(0);
            layout_rightConsoleButtons.Name = "layout_rightConsoleButtons";
            layout_rightConsoleButtons.Size = new Size(901, 43);
            layout_rightConsoleButtons.TabIndex = 11;
            // 
            // btn_saveImage
            // 
            btn_saveImage.DataBindings.Add(new Binding("Command", binding_imageViewModel, "SaveImageCommand", true));
            btn_saveImage.DataBindings.Add(new Binding("Enabled", binding_simulationViewModel, "EnableResetButton", true));
            btn_saveImage.Location = new Point(769, 4);
            btn_saveImage.Margin = new Padding(3, 4, 3, 4);
            btn_saveImage.Name = "btn_saveImage";
            btn_saveImage.Size = new Size(129, 31);
            btn_saveImage.TabIndex = 1;
            btn_saveImage.Text = "Save image";
            btn_saveImage.UseVisualStyleBackColor = true;
            // 
            // binding_imageViewModel
            // 
            binding_imageViewModel.DataSource = typeof(ViewModels.MainForm.Components.ImageViewModel);
            // 
            // btn_clearConsole
            // 
            btn_clearConsole.Location = new Point(634, 4);
            btn_clearConsole.Margin = new Padding(3, 4, 3, 4);
            btn_clearConsole.Name = "btn_clearConsole";
            btn_clearConsole.Size = new Size(129, 31);
            btn_clearConsole.TabIndex = 0;
            btn_clearConsole.Text = "Clear console";
            btn_clearConsole.UseVisualStyleBackColor = true;
            btn_clearConsole.Click += Btn_clearConsole_Click;
            // 
            // text_console
            // 
            text_console.Location = new Point(3, 675);
            text_console.Multiline = true;
            text_console.Name = "text_console";
            text_console.Size = new Size(895, 178);
            text_console.TabIndex = 2;
            // 
            // layout_pictureBoxContainer
            // 
            layout_pictureBoxContainer.ColumnCount = 1;
            layout_pictureBoxContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout_pictureBoxContainer.Controls.Add(picture_imageDisplay, 0, 0);
            layout_pictureBoxContainer.Dock = DockStyle.Fill;
            layout_pictureBoxContainer.Location = new Point(0, 0);
            layout_pictureBoxContainer.Margin = new Padding(0);
            layout_pictureBoxContainer.Name = "layout_pictureBoxContainer";
            layout_pictureBoxContainer.RowCount = 1;
            layout_pictureBoxContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_pictureBoxContainer.Size = new Size(901, 672);
            layout_pictureBoxContainer.TabIndex = 3;
            // 
            // picture_imageDisplay
            // 
            picture_imageDisplay.Anchor = AnchorStyles.None;
            picture_imageDisplay.DataBindings.Add(new Binding("Image", binding_imageViewModel, "DisplayImage", true));
            picture_imageDisplay.Location = new Point(400, 286);
            picture_imageDisplay.Margin = new Padding(3, 4, 3, 4);
            picture_imageDisplay.Name = "picture_imageDisplay";
            picture_imageDisplay.Size = new Size(100, 100);
            picture_imageDisplay.TabIndex = 1;
            picture_imageDisplay.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1371, 900);
            Controls.Add(layout_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Wave Function Collapse Image Generator";
            Load += MainForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)binding_tilesetViewModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_availableTilesets).EndInit();
            group_simulation.ResumeLayout(false);
            layout_simulationParams.ResumeLayout(false);
            layout_simulationParams.PerformLayout();
            layout_seed.ResumeLayout(false);
            layout_seed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_seed).EndInit();
            ((System.ComponentModel.ISupportInitialize)binding_simulationViewModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_backtrackingDepth).EndInit();
            layout_simulationButtons.ResumeLayout(false);
            layout_right.ResumeLayout(false);
            layout_right.PerformLayout();
            layout_rightConsoleButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)binding_imageViewModel).EndInit();
            layout_pictureBoxContainer.ResumeLayout(false);
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
        private TextBox text_console;
        private Button btn_pause;
        private Button btn_run;
        private BindingSource binding_imageViewModel;
        private BindingSource binding_tilesetViewModel;
        private BindingSource data_availableTilesets;
        private TableLayoutPanel layout_pictureBoxContainer;
        private Button btn_saveImage;
        private Button btn_clearConsole;
    }
}
