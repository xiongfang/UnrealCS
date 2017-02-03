#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A transform section</summary>
	public partial class UMovieScene2DTransformSection
	{
		static readonly int Translation__Offset;
		/// <summary>Translation curves</summary>
		public FRichCurve Translation
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Translation__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Rotation__Offset;
		/// <summary>Rotation curve</summary>
		public FRichCurve Rotation
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Rotation__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Scale__Offset;
		/// <summary>Scale curves</summary>
		public FRichCurve Scale
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Shear__Offset;
		/// <summary>Shear curve</summary>
		public FRichCurve Shear
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Shear__Offset, typeof(FRichCurve));}
			
		}
		
		static UMovieScene2DTransformSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene2DTransformSection");
			Translation__Offset=GetPropertyOffset(NativeClassPtr,"Translation");
			Rotation__Offset=GetPropertyOffset(NativeClassPtr,"Rotation");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			Shear__Offset=GetPropertyOffset(NativeClassPtr,"Shear");
			
		}
		
	}
	
}
#endif
#endif
