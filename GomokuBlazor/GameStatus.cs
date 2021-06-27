namespace GomokuBlazor
{
	public class GameStatus
	{
		public readonly BoardModel Cells = new BoardModel();
		public EnumPlayer Turn { get; set; } = EnumPlayer.White;
		public bool IsFinished { get; set; } = false;
		public EnumPlayer? Winner { get; set; } = null;
	}
}
