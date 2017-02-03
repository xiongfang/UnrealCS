#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneBoolSection
	{
		static readonly int DefaultValue__Offset;
		public bool DefaultValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultValue__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BoolCurve__Offset;
		public FIntegralCurve BoolCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+BoolCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static UMovieSceneBoolSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneBoolSection");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			BoolCurve__Offset=GetPropertyOffset(NativeClassPtr,"BoolCurve");
			
		}
		
	}
	
}
#endif
#endif
