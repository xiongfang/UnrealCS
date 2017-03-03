#if WITH_GAME
#if PLATFORM_32BITS
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
		public TObjectArray<UDynamicBlueprintBinding>  DynamicBindingObjects
		{
					get{ CheckIsValid();return new TObjectArray<UDynamicBlueprintBinding>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DynamicBindingObjects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DynamicBindingObjects__Offset, false);}
			
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
		
		static readonly int SimpleConstructionScript__Offset;
		public USimpleConstructionScript SimpleConstructionScript
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SimpleConstructionScript__Offset); if (v == IntPtr.Zero)return null; USimpleConstructionScript retValue = new USimpleConstructionScript(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InheritableComponentHandler__Offset;
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
		public TStructArray<FEventGraphFastCallPair> FastCallPairs
		{
			get{ CheckIsValid();return new TStructArray<FEventGraphFastCallPair>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FastCallPairs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FastCallPairs__Offset, false);}
			
		}
		
		static readonly int bHasInstrumentation__Offset;
		public bool bHasInstrumentation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasInstrumentation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bHasNativizedParent__Offset;
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
			bHasNativizedParent__Offset=GetPropertyOffset(NativeClassPtr,"bHasNativizedParent");
			
		}
		
	}
	
}
#endif
#endif
