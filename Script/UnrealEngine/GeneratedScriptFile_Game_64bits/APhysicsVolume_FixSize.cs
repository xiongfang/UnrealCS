#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APhysicsVolume
	{
		static readonly int TerminalVelocity__Offset;
		public float TerminalVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TerminalVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TerminalVelocity__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		public int Priority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int FluidFriction__Offset;
		public float FluidFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FluidFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FluidFriction__Offset, false);}
			
		}
		
		static readonly int bWaterVolume__Offset;
		public bool bWaterVolume
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWaterVolume__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWaterVolume__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPhysicsOnContact__Offset;
		public bool bPhysicsOnContact
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPhysicsOnContact__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPhysicsOnContact__Offset, 1,0,2,2);}
			
		}
		
		static APhysicsVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PhysicsVolume");
			TerminalVelocity__Offset=GetPropertyOffset(NativeClassPtr,"TerminalVelocity");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			FluidFriction__Offset=GetPropertyOffset(NativeClassPtr,"FluidFriction");
			bWaterVolume__Offset=GetPropertyOffset(NativeClassPtr,"bWaterVolume");
			bPhysicsOnContact__Offset=GetPropertyOffset(NativeClassPtr,"bPhysicsOnContact");
			
		}
		
	}
	
}
#endif
#endif
