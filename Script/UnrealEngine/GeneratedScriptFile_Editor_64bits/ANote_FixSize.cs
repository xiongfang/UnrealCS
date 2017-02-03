#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANote
	{
		static readonly int Text__Offset;
		public FString Text
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int SpriteComponent__Offset;
		public UBillboardComponent SpriteComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpriteComponent__Offset); if (v == IntPtr.Zero)return null; UBillboardComponent retValue = new UBillboardComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static ANote()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Note");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			SpriteComponent__Offset=GetPropertyOffset(NativeClassPtr,"SpriteComponent");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
