#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_RemoveLinearKeys
	{
		static readonly int MaxPosDiff__Offset;
		/// <summary>Maximum position difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
		public float MaxPosDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxPosDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxPosDiff__Offset, false);}
			
		}
		
		static readonly int MaxAngleDiff__Offset;
		/// <summary>Maximum angle difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
		public float MaxAngleDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxAngleDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxAngleDiff__Offset, false);}
			
		}
		
		static readonly int MaxScaleDiff__Offset;
		/// <summary>Maximum Scale difference to use when testing if an animation key may be removed. Lower values retain more keys, but yield less compression.</summary>
		public float MaxScaleDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxScaleDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxScaleDiff__Offset, false);}
			
		}
		
		static readonly int MaxEffectorDiff__Offset;
		/// <summary>
		/// As keys are tested for removal, we monitor the effects all the way down to the end effectors.
		/// If their position changes by more than this amount as a result of removing a key, the key will be retained.
		/// This value is used for all bones except the end-effectors parent.
		/// </summary>
		public float MaxEffectorDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxEffectorDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxEffectorDiff__Offset, false);}
			
		}
		
		static readonly int MinEffectorDiff__Offset;
		/// <summary>
		/// As keys are tested for removal, we monitor the effects all the way down to the end effectors.
		/// If their position changes by more than this amount as a result of removing a key, the key will be retained.
		/// This value is used for the end-effectors parent, allowing tighter restrictions near the end of a skeletal chain.
		/// </summary>
		public float MinEffectorDiff
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinEffectorDiff__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinEffectorDiff__Offset, false);}
			
		}
		
		static readonly int EffectorDiffSocket__Offset;
		/// <summary>
		/// Error threshold for End Effectors with Sockets attached to them.
		/// Typically more important bone, where we want to be less aggressive with compression.
		/// </summary>
		public float EffectorDiffSocket
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EffectorDiffSocket__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EffectorDiffSocket__Offset, false);}
			
		}
		
		static readonly int ParentKeyScale__Offset;
		/// <summary>
		/// A scale value which increases the likelihood that a bone will retain a key if it's parent also had a key at the same time position.
		/// Higher values can remove shaking artifacts from the animation, at the cost of compression.
		/// </summary>
		public float ParentKeyScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ParentKeyScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParentKeyScale__Offset, false);}
			
		}
		
		static readonly int bRetarget__Offset;
		/// <summary>
		/// true = As the animation is compressed, adjust animated nodes to compensate for compression error.
		/// false= Do not adjust animated nodes.
		/// </summary>
		public bool bRetarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRetarget__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRetarget__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bActuallyFilterLinearKeys__Offset;
		/// <summary>
		/// Controls whether the final filtering step will occur, or only the retargetting after bitwise compression.
		/// If both this and bRetarget are false, then the linear compressor will do no better than the underlying bitwise compressor, extremely slowly.
		/// </summary>
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
