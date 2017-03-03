#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionVectorNoise
	{
		static readonly int Position__Offset;
		/// <summary>2 to 3 dimensional vector</summary>
		public FExpressionInput Position
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int NoiseFunction__Offset;
		/// <summary>Noise function, affects performance and look</summary>
		public EVectorNoiseFunction NoiseFunction
		{
			get{ CheckIsValid();return (EVectorNoiseFunction)Marshal.PtrToStructure(_this.Get()+NoiseFunction__Offset, typeof(EVectorNoiseFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseFunction__Offset, false);}
			
		}
		
		static readonly int Quality__Offset;
		/// <summary>For noise functions where applicable, lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
		public int Quality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Quality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Quality__Offset, false);}
			
		}
		
		static readonly int bTiling__Offset;
		/// <summary>Whether tile the noise pattern, useful for baking to seam-free repeating textures</summary>
		public bool bTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTiling__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTiling__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TileSize__Offset;
		/// <summary>
		/// How many units in each tile (if Tiling is on)
		/// For Perlin noise functions, Tile Size must be a multiple of three
		/// </summary>
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
