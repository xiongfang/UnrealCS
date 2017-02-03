#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionClamp
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Min__Offset;
		public FExpressionInput Min
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Min__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Max__Offset;
		public FExpressionInput Max
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Max__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ClampMode__Offset;
		public EClampMode ClampMode
		{
			get{ CheckIsValid();return (EClampMode)Marshal.PtrToStructure(_this.Get()+ClampMode__Offset, typeof(EClampMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClampMode__Offset, false);}
			
		}
		
		static readonly int MinDefault__Offset;
		public float MinDefault
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDefault__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDefault__Offset, false);}
			
		}
		
		static readonly int MaxDefault__Offset;
		public float MaxDefault
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDefault__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDefault__Offset, false);}
			
		}
		
		static UMaterialExpressionClamp()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionClamp");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			Min__Offset=GetPropertyOffset(NativeClassPtr,"Min");
			Max__Offset=GetPropertyOffset(NativeClassPtr,"Max");
			ClampMode__Offset=GetPropertyOffset(NativeClassPtr,"ClampMode");
			MinDefault__Offset=GetPropertyOffset(NativeClassPtr,"MinDefault");
			MaxDefault__Offset=GetPropertyOffset(NativeClassPtr,"MaxDefault");
			
		}
		
	}
	
}
#endif
#endif
