#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTransformPosition
	{
		static readonly int Input__Offset;
		/// <summary>input expression for this transform</summary>
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int TransformSourceType__Offset;
		/// <summary>source format of the position that will be transformed</summary>
		public EMaterialPositionTransformSource TransformSourceType
		{
			get{ CheckIsValid();return (EMaterialPositionTransformSource)Marshal.PtrToStructure(_this.Get()+TransformSourceType__Offset, typeof(EMaterialPositionTransformSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TransformSourceType__Offset, false);}
			
		}
		
		static readonly int TransformType__Offset;
		/// <summary>type of transform to apply to the input expression</summary>
		public EMaterialPositionTransformSource TransformType
		{
			get{ CheckIsValid();return (EMaterialPositionTransformSource)Marshal.PtrToStructure(_this.Get()+TransformType__Offset, typeof(EMaterialPositionTransformSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TransformType__Offset, false);}
			
		}
		
		static UMaterialExpressionTransformPosition()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTransformPosition");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			TransformSourceType__Offset=GetPropertyOffset(NativeClassPtr,"TransformSourceType");
			TransformType__Offset=GetPropertyOffset(NativeClassPtr,"TransformType");
			
		}
		
	}
	
}
#endif
#endif
