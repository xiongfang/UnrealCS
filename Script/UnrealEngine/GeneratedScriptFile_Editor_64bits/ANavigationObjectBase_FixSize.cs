#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavigationObjectBase
	{
		static readonly int CapsuleComponent__Offset;
		public UCapsuleComponent CapsuleComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CapsuleComponent__Offset); if (v == IntPtr.Zero)return null; UCapsuleComponent retValue = new UCapsuleComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GoodSprite__Offset;
		public UBillboardComponent GoodSprite
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GoodSprite__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BadSprite__Offset;
		public UBillboardComponent BadSprite
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BadSprite__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bIsPIEPlayerStart__Offset;
		/// <summary>True if this nav point was spawned to be a PIE player start.</summary>
		public bool bIsPIEPlayerStart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsPIEPlayerStart__Offset, 1, 0, 1, 1);}
			
		}
		
		static ANavigationObjectBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationObjectBase");
			CapsuleComponent__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleComponent");
			GoodSprite__Offset=GetPropertyOffset(NativeClassPtr,"GoodSprite");
			BadSprite__Offset=GetPropertyOffset(NativeClassPtr,"BadSprite");
			bIsPIEPlayerStart__Offset=GetPropertyOffset(NativeClassPtr,"bIsPIEPlayerStart");
			
		}
		
	}
	
}
#endif
#endif
