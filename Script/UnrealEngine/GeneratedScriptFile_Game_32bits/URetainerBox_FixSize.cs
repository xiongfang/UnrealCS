#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URetainerBox
	{
		static readonly int Phase__Offset;
		public int Phase
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Phase__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Phase__Offset, false);}
			
		}
		
		static readonly int PhaseCount__Offset;
		public int PhaseCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PhaseCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhaseCount__Offset, false);}
			
		}
		
		static readonly int EffectMaterial__Offset;
		public UMaterialInterface EffectMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EffectMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + EffectMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + EffectMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int TextureParameter__Offset;
		public FName TextureParameter
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+TextureParameter__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureParameter__Offset, false);}
			
		}
		
		static URetainerBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("RetainerBox");
			Phase__Offset=GetPropertyOffset(NativeClassPtr,"Phase");
			PhaseCount__Offset=GetPropertyOffset(NativeClassPtr,"PhaseCount");
			EffectMaterial__Offset=GetPropertyOffset(NativeClassPtr,"EffectMaterial");
			TextureParameter__Offset=GetPropertyOffset(NativeClassPtr,"TextureParameter");
			
		}
		
	}
	
}
#endif
#endif
