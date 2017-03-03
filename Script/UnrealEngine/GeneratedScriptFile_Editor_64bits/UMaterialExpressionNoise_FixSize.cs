#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionNoise
	{
		static readonly int Position__Offset;
		/// <summary>2 to 3 dimensional vector</summary>
		public FExpressionInput Position
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int FilterWidth__Offset;
		/// <summary>scalar, to clamp the Levels at pixel level, can be computed like this: max(length(ddx(Position)), length(ddy(Position))</summary>
		public FExpressionInput FilterWidth
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+FilterWidth__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Scale__Offset;
		/// <summary>can also be done with a multiply on the Position</summary>
		public float Scale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Scale__Offset, false);}
			
		}
		
		static readonly int Quality__Offset;
		/// <summary>Lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
		public int Quality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Quality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Quality__Offset, false);}
			
		}
		
		static readonly int NoiseFunction__Offset;
		/// <summary>Noise function, affects performance and look</summary>
		public ENoiseFunction NoiseFunction
		{
			get{ CheckIsValid();return (ENoiseFunction)Marshal.PtrToStructure(_this.Get()+NoiseFunction__Offset, typeof(ENoiseFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseFunction__Offset, false);}
			
		}
		
		static readonly int bTurbulence__Offset;
		/// <summary>How multiple frequencies are getting combined</summary>
		public bool bTurbulence
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTurbulence__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTurbulence__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Levels__Offset;
		/// <summary>1 = fast but little detail, .. larger numbers cost more performance</summary>
		public int Levels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Levels__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Levels__Offset, false);}
			
		}
		
		static readonly int OutputMin__Offset;
		public float OutputMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutputMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputMin__Offset, false);}
			
		}
		
		static readonly int OutputMax__Offset;
		public float OutputMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OutputMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputMax__Offset, false);}
			
		}
		
		static readonly int LevelScale__Offset;
		/// <summary>usually 2 but higher values allow efficient use of few levels</summary>
		public float LevelScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelScale__Offset, false);}
			
		}
		
		static readonly int bTiling__Offset;
		/// <summary>Whether to use tiling noise pattern, useful for baking to seam-free repeating textures</summary>
		public bool bTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTiling__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTiling__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RepeatSize__Offset;
		/// <summary>How many units in each tile (if Tiling is on)</summary>
		public uint RepeatSize
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+RepeatSize__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RepeatSize__Offset, false);}
			
		}
		
		static UMaterialExpressionNoise()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionNoise");
			Position__Offset=GetPropertyOffset(NativeClassPtr,"Position");
			FilterWidth__Offset=GetPropertyOffset(NativeClassPtr,"FilterWidth");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			Quality__Offset=GetPropertyOffset(NativeClassPtr,"Quality");
			NoiseFunction__Offset=GetPropertyOffset(NativeClassPtr,"NoiseFunction");
			bTurbulence__Offset=GetPropertyOffset(NativeClassPtr,"bTurbulence");
			Levels__Offset=GetPropertyOffset(NativeClassPtr,"Levels");
			OutputMin__Offset=GetPropertyOffset(NativeClassPtr,"OutputMin");
			OutputMax__Offset=GetPropertyOffset(NativeClassPtr,"OutputMax");
			LevelScale__Offset=GetPropertyOffset(NativeClassPtr,"LevelScale");
			bTiling__Offset=GetPropertyOffset(NativeClassPtr,"bTiling");
			RepeatSize__Offset=GetPropertyOffset(NativeClassPtr,"RepeatSize");
			
		}
		
	}
	
}
#endif
#endif
