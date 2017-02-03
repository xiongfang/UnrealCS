#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for 3D constraint section</summary>
	public partial class UMovieScene3DConstraintSection
	{
		static readonly int ConstraintId__Offset;
		/// <summary>The possessable guid that this constraint uses</summary>
		public FGuid ConstraintId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ConstraintId__Offset, typeof(FGuid));}
			
		}
		
		static UMovieScene3DConstraintSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DConstraintSection");
			ConstraintId__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintId");
			
		}
		
	}
	
}
#endif
#endif
