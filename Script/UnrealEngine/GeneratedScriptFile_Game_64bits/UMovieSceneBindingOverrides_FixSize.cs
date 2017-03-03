#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneBindingOverrides
	{
		static readonly int BindingData__Offset;
		public TStructArray<FMovieSceneBindingOverrideData> BindingData
		{
			get{ CheckIsValid();return new TStructArray<FMovieSceneBindingOverrideData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BindingData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BindingData__Offset, false);}
			
		}
		
		static UMovieSceneBindingOverrides()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneBindingOverrides");
			BindingData__Offset=GetPropertyOffset(NativeClassPtr,"BindingData");
			
		}
		
	}
	
}
#endif
#endif
