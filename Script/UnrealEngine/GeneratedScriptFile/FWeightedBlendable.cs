using System;
namespace UnrealEngine
{
	public partial struct FWeightedBlendable
	{
		/// <summary>0:no effect .. 1:full effect</summary>
		public float Weight;
		/// <summary>should be of the IBlendableInterface* type but UProperties cannot express that</summary>
		public UObject Object;
		
	}
	
}
