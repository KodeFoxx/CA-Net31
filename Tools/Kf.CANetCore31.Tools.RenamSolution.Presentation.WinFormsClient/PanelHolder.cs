using Kf.CANetCore31.Tools.RenameSolution.Domain;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kf.CANetCore31.Tools.RenameSolution.Presentation.WinFormsClient
{
    public partial class PanelHolder : Form
    {
        public PanelHolder()
        {
            InitializeComponent();
        }

        #region Constants
        private readonly Color _controlLightLight = SystemColors.ControlLightLight;
        private readonly Color _controlLight = SystemColors.ControlLight;
        private readonly Color _errorColor = Color.Salmon;
        private readonly Color _errorColorText = Color.White;
        private readonly Color _errorColorBorder = Color.Red;
        private readonly Color _okColor = Color.LightGreen;
        private readonly Color _okColorText = Color.Black;
        private readonly Color _okColorBorder = Color.Green;
        #endregion

        #region Step 1
        private void BrowseSolutionPath()
        {
            var oldSolutionPath = uxSolutionPath.Text;
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Visual Studio Solution (*.sln)|*.sln";
                openFileDialog.Title = "Select a Visual Studio Solution file...";
                openFileDialog.CheckPathExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Multiselect = false;

                var result = openFileDialog.ShowDialog();

                if (!(new DialogResult[] { DialogResult.Yes, DialogResult.OK }.Contains(result)))
                    AppState.SolutionPath = oldSolutionPath;
                else
                    AppState.SolutionPath = openFileDialog.FileName;

                UpdateSolutionPath();
            }
        }
        private void UpdateSolutionPath()
        {
            uxSolutionPath.Text = AppState.SolutionPath;
            if (File.Exists(AppState.SolutionPath) && AppState.Solution.Key != Solution.Empty)
                ColorControlOk(uxSolutionPath);
            else
            {
                ColorControlError(uxSolutionPath);

                MessageBox.Show(
                    AppState.Solution.Value.InnerException.Message,
                    AppState.Solution.Value.GetType().GetTypeName(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void uxBrowseSolutionPath_Click(object sender, System.EventArgs e)
            => BrowseSolutionPath();
        #endregion

        #region Color Handling
        private void ColorControlError(Control control)
        {
            control.BackColor = _errorColor;
            control.ForeColor = _errorColorText;
        }
        private void ColorControlOk(Control control)
        {
            control.BackColor = _okColor;
            control.ForeColor = _okColorText;
        }
        #endregion
    }
}
