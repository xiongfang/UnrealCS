#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionNoise
	{
		static readonly int Position__Offset;
		public FExpressionInput Position
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Position__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int FilterWidth__Offset;
		public FExpressionInput FilterWidth
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+FilterWidth__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Scale__Offset;
		public float Scale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Scale__Offset, false);}
			
		}
		
		static readonly int Quality__Offset;
		public int Quality
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Quality__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Quality__Offset, false);}
			
		}
		
		static readonly int NoiseFunction__Offset;
		public ENoiseFunction NoiseFunction
		{
			get{ CheckIsValid();return (ENoiseFunction)Marshal.PtrToStructure(_this.Get()+NoiseFunction__Offset, typeof(ENoiseFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseFunction__Offset, false);}
			
		}
		
		static readonly int bTurbulence__Offset;
		public bool bTurbulence
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTurbulence__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTurbulence__Offset, 1,0,1,1);}
			
		}
		
		static readonly int Levels__Offset;
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
		public float LevelScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LevelScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelScale__Offset, false);}
			
		}
		
		static readonly int bTiling__Offset;
		public bool bTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTiling__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTiling__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RepeatSize__Offset;
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
