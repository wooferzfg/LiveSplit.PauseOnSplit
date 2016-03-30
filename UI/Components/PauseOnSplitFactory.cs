using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using UpdateManager;

[assembly: ComponentFactory(typeof(PauseOnSplitFactory))]

namespace LiveSplit.UI.Components
{
	public class PauseOnSplitFactory : IComponentFactory, IUpdateable
	{
		public string ComponentName
		{
			get
			{
				return "Pause On Split";
			}
		}

		public string Description
		{
			get
			{
				return "Pauses the timer immediately after you split.";
			}
		}

		public ComponentCategory Category
		{
			get
			{
				return ComponentCategory.Control;
			}
		}

		public string UpdateName
		{
			get
			{
				return ComponentName;
			}
		}

		public string XMLURL
		{
			get
			{
				return "http://livesplit.org/update/Components/noupdates.xml";
			}
		}

		public string UpdateURL
		{
			get
			{
				return "http://livesplit.org/update/";
			}
		}

		public Version Version
		{
			get
			{
				return Version.Parse("1.0.0");
			}
		}

		public IComponent Create(LiveSplitState state)
		{
			return new PauseOnSplit(state);
		}
	}
}
