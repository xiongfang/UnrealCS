using System;
namespace UnrealEngine
{
	public partial class UDistributionFloat:UDistribution
	{
		/// <summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
		public bool bCanBeBaked;
		
		public bool bBakedDataSuccesfully;
		
		
	}
	
}
