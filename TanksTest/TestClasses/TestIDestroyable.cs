using Tanks.Interfaces;

namespace TanksTest.TestClasses
{
	public class TestIDestroyable : IDestroyable
	{
		public string Name { get; set; }
		public TestIDestroyable(string name)
		{
			Name = name;
		}
	}
}
