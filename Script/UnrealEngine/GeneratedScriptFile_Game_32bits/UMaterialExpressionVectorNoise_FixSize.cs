#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionVectorNoise
	{
		static readonly int Position__Offset;
		public FExpressionInput Position
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int NoiseFunction__Offset;
		public EVectorNoiseFunction NoiseFunction
		{
			get{ CheckIsValid();return (EVectorNoiseFunction)Marshal.PtrToStructure(_this.Get()+NoiseFunction__Offset, typeof(EVectorNoiseFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseFunction__Offset, false);}
			
		}
		
		static readonly int Quality__Offset;
		public int Quality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Quality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Quality__Offset, false);}
			
		}
		
		static readonly int bTiling__Offset;
		public bool bTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTiling__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTiling__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TileSize__Offset;
		public uint TileSize
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+TileSize__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TileSize__Offset, false);}
			
		}
		
		static UMaterialExpressionVectorNoise()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionVectorNoise");
			Position__Offset=GetPropertyOffset(NativeClassPtr,"Position");
			NoiseFunction__Offset=GetPropertyOffset(NativeClassPtr,"NoiseFunction");
			Quality__Offset=GetPropertyOffset(NativeClassPtr,"Quality");
			bTiling__Offset=GetPropertyOffset(NativeClassPtr,"bTiling");
			TileSize__Offset=GetPropertyOffset(NativeClassPtr,"TileSize");
			
		}
		
	}
	
}
#endif
#endif
