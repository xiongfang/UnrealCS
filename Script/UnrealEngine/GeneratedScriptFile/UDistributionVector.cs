using System;
namespace UnrealEngine
{
	public partial class UDistributionVector:UDistribution
	{
		/// <summary>Can this variable be baked out to a FRawDistribution? Should be true 99% of the time</summary>
		public bool bCanBeBaked;
		
		/// <summary>Set internally when the distribution is updated so that that FRawDistribution can know to update itself</summary>
		public bool bIsDirty;
		
		public bool bBakedDataSuccesfully;
		
		
	}
	
}
