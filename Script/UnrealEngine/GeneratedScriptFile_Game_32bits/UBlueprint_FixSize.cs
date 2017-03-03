#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlueprint
	{
		static readonly int bRecompileOnLoad__Offset;
		public bool bRecompileOnLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRecompileOnLoad__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ParentClass__Offset;
		public TSubclassOf<UObject>  ParentClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ParentClass__Offset); return v; }
			
		}
		
		static readonly int PRIVATE_InnermostPreviousCDO__Offset;
		public UObject PRIVATE_InnermostPreviousCDO
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PRIVATE_InnermostPreviousCDO__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bHasBeenRegenerated__Offset;
		public bool bHasBeenRegenerated
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBeenRegenerated__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsRegeneratingOnLoad__Offset;
		public bool bIsRegeneratingOnLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsRegeneratingOnLoad__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int SimpleConstructionScript__Offset;
		public USimpleConstructionScript SimpleConstructionScript
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SimpleConstructionScript__Offset); if (v == IntPtr.Zero)return null; USimpleConstructionScript retValue = new USimpleConstructionScript(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ComponentTemplates__Offset;
		public TObjectArray<UActorComponent>  ComponentTemplates
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ComponentTemplates__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ComponentTemplates__Offset, false);}
			
		}
		
		static readonly int Timelines__Offset;
		public TObjectArray<UTimelineTemplate>  Timelines
		{
					get{ CheckIsValid();return new TObjectArray<UTimelineTemplate>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Timelines__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Timelines__Offset, false);}
			
		}
		
		static readonly int InheritableComponentHandler__Offset;
		public UInheritableComponentHandler InheritableComponentHandler
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InheritableComponentHandler__Offset); if (v == IntPtr.Zero)return null; UInheritableComponentHandler retValue = new UInheritableComponentHandler(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BlueprintType__Offset;
		public EBlueprintType BlueprintType
		{
			get{ CheckIsValid();return (EBlueprintType)Marshal.PtrToStructure(_this.Get()+BlueprintType__Offset, typeof(EBlueprintType));}
			
		}
		
		static readonly int BlueprintSystemVersion__Offset;
		public int BlueprintSystemVersion
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+BlueprintSystemVersion__Offset, typeof(int));}
			
		}
		
		static readonly int bNativize__Offset;
		public bool bNativize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNativize__Offset, 1, 0, 1, 255);}
			
		}
		
		static UBlueprint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Blueprint");
			bRecompileOnLoad__Offset=GetPropertyOffset(NativeClassPtr,"bRecompileOnLoad");
			ParentClass__Offset=GetPropertyOffset(NativeClassPtr,"ParentClass");
			PRIVATE_InnermostPreviousCDO__Offset=GetPropertyOffset(NativeClassPtr,"PRIVATE_InnermostPreviousCDO");
			bHasBeenRegenerated__Offset=GetPropertyOffset(NativeClassPtr,"bHasBeenRegenerated");
			bIsRegeneratingOnLoad__Offset=GetPropertyOffset(NativeClassPtr,"bIsRegeneratingOnLoad");
			SimpleConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"SimpleConstructionScript");
			ComponentTemplates__Offset=GetPropertyOffset(NativeClassPtr,"ComponentTemplates");
			Timelines__Offset=GetPropertyOffset(NativeClassPtr,"Timelines");
			InheritableComponentHandler__Offset=GetPropertyOffset(NativeClassPtr,"InheritableComponentHandler");
			BlueprintType__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintType");
			BlueprintSystemVersion__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintSystemVersion");
			bNativize__Offset=GetPropertyOffset(NativeClassPtr,"bNativize");
			
		}
		
	}
	
}
#endif
#endif
