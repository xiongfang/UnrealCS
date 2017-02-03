#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_RemoveLinearKeys
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
		
		static readonly int MaxEffectorDiff__Offset;
		public float MaxEffectorDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEffectorDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxEffectorDiff__Offset, false);}
			
		}
		
		static readonly int MinEffectorDiff__Offset;
		public float MinEffectorDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinEffectorDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinEffectorDiff__Offset, false);}
			
		}
		
		static readonly int EffectorDiffSocket__Offset;
		public float EffectorDiffSocket
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EffectorDiffSocket__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EffectorDiffSocket__Offset, false);}
			
		}
		
		static readonly int ParentKeyScale__Offset;
		public float ParentKeyScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ParentKeyScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParentKeyScale__Offset, false);}
			
		}
		
		static readonly int bRetarget__Offset;
		public bool bRetarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRetarget__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRetarget__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bActuallyFilterLinearKeys__Offset;
		public bool bActuallyFilterLinearKeys
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActuallyFilterLinearKeys__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bActuallyFilterLinearKeys__Offset, 1,0,2,2);}
			
		}
		
		static UAnimCompress_RemoveLinearKeys()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimCompress_RemoveLinearKeys");
			MaxPosDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxPosDiff");
			MaxAngleDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxAngleDiff");
			MaxScaleDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxScaleDiff");
			MaxEffectorDiff__Offset=GetPropertyOffset(NativeClassPtr,"MaxEffectorDiff");
			MinEffectorDiff__Offset=GetPropertyOffset(NativeClassPtr,"MinEffectorDiff");
			EffectorDiffSocket__Offset=GetPropertyOffset(NativeClassPtr,"EffectorDiffSocket");
			ParentKeyScale__Offset=GetPropertyOffset(NativeClassPtr,"ParentKeyScale");
			bRetarget__Offset=GetPropertyOffset(NativeClassPtr,"bRetarget");
			bActuallyFilterLinearKeys__Offset=GetPropertyOffset(NativeClassPtr,"bActuallyFilterLinearKeys");
			
		}
		
	}
	
}
#endif
#endif
