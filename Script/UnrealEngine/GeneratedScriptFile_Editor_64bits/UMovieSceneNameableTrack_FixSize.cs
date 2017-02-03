#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for movie scene tracks that can be renamed by the user.</summary>
	public partial class UMovieSceneNameableTrack
	{
		static readonly int DisplayName__Offset;
		/// <summary>The track's human readable display name.</summary>
		public string DisplayName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+DisplayName__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+DisplayName__Offset, false);}
			
		}
		
		static UMovieSceneNameableTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneNameableTrack");
			DisplayName__Offset=GetPropertyOffset(NativeClassPtr,"DisplayName");
			
		}
		
	}
	
}
#endif
#endif
