#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFunctionOutput
	{
		static readonly int OutputName__Offset;
		/// <summary>The output's name, which will be drawn on the connector in function call expressions that use this function.</summary>
		public FString OutputName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+OutputName__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OutputName__Offset, false);}
			
		}
		
		static readonly int Description__Offset;
		/// <summary>The output's description, which will be used as a tooltip on the connector in function call expressions that use this function.</summary>
		public FString Description
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Description__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Description__Offset, false);}
			
		}
		
		static readonly int SortPriority__Offset;
		/// <summary>Controls where the output is displayed relative to the other outputs.</summary>
		public int SortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortPriority__Offset, false);}
			
		}
		
		static readonly int A__Offset;
		/// <summary>Stores the expression in the material function connected to this output.</summary>
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int bLastPreviewed__Offset;
		/// <summary>Whether this output was previewed the last time this function was edited.</summary>
		public bool bLastPreviewed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLastPreviewed__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int Id__Offset;
		/// <summary>Id of this input, used to maintain references through name changes.</summary>
		public FGuid Id
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+Id__Offset, typeof(FGuid));}
			
		}
		
		static UMaterialExpressionFunctionOutput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionFunctionOutput");
			OutputName__Offset=GetPropertyOffset(NativeClassPtr,"OutputName");
			Description__Offset=GetPropertyOffset(NativeClassPtr,"Description");
			SortPriority__Offset=GetPropertyOffset(NativeClassPtr,"SortPriority");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			bLastPreviewed__Offset=GetPropertyOffset(NativeClassPtr,"bLastPreviewed");
			Id__Offset=GetPropertyOffset(NativeClassPtr,"Id");
			
		}
		
	}
	
}
#endif
#endif
