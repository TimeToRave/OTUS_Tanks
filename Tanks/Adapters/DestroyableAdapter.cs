using Tanks.Interfaces;

namespace Tanks.Adapters
{
	public class DestroyableAdapter : IDestroyable
	{
		IEntity Entity { get; set; }

		public DestroyableAdapter(IEntity entity)
		{
			Entity = entity;
		}

		public string Name
		{
			get
			{
				return (string) Entity["Name"];
			}
			set
			{
				Entity["Name"] = value;
			}
		}
	}
}
