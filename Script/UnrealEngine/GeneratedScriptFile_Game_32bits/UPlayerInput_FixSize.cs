#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPlayerInput
	{
		static readonly int DebugExecBindings__Offset;
		public TStructArray<FKeyBind> DebugExecBindings
		{
			get{ CheckIsValid();return new TStructArray<FKeyBind>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugExecBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugExecBindings__Offset, false);}
			
		}
		
		static readonly int InvertedAxis__Offset;
		public TStructArray<FName> InvertedAxis
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InvertedAxis__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InvertedAxis__Offset, false);}
			
		}
		
		static UPlayerInput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerInput");
			DebugExecBindings__Offset=GetPropertyOffset(NativeClassPtr,"DebugExecBindings");
			InvertedAxis__Offset=GetPropertyOffset(NativeClassPtr,"InvertedAxis");
			
		}
		
	}
	
}
#endif
#endif
