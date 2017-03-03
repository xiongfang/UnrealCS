#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDragDropOperation
	{
		static readonly int Tag__Offset;
		public FString Tag
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+Tag__Offset, typeof(FString));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Tag__Offset, false);}
			
		}
		
		static readonly int Payload__Offset;
		public UObject Payload
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Payload__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Payload__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Payload__Offset, value._this.Get()); }
			
		}
		
		static readonly int DefaultDragVisual__Offset;
		public UWidget DefaultDragVisual
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultDragVisual__Offset); if (v == IntPtr.Zero)return null; UWidget retValue = new UWidget(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DefaultDragVisual__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DefaultDragVisual__Offset, value._this.Get()); }
			
		}
		
		static readonly int Offset__Offset;
		public FVector2D Offset
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Offset__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Offset__Offset, false);}
			
		}
		
		static readonly int OnDrop__Offset;
		public FMulticastScriptDelegate OnDrop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnDrop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnDrop__Offset, false);}
			
		}
		
		static readonly int OnDragCancelled__Offset;
		public FMulticastScriptDelegate OnDragCancelled
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnDragCancelled__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnDragCancelled__Offset, false);}
			
		}
		
		static readonly int OnDragged__Offset;
		public FMulticastScriptDelegate OnDragged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnDragged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnDragged__Offset, false);}
			
		}
		
		static UDragDropOperation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DragDropOperation");
			Tag__Offset=GetPropertyOffset(NativeClassPtr,"Tag");
			Payload__Offset=GetPropertyOffset(NativeClassPtr,"Payload");
			DefaultDragVisual__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDragVisual");
			Offset__Offset=GetPropertyOffset(NativeClassPtr,"Offset");
			OnDrop__Offset=GetPropertyOffset(NativeClassPtr,"OnDrop");
			OnDragCancelled__Offset=GetPropertyOffset(NativeClassPtr,"OnDragCancelled");
			OnDragged__Offset=GetPropertyOffset(NativeClassPtr,"OnDragged");
			
		}
		
	}
	
}
#endif
#endif
