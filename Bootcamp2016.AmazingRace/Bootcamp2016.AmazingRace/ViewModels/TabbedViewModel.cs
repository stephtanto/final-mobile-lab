﻿using System.Collections.Generic;
using Caliburn.Micro;

namespace Bootcamp2016.AmazingRace.ViewModels
{
    /// <summary>
    /// Tabbed view to contain a leader list and a clues list
    /// </summary>
    public class TabbedViewModel : Conductor<BaseScreen>.Collection.OneActive
    {
		public TabbedViewModel(IEnumerable<BaseScreen> tabs) {
			Items.AddRange(tabs);
		}
	}
}
