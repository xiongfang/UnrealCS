#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_RemoveTrivialKeys
	{
		static readonly int MaxPosDiff__Offset;
		public float MaxPosDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxPosDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxPosDiff__Offset, false);}
			
		}
		
		static readonly int MaxAngleDiff__Offset;
		public float MaxAngleDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAngleDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAngleDiff__Offset, false);}
			
		}
		
		static readonly int MaxScaleDiff__Offset;
		public float MaxScaleDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxScaleDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxScaleDiff__Offset, false);}
			
		}
		
		static UAnimCompress_RemoveTrivialKeys()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimCompress_RemoveTrivialKeys");
			MaxPosDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxPosDiff");
			MaxAngleDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxAngleDiff");
			MaxScaleDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxScaleDiff");
			
		}
		
	}
	
}
#endif
#endif
