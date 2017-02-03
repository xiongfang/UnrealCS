#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Volume that causes damage over time to any Actor that overlaps its collision.</summary>
	public partial class APainCausingVolume
	{
		static readonly int bPainCausing__Offset;
		/// <summary>Whether volume currently causes damage.</summary>
		public bool bPainCausing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPainCausing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPainCausing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DamagePerSec__Offset;
		/// <summary>Damage done per second to actors in this volume when bPainCausing=true</summary>
		public float DamagePerSec
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DamagePerSec__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DamagePerSec__Offset, false);}
			
		}
		
		static readonly int DamageType__Offset;
		/// <summary>Type of damage done</summary>
		public TSubclassOf<UDamageType>  DamageType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DamageType__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DamageType__Offset, value); }
			
		}
		
		static readonly int PainInterval__Offset;
		/// <summary>If pain causing, time between damage applications.</summary>
		public float PainInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PainInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PainInterval__Offset, false);}
			
		}
		
		static readonly int bEntryPain__Offset;
		/// <summary>if bPainCausing, cause pain when something enters the volume in addition to damage each second</summary>
		public bool bEntryPain
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEntryPain__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEntryPain__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BACKUP_bPainCausing__Offset;
		/// <summary>Checkpointed bPainCausing value</summary>
		public bool BACKUP_bPainCausing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), BACKUP_bPainCausing__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DamageInstigator__Offset;
		/// <summary>Controller that gets credit for any damage caused by this volume</summary>
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
