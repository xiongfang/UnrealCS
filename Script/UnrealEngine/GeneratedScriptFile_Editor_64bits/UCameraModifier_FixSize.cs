#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A CameraModifier is a base class for objects that may adjust the final camera properties after
	/// being computed by the APlayerCameraManager (@see ModifyCamera). A CameraModifier
	/// can be stateful, and is associated uniquely with a specific APlayerCameraManager.
	/// </summary>
	public partial class UCameraModifier
	{
		static readonly int bDebug__Offset;
		/// <summary>If true, enables certain debug visualization features.</summary>
		public bool bDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDebug__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDebug__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bExclusive__Offset;
		/// <summary>If true, no other modifiers of same priority allowed.</summary>
		public bool bExclusive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExclusive__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bExclusive__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>Priority value that determines the order in which modifiers are applied. 0 = highest priority, 255 = lowest.</summary>
		public byte Priority
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(byte));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int CameraOwner__Offset;
		/// <summary>Camera this object is associated with.</summary>
		public APlayerCameraManager CameraOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraOwner__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AlphaInTime__Offset;
		/// <summary>When blending in, alpha proceeds from 0 to 1 over this time</summary>
		public float AlphaInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaInTime__Offset, false);}
			
		}
		
		static readonly int AlphaOutTime__Offset;
		/// <summary>When blending out, alpha proceeds from 1 to 0 over this time</summary>
		public float AlphaOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaOutTime__Offset, false);}
			
		}
		
		static readonly int Alpha__Offset;
		/// <summary>Current blend alpha.</summary>
		public float Alpha
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Alpha__Offset, typeof(float));}
			
		}
		
		static UCameraModifier()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraModifier");
			bDebug__Offset=GetPropertyOffset(NativeClassPtr,"bDebug");
			bExclusive__Offset=GetPropertyOffset(NativeClassPtr,"bExclusive");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			CameraOwner__Offset=GetPropertyOffset(NativeClassPtr,"CameraOwner");
			AlphaInTime__Offset=GetPropertyOffset(NativeClassPtr,"AlphaInTime");
			AlphaOutTime__Offset=GetPropertyOffset(NativeClassPtr,"AlphaOutTime");
			Alpha__Offset=GetPropertyOffset(NativeClassPtr,"Alpha");
			
		}
		
	}
	
}
#endif
#endif
