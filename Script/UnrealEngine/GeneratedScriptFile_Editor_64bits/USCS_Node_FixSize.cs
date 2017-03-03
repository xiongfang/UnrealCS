#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USCS_Node
	{
		static readonly int ComponentClass__Offset;
		/// <summary>Component class</summary>
		public UClass ComponentClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ComponentClass__Offset); return v; }
			
		}
		
		static readonly int ComponentTemplate__Offset;
		/// <summary>Template for the component to create</summary>
		public UActorComponent ComponentTemplate
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ComponentTemplate__Offset); if (v == IntPtr.Zero)return null; UActorComponent retValue = new UActorComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CookedComponentInstancingData__Offset;
		/// <summary>Cached data for faster runtime instancing (only used in cooked builds)</summary>
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData
		{
			get{ CheckIsValid();return (FBlueprintCookedComponentInstancingData)Marshal.PtrToStructure(_this.Get()+CookedComponentInstancingData__Offset, typeof(FBlueprintCookedComponentInstancingData));}
			
		}
		
		static readonly int VariableName__Offset;
		public FName VariableName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+VariableName__Offset, typeof(FName));}
			
		}
		
		static readonly int CategoryName__Offset;
		/// <summary>If non-None, the assigned category name</summary>
		public string CategoryName
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+CategoryName__Offset, typeof(FText))).ToString();}
			
		}
		
		static readonly int AttachToName__Offset;
		/// <summary>Socket/Bone that Node might attach to</summary>
		public FName AttachToName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachToName__Offset, typeof(FName));}
			
		}
		
		static readonly int ParentComponentOrVariableName__Offset;
		/// <summary>Component template or variable that Node might be parented to</summary>
		public FName ParentComponentOrVariableName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParentComponentOrVariableName__Offset, typeof(FName));}
			
		}
		
		static readonly int ParentComponentOwnerClassName__Offset;
		/// <summary>If the node is attached to another node inherited from a parent Blueprint, this contains the name of the Blueprint parent class that owns the component template //@TODO: We can potentially remove this if/when inherited SCS component template instances are included in subobject serialization, as we could then infer that the owner class is always the same as the BP class.</summary>
		public FName ParentComponentOwnerClassName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParentComponentOwnerClassName__Offset, typeof(FName));}
			
		}
		
		static readonly int bIsParentComponentNative__Offset;
		/// <summary>If the node is parented, this indicates whether or not the template is found in the CDO's Components array</summary>
		public bool bIsParentComponentNative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParentComponentNative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ChildNodes__Offset;
		/// <summary>Set of child nodes</summary>
		public TObjectArray<USCS_Node>  ChildNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildNodes__Offset, false);}
			
		}
		
		static readonly int MetaDataArray__Offset;
		/// <summary>Metadata information for this Node</summary>
		public TStructArray<FBPVariableMetaDataEntry> MetaDataArray
		{
			get{ CheckIsValid();return new TStructArray<FBPVariableMetaDataEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MetaDataArray__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MetaDataArray__Offset, false);}
			
		}
		
		static readonly int VariableGuid__Offset;
		public FGuid VariableGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+VariableGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int bIsFalseRoot__Offset;
		/// <summary>(DEPRECATED)</summary>
		public bool bIsFalseRoot
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFalseRoot__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsNative__Offset;
		/// <summary>(DEPRECATED) Indicates if this is a native component or not</summary>
		public bool bIsNative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsNative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int NativeComponentName__Offset;
		/// <summary>(DEPRECATED) If this is a native component, this is the name of the UActorComponent</summary>
		public FName NativeComponentName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NativeComponentName__Offset, typeof(FName));}
			
		}
		
		static readonly int bVariableNameAutoGenerated__Offset;
		/// <summary>(DEPRECATED) If true, the variable name was a autogenerated and is not presented to the user</summary>
		public bool bVariableNameAutoGenerated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVariableNameAutoGenerated__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int InternalVariableName__Offset;
		/// <summary>
		/// Internal variable name. This is used for:
		///                       a) Generating the component template (archetype) object name.
		///                       b) A UObjectProperty in the generated Blueprint class. This holds a reference to the component instance created at Actor construction time.
		///                       c) Archetype lookup through the generated Blueprint class. All instances route back to the archetype through the variable name (i.e. not the template name).
		/// </summary>
		public FName InternalVariableName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+InternalVariableName__Offset, typeof(FName));}
			
		}
		
		static USCS_Node()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SCS_Node");
			ComponentClass__Offset=GetPropertyOffset(NativeClassPtr,"ComponentClass");
			ComponentTemplate__Offset=GetPropertyOffset(NativeClassPtr,"ComponentTemplate");
			CookedComponentInstancingData__Offset=GetPropertyOffset(NativeClassPtr,"CookedComponentInstancingData");
			VariableName__Offset=GetPropertyOffset(NativeClassPtr,"VariableName");
			CategoryName__Offset=GetPropertyOffset(NativeClassPtr,"CategoryName");
			AttachToName__Offset=GetPropertyOffset(NativeClassPtr,"AttachToName");
			ParentComponentOrVariableName__Offset=GetPropertyOffset(NativeClassPtr,"ParentComponentOrVariableName");
			ParentComponentOwnerClassName__Offset=GetPropertyOffset(NativeClassPtr,"ParentComponentOwnerClassName");
			bIsParentComponentNative__Offset=GetPropertyOffset(NativeClassPtr,"bIsParentComponentNative");
			ChildNodes__Offset=GetPropertyOffset(NativeClassPtr,"ChildNodes");
			MetaDataArray__Offset=GetPropertyOffset(NativeClassPtr,"MetaDataArray");
			VariableGuid__Offset=GetPropertyOffset(NativeClassPtr,"VariableGuid");
			bIsFalseRoot__Offset=GetPropertyOffset(NativeClassPtr,"bIsFalseRoot");
			bIsNative__Offset=GetPropertyOffset(NativeClassPtr,"bIsNative");
			NativeComponentName__Offset=GetPropertyOffset(NativeClassPtr,"NativeComponentName");
			bVariableNameAutoGenerated__Offset=GetPropertyOffset(NativeClassPtr,"bVariableNameAutoGenerated");
			InternalVariableName__Offset=GetPropertyOffset(NativeClassPtr,"InternalVariableName");
			
		}
		
	}
	
}
#endif
#endif
