#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.
	/// Useful as a 'dummy' component in the hierarchy to offset others.
	/// @see [Scene Components](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#scenecomponents)
	/// </summary>
	public partial class USceneComponent
	{
		static readonly int AttachParent__Offset;
		public USceneComponent AttachParent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttachParent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AttachChildren__Offset;
		/// <summary>List of child SceneComponents that are attached to us.</summary>
		public TObjectArray<USceneComponent>  AttachChildren
		{
					get{ CheckIsValid();return new TObjectArray<USceneComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AttachChildren__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AttachChildren__Offset, false);}
			
		}
		
		static readonly int AttachSocketName__Offset;
		/// <summary>Optional socket name on AttachParent that we are attached to.</summary>
		public FName AttachSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachSocketName__Offset, typeof(FName));}
			
		}
		
		static readonly int bWorldToComponentUpdated__Offset;
		/// <summary>True if we have ever updated ComponentToWorld based on RelativeLocation/Rotation/Scale. Used at startup to make sure it is initialized.</summary>
		public bool bWorldToComponentUpdated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWorldToComponentUpdated__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bAbsoluteLocation__Offset;
		/// <summary>If RelativeLocation should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteLocation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAbsoluteLocation__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAbsoluteLocation__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAbsoluteRotation__Offset;
		/// <summary>If RelativeRotation should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAbsoluteRotation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAbsoluteRotation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAbsoluteScale__Offset;
		/// <summary>If RelativeScale3D should be considered relative to the world, rather than the parent</summary>
		public bool bAbsoluteScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAbsoluteScale__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAbsoluteScale__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bVisible__Offset;
		/// <summary>Whether to completely draw the primitive; if false, the primitive is not drawn, does not cast a shadow.</summary>
		public bool bVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisible__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVisible__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bHiddenInGame__Offset;
		/// <summary>Whether to hide the primitive in game, if the primitive is Visible.</summary>
		public bool bHiddenInGame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenInGame__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHiddenInGame__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bShouldUpdatePhysicsVolume__Offset;
		/// <summary>
		/// Whether or not the cached PhysicsVolume this component overlaps should be updated when the component is moved.
		/// @see GetPhysicsVolume()
		/// </summary>
		public bool bShouldUpdatePhysicsVolume
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldUpdatePhysicsVolume__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldUpdatePhysicsVolume__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bBoundsChangeTriggersStreamingDataRebuild__Offset;
		/// <summary>If true, a change in the bounds of the component will call trigger a streaming data rebuild</summary>
		public bool bBoundsChangeTriggersStreamingDataRebuild
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBoundsChangeTriggersStreamingDataRebuild__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bUseAttachParentBound__Offset;
		/// <summary>
		/// If true, this component uses its parents bounds when attached.
		/// This can be a significant optimization with many components attached together.
		/// </summary>
		public bool bUseAttachParentBound
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAttachParentBound__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAttachParentBound__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bAbsoluteTranslation__Offset;
		/// <summary>DEPRECATED</summary>
		public bool bAbsoluteTranslation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAbsoluteTranslation__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int RelativeLocation__Offset;
		/// <summary>Location of the component relative to its parent</summary>
		public FVector RelativeLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeLocation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeLocation__Offset, false);}
			
		}
		
		static readonly int RelativeRotation__Offset;
		/// <summary>Rotation of the component relative to its parent</summary>
		public FRotator RelativeRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RelativeRotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeRotation__Offset, false);}
			
		}
		
		static readonly int RelativeScale3D__Offset;
		/// <summary>
		/// Non-uniform scaling of the component relative to its parent.
		/// Note that scaling is always applied in local space (no shearing etc)
		/// </summary>
		public FVector RelativeScale3D
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeScale3D__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeScale3D__Offset, false);}
			
		}
		
		static readonly int RelativeTranslation__Offset;
		public FVector RelativeTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeTranslation__Offset, typeof(FVector));}
			
		}
		
		static readonly int Mobility__Offset;
		/// <summary>How often this component is allowed to move, used to make various optimizations. Only safe to set in constructor.</summary>
		public EComponentMobility Mobility
		{
			get{ CheckIsValid();return (EComponentMobility)Marshal.PtrToStructure(_this.Get()+Mobility__Offset, typeof(EComponentMobility));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Mobility__Offset, false);}
			
		}
		
		static readonly int DetailMode__Offset;
		/// <summary>If detail mode is >= system detail mode, primitive won't be rendered.</summary>
		public EDetailMode DetailMode
		{
			get{ CheckIsValid();return (EDetailMode)Marshal.PtrToStructure(_this.Get()+DetailMode__Offset, typeof(EDetailMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DetailMode__Offset, false);}
			
		}
		
		static readonly int ComponentVelocity__Offset;
		/// <summary>
		/// Velocity of the component.
		/// @see GetComponentVelocity()
		/// </summary>
		public FVector ComponentVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ComponentVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int PhysicsVolumeChangedDelegate__Offset;
		/// <summary>Delegate that will be called when PhysicsVolume has been changed *</summary>
		public FMulticastScriptDelegate PhysicsVolumeChangedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+PhysicsVolumeChangedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsVolumeChangedDelegate__Offset, false);}
			
		}
		
		static readonly int bVisualizeComponent__Offset;
		public bool bVisualizeComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisualizeComponent__Offset, 1, 0, 1, 1);}
			
		}
		
		static USceneComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneComponent");
			AttachParent__Offset=GetPropertyOffset(NativeClassPtr,"AttachParent");
			AttachChildren__Offset=GetPropertyOffset(NativeClassPtr,"AttachChildren");
			AttachSocketName__Offset=GetPropertyOffset(NativeClassPtr,"AttachSocketName");
			bWorldToComponentUpdated__Offset=GetPropertyOffset(NativeClassPtr,"bWorldToComponentUpdated");
			bAbsoluteLocation__Offset=GetPropertyOffset(NativeClassPtr,"bAbsoluteLocation");
			bAbsoluteRotation__Offset=GetPropertyOffset(NativeClassPtr,"bAbsoluteRotation");
			bAbsoluteScale__Offset=GetPropertyOffset(NativeClassPtr,"bAbsoluteScale");
			bVisible__Offset=GetPropertyOffset(NativeClassPtr,"bVisible");
			bHiddenInGame__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenInGame");
			bShouldUpdatePhysicsVolume__Offset=GetPropertyOffset(NativeClassPtr,"bShouldUpdatePhysicsVolume");
			bBoundsChangeTriggersStreamingDataRebuild__Offset=GetPropertyOffset(NativeClassPtr,"bBoundsChangeTriggersStreamingDataRebuild");
			bUseAttachParentBound__Offset=GetPropertyOffset(NativeClassPtr,"bUseAttachParentBound");
			bAbsoluteTranslation__Offset=GetPropertyOffset(NativeClassPtr,"bAbsoluteTranslation");
			RelativeLocation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeLocation");
			RelativeRotation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeRotation");
			RelativeScale3D__Offset=GetPropertyOffset(NativeClassPtr,"RelativeScale3D");
			RelativeTranslation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeTranslation");
			Mobility__Offset=GetPropertyOffset(NativeClassPtr,"Mobility");
			DetailMode__Offset=GetPropertyOffset(NativeClassPtr,"DetailMode");
			ComponentVelocity__Offset=GetPropertyOffset(NativeClassPtr,"ComponentVelocity");
			PhysicsVolumeChangedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsVolumeChangedDelegate");
			bVisualizeComponent__Offset=GetPropertyOffset(NativeClassPtr,"bVisualizeComponent");
			
		}
		
	}
	
}
#endif
#endif
