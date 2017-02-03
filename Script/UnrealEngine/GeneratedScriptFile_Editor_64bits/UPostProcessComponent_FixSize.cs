#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PostProcessComponent. Enables Post process controls for blueprints.
	///    Will use a parent UShapeComponent to provide volume data if available.
	/// </summary>
	public partial class UPostProcessComponent
	{
		static readonly int Settings__Offset;
		/// <summary>Post process settings to use for this volume.</summary>
		public FPostProcessSettings Settings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Settings__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>
		/// Priority of this volume. In the case of overlapping volumes the one with the highest priority
		/// overrides the lower priority ones. The order is undefined if two or more overlapping volumes have the same priority.
		/// </summary>
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static readonly int BlendRadius__Offset;
		/// <summary>World space radius around the volume that is used for blending (only if not unbound).</summary>
		public float BlendRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendRadius__Offset, false);}
			
		}
		
		static readonly int BlendWeight__Offset;
		/// <summary>0:no effect, 1:full effect</summary>
		public float BlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendWeight__Offset, false);}
			
		}
		
		static readonly int bEnabled__Offset;
		/// <summary>Whether this volume is enabled or not.</summary>
		public bool bEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnabled__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnabled__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUnbound__Offset;
		/// <summary>set this to false to use the parent shape component as volume bounds. True affects the whole world regardless.</summary>
		public bool bUnbound
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUnbound__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUnbound__Offset, 1,0,2,2);}
			
		}
		
		static UPostProcessComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PostProcessComponent");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			BlendRadius__Offset=GetPropertyOffset(NativeClassPtr,"BlendRadius");
			BlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"BlendWeight");
			bEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bEnabled");
			bUnbound__Offset=GetPropertyOffset(NativeClassPtr,"bUnbound");
			
		}
		
	}
	
}
#endif
#endif
