using System;
namespace UnrealEngine
{
	public partial class UAnimClassData:UObject
	{
		/// <summary>Target skeleton for this blueprint class</summary>
		public USkeleton TargetSkeleton;
		
		/// <summary>The index of the root node in the animation tree</summary>
		public int RootAnimNodeIndex;
		
		public UStructProperty RootAnimNodeProperty;
		
		
	}
	
}
