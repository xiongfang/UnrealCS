#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUserDefinedStruct
	{
		static readonly int Status__Offset;
		public EUserDefinedStructureStatus Status
		{
			get{ CheckIsValid();return (EUserDefinedStructureStatus)Marshal.PtrToStructure(_this.Get()+Status__Offset, typeof(EUserDefinedStructureStatus));}
			
		}
		
		static readonly int ErrorMessage__Offset;
		public FString ErrorMessage
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ErrorMessage__Offset, typeof(FString));}
			
		}
		
		static readonly int EditorData__Offset;
		public UObject EditorData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EditorData__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Guid__Offset;
		public FGuid Guid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+Guid__Offset, typeof(FGuid));}
			
		}
		
		static UUserDefinedStruct()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UserDefinedStruct");
			Status__Offset=GetPropertyOffset(NativeClassPtr,"Status");
			ErrorMessage__Offset=GetPropertyOffset(NativeClassPtr,"ErrorMessage");
			EditorData__Offset=GetPropertyOffset(NativeClassPtr,"EditorData");
			Guid__Offset=GetPropertyOffset(NativeClassPtr,"Guid");
			
		}
		
	}
	
}
#endif
#endif
