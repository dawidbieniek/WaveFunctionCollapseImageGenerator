using System.ComponentModel;

using WaveFunctionCollapseImageGenerator.ViewModels.MainForm;

namespace WaveFunctionCollapseImageGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            ViewModel = new();

            InitializeComponent();

            binding_gridViewModel.DataSource = ViewModel.GridViewModel;
            binding_simulationViewModel.DataSource = ViewModel.SimulationViewModel;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainFormViewModel ViewModel { get; set; }
    }
}