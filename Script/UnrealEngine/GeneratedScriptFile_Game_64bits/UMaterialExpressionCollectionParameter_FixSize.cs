#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionCollectionParameter
	{
		static readonly int Collection__Offset;
		public UMaterialParameterCollection Collection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Collection__Offset); if (v == IntPtr.Zero)return null; UMaterialParameterCollection retValue = new UMaterialParameterCollection(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Collection__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Collection__Offset, value._this.Get()); }
			
		}
		
		static readonly int ParameterName__Offset;
		public FName ParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParameterName__Offset, false);}
			
		}
		
		static readonly int ParameterId__Offset;
		public FGuid ParameterId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ParameterId__Offset, typeof(FGuid));}
			
		}
		
		static UMaterialExpressionCollectionParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionCollectionParameter");
			Collection__Offset=GetPropertyOffset(NativeClassPtr,"Collection");
			ParameterName__Offset=GetPropertyOffset(NativeClassPtr,"ParameterName");
			ParameterId__Offset=GetPropertyOffset(NativeClassPtr,"ParameterId");
			
		}
		
	}
	
}
#endif
#endif
