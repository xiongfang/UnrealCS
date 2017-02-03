#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotifyState_Trail
	{
		static readonly int PSTemplate__Offset;
		public UParticleSystem PSTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PSTemplate__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PSTemplate__Offset, value._this.Get()); }
			
		}
		
		static readonly int FirstSocketName__Offset;
		public FName FirstSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+FirstSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FirstSocketName__Offset, false);}
			
		}
		
		static readonly int SecondSocketName__Offset;
		public FName SecondSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SecondSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SecondSocketName__Offset, false);}
			
		}
		
		static readonly int WidthScaleMode__Offset;
		public ETrailWidthMode WidthScaleMode
		{
			get{ CheckIsValid();return (ETrailWidthMode)Marshal.PtrToStructure(_this.Get()+WidthScaleMode__Offset, typeof(ETrailWidthMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthScaleMode__Offset, false);}
			
		}
		
		static readonly int WidthScaleCurve__Offset;
		public FName WidthScaleCurve
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+WidthScaleCurve__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthScaleCurve__Offset, false);}
			
		}
		
		static readonly int bRecycleSpawnedSystems__Offset;
		public bool bRecycleSpawnedSystems
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRecycleSpawnedSystems__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRecycleSpawnedSystems__Offset, 1,0,1,1);}
			
		}
		
		static UAnimNotifyState_Trail()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotifyState_Trail");
			PSTemplate__Offset=GetPropertyOffset(NativeClassPtr,"PSTemplate");
			FirstSocketName__Offset=GetPropertyOffset(NativeClassPtr,"FirstSocketName");
			SecondSocketName__Offset=GetPropertyOffset(NativeClassPtr,"SecondSocketName");
			WidthScaleMode__Offset=GetPropertyOffset(NativeClassPtr,"WidthScaleMode");
			WidthScaleCurve__Offset=GetPropertyOffset(NativeClassPtr,"WidthScaleCurve");
			bRecycleSpawnedSystems__Offset=GetPropertyOffset(NativeClassPtr,"bRecycleSpawnedSystems");
			
		}
		
	}
	
}
#endif
#endif
