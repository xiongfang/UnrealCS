#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single bool section.</summary>
	public partial class UMovieSceneBoolSection
	{
		static readonly int DefaultValue__Offset;
		/// <summary>The default value to use when no keys are present - use GetCurve().SetDefaultValue()</summary>
		public bool DefaultValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DefaultValue__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BoolCurve__Offset;
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the bools separately
		/// // but that may not be worth the effort
		/// </summary>
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
