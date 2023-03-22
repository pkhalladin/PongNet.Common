namespace PongNet.Common
{
	public static class EnumExtender
	{
		public static int AsInt32<T>(this T @this) where T: Enum
		{
			return (int)Convert.ChangeType(@this, typeof(int));
		}

		public static bool HasFlag<T>(this T @this, T flag) where T: Enum
		{
			return (AsInt32(@this) & AsInt32(flag)) != 0;
		}

		public static bool HasFlags<T>(this T @this, params T[] flags) where T: Enum
		{
			foreach (T flag in flags)
			{
				if (!HasFlag(@this, flag))
				{
					return false;
				}
			}
			return true;
		}	
	}
}
