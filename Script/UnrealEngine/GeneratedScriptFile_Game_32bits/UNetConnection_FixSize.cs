#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNetConnection
	{
		static readonly int Children__Offset;
		public TObjectArray<UChildConnection>  Children
		{
					get{ CheckIsValid();return new TObjectArray<UChildConnection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Children__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Children__Offset, false);}
			
		}
		
		static readonly int Driver__Offset;
		public UNetDriver Driver
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Driver__Offset); if (v == IntPtr.Zero)return null; UNetDriver retValue = new UNetDriver(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PackageMap__Offset;
		public UPackageMap PackageMap
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PackageMap__Offset); if (v == IntPtr.Zero)return null; UPackageMap retValue = new UPackageMap(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OpenChannels__Offset;
		public TObjectArray<UChannel>  OpenChannels
		{
					get{ CheckIsValid();return new TObjectArray<UChannel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OpenChannels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OpenChannels__Offset, false);}
			
		}
		
		static readonly int SentTemporaries__Offset;
		public TObjectArray<AActor>  SentTemporaries
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SentTemporaries__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SentTemporaries__Offset, false);}
			
		}
		
		static readonly int ViewTarget__Offset;
		public AActor ViewTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ViewTarget__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OwningActor__Offset;
		public AActor OwningActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaxPacket__Offset;
		public int MaxPacket
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxPacket__Offset, typeof(int));}
			
		}
		
		static readonly int InternalAck__Offset;
		public bool InternalAck
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), InternalAck__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int PlayerId__Offset;
		public FUniqueNetIdRepl PlayerId
		{
			get{ CheckIsValid();return (FUniqueNetIdRepl)Marshal.PtrToStructure(_this.Get()+PlayerId__Offset, typeof(FUniqueNetIdRepl));}
			
		}
		
		static readonly int LastReceiveTime__Offset;
		public double LastReceiveTime
		{
			get{ CheckIsValid();return (double)Marshal.PtrToStructure(_this.Get()+LastReceiveTime__Offset, typeof(double));}
			
		}
		
		static readonly int ChannelsToTick__Offset;
		public TObjectArray<UChannel>  ChannelsToTick
		{
					get{ CheckIsValid();return new TObjectArray<UChannel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChannelsToTick__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChannelsToTick__Offset, false);}
			
		}
		
		static UNetConnection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetConnection");
			Children__Offset=GetPropertyOffset(NativeClassPtr,"Children");
			Driver__Offset=GetPropertyOffset(NativeClassPtr,"Driver");
			PackageMap__Offset=GetPropertyOffset(NativeClassPtr,"PackageMap");
			OpenChannels__Offset=GetPropertyOffset(NativeClassPtr,"OpenChannels");
			SentTemporaries__Offset=GetPropertyOffset(NativeClassPtr,"SentTemporaries");
			ViewTarget__Offset=GetPropertyOffset(NativeClassPtr,"ViewTarget");
			OwningActor__Offset=GetPropertyOffset(NativeClassPtr,"OwningActor");
			MaxPacket__Offset=GetPropertyOffset(NativeClassPtr,"MaxPacket");
			InternalAck__Offset=GetPropertyOffset(NativeClassPtr,"InternalAck");
			PlayerId__Offset=GetPropertyOffset(NativeClassPtr,"PlayerId");
			LastReceiveTime__Offset=GetPropertyOffset(NativeClassPtr,"LastReceiveTime");
			ChannelsToTick__Offset=GetPropertyOffset(NativeClassPtr,"ChannelsToTick");
			
		}
		
	}
	
}
#endif
#endif
