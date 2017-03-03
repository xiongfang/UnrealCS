#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEngine
	{
		static readonly int TinyFont__Offset;
		public UFont TinyFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TinyFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TinyFontName__Offset;
		public FStringAssetReference TinyFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+TinyFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TinyFontName__Offset, false);}
			
		}
		
		static readonly int SmallFont__Offset;
		public UFont SmallFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SmallFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SmallFontName__Offset;
		public FStringAssetReference SmallFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+SmallFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmallFontName__Offset, false);}
			
		}
		
		static readonly int MediumFont__Offset;
		public UFont MediumFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MediumFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MediumFontName__Offset;
		public FStringAssetReference MediumFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+MediumFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MediumFontName__Offset, false);}
			
		}
		
		static readonly int LargeFont__Offset;
		public UFont LargeFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LargeFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LargeFontName__Offset;
		public FStringAssetReference LargeFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+LargeFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LargeFontName__Offset, false);}
			
		}
		
		static readonly int SubtitleFont__Offset;
		public UFont SubtitleFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubtitleFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubtitleFontName__Offset;
		public FStringAssetReference SubtitleFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+SubtitleFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitleFontName__Offset, false);}
			
		}
		
		static readonly int AdditionalFonts__Offset;
		public TObjectArray<UFont>  AdditionalFonts
		{
					get{ CheckIsValid();return new TObjectArray<UFont>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AdditionalFonts__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AdditionalFonts__Offset, false);}
			
		}
		
		static readonly int AdditionalFontNames__Offset;
		public TStructArray<FString> AdditionalFontNames
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AdditionalFontNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AdditionalFontNames__Offset, false);}
			
		}
		
		static readonly int ConsoleClass__Offset;
		public TSubclassOf<UConsole>  ConsoleClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConsoleClass__Offset); return v; }
			
		}
		
		static readonly int ConsoleClassName__Offset;
		public FStringClassReference ConsoleClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+ConsoleClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConsoleClassName__Offset, false);}
			
		}
		
		static readonly int GameViewportClientClass__Offset;
		public TSubclassOf<UGameViewportClient>  GameViewportClientClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameViewportClientClass__Offset); return v; }
			
		}
		
		static readonly int GameViewportClientClassName__Offset;
		public FStringClassReference GameViewportClientClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GameViewportClientClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GameViewportClientClassName__Offset, false);}
			
		}
		
		static readonly int LocalPlayerClass__Offset;
		public TSubclassOf<ULocalPlayer>  LocalPlayerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LocalPlayerClass__Offset); return v; }
			
		}
		
		static readonly int LocalPlayerClassName__Offset;
		public FStringClassReference LocalPlayerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+LocalPlayerClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocalPlayerClassName__Offset, false);}
			
		}
		
		static readonly int WorldSettingsClass__Offset;
		public TSubclassOf<AWorldSettings>  WorldSettingsClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldSettingsClass__Offset); return v; }
			
		}
		
		static readonly int WorldSettingsClassName__Offset;
		public FStringClassReference WorldSettingsClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+WorldSettingsClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldSettingsClassName__Offset, false);}
			
		}
		
		static readonly int NavigationSystemClassName__Offset;
		public FStringClassReference NavigationSystemClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+NavigationSystemClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int NavigationSystemClass__Offset;
		public TSubclassOf<UNavigationSystem>  NavigationSystemClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavigationSystemClass__Offset); return v; }
			
		}
		
		static readonly int AvoidanceManagerClassName__Offset;
		public FStringClassReference AvoidanceManagerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+AvoidanceManagerClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int AvoidanceManagerClass__Offset;
		public TSubclassOf<UAvoidanceManager>  AvoidanceManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AvoidanceManagerClass__Offset); return v; }
			
		}
		
		static readonly int PhysicsCollisionHandlerClass__Offset;
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset); return v; }
			
		}
		
		static readonly int PhysicsCollisionHandlerClassName__Offset;
		public FStringClassReference PhysicsCollisionHandlerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+PhysicsCollisionHandlerClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsCollisionHandlerClassName__Offset, false);}
			
		}
		
		static readonly int GameUserSettingsClassName__Offset;
		public FStringClassReference GameUserSettingsClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GameUserSettingsClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int GameUserSettingsClass__Offset;
		public TSubclassOf<UGameUserSettings>  GameUserSettingsClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameUserSettingsClass__Offset); return v; }
			
		}
		
		static readonly int AIControllerClassName__Offset;
		public FStringClassReference AIControllerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+AIControllerClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int GameUserSettings__Offset;
		public UGameUserSettings GameUserSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameUserSettings__Offset); if (v == IntPtr.Zero)return null; UGameUserSettings retValue = new UGameUserSettings(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelScriptActorClass__Offset;
		public TSubclassOf<ALevelScriptActor>  LevelScriptActorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelScriptActorClass__Offset); return v; }
			
		}
		
		static readonly int LevelScriptActorClassName__Offset;
		public FStringClassReference LevelScriptActorClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+LevelScriptActorClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelScriptActorClassName__Offset, false);}
			
		}
		
		static readonly int DefaultBlueprintBaseClassName__Offset;
		public FStringClassReference DefaultBlueprintBaseClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+DefaultBlueprintBaseClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultBlueprintBaseClassName__Offset, false);}
			
		}
		
		static readonly int GameSingletonClassName__Offset;
		public FStringClassReference GameSingletonClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GameSingletonClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GameSingletonClassName__Offset, false);}
			
		}
		
		static readonly int GameSingleton__Offset;
		public UObject GameSingleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSingleton__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayOnConsoleSaveDir__Offset;
		public FString PlayOnConsoleSaveDir
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PlayOnConsoleSaveDir__Offset, typeof(FString));}
			
		}
		
		static readonly int DefaultTexture__Offset;
		public UTexture2D DefaultTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultTextureName__Offset;
		public FStringAssetReference DefaultTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultDiffuseTexture__Offset;
		public UTexture DefaultDiffuseTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultDiffuseTexture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultDiffuseTextureName__Offset;
		public FStringAssetReference DefaultDiffuseTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultDiffuseTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultBSPVertexTexture__Offset;
		public UTexture2D DefaultBSPVertexTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBSPVertexTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultBSPVertexTextureName__Offset;
		public FStringAssetReference DefaultBSPVertexTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBSPVertexTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int HighFrequencyNoiseTexture__Offset;
		public UTexture2D HighFrequencyNoiseTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HighFrequencyNoiseTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int HighFrequencyNoiseTextureName__Offset;
		public FStringAssetReference HighFrequencyNoiseTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+HighFrequencyNoiseTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultBokehTexture__Offset;
		public UTexture2D DefaultBokehTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBokehTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultBokehTextureName__Offset;
		public FStringAssetReference DefaultBokehTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBokehTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int WireframeMaterial__Offset;
		public UMaterial WireframeMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WireframeMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WireframeMaterialName__Offset;
		public FString WireframeMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+WireframeMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int DebugMeshMaterial__Offset;
		public UMaterial DebugMeshMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DebugMeshMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugMeshMaterialName__Offset;
		public FStringAssetReference DebugMeshMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DebugMeshMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LevelColorationLitMaterial__Offset;
		public UMaterial LevelColorationLitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelColorationLitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelColorationLitMaterialName__Offset;
		public FString LevelColorationLitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LevelColorationLitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int LevelColorationUnlitMaterial__Offset;
		public UMaterial LevelColorationUnlitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelColorationUnlitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelColorationUnlitMaterialName__Offset;
		public FString LevelColorationUnlitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LevelColorationUnlitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int LightingTexelDensityMaterial__Offset;
		public UMaterial LightingTexelDensityMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightingTexelDensityMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LightingTexelDensityName__Offset;
		public FString LightingTexelDensityName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LightingTexelDensityName__Offset, typeof(FString));}
			
		}
		
		static readonly int ShadedLevelColorationLitMaterial__Offset;
		public UMaterial ShadedLevelColorationLitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadedLevelColorationLitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ShadedLevelColorationLitMaterialName__Offset;
		public FString ShadedLevelColorationLitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ShadedLevelColorationLitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int ShadedLevelColorationUnlitMaterial__Offset;
		public UMaterial ShadedLevelColorationUnlitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadedLevelColorationUnlitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ShadedLevelColorationUnlitMaterialName__Offset;
		public FString ShadedLevelColorationUnlitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ShadedLevelColorationUnlitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int RemoveSurfaceMaterial__Offset;
		public UMaterial RemoveSurfaceMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RemoveSurfaceMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RemoveSurfaceMaterialName__Offset;
		public FStringAssetReference RemoveSurfaceMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+RemoveSurfaceMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int VertexColorMaterial__Offset;
		public UMaterial VertexColorMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorMaterialName__Offset;
		public FString VertexColorMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_ColorOnly__Offset;
		public UMaterial VertexColorViewModeMaterial_ColorOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_ColorOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_ColorOnly__Offset;
		public FString VertexColorViewModeMaterialName_ColorOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_ColorOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_AlphaAsColor__Offset;
		public UMaterial VertexColorViewModeMaterial_AlphaAsColor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_AlphaAsColor__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_AlphaAsColor__Offset;
		public FString VertexColorViewModeMaterialName_AlphaAsColor
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_AlphaAsColor__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_RedOnly__Offset;
		public UMaterial VertexColorViewModeMaterial_RedOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_RedOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_RedOnly__Offset;
		public FString VertexColorViewModeMaterialName_RedOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_RedOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_GreenOnly__Offset;
		public UMaterial VertexColorViewModeMaterial_GreenOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_GreenOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_GreenOnly__Offset;
		public FString VertexColorViewModeMaterialName_GreenOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_GreenOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_BlueOnly__Offset;
		public UMaterial VertexColorViewModeMaterial_BlueOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_BlueOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_BlueOnly__Offset;
		public FString VertexColorViewModeMaterialName_BlueOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_BlueOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int ConstraintLimitMaterial__Offset;
		public UMaterial ConstraintLimitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialX__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialX
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialX__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialXAxis__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialXAxis
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialXAxis__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialY__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialY
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialY__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialYAxis__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialYAxis
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialYAxis__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialZ__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialZ
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialZ__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialZAxis__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialZAxis
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialZAxis__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ConstraintLimitMaterialPrismatic__Offset;
		public UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConstraintLimitMaterialPrismatic__Offset); if (v == IntPtr.Zero)return null; UMaterialInstanceDynamic retValue = new UMaterialInstanceDynamic(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InvalidLightmapSettingsMaterial__Offset;
		public UMaterial InvalidLightmapSettingsMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InvalidLightmapSettingsMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InvalidLightmapSettingsMaterialName__Offset;
		public FStringAssetReference InvalidLightmapSettingsMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+InvalidLightmapSettingsMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int PreviewShadowsIndicatorMaterial__Offset;
		public UMaterial PreviewShadowsIndicatorMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewShadowsIndicatorMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreviewShadowsIndicatorMaterialName__Offset;
		public FStringAssetReference PreviewShadowsIndicatorMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+PreviewShadowsIndicatorMaterialName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviewShadowsIndicatorMaterialName__Offset, false);}
			
		}
		
		static readonly int ArrowMaterial__Offset;
		public UMaterial ArrowMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ArrowMaterialName__Offset;
		public FStringAssetReference ArrowMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+ArrowMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LightingOnlyBrightness__Offset;
		public FLinearColor LightingOnlyBrightness
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightingOnlyBrightness__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int ShaderComplexityColors__Offset;
		public TStructArray<FLinearColor> ShaderComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ShaderComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ShaderComplexityColors__Offset, false);}
			
		}
		
		static readonly int QuadComplexityColors__Offset;
		public TStructArray<FLinearColor> QuadComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+QuadComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+QuadComplexityColors__Offset, false);}
			
		}
		
		static readonly int LightComplexityColors__Offset;
		public TStructArray<FLinearColor> LightComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LightComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LightComplexityColors__Offset, false);}
			
		}
		
		static readonly int StationaryLightOverlapColors__Offset;
		public TStructArray<FLinearColor> StationaryLightOverlapColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StationaryLightOverlapColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StationaryLightOverlapColors__Offset, false);}
			
		}
		
		static readonly int LODColorationColors__Offset;
		public TStructArray<FLinearColor> LODColorationColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODColorationColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODColorationColors__Offset, false);}
			
		}
		
		static readonly int HLODColorationColors__Offset;
		public TStructArray<FLinearColor> HLODColorationColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HLODColorationColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HLODColorationColors__Offset, false);}
			
		}
		
		static readonly int StreamingAccuracyColors__Offset;
		public TStructArray<FLinearColor> StreamingAccuracyColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingAccuracyColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingAccuracyColors__Offset, false);}
			
		}
		
		static readonly int MaxPixelShaderAdditiveComplexityCount__Offset;
		public float MaxPixelShaderAdditiveComplexityCount
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxPixelShaderAdditiveComplexityCount__Offset, typeof(float));}
			
		}
		
		static readonly int MaxES2PixelShaderAdditiveComplexityCount__Offset;
		public float MaxES2PixelShaderAdditiveComplexityCount
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxES2PixelShaderAdditiveComplexityCount__Offset, typeof(float));}
			
		}
		
		static readonly int MinLightMapDensity__Offset;
		public float MinLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int IdealLightMapDensity__Offset;
		public float IdealLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IdealLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int MaxLightMapDensity__Offset;
		public float MaxLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int bRenderLightMapDensityGrayscale__Offset;
		public bool bRenderLightMapDensityGrayscale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderLightMapDensityGrayscale__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int RenderLightMapDensityGrayscaleScale__Offset;
		public float RenderLightMapDensityGrayscaleScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RenderLightMapDensityGrayscaleScale__Offset, typeof(float));}
			
		}
		
		static readonly int RenderLightMapDensityColorScale__Offset;
		public float RenderLightMapDensityColorScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RenderLightMapDensityColorScale__Offset, typeof(float));}
			
		}
		
		static readonly int LightMapDensityVertexMappedColor__Offset;
		public FLinearColor LightMapDensityVertexMappedColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightMapDensityVertexMappedColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int LightMapDensitySelectedColor__Offset;
		public FLinearColor LightMapDensitySelectedColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightMapDensitySelectedColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int StatColorMappings__Offset;
		public TStructArray<FStatColorMapping> StatColorMappings
		{
			get{ CheckIsValid();return new TStructArray<FStatColorMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StatColorMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StatColorMappings__Offset, false);}
			
		}
		
		static readonly int DefaultPhysMaterial__Offset;
		public UPhysicalMaterial DefaultPhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPhysMaterialName__Offset;
		public FStringAssetReference DefaultPhysMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultPhysMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int ActiveGameNameRedirects__Offset;
		public TStructArray<FGameNameRedirect> ActiveGameNameRedirects
		{
			get{ CheckIsValid();return new TStructArray<FGameNameRedirect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveGameNameRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveGameNameRedirects__Offset, false);}
			
		}
		
		static readonly int ActiveClassRedirects__Offset;
		public TStructArray<FClassRedirect> ActiveClassRedirects
		{
			get{ CheckIsValid();return new TStructArray<FClassRedirect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveClassRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveClassRedirects__Offset, false);}
			
		}
		
		static readonly int ActivePluginRedirects__Offset;
		public TStructArray<FPluginRedirect> ActivePluginRedirects
		{
			get{ CheckIsValid();return new TStructArray<FPluginRedirect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActivePluginRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActivePluginRedirects__Offset, false);}
			
		}
		
		static readonly int ActiveStructRedirects__Offset;
		public TStructArray<FStructRedirect> ActiveStructRedirects
		{
			get{ CheckIsValid();return new TStructArray<FStructRedirect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveStructRedirects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveStructRedirects__Offset, false);}
			
		}
		
		static readonly int PreIntegratedSkinBRDFTexture__Offset;
		public UTexture2D PreIntegratedSkinBRDFTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreIntegratedSkinBRDFTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreIntegratedSkinBRDFTextureName__Offset;
		public FStringAssetReference PreIntegratedSkinBRDFTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+PreIntegratedSkinBRDFTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int MiniFontTexture__Offset;
		public UTexture2D MiniFontTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MiniFontTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MiniFontTextureName__Offset;
		public FStringAssetReference MiniFontTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+MiniFontTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int WeightMapPlaceholderTexture__Offset;
		public UTexture WeightMapPlaceholderTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WeightMapPlaceholderTexture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WeightMapPlaceholderTextureName__Offset;
		public FStringAssetReference WeightMapPlaceholderTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+WeightMapPlaceholderTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LightMapDensityTexture__Offset;
		public UTexture2D LightMapDensityTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightMapDensityTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LightMapDensityTextureName__Offset;
		public FStringAssetReference LightMapDensityTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+LightMapDensityTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int GameViewport__Offset;
		public UGameViewportClient GameViewport
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameViewport__Offset); if (v == IntPtr.Zero)return null; UGameViewportClient retValue = new UGameViewportClient(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DeferredCommands__Offset;
		public TStructArray<FString> DeferredCommands
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DeferredCommands__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DeferredCommands__Offset, false);}
			
		}
		
		static readonly int TickCycles__Offset;
		public int TickCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TickCycles__Offset, typeof(int));}
			
		}
		
		static readonly int GameCycles__Offset;
		public int GameCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+GameCycles__Offset, typeof(int));}
			
		}
		
		static readonly int ClientCycles__Offset;
		public int ClientCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ClientCycles__Offset, typeof(int));}
			
		}
		
		static readonly int NearClipPlane__Offset;
		public float NearClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NearClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NearClipPlane__Offset, false);}
			
		}
		
		static readonly int bHardwareSurveyEnabled__Offset;
		public bool bHardwareSurveyEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHardwareSurveyEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSubtitlesEnabled__Offset;
		public bool bSubtitlesEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubtitlesEnabled__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubtitlesEnabled__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSubtitlesForcedOff__Offset;
		public bool bSubtitlesForcedOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubtitlesForcedOff__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubtitlesForcedOff__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MaximumLoopIterationCount__Offset;
		public int MaximumLoopIterationCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaximumLoopIterationCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaximumLoopIterationCount__Offset, false);}
			
		}
		
		static readonly int bCanBlueprintsTickByDefault__Offset;
		public bool bCanBlueprintsTickByDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBlueprintsTickByDefault__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBlueprintsTickByDefault__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOptimizeAnimBlueprintMemberVariableAccess__Offset;
		public bool bOptimizeAnimBlueprintMemberVariableAccess
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOptimizeAnimBlueprintMemberVariableAccess__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOptimizeAnimBlueprintMemberVariableAccess__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bAllowMultiThreadedAnimationUpdate__Offset;
		public bool bAllowMultiThreadedAnimationUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowMultiThreadedAnimationUpdate__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowMultiThreadedAnimationUpdate__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableEditorPSysRealtimeLOD__Offset;
		public bool bEnableEditorPSysRealtimeLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableEditorPSysRealtimeLOD__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bSmoothFrameRate__Offset;
		public bool bSmoothFrameRate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmoothFrameRate__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmoothFrameRate__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseFixedFrameRate__Offset;
		public bool bUseFixedFrameRate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedFrameRate__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedFrameRate__Offset, 1,0,64,64);}
			
		}
		
		static readonly int FixedFrameRate__Offset;
		public float FixedFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedFrameRate__Offset, false);}
			
		}
		
		static readonly int SmoothedFrameRateRange__Offset;
		public FFloatRange SmoothedFrameRateRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+SmoothedFrameRateRange__Offset, typeof(FFloatRange));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmoothedFrameRateRange__Offset, false);}
			
		}
		
		static readonly int bCheckForMultiplePawnsSpawnedInAFrame__Offset;
		public bool bCheckForMultiplePawnsSpawnedInAFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheckForMultiplePawnsSpawnedInAFrame__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int NumPawnsAllowedToBeSpawnedInAFrame__Offset;
		public int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPawnsAllowedToBeSpawnedInAFrame__Offset, typeof(int));}
			
		}
		
		static readonly int bShouldGenerateLowQualityLightmaps__Offset;
		public bool bShouldGenerateLowQualityLightmaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldGenerateLowQualityLightmaps__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int C_WorldBox__Offset;
		public FColor C_WorldBox
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_WorldBox__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BrushWire__Offset;
		public FColor C_BrushWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BrushWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_AddWire__Offset;
		public FColor C_AddWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_AddWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_SubtractWire__Offset;
		public FColor C_SubtractWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_SubtractWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_SemiSolidWire__Offset;
		public FColor C_SemiSolidWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_SemiSolidWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_NonSolidWire__Offset;
		public FColor C_NonSolidWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_NonSolidWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_WireBackground__Offset;
		public FColor C_WireBackground
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_WireBackground__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_ScaleBoxHi__Offset;
		public FColor C_ScaleBoxHi
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_ScaleBoxHi__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_VolumeCollision__Offset;
		public FColor C_VolumeCollision
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_VolumeCollision__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BSPCollision__Offset;
		public FColor C_BSPCollision
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BSPCollision__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_OrthoBackground__Offset;
		public FColor C_OrthoBackground
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_OrthoBackground__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_Volume__Offset;
		public FColor C_Volume
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_Volume__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BrushShape__Offset;
		public FColor C_BrushShape
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BrushShape__Offset, typeof(FColor));}
			
		}
		
		static readonly int StreamingDistanceFactor__Offset;
		public float StreamingDistanceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceFactor__Offset, false);}
			
		}
		
		static readonly int TransitionType__Offset;
		public ETransitionType TransitionType
		{
			get{ CheckIsValid();return (ETransitionType)Marshal.PtrToStructure(_this.Get()+TransitionType__Offset, typeof(ETransitionType));}
			
		}
		
		static readonly int TransitionDescription__Offset;
		public FString TransitionDescription
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TransitionDescription__Offset, typeof(FString));}
			
		}
		
		static readonly int TransitionGameMode__Offset;
		public FString TransitionGameMode
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TransitionGameMode__Offset, typeof(FString));}
			
		}
		
		static readonly int MeshLODRange__Offset;
		public float MeshLODRange
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MeshLODRange__Offset, typeof(float));}
			
		}
		
		static readonly int bAllowMatureLanguage__Offset;
		public bool bAllowMatureLanguage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowMatureLanguage__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CameraRotationThreshold__Offset;
		public float CameraRotationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraRotationThreshold__Offset, typeof(float));}
			
		}
		
		static readonly int CameraTranslationThreshold__Offset;
		public float CameraTranslationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraTranslationThreshold__Offset, typeof(float));}
			
		}
		
		static readonly int PrimitiveProbablyVisibleTime__Offset;
		public float PrimitiveProbablyVisibleTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrimitiveProbablyVisibleTime__Offset, typeof(float));}
			
		}
		
		static readonly int MaxOcclusionPixelsFraction__Offset;
		public float MaxOcclusionPixelsFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxOcclusionPixelsFraction__Offset, typeof(float));}
			
		}
		
		static readonly int bPauseOnLossOfFocus__Offset;
		public bool bPauseOnLossOfFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseOnLossOfFocus__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int MaxParticleResize__Offset;
		public int MaxParticleResize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleResize__Offset, typeof(int));}
			
		}
		
		static readonly int MaxParticleResizeWarn__Offset;
		public int MaxParticleResizeWarn
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleResizeWarn__Offset, typeof(int));}
			
		}
		
		static readonly int PendingDroppedNotes__Offset;
		public TStructArray<FDropNoteInfo> PendingDroppedNotes
		{
			get{ CheckIsValid();return new TStructArray<FDropNoteInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PendingDroppedNotes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PendingDroppedNotes__Offset, false);}
			
		}
		
		static readonly int PhysicErrorCorrection__Offset;
		public FRigidBodyErrorCorrection PhysicErrorCorrection
		{
			get{ CheckIsValid();return (FRigidBodyErrorCorrection)Marshal.PtrToStructure(_this.Get()+PhysicErrorCorrection__Offset, typeof(FRigidBodyErrorCorrection));}
			
		}
		
		static readonly int NetClientTicksPerSecond__Offset;
		public float NetClientTicksPerSecond
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetClientTicksPerSecond__Offset, typeof(float));}
			
		}
		
		static readonly int DisplayGamma__Offset;
		public float DisplayGamma
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DisplayGamma__Offset, typeof(float));}
			
		}
		
		static readonly int MinDesiredFrameRate__Offset;
		public float MinDesiredFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredFrameRate__Offset, false);}
			
		}
		
		static readonly int DefaultSelectedMaterialColor__Offset;
		public FLinearColor DefaultSelectedMaterialColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DefaultSelectedMaterialColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectedMaterialColor__Offset;
		public FLinearColor SelectedMaterialColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectedMaterialColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectionOutlineColor__Offset;
		public FLinearColor SelectionOutlineColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectionOutlineColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SubduedSelectionOutlineColor__Offset;
		public FLinearColor SubduedSelectionOutlineColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SubduedSelectionOutlineColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectedMaterialColorOverride__Offset;
		public FLinearColor SelectedMaterialColorOverride
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectedMaterialColorOverride__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int bIsOverridingSelectedColor__Offset;
		public bool bIsOverridingSelectedColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsOverridingSelectedColor__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableOnScreenDebugMessages__Offset;
		public bool bEnableOnScreenDebugMessages
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableOnScreenDebugMessages__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bEnableOnScreenDebugMessagesDisplay__Offset;
		public bool bEnableOnScreenDebugMessagesDisplay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableOnScreenDebugMessagesDisplay__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSuppressMapWarnings__Offset;
		public bool bSuppressMapWarnings
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressMapWarnings__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDisableAILogging__Offset;
		public bool bDisableAILogging
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableAILogging__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bEnableVisualLogRecordingOnStart__Offset;
		public uint bEnableVisualLogRecordingOnStart
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+bEnableVisualLogRecordingOnStart__Offset, typeof(uint));}
			
		}
		
		static readonly int ScreenSaverInhibitorSemaphore__Offset;
		public int ScreenSaverInhibitorSemaphore
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ScreenSaverInhibitorSemaphore__Offset, typeof(int));}
			
		}
		
		static readonly int bLockReadOnlyLevels__Offset;
		public bool bLockReadOnlyLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockReadOnlyLevels__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ParticleEventManagerClassPath__Offset;
		public FString ParticleEventManagerClassPath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ParticleEventManagerClassPath__Offset, typeof(FString));}
			
		}
		
		static readonly int SelectionHighlightIntensity__Offset;
		public float SelectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int SelectionMeshSectionHighlightIntensity__Offset;
		public float SelectionMeshSectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionMeshSectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int BSPSelectionHighlightIntensity__Offset;
		public float BSPSelectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BSPSelectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int HoverHighlightIntensity__Offset;
		public float HoverHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HoverHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int SelectionHighlightIntensityBillboards__Offset;
		public float SelectionHighlightIntensityBillboards
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionHighlightIntensityBillboards__Offset, typeof(float));}
			
		}
		
		static readonly int NetDriverDefinitions__Offset;
		public TStructArray<FNetDriverDefinition> NetDriverDefinitions
		{
			get{ CheckIsValid();return new TStructArray<FNetDriverDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NetDriverDefinitions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NetDriverDefinitions__Offset, false);}
			
		}
		
		static readonly int ServerActors__Offset;
		public TStructArray<FString> ServerActors
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ServerActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ServerActors__Offset, false);}
			
		}
		
		static readonly int RuntimeServerActors__Offset;
		public TStructArray<FString> RuntimeServerActors
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RuntimeServerActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RuntimeServerActors__Offset, false);}
			
		}
		
		static readonly int bStartedLoadMapMovie__Offset;
		public bool bStartedLoadMapMovie
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartedLoadMapMovie__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int NextWorldContextHandle__Offset;
		public int NextWorldContextHandle
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NextWorldContextHandle__Offset, typeof(int));}
			
		}
		
		static UEngine()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Engine");
			TinyFont__Offset=GetPropertyOffset(NativeClassPtr,"TinyFont");
			TinyFontName__Offset=GetPropertyOffset(NativeClassPtr,"TinyFontName");
			SmallFont__Offset=GetPropertyOffset(NativeClassPtr,"SmallFont");
			SmallFontName__Offset=GetPropertyOffset(NativeClassPtr,"SmallFontName");
			MediumFont__Offset=GetPropertyOffset(NativeClassPtr,"MediumFont");
			MediumFontName__Offset=GetPropertyOffset(NativeClassPtr,"MediumFontName");
			LargeFont__Offset=GetPropertyOffset(NativeClassPtr,"LargeFont");
			LargeFontName__Offset=GetPropertyOffset(NativeClassPtr,"LargeFontName");
			SubtitleFont__Offset=GetPropertyOffset(NativeClassPtr,"SubtitleFont");
			SubtitleFontName__Offset=GetPropertyOffset(NativeClassPtr,"SubtitleFontName");
			AdditionalFonts__Offset=GetPropertyOffset(NativeClassPtr,"AdditionalFonts");
			AdditionalFontNames__Offset=GetPropertyOffset(NativeClassPtr,"AdditionalFontNames");
			ConsoleClass__Offset=GetPropertyOffset(NativeClassPtr,"ConsoleClass");
			ConsoleClassName__Offset=GetPropertyOffset(NativeClassPtr,"ConsoleClassName");
			GameViewportClientClass__Offset=GetPropertyOffset(NativeClassPtr,"GameViewportClientClass");
			GameViewportClientClassName__Offset=GetPropertyOffset(NativeClassPtr,"GameViewportClientClassName");
			LocalPlayerClass__Offset=GetPropertyOffset(NativeClassPtr,"LocalPlayerClass");
			LocalPlayerClassName__Offset=GetPropertyOffset(NativeClassPtr,"LocalPlayerClassName");
			WorldSettingsClass__Offset=GetPropertyOffset(NativeClassPtr,"WorldSettingsClass");
			WorldSettingsClassName__Offset=GetPropertyOffset(NativeClassPtr,"WorldSettingsClassName");
			NavigationSystemClassName__Offset=GetPropertyOffset(NativeClassPtr,"NavigationSystemClassName");
			NavigationSystemClass__Offset=GetPropertyOffset(NativeClassPtr,"NavigationSystemClass");
			AvoidanceManagerClassName__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceManagerClassName");
			AvoidanceManagerClass__Offset=GetPropertyOffset(NativeClassPtr,"AvoidanceManagerClass");
			PhysicsCollisionHandlerClass__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsCollisionHandlerClass");
			PhysicsCollisionHandlerClassName__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsCollisionHandlerClassName");
			GameUserSettingsClassName__Offset=GetPropertyOffset(NativeClassPtr,"GameUserSettingsClassName");
			GameUserSettingsClass__Offset=GetPropertyOffset(NativeClassPtr,"GameUserSettingsClass");
			AIControllerClassName__Offset=GetPropertyOffset(NativeClassPtr,"AIControllerClassName");
			GameUserSettings__Offset=GetPropertyOffset(NativeClassPtr,"GameUserSettings");
			LevelScriptActorClass__Offset=GetPropertyOffset(NativeClassPtr,"LevelScriptActorClass");
			LevelScriptActorClassName__Offset=GetPropertyOffset(NativeClassPtr,"LevelScriptActorClassName");
			DefaultBlueprintBaseClassName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBlueprintBaseClassName");
			GameSingletonClassName__Offset=GetPropertyOffset(NativeClassPtr,"GameSingletonClassName");
			GameSingleton__Offset=GetPropertyOffset(NativeClassPtr,"GameSingleton");
			PlayOnConsoleSaveDir__Offset=GetPropertyOffset(NativeClassPtr,"PlayOnConsoleSaveDir");
			DefaultTexture__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTexture");
			DefaultTextureName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTextureName");
			DefaultDiffuseTexture__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDiffuseTexture");
			DefaultDiffuseTextureName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDiffuseTextureName");
			DefaultBSPVertexTexture__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBSPVertexTexture");
			DefaultBSPVertexTextureName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBSPVertexTextureName");
			HighFrequencyNoiseTexture__Offset=GetPropertyOffset(NativeClassPtr,"HighFrequencyNoiseTexture");
			HighFrequencyNoiseTextureName__Offset=GetPropertyOffset(NativeClassPtr,"HighFrequencyNoiseTextureName");
			DefaultBokehTexture__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBokehTexture");
			DefaultBokehTextureName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBokehTextureName");
			WireframeMaterial__Offset=GetPropertyOffset(NativeClassPtr,"WireframeMaterial");
			WireframeMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"WireframeMaterialName");
			DebugMeshMaterial__Offset=GetPropertyOffset(NativeClassPtr,"DebugMeshMaterial");
			DebugMeshMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"DebugMeshMaterialName");
			LevelColorationLitMaterial__Offset=GetPropertyOffset(NativeClassPtr,"LevelColorationLitMaterial");
			LevelColorationLitMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"LevelColorationLitMaterialName");
			LevelColorationUnlitMaterial__Offset=GetPropertyOffset(NativeClassPtr,"LevelColorationUnlitMaterial");
			LevelColorationUnlitMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"LevelColorationUnlitMaterialName");
			LightingTexelDensityMaterial__Offset=GetPropertyOffset(NativeClassPtr,"LightingTexelDensityMaterial");
			LightingTexelDensityName__Offset=GetPropertyOffset(NativeClassPtr,"LightingTexelDensityName");
			ShadedLevelColorationLitMaterial__Offset=GetPropertyOffset(NativeClassPtr,"ShadedLevelColorationLitMaterial");
			ShadedLevelColorationLitMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"ShadedLevelColorationLitMaterialName");
			ShadedLevelColorationUnlitMaterial__Offset=GetPropertyOffset(NativeClassPtr,"ShadedLevelColorationUnlitMaterial");
			ShadedLevelColorationUnlitMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"ShadedLevelColorationUnlitMaterialName");
			RemoveSurfaceMaterial__Offset=GetPropertyOffset(NativeClassPtr,"RemoveSurfaceMaterial");
			RemoveSurfaceMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"RemoveSurfaceMaterialName");
			VertexColorMaterial__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorMaterial");
			VertexColorMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorMaterialName");
			VertexColorViewModeMaterial_ColorOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterial_ColorOnly");
			VertexColorViewModeMaterialName_ColorOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterialName_ColorOnly");
			VertexColorViewModeMaterial_AlphaAsColor__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterial_AlphaAsColor");
			VertexColorViewModeMaterialName_AlphaAsColor__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterialName_AlphaAsColor");
			VertexColorViewModeMaterial_RedOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterial_RedOnly");
			VertexColorViewModeMaterialName_RedOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterialName_RedOnly");
			VertexColorViewModeMaterial_GreenOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterial_GreenOnly");
			VertexColorViewModeMaterialName_GreenOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterialName_GreenOnly");
			VertexColorViewModeMaterial_BlueOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterial_BlueOnly");
			VertexColorViewModeMaterialName_BlueOnly__Offset=GetPropertyOffset(NativeClassPtr,"VertexColorViewModeMaterialName_BlueOnly");
			ConstraintLimitMaterial__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterial");
			ConstraintLimitMaterialX__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialX");
			ConstraintLimitMaterialXAxis__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialXAxis");
			ConstraintLimitMaterialY__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialY");
			ConstraintLimitMaterialYAxis__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialYAxis");
			ConstraintLimitMaterialZ__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialZ");
			ConstraintLimitMaterialZAxis__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialZAxis");
			ConstraintLimitMaterialPrismatic__Offset=GetPropertyOffset(NativeClassPtr,"ConstraintLimitMaterialPrismatic");
			InvalidLightmapSettingsMaterial__Offset=GetPropertyOffset(NativeClassPtr,"InvalidLightmapSettingsMaterial");
			InvalidLightmapSettingsMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"InvalidLightmapSettingsMaterialName");
			PreviewShadowsIndicatorMaterial__Offset=GetPropertyOffset(NativeClassPtr,"PreviewShadowsIndicatorMaterial");
			PreviewShadowsIndicatorMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"PreviewShadowsIndicatorMaterialName");
			ArrowMaterial__Offset=GetPropertyOffset(NativeClassPtr,"ArrowMaterial");
			ArrowMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"ArrowMaterialName");
			LightingOnlyBrightness__Offset=GetPropertyOffset(NativeClassPtr,"LightingOnlyBrightness");
			ShaderComplexityColors__Offset=GetPropertyOffset(NativeClassPtr,"ShaderComplexityColors");
			QuadComplexityColors__Offset=GetPropertyOffset(NativeClassPtr,"QuadComplexityColors");
			LightComplexityColors__Offset=GetPropertyOffset(NativeClassPtr,"LightComplexityColors");
			StationaryLightOverlapColors__Offset=GetPropertyOffset(NativeClassPtr,"StationaryLightOverlapColors");
			LODColorationColors__Offset=GetPropertyOffset(NativeClassPtr,"LODColorationColors");
			HLODColorationColors__Offset=GetPropertyOffset(NativeClassPtr,"HLODColorationColors");
			StreamingAccuracyColors__Offset=GetPropertyOffset(NativeClassPtr,"StreamingAccuracyColors");
			MaxPixelShaderAdditiveComplexityCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxPixelShaderAdditiveComplexityCount");
			MaxES2PixelShaderAdditiveComplexityCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxES2PixelShaderAdditiveComplexityCount");
			MinLightMapDensity__Offset=GetPropertyOffset(NativeClassPtr,"MinLightMapDensity");
			IdealLightMapDensity__Offset=GetPropertyOffset(NativeClassPtr,"IdealLightMapDensity");
			MaxLightMapDensity__Offset=GetPropertyOffset(NativeClassPtr,"MaxLightMapDensity");
			bRenderLightMapDensityGrayscale__Offset=GetPropertyOffset(NativeClassPtr,"bRenderLightMapDensityGrayscale");
			RenderLightMapDensityGrayscaleScale__Offset=GetPropertyOffset(NativeClassPtr,"RenderLightMapDensityGrayscaleScale");
			RenderLightMapDensityColorScale__Offset=GetPropertyOffset(NativeClassPtr,"RenderLightMapDensityColorScale");
			LightMapDensityVertexMappedColor__Offset=GetPropertyOffset(NativeClassPtr,"LightMapDensityVertexMappedColor");
			LightMapDensitySelectedColor__Offset=GetPropertyOffset(NativeClassPtr,"LightMapDensitySelectedColor");
			StatColorMappings__Offset=GetPropertyOffset(NativeClassPtr,"StatColorMappings");
			DefaultPhysMaterial__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPhysMaterial");
			DefaultPhysMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPhysMaterialName");
			ActiveGameNameRedirects__Offset=GetPropertyOffset(NativeClassPtr,"ActiveGameNameRedirects");
			ActiveClassRedirects__Offset=GetPropertyOffset(NativeClassPtr,"ActiveClassRedirects");
			ActivePluginRedirects__Offset=GetPropertyOffset(NativeClassPtr,"ActivePluginRedirects");
			ActiveStructRedirects__Offset=GetPropertyOffset(NativeClassPtr,"ActiveStructRedirects");
			PreIntegratedSkinBRDFTexture__Offset=GetPropertyOffset(NativeClassPtr,"PreIntegratedSkinBRDFTexture");
			PreIntegratedSkinBRDFTextureName__Offset=GetPropertyOffset(NativeClassPtr,"PreIntegratedSkinBRDFTextureName");
			MiniFontTexture__Offset=GetPropertyOffset(NativeClassPtr,"MiniFontTexture");
			MiniFontTextureName__Offset=GetPropertyOffset(NativeClassPtr,"MiniFontTextureName");
			WeightMapPlaceholderTexture__Offset=GetPropertyOffset(NativeClassPtr,"WeightMapPlaceholderTexture");
			WeightMapPlaceholderTextureName__Offset=GetPropertyOffset(NativeClassPtr,"WeightMapPlaceholderTextureName");
			LightMapDensityTexture__Offset=GetPropertyOffset(NativeClassPtr,"LightMapDensityTexture");
			LightMapDensityTextureName__Offset=GetPropertyOffset(NativeClassPtr,"LightMapDensityTextureName");
			GameViewport__Offset=GetPropertyOffset(NativeClassPtr,"GameViewport");
			DeferredCommands__Offset=GetPropertyOffset(NativeClassPtr,"DeferredCommands");
			TickCycles__Offset=GetPropertyOffset(NativeClassPtr,"TickCycles");
			GameCycles__Offset=GetPropertyOffset(NativeClassPtr,"GameCycles");
			ClientCycles__Offset=GetPropertyOffset(NativeClassPtr,"ClientCycles");
			NearClipPlane__Offset=GetPropertyOffset(NativeClassPtr,"NearClipPlane");
			bHardwareSurveyEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bHardwareSurveyEnabled");
			bSubtitlesEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bSubtitlesEnabled");
			bSubtitlesForcedOff__Offset=GetPropertyOffset(NativeClassPtr,"bSubtitlesForcedOff");
			MaximumLoopIterationCount__Offset=GetPropertyOffset(NativeClassPtr,"MaximumLoopIterationCount");
			bCanBlueprintsTickByDefault__Offset=GetPropertyOffset(NativeClassPtr,"bCanBlueprintsTickByDefault");
			bOptimizeAnimBlueprintMemberVariableAccess__Offset=GetPropertyOffset(NativeClassPtr,"bOptimizeAnimBlueprintMemberVariableAccess");
			bAllowMultiThreadedAnimationUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bAllowMultiThreadedAnimationUpdate");
			bEnableEditorPSysRealtimeLOD__Offset=GetPropertyOffset(NativeClassPtr,"bEnableEditorPSysRealtimeLOD");
			bSmoothFrameRate__Offset=GetPropertyOffset(NativeClassPtr,"bSmoothFrameRate");
			bUseFixedFrameRate__Offset=GetPropertyOffset(NativeClassPtr,"bUseFixedFrameRate");
			FixedFrameRate__Offset=GetPropertyOffset(NativeClassPtr,"FixedFrameRate");
			SmoothedFrameRateRange__Offset=GetPropertyOffset(NativeClassPtr,"SmoothedFrameRateRange");
			bCheckForMultiplePawnsSpawnedInAFrame__Offset=GetPropertyOffset(NativeClassPtr,"bCheckForMultiplePawnsSpawnedInAFrame");
			NumPawnsAllowedToBeSpawnedInAFrame__Offset=GetPropertyOffset(NativeClassPtr,"NumPawnsAllowedToBeSpawnedInAFrame");
			bShouldGenerateLowQualityLightmaps__Offset=GetPropertyOffset(NativeClassPtr,"bShouldGenerateLowQualityLightmaps");
			C_WorldBox__Offset=GetPropertyOffset(NativeClassPtr,"C_WorldBox");
			C_BrushWire__Offset=GetPropertyOffset(NativeClassPtr,"C_BrushWire");
			C_AddWire__Offset=GetPropertyOffset(NativeClassPtr,"C_AddWire");
			C_SubtractWire__Offset=GetPropertyOffset(NativeClassPtr,"C_SubtractWire");
			C_SemiSolidWire__Offset=GetPropertyOffset(NativeClassPtr,"C_SemiSolidWire");
			C_NonSolidWire__Offset=GetPropertyOffset(NativeClassPtr,"C_NonSolidWire");
			C_WireBackground__Offset=GetPropertyOffset(NativeClassPtr,"C_WireBackground");
			C_ScaleBoxHi__Offset=GetPropertyOffset(NativeClassPtr,"C_ScaleBoxHi");
			C_VolumeCollision__Offset=GetPropertyOffset(NativeClassPtr,"C_VolumeCollision");
			C_BSPCollision__Offset=GetPropertyOffset(NativeClassPtr,"C_BSPCollision");
			C_OrthoBackground__Offset=GetPropertyOffset(NativeClassPtr,"C_OrthoBackground");
			C_Volume__Offset=GetPropertyOffset(NativeClassPtr,"C_Volume");
			C_BrushShape__Offset=GetPropertyOffset(NativeClassPtr,"C_BrushShape");
			StreamingDistanceFactor__Offset=GetPropertyOffset(NativeClassPtr,"StreamingDistanceFactor");
			TransitionType__Offset=GetPropertyOffset(NativeClassPtr,"TransitionType");
			TransitionDescription__Offset=GetPropertyOffset(NativeClassPtr,"TransitionDescription");
			TransitionGameMode__Offset=GetPropertyOffset(NativeClassPtr,"TransitionGameMode");
			MeshLODRange__Offset=GetPropertyOffset(NativeClassPtr,"MeshLODRange");
			bAllowMatureLanguage__Offset=GetPropertyOffset(NativeClassPtr,"bAllowMatureLanguage");
			CameraRotationThreshold__Offset=GetPropertyOffset(NativeClassPtr,"CameraRotationThreshold");
			CameraTranslationThreshold__Offset=GetPropertyOffset(NativeClassPtr,"CameraTranslationThreshold");
			PrimitiveProbablyVisibleTime__Offset=GetPropertyOffset(NativeClassPtr,"PrimitiveProbablyVisibleTime");
			MaxOcclusionPixelsFraction__Offset=GetPropertyOffset(NativeClassPtr,"MaxOcclusionPixelsFraction");
			bPauseOnLossOfFocus__Offset=GetPropertyOffset(NativeClassPtr,"bPauseOnLossOfFocus");
			MaxParticleResize__Offset=GetPropertyOffset(NativeClassPtr,"MaxParticleResize");
			MaxParticleResizeWarn__Offset=GetPropertyOffset(NativeClassPtr,"MaxParticleResizeWarn");
			PendingDroppedNotes__Offset=GetPropertyOffset(NativeClassPtr,"PendingDroppedNotes");
			PhysicErrorCorrection__Offset=GetPropertyOffset(NativeClassPtr,"PhysicErrorCorrection");
			NetClientTicksPerSecond__Offset=GetPropertyOffset(NativeClassPtr,"NetClientTicksPerSecond");
			DisplayGamma__Offset=GetPropertyOffset(NativeClassPtr,"DisplayGamma");
			MinDesiredFrameRate__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredFrameRate");
			DefaultSelectedMaterialColor__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSelectedMaterialColor");
			SelectedMaterialColor__Offset=GetPropertyOffset(NativeClassPtr,"SelectedMaterialColor");
			SelectionOutlineColor__Offset=GetPropertyOffset(NativeClassPtr,"SelectionOutlineColor");
			SubduedSelectionOutlineColor__Offset=GetPropertyOffset(NativeClassPtr,"SubduedSelectionOutlineColor");
			SelectedMaterialColorOverride__Offset=GetPropertyOffset(NativeClassPtr,"SelectedMaterialColorOverride");
			bIsOverridingSelectedColor__Offset=GetPropertyOffset(NativeClassPtr,"bIsOverridingSelectedColor");
			bEnableOnScreenDebugMessages__Offset=GetPropertyOffset(NativeClassPtr,"bEnableOnScreenDebugMessages");
			bEnableOnScreenDebugMessagesDisplay__Offset=GetPropertyOffset(NativeClassPtr,"bEnableOnScreenDebugMessagesDisplay");
			bSuppressMapWarnings__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressMapWarnings");
			bDisableAILogging__Offset=GetPropertyOffset(NativeClassPtr,"bDisableAILogging");
			bEnableVisualLogRecordingOnStart__Offset=GetPropertyOffset(NativeClassPtr,"bEnableVisualLogRecordingOnStart");
			ScreenSaverInhibitorSemaphore__Offset=GetPropertyOffset(NativeClassPtr,"ScreenSaverInhibitorSemaphore");
			bLockReadOnlyLevels__Offset=GetPropertyOffset(NativeClassPtr,"bLockReadOnlyLevels");
			ParticleEventManagerClassPath__Offset=GetPropertyOffset(NativeClassPtr,"ParticleEventManagerClassPath");
			SelectionHighlightIntensity__Offset=GetPropertyOffset(NativeClassPtr,"SelectionHighlightIntensity");
			SelectionMeshSectionHighlightIntensity__Offset=GetPropertyOffset(NativeClassPtr,"SelectionMeshSectionHighlightIntensity");
			BSPSelectionHighlightIntensity__Offset=GetPropertyOffset(NativeClassPtr,"BSPSelectionHighlightIntensity");
			HoverHighlightIntensity__Offset=GetPropertyOffset(NativeClassPtr,"HoverHighlightIntensity");
			SelectionHighlightIntensityBillboards__Offset=GetPropertyOffset(NativeClassPtr,"SelectionHighlightIntensityBillboards");
			NetDriverDefinitions__Offset=GetPropertyOffset(NativeClassPtr,"NetDriverDefinitions");
			ServerActors__Offset=GetPropertyOffset(NativeClassPtr,"ServerActors");
			RuntimeServerActors__Offset=GetPropertyOffset(NativeClassPtr,"RuntimeServerActors");
			bStartedLoadMapMovie__Offset=GetPropertyOffset(NativeClassPtr,"bStartedLoadMapMovie");
			NextWorldContextHandle__Offset=GetPropertyOffset(NativeClassPtr,"NextWorldContextHandle");
			
		}
		
	}
	
}
#endif
#endif
