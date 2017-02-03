#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionCollectionParameter
	{
		static readonly int Collection__Offset;
		/// <summary>The Parameter Collection to use.</summary>
		public UMaterialParameterCollection Collection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Collection__Offset); if (v == IntPtr.Zero)return null; UMaterialParameterCollection retValue = new UMaterialParameterCollection(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Collection__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Collection__Offset, value._this.Get()); }
			
		}
		
		static readonly int ParameterName__Offset;
		/// <summary>Name of the parameter being referenced.</summary>
		public FName ParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+ParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParameterName__Offset, false);}
			
		}
		
		static readonly int ParameterId__Offset;
		/// <summary>Id that is set from the name, and used to handle renaming of collection parameters.</summary>
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
