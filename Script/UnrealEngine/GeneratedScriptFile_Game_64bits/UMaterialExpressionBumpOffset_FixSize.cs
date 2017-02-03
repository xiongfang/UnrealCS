#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionBumpOffset
	{
		static readonly int Coordinate__Offset;
		public FExpressionInput Coordinate
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Coordinate__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Height__Offset;
		public FExpressionInput Height
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Height__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int HeightRatioInput__Offset;
		public FExpressionInput HeightRatioInput
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+HeightRatioInput__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int HeightRatio__Offset;
		public float HeightRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HeightRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HeightRatio__Offset, false);}
			
		}
		
		static readonly int ReferencePlane__Offset;
		public float ReferencePlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ReferencePlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReferencePlane__Offset, false);}
			
		}
		
		static readonly int ConstCoordinate__Offset;
		public uint ConstCoordinate
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ConstCoordinate__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstCoordinate__Offset, false);}
			
		}
		
		static UMaterialExpressionBumpOffset()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionBumpOffset");
			Coordinate__Offset=GetPropertyOffset(NativeClassPtr,"Coordinate");
			Height__Offset=GetPropertyOffset(NativeClassPtr,"Height");
			HeightRatioInput__Offset=GetPropertyOffset(NativeClassPtr,"HeightRatioInput");
			HeightRatio__Offset=GetPropertyOffset(NativeClassPtr,"HeightRatio");
			ReferencePlane__Offset=GetPropertyOffset(NativeClassPtr,"ReferencePlane");
			ConstCoordinate__Offset=GetPropertyOffset(NativeClassPtr,"ConstCoordinate");
			
		}
		
	}
	
}
#endif
#endif
