#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Defines level bounds
	/// Updates bounding box automatically based on actors transformation changes or holds fixed user defined bounding box
	/// Uses only actors where AActor::IsLevelBoundsRelevant() == true
	/// </summary>
	public partial class ALevelBounds
	{
		static readonly int bAutoUpdateBounds__Offset;
		/// <summary>Whether to automatically update actor bounds based on all relevant actors bounds belonging to the same level</summary>
		public bool bAutoUpdateBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoUpdateBounds__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoUpdateBounds__Offset, 1,0,1,255);}
			
		}
		
		static ALevelBounds()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelBounds");
			bAutoUpdateBounds__Offset=GetPropertyOffset(NativeClassPtr,"bAutoUpdateBounds");
			
		}
		
	}
	
}
#endif
#endif
