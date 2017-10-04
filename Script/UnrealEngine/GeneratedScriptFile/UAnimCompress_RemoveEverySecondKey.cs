using System;
namespace UnrealEngine
{
	public partial class UAnimCompress_RemoveEverySecondKey:UAnimCompress
	{
		/// <summary>Animations with fewer than MinKeys will not lose any keys.</summary>
		public int MinKeys;
		
		/// <summary>
		/// If bStartAtSecondKey is true, remove keys 1,3,5,etc.
		/// If bStartAtSecondKey is false, remove keys 0,2,4,etc.
		/// </summary>
		public bool bStartAtSecondKey;
		
		
	}
	
}
