﻿using System;
using System.Collections.Generic;
using System.Text;

namespace congestion.calculator.Models
{
	public class Tractor : Vehicle
	{
		public Tractor()
		{
			Name = "Tractor";
		}
		public string Name { get; set; }
		public string GetVehicleType() => Name;
	}
}
