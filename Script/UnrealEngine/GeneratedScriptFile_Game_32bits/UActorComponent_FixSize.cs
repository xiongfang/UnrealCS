#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UActorComponent
	{
		static readonly int PrimaryComponentTick__Offset;
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get{ CheckIsValid();return (FActorComponentTickFunction)Marshal.PtrToStructure(_this.Get()+PrimaryComponentTick__Offset, typeof(FActorComponentTickFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrimaryComponentTick__Offset, false);}
			
		}
		
		static readonly int ComponentTags__Offset;
		public TStructArray<FName> ComponentTags
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ComponentTags__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ComponentTags__Offset, false);}
			
		}
		
		static readonly int AssetUserData__Offset;
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int bReplicates__Offset;
		public bool bReplicates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bNetAddressable__Offset;
		public bool bNetAddressable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetAddressable__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bCreatedByConstructionScript__Offset;
		public bool bCreatedByConstructionScript
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCreatedByConstructionScript__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bInstanceComponent__Offset;
		public bool bInstanceComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInstanceComponent__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAutoActivate__Offset;
		public bool bAutoActivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoActivate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoActivate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIsActive__Offset;
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
		public bool bCanEverAffectNavigation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanEverAffectNavigation__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanEverAffectNavigation__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bIsEditorOnly__Offset;
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
