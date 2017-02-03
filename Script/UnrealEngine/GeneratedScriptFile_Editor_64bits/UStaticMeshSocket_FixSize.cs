#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UStaticMeshSocket
	{
		static readonly int SocketName__Offset;
		/// <summary>
		/// Defines a named attachment location on the UStaticMesh.
		/// These are set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the StaticMeshComponent.
		/// The Outer of a StaticMeshSocket should always be the UStaticMesh.
		/// </summary>
		public FName SocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SocketName__Offset, typeof(FName));}
			
		}
		
		static readonly int RelativeLocation__Offset;
		public FVector RelativeLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeLocation__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeLocation__Offset, false);}
			
		}
		
		static readonly int RelativeRotation__Offset;
		public FRotator RelativeRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+RelativeRotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeRotation__Offset, false);}
			
		}
		
		static readonly int RelativeScale__Offset;
		public FVector RelativeScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RelativeScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RelativeScale__Offset, false);}
			
		}
		
		static readonly int Tag__Offset;
		public FString Tag
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Tag__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Tag__Offset, false);}
			
		}
		
		static readonly int PreviewStaticMesh__Offset;
		public UStaticMesh PreviewStaticMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewStaticMesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewStaticMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewStaticMesh__Offset, value._this.Get()); }
			
		}
		
		static UStaticMeshSocket()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMeshSocket");
			SocketName__Offset=GetPropertyOffset(NativeClassPtr,"SocketName");
			RelativeLocation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeLocation");
			RelativeRotation__Offset=GetPropertyOffset(NativeClassPtr,"RelativeRotation");
			RelativeScale__Offset=GetPropertyOffset(NativeClassPtr,"RelativeScale");
			Tag__Offset=GetPropertyOffset(NativeClassPtr,"Tag");
			PreviewStaticMesh__Offset=GetPropertyOffset(NativeClassPtr,"PreviewStaticMesh");
			
		}
		
	}
	
}
#endif
#endif
