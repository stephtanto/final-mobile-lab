using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp2016.AmazingRace.ViewModels {
	public class CluesItemViewModel {
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime RemainingTime { get; set; }
		public bool IsDone { get; set; }
	}
}
