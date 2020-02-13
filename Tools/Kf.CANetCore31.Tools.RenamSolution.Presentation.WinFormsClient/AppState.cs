using Kf.CANetCore31.Tools.RenameSolution.Domain;
using System.Collections.Generic;

namespace Kf.CANetCore31.Tools.RenameSolution.Presentation.WinFormsClient
{
    public static class AppState
    {
        public static string SolutionPath { get; set; }
        public static KeyValuePair<Solution, SolutionLoadException> Solution {
            get {
                try
                {
                    return KeyValuePair.Create<Solution, SolutionLoadException>(Domain.Solution.LoadFrom(SolutionPath), null);
                }
                catch (SolutionLoadException solutionLoadException)
                {
                    return KeyValuePair.Create(Domain.Solution.Empty, solutionLoadException);
                }
            }
        }
    }
}
