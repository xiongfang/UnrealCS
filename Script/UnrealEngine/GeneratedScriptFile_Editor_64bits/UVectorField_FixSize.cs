#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVectorField
	{
		static readonly int Bounds__Offset;
		/// <summary>Bounds of the volume in local space.</summary>
		public FBox Bounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+Bounds__Offset, typeof(FBox));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Bounds__Offset, false);}
			
		}
		
		static readonly int Intensity__Offset;
		/// <summary>The intensity with which to multiplie vectors in this field.</summary>
		public float Intensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Intensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Intensity__Offset, false);}
			
		}
		
		static UVectorField()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorField");
			Bounds__Offset=GetPropertyOffset(NativeClassPtr,"Bounds");
			Intensity__Offset=GetPropertyOffset(NativeClassPtr,"Intensity");
			
		}
		
	}
	
}
#endif
#endif
