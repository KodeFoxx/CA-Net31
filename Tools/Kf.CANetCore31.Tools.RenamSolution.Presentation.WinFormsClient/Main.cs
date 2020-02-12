using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            uxLogo.Image = Image.FromFile("kflogo.gif");

            var productBuildDate = GetBuildDate(Assembly.GetExecutingAssembly());
            uxProductBuildVersion.Text = $"v.{productBuildDate:yyyymmdd.HHmmss}";
        }

        private void uxClose_Click(object sender, System.EventArgs e)
            => Close();

        private void uxBrandLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var openBrowserProcess = new Process();
            openBrowserProcess.StartInfo.FileName = uxBrandLink.Text;
            openBrowserProcess.StartInfo.UseShellExecute = true;
            openBrowserProcess.Start();
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
    }
}
