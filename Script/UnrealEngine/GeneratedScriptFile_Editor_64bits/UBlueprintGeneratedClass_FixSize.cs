#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlueprintGeneratedClass
	{
		static readonly int NumReplicatedProperties__Offset;
		public int NumReplicatedProperties
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumReplicatedProperties__Offset, typeof(int));}
			
		}
		
		static readonly int DynamicBindingObjects__Offset;
		/// <summary>Array of objects containing information for dynamically binding delegates to functions in this blueprint</summary>
		public TObjectArray<UDynamicBlueprintBinding>  DynamicBindingObjects
		{
					get{ CheckIsValid();return new TObjectArray<UDynamicBlueprintBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DynamicBindingObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DynamicBindingObjects__Offset, false);}
			
		}
		
		static readonly int ComponentTemplates__Offset;
		/// <summary>Array of component template objects, used by AddComponent function</summary>
		public TObjectArray<UActorComponent>  ComponentTemplates
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ComponentTemplates__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ComponentTemplates__Offset, false);}
			
		}
		
		static readonly int Timelines__Offset;
		/// <summary>Array of templates for timelines that should be created</summary>
		public TObjectArray<UTimelineTemplate>  Timelines
		{
					get{ CheckIsValid();return new TObjectArray<UTimelineTemplate>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Timelines__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Timelines__Offset, false);}
			
		}
		
		static readonly int SimpleConstructionScript__Offset;
		/// <summary>'Simple' construction script - graph of components to instance</summary>
		public USimpleConstructionScript SimpleConstructionScript
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SimpleConstructionScript__Offset); if (v == IntPtr.Zero)return null; USimpleConstructionScript retValue = new USimpleConstructionScript(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InheritableComponentHandler__Offset;
		/// <summary>Stores data to override (in children classes) components (created by SCS) from parent classes</summary>
		public UInheritableComponentHandler InheritableComponentHandler
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InheritableComponentHandler__Offset); if (v == IntPtr.Zero)return null; UInheritableComponentHandler retValue = new UInheritableComponentHandler(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UberGraphFramePointerProperty__Offset;
		public UStructProperty UberGraphFramePointerProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UberGraphFramePointerProperty__Offset); if (v == IntPtr.Zero)return null; UStructProperty retValue = new UStructProperty(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UberGraphFunction__Offset;
		public UFunction UberGraphFunction
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UberGraphFunction__Offset); if (v == IntPtr.Zero)return null; UFunction retValue = new UFunction(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int FastCallPairs__Offset;
		/// <summary>
		/// This is a list of event graph call function nodes that are simple (no argument) thunks into the event graph (typically used for animation delegates, etc...)
		/// It is a deprecated list only used for backwards compatibility prior to VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION.
		/// </summary>
		public TStructArray<FEventGraphFastCallPair> FastCallPairs
		{
			get{ CheckIsValid();return new TStructArray<FEventGraphFastCallPair>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FastCallPairs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FastCallPairs__Offset, false);}
			
		}
		
		static readonly int bHasInstrumentation__Offset;
		/// <summary>If this Generated Class has instrumentation</summary>
		public bool bHasInstrumentation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasInstrumentation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int OverridenArchetypeForCDO__Offset;
		public UObject OverridenArchetypeForCDO
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OverridenArchetypeForCDO__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bHasNativizedParent__Offset;
		/// <summary>Flag used to indicate if this class has a nativized parent in a cooked build.</summary>
		public bool bHasNativizedParent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasNativizedParent__Offset, 1, 0, 1, 255);}
			
		}
		
		static UBlueprintGeneratedClass()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlueprintGeneratedClass");
			NumReplicatedProperties__Offset=GetPropertyOffset(NativeClassPtr,"NumReplicatedProperties");
			DynamicBindingObjects__Offset=GetPropertyOffset(NativeClassPtr,"DynamicBindingObjects");
			ComponentTemplates__Offset=GetPropertyOffset(NativeClassPtr,"ComponentTemplates");
			Timelines__Offset=GetPropertyOffset(NativeClassPtr,"Timelines");
			SimpleConstructionScript__Offset=GetPropertyOffset(NativeClassPtr,"SimpleConstructionScript");
			InheritableComponentHandler__Offset=GetPropertyOffset(NativeClassPtr,"InheritableComponentHandler");
			UberGraphFramePointerProperty__Offset=GetPropertyOffset(NativeClassPtr,"UberGraphFramePointerProperty");
			UberGraphFunction__Offset=GetPropertyOffset(NativeClassPtr,"UberGraphFunction");
			FastCallPairs__Offset=GetPropertyOffset(NativeClassPtr,"FastCallPairs");
			bHasInstrumentation__Offset=GetPropertyOffset(NativeClassPtr,"bHasInstrumentation");
			OverridenArchetypeForCDO__Offset=GetPropertyOffset(NativeClassPtr,"OverridenArchetypeForCDO");
			bHasNativizedParent__Offset=GetPropertyOffset(NativeClassPtr,"bHasNativizedParent");
			
		}
		
	}
	
}
#endif
#endif
