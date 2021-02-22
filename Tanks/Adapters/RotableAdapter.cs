using Tanks.Classes;
using Tanks.Interfaces;

namespace Tanks.Adapters
{
	class RotableAdapter : IRotable
	{
		IEntity Entity { get; set; }

		public RotableAdapter(IEntity entity)
		{
			Entity = entity;
		}

		public Point Velocity
		{
			get
			{
				return (Point)Entity["Velocity"];
			}
			set
			{
				Entity["Velocity"] = value;
			}
		}
	}
}
