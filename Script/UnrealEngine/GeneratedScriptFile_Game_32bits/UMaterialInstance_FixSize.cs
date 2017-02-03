#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialInstance
	{
		static readonly int PhysMaterial__Offset;
		public UPhysicalMaterial PhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int Parent__Offset;
		public UMaterialInterface Parent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Parent__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Parent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Parent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bHasStaticPermutationResource__Offset;
		public bool bHasStaticPermutationResource
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasStaticPermutationResource__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bOverrideSubsurfaceProfile__Offset;
		public bool bOverrideSubsurfaceProfile
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideSubsurfaceProfile__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideSubsurfaceProfile__Offset, 1,0,4,4);}
			
		}
		
		static readonly int FontParameterValues__Offset;
		public TStructArray<FFontParameterValue> FontParameterValues
		{
			get{ CheckIsValid();return new TStructArray<FFontParameterValue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FontParameterValues__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FontParameterValues__Offset, false);}
			
		}
		
		static readonly int ScalarParameterValues__Offset;
		public TStructArray<FScalarParameterValue> ScalarParameterValues
		{
			get{ CheckIsValid();return new TStructArray<FScalarParameterValue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ScalarParameterValues__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ScalarParameterValues__Offset, false);}
			
		}
		
		static readonly int TextureParameterValues__Offset;
		public TStructArray<FTextureParameterValue> TextureParameterValues
		{
			get{ CheckIsValid();return new TStructArray<FTextureParameterValue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TextureParameterValues__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TextureParameterValues__Offset, false);}
			
		}
		
		static readonly int VectorParameterValues__Offset;
		public TStructArray<FVectorParameterValue> VectorParameterValues
		{
			get{ CheckIsValid();return new TStructArray<FVectorParameterValue>((FScriptArray)Marshal.PtrToStructure(_this.Get()+VectorParameterValues__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+VectorParameterValues__Offset, false);}
			
		}
		
		static readonly int bOverrideBaseProperties__Offset;
		public bool bOverrideBaseProperties
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideBaseProperties__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BasePropertyOverrides__Offset;
		public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides
		{
			get{ CheckIsValid();return (FMaterialInstanceBasePropertyOverrides)Marshal.PtrToStructure(_this.Get()+BasePropertyOverrides__Offset, typeof(FMaterialInstanceBasePropertyOverrides));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BasePropertyOverrides__Offset, false);}
			
		}
		
		static UMaterialInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialInstance");
			PhysMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PhysMaterial");
			Parent__Offset=GetPropertyOffset(NativeClassPtr,"Parent");
			bHasStaticPermutationResource__Offset=GetPropertyOffset(NativeClassPtr,"bHasStaticPermutationResource");
			bOverrideSubsurfaceProfile__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideSubsurfaceProfile");
			FontParameterValues__Offset=GetPropertyOffset(NativeClassPtr,"FontParameterValues");
			ScalarParameterValues__Offset=GetPropertyOffset(NativeClassPtr,"ScalarParameterValues");
			TextureParameterValues__Offset=GetPropertyOffset(NativeClassPtr,"TextureParameterValues");
			VectorParameterValues__Offset=GetPropertyOffset(NativeClassPtr,"VectorParameterValues");
			bOverrideBaseProperties__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideBaseProperties");
			BasePropertyOverrides__Offset=GetPropertyOffset(NativeClassPtr,"BasePropertyOverrides");
			
		}
		
	}
	
}
#endif
#endif
