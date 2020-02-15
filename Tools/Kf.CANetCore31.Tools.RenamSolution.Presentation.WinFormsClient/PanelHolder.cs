using Kf.CANetCore31.Tools.RenameSolution.Domain;
using Microsoft.Build.Construction;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Kf.CANetCore31.Tools.RenameSolution.Presentation.WinFormsClient
{
    public partial class PanelHolder : Form
    {
        public PanelHolder()
        {
            InitializeComponent();
            UpdateSolutionPath(showError: false);
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
                if (oldSolutionPath.IsNullOrWhiteSpace())
                    openFileDialog.InitialDirectory = SolutionFileScanner.Scan(Assembly.GetExecutingAssembly().Location, true).FirstOrDefault()?.FileInfo?.DirectoryName;
                else
                    openFileDialog.InitialDirectory = oldSolutionPath;

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
        private void ClearSolutionPath()
        {
            AppState.SolutionPath = null;
            UpdateSolutionPath(showError: false);
        }
        private void UpdateSolutionPath(bool showError = true)
        {
            uxSolutionPath.Text = AppState.SolutionPath;
            if (File.Exists(AppState.SolutionPath) && AppState.Solution.Key != Solution.Empty)
            {
                ColorControlOk(uxSolutionPath);

                var solutionName = AppState.Solution.Key.FileInfo.Name;
                var solution = AppState.Solution.Key.SolutionFile;
                var projects = solution.ProjectsInOrder;

                uxSelectedSolutionInfo.Enabled = true;
                uxSelectedSolutionInfo.Text = $" Selected solution '{solutionName}' ";
                uxSolutionName.Text = solutionName;
                uxRootNamespace.Text = solutionName.Replace(".sln", "");
                BuildProjectOverviewTab(projects);
                BuildProjectStructureTab(projects);

                uxProjectsToggelOverview_LinkClicked(null, null);
            }
            else
            {
                ColorControlError(uxSolutionPath);

                uxSelectedSolutionInfo.Enabled = false;
                uxSelectedSolutionInfo.Text = $" (no solution selected) ";
                uxSolutionName.Text = "";
                uxRootNamespace.Text = "";
                uxProjects.Items.Clear();
                uxProjects.Columns.Clear();

                if (showError)
                    MessageBox.Show(
                        AppState.Solution.Value.InnerException.Message,
                        AppState.Solution.Value.GetType().GetTypeName(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void BuildProjectOverviewTab(IReadOnlyList<ProjectInSolution> projects)
        {
            uxProjects.Visible = false;
            uxProjects.Items.Clear();
            uxProjects.Columns.Clear();
            uxProjects.Columns.Add("Name");
            uxProjects.Columns.Add("Type");
            uxProjects.Columns.Add("Relative path");
            uxProjects.Columns.Add("Guid");
            uxProjects.Columns.Add("Parent guid");
            foreach (var project in projects.Where(p => p.ProjectType == SolutionProjectType.KnownToBeMSBuildFormat))
            {
                var listViewItem = new ListViewItem(project.ProjectName);
                var listViewSubItems = new ListViewItem.ListViewSubItem[] {
                            new ListViewItem.ListViewSubItem(listViewItem, project.ProjectType.ToString()),
                            new ListViewItem.ListViewSubItem(listViewItem, project.RelativePath),
                            new ListViewItem.ListViewSubItem(listViewItem, project.ProjectGuid),
                            new ListViewItem.ListViewSubItem(listViewItem, project.ParentProjectGuid),
                        };
                listViewItem.SubItems.AddRange(listViewSubItems);
                uxProjects.Items.Add(listViewItem);
            }
            uxProjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            uxProjects.Visible = true;
        }
        private void BuildProjectStructureTab(IReadOnlyList<ProjectInSolution> projects)
        {
            uxProjectsStructure.Visible = false;
            uxProjectsStructure.Nodes.Clear();
            uxProjectsStructure.Nodes.Add("(work in progress, feauture in development)");
            uxProjectsStructure.Visible = true;
        }

        private void uxBrowseSolutionPath_Click(object sender, System.EventArgs e)
            => BrowseSolutionPath();
        private void uxClearSolutionPath_Click(object sender, System.EventArgs e)
            => ClearSolutionPath();
        private void uxProjectsToggelOverview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uxProjects.Visible = true;
            uxProjects.Location = new Point(10, 93);
            uxProjects.Size = new Size(814, 217);
            uxProjectsStructure.Visible = false;
        }
        private void uxProjectsToggleProjectStructure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uxProjects.Visible = false;
            uxProjectsStructure.Location = new Point(10, 93);
            uxProjectsStructure.Size = new Size(814, 217);
            uxProjectsStructure.Visible = true;
        }
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
