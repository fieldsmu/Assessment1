using Assessment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment1.ViewModels {
	public class VehiclesForOwner {

		public Owner Owner { get; set; }
		public IEnumerable<Vehicle> Vehicles { get; set; }

		public VehiclesForOwner() {

		}
	}
}