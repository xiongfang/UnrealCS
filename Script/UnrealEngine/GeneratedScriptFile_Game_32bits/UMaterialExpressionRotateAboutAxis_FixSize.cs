#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionRotateAboutAxis
	{
		static readonly int NormalizedRotationAxis__Offset;
		public FExpressionInput NormalizedRotationAxis
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+NormalizedRotationAxis__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int RotationAngle__Offset;
		public FExpressionInput RotationAngle
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+RotationAngle__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int PivotPoint__Offset;
		public FExpressionInput PivotPoint
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+PivotPoint__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Position__Offset;
		public FExpressionInput Position
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Period__Offset;
		public float Period
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Period__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Period__Offset, false);}
			
		}
		
		static UMaterialExpressionRotateAboutAxis()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionRotateAboutAxis");
			NormalizedRotationAxis__Offset=GetPropertyOffset(NativeClassPtr,"NormalizedRotationAxis");
			RotationAngle__Offset=GetPropertyOffset(NativeClassPtr,"RotationAngle");
			PivotPoint__Offset=GetPropertyOffset(NativeClassPtr,"PivotPoint");
			Position__Offset=GetPropertyOffset(NativeClassPtr,"Position");
			Period__Offset=GetPropertyOffset(NativeClassPtr,"Period");
			
		}
		
	}
	
}
#endif
#endif
