#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionQualitySwitch
	{
		static readonly int Default__Offset;
		/// <summary>Default connection, used when a specific quality level input is missing.</summary>
		public FExpressionInput Default
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Default__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Inputs__Offset;
		public FExpressionInput Inputs
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Inputs__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionQualitySwitch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionQualitySwitch");
			Default__Offset=GetPropertyOffset(NativeClassPtr,"Default");
			Inputs__Offset=GetPropertyOffset(NativeClassPtr,"Inputs");
			
		}
		
	}
	
}
#endif
#endif
