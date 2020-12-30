using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class VariableTextComponentFactory : IComponentFactory
    {
        public string ComponentName => "Variable Text";

        public string Description => "Displays any text that you want it to show, with support for simple variable expansion.";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new VariableTextComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.VariableText.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("0.0.1");
    }
}
