#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavMeshBoundsVolume
	{
		static readonly int SupportedAgents__Offset;
		public FNavAgentSelector SupportedAgents
		{
			get{ CheckIsValid();return (FNavAgentSelector)Marshal.PtrToStructure(_this.Get()+SupportedAgents__Offset, typeof(FNavAgentSelector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SupportedAgents__Offset, false);}
			
		}
		
		static ANavMeshBoundsVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavMeshBoundsVolume");
			SupportedAgents__Offset=GetPropertyOffset(NativeClassPtr,"SupportedAgents");
			
		}
		
	}
	
}
#endif
#endif
