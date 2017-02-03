#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single floating point section.</summary>
	public partial class UMovieSceneFadeSection
	{
		static readonly int FadeColor__Offset;
		/// <summary>Fade color.</summary>
		public FLinearColor FadeColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+FadeColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeColor__Offset, false);}
			
		}
		
		static readonly int bFadeAudio__Offset;
		/// <summary>Fade audio.</summary>
		public bool bFadeAudio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFadeAudio__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFadeAudio__Offset, 1,0,1,1);}
			
		}
		
		static UMovieSceneFadeSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneFadeSection");
			FadeColor__Offset=GetPropertyOffset(NativeClassPtr,"FadeColor");
			bFadeAudio__Offset=GetPropertyOffset(NativeClassPtr,"bFadeAudio");
			
		}
		
	}
	
}
#endif
#endif
