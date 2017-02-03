#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PhysicsVolume: A bounding volume which affects actor physics.
	/// Each AActor is affected at any time by one PhysicsVolume.
	/// </summary>
	public partial class APhysicsVolume
	{
		static readonly int TerminalVelocity__Offset;
		/// <summary>Terminal velocity of pawns using CharacterMovement when falling.</summary>
		public float TerminalVelocity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TerminalVelocity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TerminalVelocity__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>Determines which PhysicsVolume takes precedence if they overlap (higher number = higher priority).</summary>
		public int Priority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int FluidFriction__Offset;
		/// <summary>This property controls the amount of friction applied by the volume as pawns using CharacterMovement move through it. The higher this value, the harder it will feel to move through</summary>
		public float FluidFriction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FluidFriction__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FluidFriction__Offset, false);}
			
		}
		
		static readonly int bWaterVolume__Offset;
		/// <summary>True if this volume contains a fluid like water</summary>
		public bool bWaterVolume
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWaterVolume__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWaterVolume__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPhysicsOnContact__Offset;
		/// <summary>By default, the origin of an AActor must be inside a PhysicsVolume for it to affect the actor. However if this flag is true, the other actor only has to touch the volume to be affected by it.</summary>
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
