#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetComponent
	{
		static readonly int WidgetClass__Offset;
		public TSubclassOf<UUserWidget>  WidgetClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WidgetClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + WidgetClass__Offset, value); }
			
		}
		
		static readonly int DrawSize__Offset;
		public FIntPoint DrawSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+DrawSize__Offset, typeof(FIntPoint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DrawSize__Offset, false);}
			
		}
		
		static readonly int bManuallyRedraw__Offset;
		public bool bManuallyRedraw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bManuallyRedraw__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bManuallyRedraw__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bRedrawRequested__Offset;
		public bool bRedrawRequested
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRedrawRequested__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RedrawTime__Offset;
		public float RedrawTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RedrawTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RedrawTime__Offset, false);}
			
		}
		
		static readonly int CurrentDrawSize__Offset;
		public FIntPoint CurrentDrawSize
		{
			get{ CheckIsValid();return (FIntPoint)Marshal.PtrToStructure(_this.Get()+CurrentDrawSize__Offset, typeof(FIntPoint));}
			
		}
		
		static readonly int bDrawAtDesiredSize__Offset;
		public bool bDrawAtDesiredSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawAtDesiredSize__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawAtDesiredSize__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Pivot__Offset;
		public FVector2D Pivot
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Pivot__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Pivot__Offset, false);}
			
		}
		
		static readonly int bReceiveHardwareInput__Offset;
		public bool bReceiveHardwareInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReceiveHardwareInput__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReceiveHardwareInput__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bWindowFocusable__Offset;
		public bool bWindowFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWindowFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWindowFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OwnerPlayer__Offset;
		public ULocalPlayer OwnerPlayer
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwnerPlayer__Offset); if (v == IntPtr.Zero)return null; ULocalPlayer retValue = new ULocalPlayer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BackgroundColor__Offset;
		public FLinearColor BackgroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+BackgroundColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BackgroundColor__Offset, false);}
			
		}
		
		static readonly int TintColorAndOpacity__Offset;
		public FLinearColor TintColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+TintColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TintColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int OpacityFromTexture__Offset;
		public float OpacityFromTexture
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OpacityFromTexture__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacityFromTexture__Offset, false);}
			
		}
		
		static readonly int bIsTwoSided__Offset;
		public bool bIsTwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsTwoSided__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsTwoSided__Offset, 1,0,1,255);}
			
		}
		
		static readonly int TickWhenOffscreen__Offset;
		public bool TickWhenOffscreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), TickWhenOffscreen__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), TickWhenOffscreen__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Widget__Offset;
		public UUserWidget Widget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Widget__Offset); if (v == IntPtr.Zero)return null; UUserWidget retValue = new UUserWidget(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BodySetup__Offset;
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TranslucentMaterial__Offset;
		public UMaterialInterface TranslucentMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TranslucentMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TranslucentMaterial_OneSided__Offset;
		public UMaterialInterface TranslucentMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TranslucentMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OpaqueMaterial__Offset;
		public UMaterialInterface OpaqueMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OpaqueMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int OpaqueMaterial_OneSided__Offset;
		public UMaterialInterface OpaqueMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OpaqueMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaskedMaterial__Offset;
		public UMaterialInterface MaskedMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaskedMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaskedMaterial_OneSided__Offset;
		public UMaterialInterface MaskedMaterial_OneSided
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaskedMaterial_OneSided__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RenderTarget__Offset;
		public UTextureRenderTarget2D RenderTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RenderTarget__Offset); if (v == IntPtr.Zero)return null; UTextureRenderTarget2D retValue = new UTextureRenderTarget2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MaterialInstance__Offset;
		public UMaterialInstanceDynamic MaterialInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MaterialInstance__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bAddedToScreen__Offset;
		public bool bAddedToScreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAddedToScreen__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEditTimeUsable__Offset;
		public bool bEditTimeUsable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditTimeUsable__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SharedLayerName__Offset;
		public FName SharedLayerName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SharedLayerName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SharedLayerName__Offset, false);}
			
		}
		
		static readonly int LayerZOrder__Offset;
		public int LayerZOrder
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LayerZOrder__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LayerZOrder__Offset, false);}
			
		}
		
		static readonly int CylinderArcAngle__Offset;
		public float CylinderArcAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CylinderArcAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CylinderArcAngle__Offset, false);}
			
		}
		
		static UWidgetComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetComponent");
			WidgetClass__Offset=GetPropertyOffset(NativeClassPtr,"WidgetClass");
			DrawSize__Offset=GetPropertyOffset(NativeClassPtr,"DrawSize");
			bManuallyRedraw__Offset=GetPropertyOffset(NativeClassPtr,"bManuallyRedraw");
			bRedrawRequested__Offset=GetPropertyOffset(NativeClassPtr,"bRedrawRequested");
			RedrawTime__Offset=GetPropertyOffset(NativeClassPtr,"RedrawTime");
			CurrentDrawSize__Offset=GetPropertyOffset(NativeClassPtr,"CurrentDrawSize");
			bDrawAtDesiredSize__Offset=GetPropertyOffset(NativeClassPtr,"bDrawAtDesiredSize");
			Pivot__Offset=GetPropertyOffset(NativeClassPtr,"Pivot");
			bReceiveHardwareInput__Offset=GetPropertyOffset(NativeClassPtr,"bReceiveHardwareInput");
			bWindowFocusable__Offset=GetPropertyOffset(NativeClassPtr,"bWindowFocusable");
			OwnerPlayer__Offset=GetPropertyOffset(NativeClassPtr,"OwnerPlayer");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			TintColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"TintColorAndOpacity");
			OpacityFromTexture__Offset=GetPropertyOffset(NativeClassPtr,"OpacityFromTexture");
			bIsTwoSided__Offset=GetPropertyOffset(NativeClassPtr,"bIsTwoSided");
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
			bAddedToScreen__Offset=GetPropertyOffset(NativeClassPtr,"bAddedToScreen");
			bEditTimeUsable__Offset=GetPropertyOffset(NativeClassPtr,"bEditTimeUsable");
			SharedLayerName__Offset=GetPropertyOffset(NativeClassPtr,"SharedLayerName");
			LayerZOrder__Offset=GetPropertyOffset(NativeClassPtr,"LayerZOrder");
			CylinderArcAngle__Offset=GetPropertyOffset(NativeClassPtr,"CylinderArcAngle");
			
		}
		
	}
	
}
#endif
#endif
