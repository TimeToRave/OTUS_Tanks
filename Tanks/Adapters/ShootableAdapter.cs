using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Interfaces;

namespace Tanks.Adapters
{
	class ShootableAdapter : IShootable
	{
		IEntity Entity { get; set; }

		public ShootableAdapter(IEntity entity)
		{
			Entity = entity;
		}

		public IEntity Weapon
		{
			get
			{
				return (IEntity)Entity["Weapon"];
			}
			set
			{
				Entity["Weapon"] = value;
			}
		}
	}
}
