using System.Collections.Generic;
using System.Linq;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient.Wizard
{
    public sealed class WizardController
    {
        public WizardController(List<WizardStep> wizardSteps)
        {
            _wizardSteps = (wizardSteps ?? new List<WizardStep>())
                .Select((wizardStep, number) => KeyValuePair.Create(number + 1, wizardStep))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            _currentStepNumber = _wizardSteps.Keys.Count > 0
                ? _wizardSteps.Keys.Min()
                : 0;
        }

        private Dictionary<int, WizardStep> _wizardSteps;
        private int _currentStepNumber;

        public int AmountOfSteps
            => _wizardSteps.Count;
        public int CurrentStepNumber
            => _currentStepNumber;
        public WizardStep Current
            => _wizardSteps.Keys.Count > 0
                ? _wizardSteps[_currentStepNumber]
                : WizardStep.Empty;
        public bool HasNextStep => (AmountOfSteps - CurrentStepNumber) > 0;

        public WizardStep Next()
        {
            if (HasNextStep)
                _currentStepNumber++;

            return Current;
        }
    }
}
