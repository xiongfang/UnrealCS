#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALODActor
	{
		static readonly int StaticMeshComponent__Offset;
		public UStaticMeshComponent StaticMeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + StaticMeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + StaticMeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SubActors__Offset;
		public TObjectArray<AActor>  SubActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubActors__Offset, false);}
			
		}
		
		static readonly int LODDrawDistance__Offset;
		public float LODDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LODDrawDistance__Offset, typeof(float));}
			
		}
		
		static readonly int LODLevel__Offset;
		public int LODLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LODLevel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODLevel__Offset, false);}
			
		}
		
		static readonly int SubObjects__Offset;
		public TObjectArray<UObject>  SubObjects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubObjects__Offset, false);}
			
		}
		
		static ALODActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LODActor");
			StaticMeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"StaticMeshComponent");
			SubActors__Offset=GetPropertyOffset(NativeClassPtr,"SubActors");
			LODDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"LODDrawDistance");
			LODLevel__Offset=GetPropertyOffset(NativeClassPtr,"LODLevel");
			SubObjects__Offset=GetPropertyOffset(NativeClassPtr,"SubObjects");
			
		}
		
	}
	
}
#endif
#endif
