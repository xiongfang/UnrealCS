#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APainCausingVolume
	{
		static readonly int bPainCausing__Offset;
		public bool bPainCausing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPainCausing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPainCausing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DamagePerSec__Offset;
		public float DamagePerSec
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DamagePerSec__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DamagePerSec__Offset, false);}
			
		}
		
		static readonly int DamageType__Offset;
		public TSubclassOf<UDamageType>  DamageType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DamageType__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DamageType__Offset, value); }
			
		}
		
		static readonly int PainInterval__Offset;
		public float PainInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PainInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PainInterval__Offset, false);}
			
		}
		
		static readonly int bEntryPain__Offset;
		public bool bEntryPain
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEntryPain__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEntryPain__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BACKUP_bPainCausing__Offset;
		public bool BACKUP_bPainCausing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), BACKUP_bPainCausing__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DamageInstigator__Offset;
		public AController DamageInstigator
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DamageInstigator__Offset); if (v == IntPtr.Zero)return null; AController retValue = new AController(); retValue._this = v; return retValue; }
			
		}
		
		static APainCausingVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PainCausingVolume");
			bPainCausing__Offset=GetPropertyOffset(NativeClassPtr,"bPainCausing");
			DamagePerSec__Offset=GetPropertyOffset(NativeClassPtr,"DamagePerSec");
			DamageType__Offset=GetPropertyOffset(NativeClassPtr,"DamageType");
			PainInterval__Offset=GetPropertyOffset(NativeClassPtr,"PainInterval");
			bEntryPain__Offset=GetPropertyOffset(NativeClassPtr,"bEntryPain");
			BACKUP_bPainCausing__Offset=GetPropertyOffset(NativeClassPtr,"BACKUP_bPainCausing");
			DamageInstigator__Offset=GetPropertyOffset(NativeClassPtr,"DamageInstigator");
			
		}
		
	}
	
}
#endif
#endif
