using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
	public class PauseOnSplit : IComponent, IDisposable
	{
		public float PaddingTop
		{
			get
			{
				return 0f;
			}
		}

		public float PaddingLeft
		{
			get
			{
				return 0f;
			}
		}

		public float PaddingBottom
		{
			get
			{
				return 0f;
			}
		}

		public float PaddingRight
		{
			get
			{
				return 0f;
			}
		}

		protected ITimerModel Model
		{
			get;
			set;
		}

		protected LiveSplitState CurrentState
		{
			get;
			set;
		}

		public float VerticalHeight
		{
			get
			{
				return 0f;
			}
		}

		public float MinimumWidth
		{
			get
			{
				return 0f;
			}
		}

		public float HorizontalWidth
		{
			get
			{
				return 0f;
			}
		}

		public float MinimumHeight
		{
			get
			{
				return 0f;
			}
		}

		public string ComponentName
		{
			get
			{
				return "Pause On Split";
			}
		}

		public IDictionary<string, Action> ContextMenuControls
		{
			get
			{
				return null;
			}
		}

		public PauseOnSplit(LiveSplitState state)
		{
			var timerModel = new TimerModel();
            timerModel.CurrentState = state;
            Model = timerModel;
            state.OnSplit += State_OnSplit;
            CurrentState = state;
		}

        private void State_OnSplit(object sender, EventArgs e)
        {
            Model.Pause();
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
		{
		}

		public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
		{
		}

		public Control GetSettingsControl(LayoutMode mode)
		{
			return null;
		}

		public void SetSettings(XmlNode settings)
		{
		}

		public XmlNode GetSettings(XmlDocument document)
		{
            return document.CreateElement("PauseOnSplit");
		}

		public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
		{
		}

		public void Dispose()
		{
            CurrentState.OnSplit -= State_OnSplit;
		}
	}
}
