using System;
namespace UnrealEngine
{
	public partial class USoundSubmix:UObject
	{
		public USoundSubmix ParentSubmix;
		
		/// <summary>The output wet level to use for the output of this submix in parent submixes</summary>
		public float OutputWetLevel;
		
		
	}
	
}
