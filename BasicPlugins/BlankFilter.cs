using System.Text.RegularExpressions;
using Rein.Plugins;

namespace Rein.BasicPlugins {
	public class BlankFilter : IPlugin {
		public string Name { get; } = "Rein.BasicPlugins.BlankFilter";
		// TRANSLATORS: Bot-Help message. BlankFilter plugin.
		public string HelpText { get; } = T._("Filter to blank messages.");
		Plugins.Type IPlugin.Type => Plugins.Type.Filter;

		private static Regex SPACE_ONLY = new Regex(@"^[\s\r\n]+$");

		public void Initialize(IPluginManager loader, IPlugin[] plugins) { }

		public bool Execute(IBot bot, IMessage message) {
			if (SPACE_ONLY.IsMatch(message.Content)) {
				message.Content = "";
				message.AppliedPlugins.Add(this.Name);
				return true;
			}
			return false;
		}
	}
}
