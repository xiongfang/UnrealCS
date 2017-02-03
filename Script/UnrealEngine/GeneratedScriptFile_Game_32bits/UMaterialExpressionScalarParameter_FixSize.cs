#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionScalarParameter
	{
		static readonly int DefaultValue__Offset;
		public float DefaultValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultValue__Offset, false);}
			
		}
		
		static readonly int SliderMin__Offset;
		public float SliderMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SliderMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderMin__Offset, false);}
			
		}
		
		static readonly int SliderMax__Offset;
		public float SliderMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SliderMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderMax__Offset, false);}
			
		}
		
		static UMaterialExpressionScalarParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionScalarParameter");
			DefaultValue__Offset=GetPropertyOffset(NativeClassPtr,"DefaultValue");
			SliderMin__Offset=GetPropertyOffset(NativeClassPtr,"SliderMin");
			SliderMax__Offset=GetPropertyOffset(NativeClassPtr,"SliderMax");
			
		}
		
	}
	
}
#endif
#endif
