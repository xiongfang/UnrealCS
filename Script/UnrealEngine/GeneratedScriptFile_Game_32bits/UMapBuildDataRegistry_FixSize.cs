#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMapBuildDataRegistry
	{
		static readonly int LevelLightingQuality__Offset;
		public ELightingBuildQuality LevelLightingQuality
		{
			get{ CheckIsValid();return (ELightingBuildQuality)Marshal.PtrToStructure(_this.Get()+LevelLightingQuality__Offset, typeof(ELightingBuildQuality));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelLightingQuality__Offset, false);}
			
		}
		
		static UMapBuildDataRegistry()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MapBuildDataRegistry");
			LevelLightingQuality__Offset=GetPropertyOffset(NativeClassPtr,"LevelLightingQuality");
			
		}
		
	}
	
}
#endif
#endif
