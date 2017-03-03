#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionPreviousFrameSwitch
	{
		static readonly int CurrentFrame__Offset;
		public FExpressionInput CurrentFrame
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CurrentFrame__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int PreviousFrame__Offset;
		public FExpressionInput PreviousFrame
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+PreviousFrame__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionPreviousFrameSwitch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionPreviousFrameSwitch");
			CurrentFrame__Offset=GetPropertyOffset(NativeClassPtr,"CurrentFrame");
			PreviousFrame__Offset=GetPropertyOffset(NativeClassPtr,"PreviousFrame");
			
		}
		
	}
	
}
#endif
#endif
