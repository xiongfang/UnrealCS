using System;
namespace UnrealEngine
{
	public partial struct FNavigationLink
	{
		public FVector Left;
		public FVector Right;
		/// <summary>if greater than 0 nav system will attempt to project navlink's start point on geometry below</summary>
		public float LeftProjectHeight;
		/// <summary>if greater than 0 nav system will attempt to project navlink's end point on geometry below</summary>
		public float MaxFallDownLength;
		public ENavLinkDirection Direction;
		public float SnapRadius;
		public float SnapHeight;
		/// <summary>restrict area only to specified agents</summary>
		public FNavAgentSelector SupportedAgents;
		/// <summary>DEPRECATED AGENT CONFIG</summary>
		public bool bSupportsAgent0;
		public bool bSupportsAgent1;
		public bool bSupportsAgent2;
		public bool bSupportsAgent3;
		public bool bSupportsAgent4;
		public bool bSupportsAgent5;
		public bool bSupportsAgent6;
		public bool bSupportsAgent7;
		public bool bSupportsAgent8;
		public bool bSupportsAgent9;
		public bool bSupportsAgent10;
		public bool bSupportsAgent11;
		public bool bSupportsAgent12;
		public bool bSupportsAgent13;
		public bool bSupportsAgent14;
		public bool bSupportsAgent15;
		/// <summary>this is an editor-only property to put descriptions in navlinks setup, to be able to identify it easier</summary>
		public FString Description;
		/// <summary>WITH_EDITORONLY_DATA</summary>
		public bool bUseSnapHeight;
		/// <summary>If set, link will try to snap to cheapest area in given radius</summary>
		public bool bSnapToCheapestArea;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag0;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag1;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag2;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag3;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag4;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag5;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag6;
		/// <summary>custom flag, check DescribeCustomFlags for details</summary>
		public bool bCustomFlag7;
		/// <summary>Area type of this link (empty = default)</summary>
		public TSubclassOf<UNavArea>  AreaClass;
		
	}
	
}
