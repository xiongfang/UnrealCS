#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ATriggerBase
	{
		static readonly int CollisionComponent__Offset;
		public UShapeComponent CollisionComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CollisionComponent__Offset); if (v == IntPtr.Zero)return null; UShapeComponent retValue = new UShapeComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CollisionComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CollisionComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ATriggerBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TriggerBase");
			CollisionComponent__Offset=GetPropertyOffset(NativeClassPtr,"CollisionComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			
		}
		
	}
	
}
#endif
#endif
