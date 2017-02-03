#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ADefaultPawn
	{
		static readonly int BaseTurnRate__Offset;
		public float BaseTurnRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseTurnRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseTurnRate__Offset, false);}
			
		}
		
		static readonly int BaseLookUpRate__Offset;
		public float BaseLookUpRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BaseLookUpRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BaseLookUpRate__Offset, false);}
			
		}
		
		static readonly int MovementComponent__Offset;
		public UPawnMovementComponent MovementComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MovementComponent__Offset); if (v == IntPtr.Zero)return null; UPawnMovementComponent retValue = new UPawnMovementComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MovementComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MovementComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int CollisionComponent__Offset;
		public USphereComponent CollisionComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CollisionComponent__Offset); if (v == IntPtr.Zero)return null; USphereComponent retValue = new USphereComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CollisionComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CollisionComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int MeshComponent__Offset;
		public UStaticMeshComponent MeshComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MeshComponent__Offset); if (v == IntPtr.Zero)return null; UStaticMeshComponent retValue = new UStaticMeshComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + MeshComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + MeshComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bAddDefaultMovementBindings__Offset;
		public bool bAddDefaultMovementBindings
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAddDefaultMovementBindings__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAddDefaultMovementBindings__Offset, 1,0,1,1);}
			
		}
		
		static ADefaultPawn()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DefaultPawn");
			BaseTurnRate__Offset=GetPropertyOffset(NativeClassPtr,"BaseTurnRate");
			BaseLookUpRate__Offset=GetPropertyOffset(NativeClassPtr,"BaseLookUpRate");
			MovementComponent__Offset=GetPropertyOffset(NativeClassPtr,"MovementComponent");
			CollisionComponent__Offset=GetPropertyOffset(NativeClassPtr,"CollisionComponent");
			MeshComponent__Offset=GetPropertyOffset(NativeClassPtr,"MeshComponent");
			bAddDefaultMovementBindings__Offset=GetPropertyOffset(NativeClassPtr,"bAddDefaultMovementBindings");
			
		}
		
	}
	
}
#endif
#endif
