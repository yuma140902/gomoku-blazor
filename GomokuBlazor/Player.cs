namespace GomokuBlazor
{
	public enum EnumPlayer
	{
		Black,
		White
	}

	public class Player
	{
		public static EnumPlayer Toggle(EnumPlayer player) => player switch
		{
			EnumPlayer.Black => EnumPlayer.White,
			EnumPlayer.White => EnumPlayer.Black
		};
	}
}
