#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldLocal
	{
		static readonly int VectorField__Offset;
		/// <summary>Vector field asset to use.</summary>
		public UVectorField VectorField
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VectorField__Offset); if (v == IntPtr.Zero)return null; UVectorField retValue = new UVectorField(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + VectorField__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + VectorField__Offset, value._this.Get()); }
			
		}
		
		static readonly int RelativeTranslation__Offset;
		/// <summary>Translation of the vector field relative to the emitter.</summary>
		public FVector RelativeTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeTranslation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeTranslation__Offset, false);}
			
		}
		
		static readonly int RelativeRotation__Offset;
		/// <summary>Rotation of the vector field relative to the emitter.</summary>
		public FRotator RelativeRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RelativeRotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeRotation__Offset, false);}
			
		}
		
		static readonly int RelativeScale3D__Offset;
		/// <summary>Scale of the vector field relative to the emitter.</summary>
		public FVector RelativeScale3D
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeScale3D__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeScale3D__Offset, false);}
			
		}
		
		static readonly int Intensity__Offset;
		/// <summary>Intensity of the local vector field.</summary>
		public float Intensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Intensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Intensity__Offset, false);}
			
		}
		
		static readonly int Tightness__Offset;
		/// <summary>Tightness tweak value: 0: Force 1: Velocity.</summary>
		public float Tightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Tightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Tightness__Offset, false);}
			
		}
		
		static readonly int bIgnoreComponentTransform__Offset;
		/// <summary>Ignore component transform.</summary>
		public bool bIgnoreComponentTransform
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreComponentTransform__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreComponentTransform__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bTileX__Offset;
		/// <summary>Tile vector field in x axis?</summary>
		public bool bTileX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTileX__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTileX__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTileY__Offset;
		/// <summary>Tile vector field in y axis?</summary>
		public bool bTileY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTileY__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTileY__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bTileZ__Offset;
		/// <summary>Tile vector field in z axis?</summary>
		public bool bTileZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTileZ__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTileZ__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseFixDT__Offset;
		/// <summary>Use fix delta time in the simulation?</summary>
		public bool bUseFixDT
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixDT__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixDT__Offset, 1,0,16,16);}
			
		}
		
		static UParticleModuleVectorFieldLocal()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVectorFieldLocal");
			VectorField__Offset=GetPropertyOffset(NativeClassPtr,"VectorField");
			RelativeTranslation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeTranslation");
			RelativeRotation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeRotation");
			RelativeScale3D__Offset=GetPropertyOffset(NativeClassPtr,"RelativeScale3D");
			Intensity__Offset=GetPropertyOffset(NativeClassPtr,"Intensity");
			Tightness__Offset=GetPropertyOffset(NativeClassPtr,"Tightness");
			bIgnoreComponentTransform__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreComponentTransform");
			bTileX__Offset=GetPropertyOffset(NativeClassPtr,"bTileX");
			bTileY__Offset=GetPropertyOffset(NativeClassPtr,"bTileY");
			bTileZ__Offset=GetPropertyOffset(NativeClassPtr,"bTileZ");
			bUseFixDT__Offset=GetPropertyOffset(NativeClassPtr,"bUseFixDT");
			
		}
		
	}
	
}
#endif
#endif
