using System.ComponentModel;

using WaveFunctionCollapseImageGenerator.Common.Loggers;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm.Components;

namespace WaveFunctionCollapseImageGenerator
{
    public partial class MainForm : Form
    {
        public MainForm(MainFormViewModel viewModel, IEventLogPublihser logPublisher)
        {
            ViewModel = viewModel;

            InitializeComponent();

            binding_gridViewModel.DataSource = ViewModel.GridViewModel;
            binding_simulationViewModel.DataSource = ViewModel.SimulationViewModel;
            binding_imageViewModel.DataSource = ViewModel.ImageViewModel;
            binding_tilesetViewModel.DataSource = ViewModel.TilesetViewModel;

            ViewModel.ImageViewModel.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(ImageViewModel.DisplayImageSize))
                    ScaleImage(ViewModel.ImageViewModel.DisplayImageSize);
            };
            logPublisher.Logged += (s, e) => Invoke(() => text_console.AppendText($"{e.Message}{Environment.NewLine}"));
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainFormViewModel ViewModel { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ = ViewModel.InitializeAsync();
        }

        private void ScaleImage(Size requestedImageSize)
        {
            if (requestedImageSize.Width > layout_pictureBoxContainer.Size.Width || requestedImageSize.Height > layout_pictureBoxContainer.Size.Height)
            {
                picture_imageDisplay.Size = new(Math.Min(layout_pictureBoxContainer.Width, requestedImageSize.Width), Math.Min(layout_pictureBoxContainer.Height, requestedImageSize.Height));
                picture_imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picture_imageDisplay.Size = requestedImageSize;
                picture_imageDisplay.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void Btn_clearConsole_Click(object sender, EventArgs e) => text_console.Clear();

        private void Btn_saveImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}