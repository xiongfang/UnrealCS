#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavModifierComponent
	{
		static readonly int AreaClass__Offset;
		public TSubclassOf<UNavArea>  AreaClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AreaClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AreaClass__Offset, value); }
			
		}
		
		static readonly int FailsafeExtent__Offset;
		/// <summary>box extent used ONLY when owning actor doesn't have collision component</summary>
		public FVector FailsafeExtent
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+FailsafeExtent__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FailsafeExtent__Offset, false);}
			
		}
		
		static UNavModifierComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavModifierComponent");
			AreaClass__Offset=GetPropertyOffset(NativeClassPtr,"AreaClass");
			FailsafeExtent__Offset=GetPropertyOffset(NativeClassPtr,"FailsafeExtent");
			
		}
		
	}
	
}
#endif
#endif
