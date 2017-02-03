#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A 3D transform section</summary>
	public partial class UMovieScene3DTransformSection
	{
		static readonly int Translation__Offset;
		/// <summary>Translation curves</summary>
		public FRichCurve Translation
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Translation__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int Rotation__Offset;
		/// <summary>Rotation curves</summary>
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
		
		static readonly int Show3DTrajectory__Offset;
		/// <summary>Whether to show the 3d trajectory</summary>
		public EShow3DTrajectory Show3DTrajectory
		{
			get{ CheckIsValid();return (EShow3DTrajectory)Marshal.PtrToStructure(_this.Get()+Show3DTrajectory__Offset, typeof(EShow3DTrajectory));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Show3DTrajectory__Offset, false);}
			
		}
		
		static UMovieScene3DTransformSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScene3DTransformSection");
			Translation__Offset=GetPropertyOffset(NativeClassPtr,"Translation");
			Rotation__Offset=GetPropertyOffset(NativeClassPtr,"Rotation");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			Show3DTrajectory__Offset=GetPropertyOffset(NativeClassPtr,"Show3DTrajectory");
			
		}
		
	}
	
}
#endif
#endif
