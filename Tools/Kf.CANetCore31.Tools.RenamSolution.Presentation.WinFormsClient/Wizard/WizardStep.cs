using Kf.CANetCore31.DomainDrivenDesign;
using System.Collections.Generic;

namespace Kf.CANetCore31.Tools.RenamSolution.Presentation.WinFormsClient.Wizard
{
    public class WizardStep
        : ValueObject, IWizardStep
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

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Description);
    }

    public sealed class WizardStep<TData>
        : ValueObject, IWizardStep
    {
        public static WizardStep<TData> Empty
            => new WizardStep<TData>();

        public static WizardStep<TData> Create(string description, TData data)
            => new WizardStep<TData>(description, data);

        private WizardStep(string description, TData data)
        {
            _wizardStep = WizardStep.Create(description);
            Data = data;
        }
        private WizardStep()
            : this(null, default)
        { }

        private readonly WizardStep _wizardStep;

        public string Description => _wizardStep.Description;
        public TData Data { get; }

        protected override IEnumerable<object> EquatableValues
            => new object[] { Description, Data };

        public override string DebuggerDisplayString
            => this.CreateDebugString(x => x.Description);
    }
}
