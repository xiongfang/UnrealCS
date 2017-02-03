#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneParameterSection
	{
		static readonly int ScalarParameterNamesAndCurves__Offset;
		public TStructArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves
		{
			get{ CheckIsValid();return new TStructArray<FScalarParameterNameAndCurve>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ScalarParameterNamesAndCurves__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ScalarParameterNamesAndCurves__Offset, false);}
			
		}
		
		static readonly int VectorParameterNamesAndCurves__Offset;
		public TStructArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves
		{
			get{ CheckIsValid();return new TStructArray<FVectorParameterNameAndCurves>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VectorParameterNamesAndCurves__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VectorParameterNamesAndCurves__Offset, false);}
			
		}
		
		static readonly int ColorParameterNamesAndCurves__Offset;
		public TStructArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves
		{
			get{ CheckIsValid();return new TStructArray<FColorParameterNameAndCurves>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ColorParameterNamesAndCurves__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ColorParameterNamesAndCurves__Offset, false);}
			
		}
		
		static UMovieSceneParameterSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneParameterSection");
			ScalarParameterNamesAndCurves__Offset=GetPropertyOffset(NativeClassPtr,"ScalarParameterNamesAndCurves");
			VectorParameterNamesAndCurves__Offset=GetPropertyOffset(NativeClassPtr,"VectorParameterNamesAndCurves");
			ColorParameterNamesAndCurves__Offset=GetPropertyOffset(NativeClassPtr,"ColorParameterNamesAndCurves");
			
		}
		
	}
	
}
#endif
#endif
