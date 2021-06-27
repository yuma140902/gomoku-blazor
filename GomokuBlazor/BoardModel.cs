namespace GomokuBlazor
{
	public class BoardModel
	{
		public const int COLUMNS = 10;
		public const int ROWS = 10;

		private readonly EnumPlayer?[] cells = new EnumPlayer?[COLUMNS * ROWS];

		public EnumPlayer? this[Vector p] {
			get {
				int idx = p.X * COLUMNS + p.Y;
				return (0 <= idx && idx < this.cells.Length) ? this.cells[idx] : null;
			}
			set {
				int idx = p.X * COLUMNS + p.Y;
				if (0 <= idx && idx < this.cells.Length)
				{
					this.cells[idx] = value;
				}
			}
		}
	}
}
