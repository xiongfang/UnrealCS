#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavRelevantComponent
	{
		static readonly int bAttachToOwnersRoot__Offset;
		public bool bAttachToOwnersRoot
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAttachToOwnersRoot__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CachedNavParent__Offset;
		public UObject CachedNavParent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CachedNavParent__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static UNavRelevantComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavRelevantComponent");
			bAttachToOwnersRoot__Offset=GetPropertyOffset(NativeClassPtr,"bAttachToOwnersRoot");
			CachedNavParent__Offset=GetPropertyOffset(NativeClassPtr,"CachedNavParent");
			
		}
		
	}
	
}
#endif
#endif
