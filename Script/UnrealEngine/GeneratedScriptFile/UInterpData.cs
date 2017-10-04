using System;
namespace UnrealEngine
{
	public partial class UInterpData:UObject
	{
		/// <summary>Duration of interpolation sequence - in seconds.</summary>
		public float InterpLength;
		
		/// <summary>Position in Interp to move things to for path-building in editor.</summary>
		public float PathBuildTime;
		
		/// <summary>Used for curve editor to remember curve-editing setup. Only loaded in editor.</summary>
		public UInterpCurveEdSetup CurveEdSetup;
		
		/// <summary>The currently selected filter.</summary>
		public UInterpFilter SelectedFilter;
		
		/// <summary>Used in editor for defining sections to loop, stretch etc.</summary>
		public float EdSectionStart;
		
		/// <summary>Used in editor for defining sections to loop, stretch etc.</summary>
		public float EdSectionEnd;
		
		/// <summary>If true, then the matinee should be baked and pruned at cook time.</summary>
		public bool bShouldBakeAndPrune;
		
		/// <summary>Cached version of the director group, if any, for easy access while in game</summary>
		public UInterpGroupDirector CachedDirectorGroup;
		
		
	}
	
}
