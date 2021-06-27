namespace GomokuBlazor
{
	public class Vector
	{
		public readonly int X;
		public readonly int Y;

		public Vector(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public static Vector operator +(Vector v1, Vector v2)
		{
			return new Vector(v1.X + v2.X, v1.Y + v2.Y);
		}

		public static Vector operator -(Vector v1, Vector v2)
		{
			return new Vector(v1.X - v2.X, v1.Y - v2.Y);
		}

		public Vector Clone()
		{
			return new Vector(this.X, this.Y);
		}

		public override bool Equals(object obj)
		{
			if (obj is Vector v)
			{
				return v.X == this.X && v.Y == this.Y;
			}
			return false;
		}

		public override string ToString() => $"({X}, {Y})";

		public override int GetHashCode() => this.ToString().GetHashCode();
	}
}
