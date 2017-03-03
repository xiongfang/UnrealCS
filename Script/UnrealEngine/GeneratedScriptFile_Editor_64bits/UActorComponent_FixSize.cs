#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// ActorComponent is the base class for components that define reusable behavior that can be added to different types of Actors.
	/// ActorComponents that have a transform are known as SceneComponents and those that can be rendered are PrimitiveComponents.
	/// @see [ActorComponent](https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/Components/index.html#actorcomponents)
	/// @see USceneComponent
	/// @see UPrimitiveComponent
	/// </summary>
	public partial class UActorComponent
	{
		static readonly int PrimaryComponentTick__Offset;
		/// <summary>Main tick function for the Actor</summary>
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get{ CheckIsValid();return (FActorComponentTickFunction)Marshal.PtrToStructure(_this.Get()+PrimaryComponentTick__Offset, typeof(FActorComponentTickFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrimaryComponentTick__Offset, false);}
			
		}
		
		static readonly int ComponentTags__Offset;
		/// <summary>Array of tags that can be used for grouping and categorizing. Can also be accessed from scripting.</summary>
		public TStructArray<FName> ComponentTags
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ComponentTags__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ComponentTags__Offset, false);}
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the component</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int bReplicates__Offset;
		/// <summary>Is this component currently replicating? Should the network code consider it for replication? Owning Actor must be replicating first!</summary>
		public bool bReplicates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bNetAddressable__Offset;
		/// <summary>Is this component safe to ID over the network by name?</summary>
		public bool bNetAddressable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetAddressable__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bCreatedByConstructionScript__Offset;
		/// <summary>True if this component was created by a construction script, and will be destroyed by DestroyConstructedComponents</summary>
		public bool bCreatedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreatedByConstructionScript__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bInstanceComponent__Offset;
		/// <summary>True if this component was created as an instance component</summary>
		public bool bInstanceComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInstanceComponent__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAutoActivate__Offset;
		/// <summary>Whether the component is activated at creation or must be explicitly activated.</summary>
		public bool bAutoActivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoActivate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoActivate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIsActive__Offset;
		/// <summary>Whether the component is currently active.</summary>
		public bool bIsActive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsActive__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bEditableWhenInherited__Offset;
		public bool bEditableWhenInherited
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditableWhenInherited__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEditableWhenInherited__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCanEverAffectNavigation__Offset;
		/// <summary>Whether this component can potentially influence navigation</summary>
		public bool bCanEverAffectNavigation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanEverAffectNavigation__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanEverAffectNavigation__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bIsEditorOnly__Offset;
		/// <summary>If true, the component will be excluded from non-editor builds</summary>
		public bool bIsEditorOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsEditorOnly__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsEditorOnly__Offset, 1,0,1,1);}
			
		}
		
		static readonly int UCSModifiedProperties__Offset;
		public TStructArray<FSimpleMemberReference> UCSModifiedProperties
		{
			get{ CheckIsValid();return new TStructArray<FSimpleMemberReference>((FScriptArray)Marshal.PtrToStructure(_this.Get()+UCSModifiedProperties__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+UCSModifiedProperties__Offset, false);}
			
		}
		
		static readonly int OnComponentActivated__Offset;
		public FMulticastScriptDelegate OnComponentActivated
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentActivated__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentActivated__Offset, false);}
			
		}
		
		static readonly int OnComponentDeactivated__Offset;
		public FMulticastScriptDelegate OnComponentDeactivated
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentDeactivated__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentDeactivated__Offset, false);}
			
		}
		
		static UActorComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ActorComponent");
			PrimaryComponentTick__Offset=GetPropertyOffset(NativeClassPtr,"PrimaryComponentTick");
			ComponentTags__Offset=GetPropertyOffset(NativeClassPtr,"ComponentTags");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			bReplicates__Offset=GetPropertyOffset(NativeClassPtr,"bReplicates");
			bNetAddressable__Offset=GetPropertyOffset(NativeClassPtr,"bNetAddressable");
			bCreatedByConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"bCreatedByConstructionScript");
			bInstanceComponent__Offset=GetPropertyOffset(NativeClassPtr,"bInstanceComponent");
			bAutoActivate__Offset=GetPropertyOffset(NativeClassPtr,"bAutoActivate");
			bIsActive__Offset=GetPropertyOffset(NativeClassPtr,"bIsActive");
			bEditableWhenInherited__Offset=GetPropertyOffset(NativeClassPtr,"bEditableWhenInherited");
			bCanEverAffectNavigation__Offset=GetPropertyOffset(NativeClassPtr,"bCanEverAffectNavigation");
			bIsEditorOnly__Offset=GetPropertyOffset(NativeClassPtr,"bIsEditorOnly");
			UCSModifiedProperties__Offset=GetPropertyOffset(NativeClassPtr,"UCSModifiedProperties");
			OnComponentActivated__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentActivated");
			OnComponentDeactivated__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentDeactivated");
			
		}
		
	}
	
}
#endif
#endif
