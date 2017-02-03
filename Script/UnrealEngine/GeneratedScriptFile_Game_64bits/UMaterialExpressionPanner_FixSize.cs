#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionPanner
	{
		static readonly int Coordinate__Offset;
		public FExpressionInput Coordinate
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Coordinate__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Time__Offset;
		public FExpressionInput Time
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Time__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Speed__Offset;
		public FExpressionInput Speed
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Speed__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int SpeedX__Offset;
		public float SpeedX
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpeedX__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpeedX__Offset, false);}
			
		}
		
		static readonly int SpeedY__Offset;
		public float SpeedY
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpeedY__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpeedY__Offset, false);}
			
		}
		
		static readonly int ConstCoordinate__Offset;
		public uint ConstCoordinate
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ConstCoordinate__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstCoordinate__Offset, false);}
			
		}
		
		static readonly int bFractionalPart__Offset;
		public bool bFractionalPart
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFractionalPart__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFractionalPart__Offset, 1,0,1,255);}
			
		}
		
		static UMaterialExpressionPanner()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionPanner");
			Coordinate__Offset=GetPropertyOffset(NativeClassPtr,"Coordinate");
			Time__Offset=GetPropertyOffset(NativeClassPtr,"Time");
			Speed__Offset=GetPropertyOffset(NativeClassPtr,"Speed");
			SpeedX__Offset=GetPropertyOffset(NativeClassPtr,"SpeedX");
			SpeedY__Offset=GetPropertyOffset(NativeClassPtr,"SpeedY");
			ConstCoordinate__Offset=GetPropertyOffset(NativeClassPtr,"ConstCoordinate");
			bFractionalPart__Offset=GetPropertyOffset(NativeClassPtr,"bFractionalPart");
			
		}
		
	}
	
}
#endif
#endif
