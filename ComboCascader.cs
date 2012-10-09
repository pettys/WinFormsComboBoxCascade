using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CascadingComboSpike
{

	public class ComboCascader
	{

		public ComboBox Self { get; private set; }
		public ComboBox Parent { get; private set; }
		private readonly Action _selfPopulater;

		public ComboCascader(ComboBox parent, ComboBox self, Action selfPopulater)
		{
			Parent = parent;
			Self = self;
			_selfPopulater = selfPopulater;
			DoTheCascade();
			Parent.SelectedValueChanged += (src, args) => DoTheCascade();
			Parent.EnabledChanged += (src, args) => DoTheCascade();
		}

		private void DoTheCascade()
		{
			if (!Parent.Enabled)
			{
				Self.Enabled = false;
				Self.Items.Clear();
				return;
			}
			object previousValue = Self.SelectedItem;
			_selfPopulater();
			Self.Enabled = Self.Items.Count > 0;
			if (previousValue != null && Self.Items.Contains(previousValue))
			{
				Self.SelectedItem = previousValue;
			}
			else
			{
				Self.SelectedItem = null;
			}
		}

	}

}
