#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An Anim Blueprint is essentially a specialized Blueprint whose graphs control the animation of a Skeletal Mesh.
	/// It can perform blending of animations, directly control the bones of the skeleton, and output a final pose
	/// for a Skeletal Mesh each frame.
	/// </summary>
	public partial class UAnimBlueprint
	{
		static readonly int TargetSkeleton__Offset;
		/// <summary>The kind of skeleton that animation graphs compiled from the blueprint will animate</summary>
		public USkeleton TargetSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TargetSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Groups__Offset;
		/// <summary>List of animation sync groups</summary>
		public TStructArray<FAnimGroupInfo> Groups
		{
			get{ CheckIsValid();return new TStructArray<FAnimGroupInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Groups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Groups__Offset, false);}
			
		}
		
		static readonly int bUseMultiThreadedAnimationUpdate__Offset;
		/// <summary>
		/// Allows this anim Blueprint to update its native update, blend tree, montages and asset players on
		/// a worker thread. The compiler will attempt to pick up any issues that may occur with threaded update.
		/// For updates to run in multiple threads both this flag and the project setting "Allow Multi Threaded
		/// Animation Update" should be set.
		/// </summary>
		public bool bUseMultiThreadedAnimationUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMultiThreadedAnimationUpdate__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMultiThreadedAnimationUpdate__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bWarnAboutBlueprintUsage__Offset;
		/// <summary>
		/// Selecting this option will cause the compiler to emit warnings whenever a call into Blueprint
		/// is made from the animation graph. This can help track down optimizations that need to be made.
		/// </summary>
		public bool bWarnAboutBlueprintUsage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnAboutBlueprintUsage__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWarnAboutBlueprintUsage__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ParentAssetOverrides__Offset;
		/// <summary>Array of overrides to asset containing nodes in the parent that have been overridden</summary>
		public TStructArray<FAnimParentNodeAssetOverride> ParentAssetOverrides
		{
			get{ CheckIsValid();return new TStructArray<FAnimParentNodeAssetOverride>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ParentAssetOverrides__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ParentAssetOverrides__Offset, false);}
			
		}
		
		static readonly int PoseWatches__Offset;
		/// <summary>
		/// Array of active pose watches (pose watch allows us to see the bone pose at a
		/// particular point of the anim graph)
		/// </summary>
		public TObjectArray<UPoseWatch>  PoseWatches
		{
					get{ CheckIsValid();return new TObjectArray<UPoseWatch>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PoseWatches__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PoseWatches__Offset, false);}
			
		}
		
		static UAnimBlueprint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimBlueprint");
			TargetSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"TargetSkeleton");
			Groups__Offset=GetPropertyOffset(NativeClassPtr,"Groups");
			bUseMultiThreadedAnimationUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bUseMultiThreadedAnimationUpdate");
			bWarnAboutBlueprintUsage__Offset=GetPropertyOffset(NativeClassPtr,"bWarnAboutBlueprintUsage");
			ParentAssetOverrides__Offset=GetPropertyOffset(NativeClassPtr,"ParentAssetOverrides");
			PoseWatches__Offset=GetPropertyOffset(NativeClassPtr,"PoseWatches");
			
		}
		
	}
	
}
#endif
#endif
