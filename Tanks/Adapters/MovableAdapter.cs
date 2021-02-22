using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Classes;
using Tanks.Interfaces; 

namespace Tanks.Adapters
{
	class MovableAdapter : IMovable
	{
		IEntity Entity { get; set; }
		
		public MovableAdapter(IEntity entity)
		{
			Entity = entity;
		}

		public Point Position
		{
			get
			{
				return (Point)Entity["Position"];
			}
			set
			{
				Entity["Position"] = value;
			}
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
