#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalMeshSocket
	{
		static readonly int SocketName__Offset;
		public FName SocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketName__Offset, false);}
			
		}
		
		static readonly int BoneName__Offset;
		public FName BoneName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BoneName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoneName__Offset, false);}
			
		}
		
		static readonly int RelativeLocation__Offset;
		public FVector RelativeLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeLocation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeLocation__Offset, false);}
			
		}
		
		static readonly int RelativeRotation__Offset;
		public FRotator RelativeRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RelativeRotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeRotation__Offset, false);}
			
		}
		
		static readonly int RelativeScale__Offset;
		public FVector RelativeScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeScale__Offset, false);}
			
		}
		
		static readonly int bForceAlwaysAnimated__Offset;
		public bool bForceAlwaysAnimated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceAlwaysAnimated__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceAlwaysAnimated__Offset, 1,0,1,255);}
			
		}
		
		static USkeletalMeshSocket()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMeshSocket");
			SocketName__Offset=GetPropertyOffset(NativeClassPtr,"SocketName");
			BoneName__Offset=GetPropertyOffset(NativeClassPtr,"BoneName");
			RelativeLocation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeLocation");
			RelativeRotation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeRotation");
			RelativeScale__Offset=GetPropertyOffset(NativeClassPtr,"RelativeScale");
			bForceAlwaysAnimated__Offset=GetPropertyOffset(NativeClassPtr,"bForceAlwaysAnimated");
			
		}
		
	}
	
}
#endif
#endif
