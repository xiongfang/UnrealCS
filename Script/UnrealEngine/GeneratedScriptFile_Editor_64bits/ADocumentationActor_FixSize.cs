#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ADocumentationActor
	{
		static readonly int DocumentLink__Offset;
		/// <summary>Link to a help document.</summary>
		public FString DocumentLink
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+DocumentLink__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DocumentLink__Offset, false);}
			
		}
		
		static readonly int Billboard__Offset;
		public UMaterialBillboardComponent Billboard
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Billboard__Offset); if (v == IntPtr.Zero)return null; UMaterialBillboardComponent retValue = new UMaterialBillboardComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Billboard__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Billboard__Offset, value._this.Get()); }
			
		}
		
		static ADocumentationActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DocumentationActor");
			DocumentLink__Offset=GetPropertyOffset(NativeClassPtr,"DocumentLink");
			Billboard__Offset=GetPropertyOffset(NativeClassPtr,"Billboard");
			
		}
		
	}
	
}
#endif
#endif
