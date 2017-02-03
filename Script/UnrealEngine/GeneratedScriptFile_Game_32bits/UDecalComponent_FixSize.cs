#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDecalComponent
	{
		static readonly int DecalMaterial__Offset;
		public UMaterialInterface DecalMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DecalMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DecalMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DecalMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int SortOrder__Offset;
		public int SortOrder
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SortOrder__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortOrder__Offset, false);}
			
		}
		
		static readonly int FadeScreenSize__Offset;
		public float FadeScreenSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeScreenSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeScreenSize__Offset, false);}
			
		}
		
		static readonly int FadeStartDelay__Offset;
		public float FadeStartDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeStartDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeStartDelay__Offset, false);}
			
		}
		
		static readonly int FadeDuration__Offset;
		public float FadeDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeDuration__Offset, false);}
			
		}
		
		static readonly int bDestroyOwnerAfterFade__Offset;
		public bool bDestroyOwnerAfterFade
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDestroyOwnerAfterFade__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDestroyOwnerAfterFade__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DecalSize__Offset;
		public FVector DecalSize
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+DecalSize__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DecalSize__Offset, false);}
			
		}
		
		static UDecalComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DecalComponent");
			DecalMaterial__Offset=GetPropertyOffset(NativeClassPtr,"DecalMaterial");
			SortOrder__Offset=GetPropertyOffset(NativeClassPtr,"SortOrder");
			FadeScreenSize__Offset=GetPropertyOffset(NativeClassPtr,"FadeScreenSize");
			FadeStartDelay__Offset=GetPropertyOffset(NativeClassPtr,"FadeStartDelay");
			FadeDuration__Offset=GetPropertyOffset(NativeClassPtr,"FadeDuration");
			bDestroyOwnerAfterFade__Offset=GetPropertyOffset(NativeClassPtr,"bDestroyOwnerAfterFade");
			DecalSize__Offset=GetPropertyOffset(NativeClassPtr,"DecalSize");
			
		}
		
	}
	
}
#endif
#endif
