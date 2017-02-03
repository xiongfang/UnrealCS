#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavAreaMeta_SwitchByAgent
	{
		static readonly int Agent0Area__Offset;
		public TSubclassOf<UNavArea>  Agent0Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent0Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent0Area__Offset, value); }
			
		}
		
		static readonly int Agent1Area__Offset;
		public TSubclassOf<UNavArea>  Agent1Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent1Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent1Area__Offset, value); }
			
		}
		
		static readonly int Agent2Area__Offset;
		public TSubclassOf<UNavArea>  Agent2Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent2Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent2Area__Offset, value); }
			
		}
		
		static readonly int Agent3Area__Offset;
		public TSubclassOf<UNavArea>  Agent3Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent3Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent3Area__Offset, value); }
			
		}
		
		static readonly int Agent4Area__Offset;
		public TSubclassOf<UNavArea>  Agent4Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent4Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent4Area__Offset, value); }
			
		}
		
		static readonly int Agent5Area__Offset;
		public TSubclassOf<UNavArea>  Agent5Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent5Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent5Area__Offset, value); }
			
		}
		
		static readonly int Agent6Area__Offset;
		public TSubclassOf<UNavArea>  Agent6Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent6Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent6Area__Offset, value); }
			
		}
		
		static readonly int Agent7Area__Offset;
		public TSubclassOf<UNavArea>  Agent7Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent7Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent7Area__Offset, value); }
			
		}
		
		static readonly int Agent8Area__Offset;
		public TSubclassOf<UNavArea>  Agent8Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent8Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent8Area__Offset, value); }
			
		}
		
		static readonly int Agent9Area__Offset;
		public TSubclassOf<UNavArea>  Agent9Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent9Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent9Area__Offset, value); }
			
		}
		
		static readonly int Agent10Area__Offset;
		public TSubclassOf<UNavArea>  Agent10Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent10Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent10Area__Offset, value); }
			
		}
		
		static readonly int Agent11Area__Offset;
		public TSubclassOf<UNavArea>  Agent11Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent11Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent11Area__Offset, value); }
			
		}
		
		static readonly int Agent12Area__Offset;
		public TSubclassOf<UNavArea>  Agent12Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent12Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent12Area__Offset, value); }
			
		}
		
		static readonly int Agent13Area__Offset;
		public TSubclassOf<UNavArea>  Agent13Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent13Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent13Area__Offset, value); }
			
		}
		
		static readonly int Agent14Area__Offset;
		public TSubclassOf<UNavArea>  Agent14Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent14Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent14Area__Offset, value); }
			
		}
		
		static readonly int Agent15Area__Offset;
		public TSubclassOf<UNavArea>  Agent15Area
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Agent15Area__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + Agent15Area__Offset, value); }
			
		}
		
		static UNavAreaMeta_SwitchByAgent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavAreaMeta_SwitchByAgent");
			Agent0Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent0Area");
			Agent1Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent1Area");
			Agent2Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent2Area");
			Agent3Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent3Area");
			Agent4Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent4Area");
			Agent5Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent5Area");
			Agent6Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent6Area");
			Agent7Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent7Area");
			Agent8Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent8Area");
			Agent9Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent9Area");
			Agent10Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent10Area");
			Agent11Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent11Area");
			Agent12Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent12Area");
			Agent13Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent13Area");
			Agent14Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent14Area");
			Agent15Area__Offset=GetPropertyOffset(NativeClassPtr,"Agent15Area");
			
		}
		
	}
	
}
#endif
#endif
