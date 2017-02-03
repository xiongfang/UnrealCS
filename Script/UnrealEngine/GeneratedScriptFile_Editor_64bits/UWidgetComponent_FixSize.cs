#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Beware! This feature is experimental and may be substantially changed or removed in future releases.
	/// A 3D instance of a Widget Blueprint that can be interacted with in the world.
	/// SlateUI [Texture]
	/// BackColor [Vector]
	/// TintColorAndOpacity [Vector]
	/// OpacityFromTexture [Scalar]
	/// ParabolaDistortion [Scalar]
	/// </summary>
	public partial class UWidgetComponent
	{
		static readonly int Space__Offset;
		/// <summary>The coordinate space in which to render the widget</summary>
		public EWidgetSpace Space
		{
			get{ CheckIsValid();return (EWidgetSpace)Marshal.PtrToStructure(_this.Get()+Space__Offset, typeof(EWidgetSpace));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Space__Offset, false);}
			
		}
		
		static readonly int WidgetClass__Offset;
		/// <summary>The class of User Widget to create and display an instance of</summary>
		public TSubclassOf<UUserWidget>  WidgetClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WidgetClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + WidgetClass__Offset, value); }
			
		}
		
		static readonly int DrawSize__Offset;
		/// <summary>The size of the displayed quad.</summary>
		public FIntPoint DrawSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+DrawSize__Offset, typeof(FIntPoint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DrawSize__Offset, false);}
			
		}
		
		static readonly int bManuallyRedraw__Offset;
		/// <summary>Should we wait to be told to redraw to actually draw?</summary>
		public bool bManuallyRedraw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bManuallyRedraw__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bManuallyRedraw__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRedrawRequested__Offset;
		/// <summary>Has anyone requested we redraw?</summary>
		public bool bRedrawRequested
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRedrawRequested__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RedrawTime__Offset;
		/// <summary>
		/// The time in between draws, if 0 - we would redraw every frame.  If 1, we would redraw every second.
		/// This will work with bManuallyRedraw as well.  So you can say, manually redraw, but only redraw at this
		/// maximum rate.
		/// </summary>
		public float RedrawTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RedrawTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RedrawTime__Offset, false);}
			
		}
		
		static readonly int LastWidgetRenderTime__Offset;
		/// <summary>What was the last time we rendered the widget?</summary>
		public float LastWidgetRenderTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastWidgetRenderTime__Offset, typeof(float));}
			
		}
		
		static readonly int bWindowFocusable__Offset;
		/// <summary>Is the virtual window created to host the widget focusable?</summary>
		public bool bWindowFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWindowFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWindowFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int CurrentDrawSize__Offset;
		/// <summary>
		/// The actual draw size, this changes based on DrawSize - or the desired size of the widget if
		/// bDrawAtDesiredSize is true.
		/// </summary>
		public FIntPoint CurrentDrawSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+CurrentDrawSize__Offset, typeof(FIntPoint));}
			
		}
		
		static readonly int bDrawAtDesiredSize__Offset;
		/// <summary>
		/// Causes the render target to automatically match the desired size.
		/// WARNING: If you change this every frame, it will be very expensive.  If you need
		///    that effect, you should keep the outer widget's sized locked and dynamically
		///    scale or resize some inner widget.
		/// </summary>
		public bool bDrawAtDesiredSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawAtDesiredSize__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawAtDesiredSize__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Pivot__Offset;
		/// <summary>The Alignment/Pivot point that the widget is placed at relative to the position.</summary>
		public FVector2D Pivot
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Pivot__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Pivot__Offset, false);}
			
		}
		
		static readonly int OwnerPlayer__Offset;
		/// <summary>
		/// The owner player for a widget component, if this widget is drawn on the screen, this controls
		/// what player's screen it appears on for split screen, if not set, users player 0.
		/// </summary>
		public ULocalPlayer OwnerPlayer
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwnerPlayer__Offset); if (v == IntPtr.Zero)return null; ULocalPlayer retValue = new ULocalPlayer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BackgroundColor__Offset;
		/// <summary>The background color of the component</summary>
		public FLinearColor BackgroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+BackgroundColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BackgroundColor__Offset, false);}
			
		}
		
		static readonly int TintColorAndOpacity__Offset;
		/// <summary>Tint color and opacity for this component</summary>
		public FLinearColor TintColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+TintColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TintColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int OpacityFromTexture__Offset;
		/// <summary>Sets the amount of opacity from the widget's UI texture to use when rendering the translucent or masked UI to the viewport (0.0-1.0)</summary>
		public float OpacityFromTexture
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OpacityFromTexture__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacityFromTexture__Offset, false);}
			
		}
		
		static readonly int BlendMode__Offset;
		/// <summary>The blend mode for the widget.</summary>
		public EWidgetBlendMode BlendMode
		{
			get{ CheckIsValid();return (EWidgetBlendMode)Marshal.PtrToStructure(_this.Get()+BlendMode__Offset, typeof(EWidgetBlendMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendMode__Offset, false);}
			
		}
		
		static readonly int bIsOpaque__Offset;
		public bool bIsOpaque
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsOpaque__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsTwoSided__Offset;
		/// <summary>Is the component visible from behind?</summary>
		public bool bIsTwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsTwoSided__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsTwoSided__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ParabolaDistortion__Offset;
		/// <summary>
		/// When enabled, distorts the UI along a parabola shape giving the UI the appearance
		/// that it's on a curved surface in front of the users face.  This only works for UI
		/// rendered to a render target.
		/// </summary>
		public float ParabolaDistortion
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ParabolaDistortion__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ParabolaDistortion__Offset, false);}
			
		}
		
		static readonly int TickWhenOffscreen__Offset;
		/// <summary>Should the component tick the widget when it's off screen?</summary>
		public bool TickWhenOffscreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), TickWhenOffscreen__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), TickWhenOffscreen__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Widget__Offset;
		/// <summary>The User Widget object displayed and managed by this component</summary>
		public UUserWidget Widget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Widget__Offset); if (v == IntPtr.Zero)return null; UUserWidget retValue = new UUserWidget(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BodySetup__Offset;
		/// <summary>The body setup of the displayed quad</summary>
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TranslucentMaterial__Offset;
		/// <summary>The material instance for translucent widget components</summary>
		public UMaterialInterface TranslucentMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TranslucentMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TranslucentMaterial_OneSided__Offset;
		/// <summary>The material instance for translucent, one-sided widget components</summary>
		public UMaterialInterface TranslucentMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TranslucentMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OpaqueMaterial__Offset;
		/// <summary>The material instance for opaque widget components</summary>
		public UMaterialInterface OpaqueMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OpaqueMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OpaqueMaterial_OneSided__Offset;
		/// <summary>The material instance for opaque, one-sided widget components</summary>
		public UMaterialInterface OpaqueMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OpaqueMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaskedMaterial__Offset;
		/// <summary>The material instance for masked widget components.</summary>
		public UMaterialInterface MaskedMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaskedMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaskedMaterial_OneSided__Offset;
		/// <summary>The material instance for masked, one-sided widget components.</summary>
		public UMaterialInterface MaskedMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaskedMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RenderTarget__Offset;
		/// <summary>The target to which the user widget is rendered</summary>
		public UTextureRenderTarget2D RenderTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RenderTarget__Offset); if (v == IntPtr.Zero)return null; UTextureRenderTarget2D retValue = new UTextureRenderTarget2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaterialInstance__Offset;
		/// <summary>The dynamic instance of the material that the render target is attached to</summary>
		public UMaterialInstanceDynamic MaterialInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaterialInstance__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bUseLegacyRotation__Offset;
		public bool bUseLegacyRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLegacyRotation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bAddedToScreen__Offset;
		public bool bAddedToScreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAddedToScreen__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEditTimeUsable__Offset;
		/// <summary>Allows the widget component to be used at editor time.  For use in the VR-Editor.</summary>
		public bool bEditTimeUsable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditTimeUsable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SharedLayerName__Offset;
		/// <summary>Layer Name the widget will live on</summary>
		public FName SharedLayerName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SharedLayerName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SharedLayerName__Offset, false);}
			
		}
		
		static readonly int LayerZOrder__Offset;
		/// <summary>ZOrder the layer will be created on, note this only matters on the first time a new layer is created, subsequent additions to the same layer will use the initially defined ZOrder</summary>
		public int LayerZOrder
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LayerZOrder__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LayerZOrder__Offset, false);}
			
		}
		
		static UWidgetComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetComponent");
			Space__Offset=GetPropertyOffset(NativeClassPtr,"Space");
			WidgetClass__Offset=GetPropertyOffset(NativeClassPtr,"WidgetClass");
			DrawSize__Offset=GetPropertyOffset(NativeClassPtr,"DrawSize");
			bManuallyRedraw__Offset=GetPropertyOffset(NativeClassPtr,"bManuallyRedraw");
			bRedrawRequested__Offset=GetPropertyOffset(NativeClassPtr,"bRedrawRequested");
			RedrawTime__Offset=GetPropertyOffset(NativeClassPtr,"RedrawTime");
			LastWidgetRenderTime__Offset=GetPropertyOffset(NativeClassPtr,"LastWidgetRenderTime");
			bWindowFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bWindowFocusable");
			CurrentDrawSize__Offset=GetPropertyOffset(NativeClassPtr,"CurrentDrawSize");
			bDrawAtDesiredSize__Offset=GetPropertyOffset(NativeClassPtr,"bDrawAtDesiredSize");
			Pivot__Offset=GetPropertyOffset(NativeClassPtr,"Pivot");
			OwnerPlayer__Offset=GetPropertyOffset(NativeClassPtr,"OwnerPlayer");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			TintColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"TintColorAndOpacity");
			OpacityFromTexture__Offset=GetPropertyOffset(NativeClassPtr,"OpacityFromTexture");
			BlendMode__Offset=GetPropertyOffset(NativeClassPtr,"BlendMode");
			bIsOpaque__Offset=GetPropertyOffset(NativeClassPtr,"bIsOpaque");
			bIsTwoSided__Offset=GetPropertyOffset(NativeClassPtr,"bIsTwoSided");
			ParabolaDistortion__Offset=GetPropertyOffset(NativeClassPtr,"ParabolaDistortion");
			TickWhenOffscreen__Offset=GetPropertyOffset(NativeClassPtr,"TickWhenOffscreen");
			Widget__Offset=GetPropertyOffset(NativeClassPtr,"Widget");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			TranslucentMaterial__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentMaterial");
			TranslucentMaterial_OneSided__Offset=GetPropertyOffset(NativeClassPtr,"TranslucentMaterial_OneSided");
			OpaqueMaterial__Offset=GetPropertyOffset(NativeClassPtr,"OpaqueMaterial");
			OpaqueMaterial_OneSided__Offset=GetPropertyOffset(NativeClassPtr,"OpaqueMaterial_OneSided");
			MaskedMaterial__Offset=GetPropertyOffset(NativeClassPtr,"MaskedMaterial");
			MaskedMaterial_OneSided__Offset=GetPropertyOffset(NativeClassPtr,"MaskedMaterial_OneSided");
			RenderTarget__Offset=GetPropertyOffset(NativeClassPtr,"RenderTarget");
			MaterialInstance__Offset=GetPropertyOffset(NativeClassPtr,"MaterialInstance");
			bUseLegacyRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUseLegacyRotation");
			bAddedToScreen__Offset=GetPropertyOffset(NativeClassPtr,"bAddedToScreen");
			bEditTimeUsable__Offset=GetPropertyOffset(NativeClassPtr,"bEditTimeUsable");
			SharedLayerName__Offset=GetPropertyOffset(NativeClassPtr,"SharedLayerName");
			LayerZOrder__Offset=GetPropertyOffset(NativeClassPtr,"LayerZOrder");
			
		}
		
	}
	
}
#endif
#endif
