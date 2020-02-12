using Kf.CANetCore31.DomainDrivenDesign;
using System.Collections.Generic;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient.Wizard
{
    public sealed class WizardStep : ValueObject
    {
        public static WizardStep Empty
            => new WizardStep();

        public static WizardStep Create(string description)
            => new WizardStep(description);

        private WizardStep(string description)
            => Description = description;
        private WizardStep()
            : this(null)
        { }

        public string Description { get; }

        protected override IEnumerable<object> EquatableValues
            => new[] { Description };
    }
}
