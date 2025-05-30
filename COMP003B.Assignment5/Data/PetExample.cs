﻿using COMP003B.Assignment5.Models;

namespace COMP003B.Assignment5.Data
{
	public class PetExample
	{
		public static List<Pets> PetDescription { get; } = new()
		{
			new Pets
			{
				Id = 4,
				Name = "Sumo",
				Type = "Great Pyrenees",
				Age = 4
			},

			new Pets
			{
				Id = 3,
				Name = "Maya",
				Type = "Pitbull",
				Age = 6
			},

			new Pets
			{
				Id = 2,
				Name = "Charlie",
				Type = "Chihuahua",
				Age = 1
			}
		};
	}
}
