#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackVectorMaterialParam
	{
		static readonly int TargetMaterials__Offset;
		/// <summary>Materials whose parameters we want to change and the references to those materials.</summary>
		public TObjectArray<UMaterialInterface>  TargetMaterials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TargetMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TargetMaterials__Offset, false);}
			
		}
		
		static readonly int ParamName__Offset;
		/// <summary>Name of parameter in the MaterialInstance which this track will modify over time.</summary>
		public FName ParamName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParamName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParamName__Offset, false);}
			
		}
		
		static UInterpTrackVectorMaterialParam()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackVectorMaterialParam");
			TargetMaterials__Offset=GetPropertyOffset(NativeClassPtr,"TargetMaterials");
			ParamName__Offset=GetPropertyOffset(NativeClassPtr,"ParamName");
			
		}
		
	}
	
}
#endif
#endif
