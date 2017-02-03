#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// DecalActor contains a DecalComponent which can be used to render material modifications on top of existing geometry.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/DecalActor
	/// @see UDecalComponent
	/// </summary>
	public partial class ADecalActor
	{
		static readonly int Decal__Offset;
		public UDecalComponent Decal
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Decal__Offset); if (v == IntPtr.Zero)return null; UDecalComponent retValue = new UDecalComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Decal__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Decal__Offset, value._this.Get()); }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BoxComponent__Offset;
		/// <summary>formerly we used this component to draw a box, now we use the DecalComponentVisualizer</summary>
		public UBoxComponent BoxComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BoxComponent__Offset); if (v == IntPtr.Zero)return null; UBoxComponent retValue = new UBoxComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ADecalActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DecalActor");
			Decal__Offset=GetPropertyOffset(NativeClassPtr,"Decal");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			BoxComponent__Offset=GetPropertyOffset(NativeClassPtr,"BoxComponent");
			
		}
		
	}
	
}
#endif
#endif
