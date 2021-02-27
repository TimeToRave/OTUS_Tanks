using Tanks.Interfaces;

namespace TanksTest.TestClasses
{
	public class TestIShootable : IShootable
	{
		public IEntity Weapon { get; set; }

		public TestIShootable ()
		{
			var entity = new TestEntity();
			entity.properties.Add("Weapon", new TestEntity());
			Weapon = entity;
		}
	}
}
