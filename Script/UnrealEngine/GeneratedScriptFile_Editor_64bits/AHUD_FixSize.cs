#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn.
	/// It also contains a list of simple hit boxes that can be used for simple item click detection.
	/// A method of rendering debug text is also included.
	/// Provides some simple methods for rendering text, textures, rectangles and materials which can also be accessed from blueprints.
	/// @see UCanvas
	/// @see FHUDHitBox
	/// @see FDebugTextInfo
	/// </summary>
	public partial class AHUD
	{
		static readonly int PlayerOwner__Offset;
		/// <summary>PlayerController which owns this HUD.</summary>
		public APlayerController PlayerOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerOwner__Offset); if (v == IntPtr.Zero)return null; APlayerController retValue = new APlayerController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bLostFocusPaused__Offset;
		/// <summary>Tells whether the game was paused due to lost focus</summary>
		public bool bLostFocusPaused
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLostFocusPaused__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bShowHUD__Offset;
		/// <summary>Whether or not the HUD should be drawn.</summary>
		public bool bShowHUD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowHUD__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowHUD__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bShowDebugInfo__Offset;
		/// <summary>If true, current ViewTarget shows debug information using its DisplayDebug().</summary>
		public bool bShowDebugInfo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowDebugInfo__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bShowHitBoxDebugInfo__Offset;
		/// <summary>If true, show hitbox debugging info.</summary>
		public bool bShowHitBoxDebugInfo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowHitBoxDebugInfo__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bShowOverlays__Offset;
		/// <summary>If true, render actor overlays.</summary>
		public bool bShowOverlays
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowOverlays__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bEnableDebugTextShadow__Offset;
		/// <summary>Put shadow on debug strings</summary>
		public bool bEnableDebugTextShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableDebugTextShadow__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableDebugTextShadow__Offset, 1,0,32,32);}
			
		}
		
		static readonly int PostRenderedActors__Offset;
		/// <summary>Holds a list of Actors that need PostRender() calls.</summary>
		public TObjectArray<AActor>  PostRenderedActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PostRenderedActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PostRenderedActors__Offset, false);}
			
		}
		
		static readonly int DebugDisplay__Offset;
		/// <summary>Array of names specifying what debug info to display for viewtarget actor.</summary>
		public TStructArray<FName> DebugDisplay
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugDisplay__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugDisplay__Offset, false);}
			
		}
		
		static readonly int ToggledDebugCategories__Offset;
		/// <summary>Array of names specifying what subsets of debug info to display for viewtarget actor.</summary>
		public TStructArray<FName> ToggledDebugCategories
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ToggledDebugCategories__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ToggledDebugCategories__Offset, false);}
			
		}
		
		static readonly int Canvas__Offset;
		/// <summary>Canvas to Draw HUD on.  Only valid during PostRender() event.</summary>
		public UCanvas Canvas
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Canvas__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugCanvas__Offset;
		/// <summary>'Foreground' debug canvas, will draw in front of Slate UI.</summary>
		public UCanvas DebugCanvas
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DebugCanvas__Offset); if (v == IntPtr.Zero)return null; UCanvas retValue = new UCanvas(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugTextList__Offset;
		public TStructArray<FDebugTextInfo> DebugTextList
		{
			get{ CheckIsValid();return new TStructArray<FDebugTextInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugTextList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugTextList__Offset, false);}
			
		}
		
		static readonly int ShowDebugTargetDesiredClass__Offset;
		/// <summary>Class filter for selecting 'ShowDebugTargetActor' when 'bShowDebugForReticleTarget' is true.</summary>
		public TSubclassOf<AActor>  ShowDebugTargetDesiredClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShowDebugTargetDesiredClass__Offset); return v; }
			
		}
		
		static readonly int ShowDebugTargetActor__Offset;
		/// <summary>Show Debug Actor used if 'bShowDebugForReticleTarget' is true, only updated if trace from reticle hit a new Actor of class 'ShowDebugTargetDesiredClass'</summary>
		public AActor ShowDebugTargetActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShowDebugTargetActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static AHUD()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HUD");
			PlayerOwner__Offset=GetPropertyOffset(NativeClassPtr,"PlayerOwner");
			bLostFocusPaused__Offset=GetPropertyOffset(NativeClassPtr,"bLostFocusPaused");
			bShowHUD__Offset=GetPropertyOffset(NativeClassPtr,"bShowHUD");
			bShowDebugInfo__Offset=GetPropertyOffset(NativeClassPtr,"bShowDebugInfo");
			bShowHitBoxDebugInfo__Offset=GetPropertyOffset(NativeClassPtr,"bShowHitBoxDebugInfo");
			bShowOverlays__Offset=GetPropertyOffset(NativeClassPtr,"bShowOverlays");
			bEnableDebugTextShadow__Offset=GetPropertyOffset(NativeClassPtr,"bEnableDebugTextShadow");
			PostRenderedActors__Offset=GetPropertyOffset(NativeClassPtr,"PostRenderedActors");
			DebugDisplay__Offset=GetPropertyOffset(NativeClassPtr,"DebugDisplay");
			ToggledDebugCategories__Offset=GetPropertyOffset(NativeClassPtr,"ToggledDebugCategories");
			Canvas__Offset=GetPropertyOffset(NativeClassPtr,"Canvas");
			DebugCanvas__Offset=GetPropertyOffset(NativeClassPtr,"DebugCanvas");
			DebugTextList__Offset=GetPropertyOffset(NativeClassPtr,"DebugTextList");
			ShowDebugTargetDesiredClass__Offset=GetPropertyOffset(NativeClassPtr,"ShowDebugTargetDesiredClass");
			ShowDebugTargetActor__Offset=GetPropertyOffset(NativeClassPtr,"ShowDebugTargetActor");
			
		}
		
	}
	
}
#endif
#endif
