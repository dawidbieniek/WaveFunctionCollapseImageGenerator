using System.ComponentModel;

using WaveFunctionCollapseImageGenerator.Common.Loggers;
using WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

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

            logPublisher.Logged += (s, e) => Invoke(() => text_console.AppendText($"{e.Message}{Environment.NewLine}"));
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainFormViewModel ViewModel { get; set; }
    }
}