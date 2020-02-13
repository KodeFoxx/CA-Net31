using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient.Wizard
{
    public sealed class WizardController<TWizardStep>
        where TWizardStep : IWizardStep
    {
        public WizardController(List<TWizardStep> wizardSteps)
        {
            _wizardSteps = (wizardSteps ?? new List<TWizardStep>())
                .Select((wizardStep, number) => KeyValuePair.Create(number + 1, wizardStep))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            _currentStepNumber = _wizardSteps.Keys.Count > 0
                ? _wizardSteps.Keys.Min()
                : 0;
        }

        private Dictionary<int, TWizardStep> _wizardSteps;
        private int _currentStepNumber;

        public int AmountOfSteps
            => _wizardSteps.Count;
        public int CurrentStepNumber
            => _currentStepNumber;
        public TWizardStep Current
            => _wizardSteps.Keys.Count > 0
                ? _wizardSteps[_currentStepNumber]
                : (TWizardStep)typeof(TWizardStep).GetProperty("Empty", BindingFlags.Static | BindingFlags.Public).GetValue(null);
        public bool HasNextStep => (AmountOfSteps - CurrentStepNumber) > 0;
        public bool HasPreviousStep => _currentStepNumber > 1;

        public TWizardStep Next()
        {
            if (HasNextStep)
                _currentStepNumber++;

            return Current;
        }

        public TWizardStep Previous()
        {
            if (HasPreviousStep)
                _currentStepNumber--;

            return Current;
        }
    }
}
