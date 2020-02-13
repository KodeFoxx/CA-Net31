using Kf.CANetCore31.Tools.RenameSolution.Presentation.WinFormsClient;
using Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient.Wizard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient
{
    public partial class Main : Form
    {
        #region Main Load
        static Main()
        {
            _wizard = new WizardController<WizardStep<Panel>>(new List<WizardStep<Panel>>
            {
                WizardStep<Panel>.Create(
                    "Select a solution",
                    GetWizardPanel(1)),
                WizardStep<Panel>.Create(
                    "Select a new name for the solution",
                    GetWizardPanel(2)),
                WizardStep<Panel>.Create(
                    "Select an output directory",
                    GetWizardPanel(3)),
                WizardStep<Panel>.Create(
                    "Review steps",
                    GetWizardPanel(4)),
                WizardStep<Panel>.Create(
                    "Execute",
                    GetWizardPanel(5))
            });
            SetWizardPanelDescriptions(_wizard);
        }
        public Main()
            => InitializeComponent();
        private void Main_Load(object sender, System.EventArgs e)
        {
            uxLogo.Image = Image.FromFile("kflogo.gif");

            var productBuildDate = GetBuildDate(Assembly.GetExecutingAssembly());
            uxProductBuildVersion.Text = $"v.{productBuildDate:yyyymmdd.HHmmss}";

            UpdatePanel();
        }
        private DateTime GetBuildDate(Assembly assembly)
        {
            const string BuildVersionMetadataPrefix = "+build";

            var attribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (attribute?.InformationalVersion != null)
            {
                var value = attribute.InformationalVersion;
                var index = value.IndexOf(BuildVersionMetadataPrefix);
                if (index > 0)
                {
                    value = value.Substring(index + BuildVersionMetadataPrefix.Length);
                    if (DateTime.TryParseExact(value, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
                        return result;
                }
            }

            return default;
        }
        #endregion

        #region Wizard
        private static WizardController<WizardStep<Panel>> _wizard;
        private static Panel GetWizardPanel(int panelNumber)
        {
            var formContainer = new PanelHolder();
            var stepTag = $"WizardStep_{panelNumber}";
            var controls = ((IEnumerable)formContainer.Controls).Cast<Control>().ToList();

            var panel = controls
                .Where(c => c.GetType() == typeof(Panel))
                .Cast<Panel>()
                .FirstOrDefault(p => p.Tag.Equals(stepTag));

            return panel ?? new Panel();
        }
        private static void SetWizardPanelDescriptions(
            WizardController<WizardStep<Panel>> wizardController)
        {
            var counter = 0;
            foreach (var wizardStep in wizardController.Steps)
            {
                counter++;
                var panel = wizardStep.Data;

                if (panel != null)
                {
                    var panelTitle = ((IEnumerable)panel.Controls).Cast<Control>().ToList()
                        .Where(c => c.GetType() == typeof(Label))
                        .Cast<Label>()
                        .FirstOrDefault(l => l.Text.StartsWith("{description}"));

                    if (panelTitle != null)
                        panelTitle.Text = _wizard.GetStepAt(counter).Description;
                }
            }
        }
        private void NextStep()
        {
            var wizardStep = _wizard.Next();
            UpdatePanel();
        }
        private void PreviousStep()
        {
            var wizardStep = _wizard.Previous();
            UpdatePanel();
        }
        private void uxNext_Click(object sender, EventArgs e)
            => NextStep();
        private void uxPrevious_Click(object sender, EventArgs e)
            => PreviousStep();
        private void UpdatePanel()
        {
            uxStepCount.Text = $"{_wizard.CurrentStepNumber}/{_wizard.AmountOfSteps}";
            uxStepInfo.Text = _wizard.Current.Description;
            uxNext.Enabled = _wizard.HasNextStep;
            uxPrevious.Enabled = _wizard.HasPreviousStep;
            uxPanelContainer.Controls.Clear();
            uxPanelContainer.Controls.Add(_wizard.Current.Data);
        }
        #endregion

        #region Click Handlers
        private void uxClose_Click(object sender, System.EventArgs e)
            => Close();

        private void uxBrandLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var openBrowserProcess = new Process();
            openBrowserProcess.StartInfo.FileName = uxBrandLink.Text;
            openBrowserProcess.StartInfo.UseShellExecute = true;
            openBrowserProcess.Start();
        }
        #endregion
    }
}
