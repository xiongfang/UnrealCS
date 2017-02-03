#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APostProcessVolume
	{
		static readonly int Settings__Offset;
		public FPostProcessSettings Settings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Settings__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int BlendRadius__Offset;
		public float BlendRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendRadius__Offset, false);}
			
		}
		
		static readonly int BlendWeight__Offset;
		public float BlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendWeight__Offset, false);}
			
		}
		
		static readonly int bEnabled__Offset;
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUnbound__Offset;
		public bool bUnbound
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUnbound__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUnbound__Offset, 1,0,2,2);}
			
		}
		
		static APostProcessVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PostProcessVolume");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			BlendRadius__Offset=GetPropertyOffset(NativeClassPtr,"BlendRadius");
			BlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"BlendWeight");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			bUnbound__Offset=GetPropertyOffset(NativeClassPtr,"bUnbound");
			
		}
		
	}
	
}
#endif
#endif
