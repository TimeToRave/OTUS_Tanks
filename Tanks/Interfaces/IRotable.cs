namespace Tanks.Interfaces
{
	/// <summary>
	/// Интерфейс, описывающий объект, который может поворачиваться
	/// </summary>
	interface IRotable
	{
		/// <summary>
		/// Текущее направление
		/// </summary>
		int Direction { get; set; }

		/// <summary>
		/// Моментальная угловая скорость
		/// </summary>
		int AngularVelocity { get; set; }
	}
}
