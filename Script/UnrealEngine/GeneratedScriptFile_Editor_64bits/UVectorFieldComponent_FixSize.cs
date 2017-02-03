#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A Component referencing a vector field.</summary>
	public partial class UVectorFieldComponent
	{
		static readonly int VectorField__Offset;
		/// <summary>The vector field asset.</summary>
		public UVectorField VectorField
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorField__Offset); if (v == IntPtr.Zero)return null; UVectorField retValue = new UVectorField(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + VectorField__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + VectorField__Offset, value._this.Get()); }
			
		}
		
		static readonly int Intensity__Offset;
		/// <summary>The intensity at which the vector field is applied.</summary>
		public float Intensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Intensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Intensity__Offset, false);}
			
		}
		
		static readonly int Tightness__Offset;
		/// <summary>How tightly particles follow the vector field.</summary>
		public float Tightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Tightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Tightness__Offset, false);}
			
		}
		
		static readonly int bPreviewVectorField__Offset;
		/// <summary>If true, the vector field is only used for preview visualizations.</summary>
		public bool bPreviewVectorField
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPreviewVectorField__Offset, 1, 0, 1, 1);}
			
		}
		
		static UVectorFieldComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldComponent");
			VectorField__Offset=GetPropertyOffset(NativeClassPtr,"VectorField");
			Intensity__Offset=GetPropertyOffset(NativeClassPtr,"Intensity");
			Tightness__Offset=GetPropertyOffset(NativeClassPtr,"Tightness");
			bPreviewVectorField__Offset=GetPropertyOffset(NativeClassPtr,"bPreviewVectorField");
			
		}
		
	}
	
}
#endif
#endif
