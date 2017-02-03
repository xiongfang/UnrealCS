#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionOutput
	{
		static readonly int OutputName__Offset;
		public FString OutputName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OutputName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputName__Offset, false);}
			
		}
		
		static readonly int Description__Offset;
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int SortPriority__Offset;
		public int SortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortPriority__Offset, false);}
			
		}
		
		static readonly int A__Offset;
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int bLastPreviewed__Offset;
		public bool bLastPreviewed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLastPreviewed__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ID__Offset;
		public FGuid ID
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ID__Offset, typeof(FGuid));}
			
		}
		
		static UMaterialExpressionFunctionOutput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionFunctionOutput");
			OutputName__Offset=GetPropertyOffset(NativeClassPtr,"OutputName");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			SortPriority__Offset=GetPropertyOffset(NativeClassPtr,"SortPriority");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			bLastPreviewed__Offset=GetPropertyOffset(NativeClassPtr,"bLastPreviewed");
			ID__Offset=GetPropertyOffset(NativeClassPtr,"ID");
			
		}
		
	}
	
}
#endif
#endif
