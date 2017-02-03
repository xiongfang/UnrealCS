#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNetDriver
	{
		static readonly int NetConnectionClassName__Offset;
		public FString NetConnectionClassName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+NetConnectionClassName__Offset, typeof(FString));}
			
		}
		
		static readonly int MaxDownloadSize__Offset;
		public int MaxDownloadSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxDownloadSize__Offset, typeof(int));}
			
		}
		
		static readonly int bClampListenServerTickRate__Offset;
		public bool bClampListenServerTickRate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClampListenServerTickRate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int NetServerMaxTickRate__Offset;
		public int NetServerMaxTickRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NetServerMaxTickRate__Offset, typeof(int));}
			
		}
		
		static readonly int MaxInternetClientRate__Offset;
		public int MaxInternetClientRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxInternetClientRate__Offset, typeof(int));}
			
		}
		
		static readonly int MaxClientRate__Offset;
		public int MaxClientRate
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxClientRate__Offset, typeof(int));}
			
		}
		
		static readonly int ServerTravelPause__Offset;
		public float ServerTravelPause
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerTravelPause__Offset, typeof(float));}
			
		}
		
		static readonly int SpawnPrioritySeconds__Offset;
		public float SpawnPrioritySeconds
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpawnPrioritySeconds__Offset, typeof(float));}
			
		}
		
		static readonly int RelevantTimeout__Offset;
		public float RelevantTimeout
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RelevantTimeout__Offset, typeof(float));}
			
		}
		
		static readonly int KeepAliveTime__Offset;
		public float KeepAliveTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+KeepAliveTime__Offset, typeof(float));}
			
		}
		
		static readonly int InitialConnectTimeout__Offset;
		public float InitialConnectTimeout
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialConnectTimeout__Offset, typeof(float));}
			
		}
		
		static readonly int ConnectionTimeout__Offset;
		public float ConnectionTimeout
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ConnectionTimeout__Offset, typeof(float));}
			
		}
		
		static readonly int bNoTimeouts__Offset;
		public bool bNoTimeouts
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoTimeouts__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ServerConnection__Offset;
		public UNetConnection ServerConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ServerConnection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ClientConnections__Offset;
		public TObjectArray<UNetConnection>  ClientConnections
		{
					get{ CheckIsValid();return new TObjectArray<UNetConnection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ClientConnections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ClientConnections__Offset, false);}
			
		}
		
		static readonly int World__Offset;
		public UWorld World
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + World__Offset); if (v == IntPtr.Zero)return null; UWorld retValue = new UWorld(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetConnectionClass__Offset;
		public UClass NetConnectionClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetConnectionClass__Offset); return v; }
			
		}
		
		static readonly int RoleProperty__Offset;
		public UProperty RoleProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RoleProperty__Offset); if (v == IntPtr.Zero)return null; UProperty retValue = new UProperty(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RemoteRoleProperty__Offset;
		public UProperty RemoteRoleProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RemoteRoleProperty__Offset); if (v == IntPtr.Zero)return null; UProperty retValue = new UProperty(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetDriverName__Offset;
		public FName NetDriverName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NetDriverName__Offset, typeof(FName));}
			
		}
		
		static readonly int Time__Offset;
		public float Time
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Time__Offset, typeof(float));}
			
		}
		
		static UNetDriver()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetDriver");
			NetConnectionClassName__Offset=GetPropertyOffset(NativeClassPtr,"NetConnectionClassName");
			MaxDownloadSize__Offset=GetPropertyOffset(NativeClassPtr,"MaxDownloadSize");
			bClampListenServerTickRate__Offset=GetPropertyOffset(NativeClassPtr,"bClampListenServerTickRate");
			NetServerMaxTickRate__Offset=GetPropertyOffset(NativeClassPtr,"NetServerMaxTickRate");
			MaxInternetClientRate__Offset=GetPropertyOffset(NativeClassPtr,"MaxInternetClientRate");
			MaxClientRate__Offset=GetPropertyOffset(NativeClassPtr,"MaxClientRate");
			ServerTravelPause__Offset=GetPropertyOffset(NativeClassPtr,"ServerTravelPause");
			SpawnPrioritySeconds__Offset=GetPropertyOffset(NativeClassPtr,"SpawnPrioritySeconds");
			RelevantTimeout__Offset=GetPropertyOffset(NativeClassPtr,"RelevantTimeout");
			KeepAliveTime__Offset=GetPropertyOffset(NativeClassPtr,"KeepAliveTime");
			InitialConnectTimeout__Offset=GetPropertyOffset(NativeClassPtr,"InitialConnectTimeout");
			ConnectionTimeout__Offset=GetPropertyOffset(NativeClassPtr,"ConnectionTimeout");
			bNoTimeouts__Offset=GetPropertyOffset(NativeClassPtr,"bNoTimeouts");
			ServerConnection__Offset=GetPropertyOffset(NativeClassPtr,"ServerConnection");
			ClientConnections__Offset=GetPropertyOffset(NativeClassPtr,"ClientConnections");
			World__Offset=GetPropertyOffset(NativeClassPtr,"World");
			NetConnectionClass__Offset=GetPropertyOffset(NativeClassPtr,"NetConnectionClass");
			RoleProperty__Offset=GetPropertyOffset(NativeClassPtr,"RoleProperty");
			RemoteRoleProperty__Offset=GetPropertyOffset(NativeClassPtr,"RemoteRoleProperty");
			NetDriverName__Offset=GetPropertyOffset(NativeClassPtr,"NetDriverName");
			Time__Offset=GetPropertyOffset(NativeClassPtr,"Time");
			
		}
		
	}
	
}
#endif
#endif
