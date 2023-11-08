using System.Drawing;

namespace PongNet.Common
{
	public static class Default
	{
		// shared
		public static readonly string Title = "PongNet 1.0";
		public static readonly int FormClientWidth = 800;
		public static readonly int FormClientHeight = 500;
		public static readonly Color PrimaryColor = Color.White;
		public static readonly Color SecondaryColor = Color.Black;
		public static readonly Brush PrimaryColorBrush = new SolidBrush(PrimaryColor);
		public static readonly Brush SecondaryColorBrush = new SolidBrush(SecondaryColor);
		public static readonly Pen PrimaryColorPen = new Pen(PrimaryColor);
        public static readonly Pen SecondaryColorPen = new Pen(SecondaryColor);

        // game
        public static readonly Font GameFont = new Font("Courier New", 30.0f, FontStyle.Bold);

        // menu
        public static readonly Font MenuFont = new Font("Courier New", 15.0f, FontStyle.Bold);
		public static readonly string MenuCheckedPrefix = "->";
	}
}
