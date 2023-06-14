using System.Drawing;

namespace PongNet.Common
{
	public static class Default
	{
		public static readonly string Title = "PongNet 1.0";
		public static readonly int FormClientWidth = 800;
		public static readonly int FormClientHeight = 500;
		public static readonly Font Font = new Font("Courier New", 15.0f, FontStyle.Bold);
		public static readonly Color PrimaryColor = Color.White;
		public static readonly Color SecondaryColor = Color.Black;
		public static readonly Brush PrimaryColorBrush = new SolidBrush(PrimaryColor);
		public static readonly Brush SecondaryColorBrush = new SolidBrush(SecondaryColor);
	}
}
