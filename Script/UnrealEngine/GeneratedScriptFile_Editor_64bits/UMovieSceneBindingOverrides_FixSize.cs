#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A one-to-many definition of movie scene object binding IDs to overridden objects that should be bound to that binding.</summary>
	public partial class UMovieSceneBindingOverrides
	{
		static readonly int BindingData__Offset;
		/// <summary>The actual binding data</summary>
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
