#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems.
	/// Also defines default classes for certain engine systems.
	/// </summary>
	public partial class UEngine
	{
		static readonly int TinyFont__Offset;
		/// <summary>Fonts.</summary>
		public UFont TinyFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TinyFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TinyFontName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference TinyFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+TinyFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TinyFontName__Offset, false);}
			
		}
		
		static readonly int SmallFont__Offset;
		/// <summary>@todo document</summary>
		public UFont SmallFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SmallFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SmallFontName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference SmallFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+SmallFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmallFontName__Offset, false);}
			
		}
		
		static readonly int MediumFont__Offset;
		/// <summary>@todo document</summary>
		public UFont MediumFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MediumFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MediumFontName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference MediumFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+MediumFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MediumFontName__Offset, false);}
			
		}
		
		static readonly int LargeFont__Offset;
		/// <summary>@todo document</summary>
		public UFont LargeFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LargeFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LargeFontName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference LargeFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+LargeFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LargeFontName__Offset, false);}
			
		}
		
		static readonly int SubtitleFont__Offset;
		/// <summary>@todo document</summary>
		public UFont SubtitleFont
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SubtitleFont__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubtitleFontName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference SubtitleFontName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+SubtitleFontName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubtitleFontName__Offset, false);}
			
		}
		
		static readonly int AdditionalFonts__Offset;
		/// <summary>Any additional fonts that script may use without hard-referencing the font.</summary>
		public TObjectArray<UFont>  AdditionalFonts
		{
					get{ CheckIsValid();return new TObjectArray<UFont>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AdditionalFonts__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AdditionalFonts__Offset, false);}
			
		}
		
		static readonly int AdditionalFontNames__Offset;
		/// <summary>@todo document</summary>
		public TStructArray<FString> AdditionalFontNames
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AdditionalFontNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AdditionalFontNames__Offset, false);}
			
		}
		
		static readonly int ConsoleClass__Offset;
		/// <summary>The class to use for the game console.</summary>
		public TSubclassOf<UConsole>  ConsoleClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ConsoleClass__Offset); return v; }
			
		}
		
		static readonly int ConsoleClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference ConsoleClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+ConsoleClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConsoleClassName__Offset, false);}
			
		}
		
		static readonly int GameViewportClientClass__Offset;
		/// <summary>The class to use for the game viewport client.</summary>
		public TSubclassOf<UGameViewportClient>  GameViewportClientClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameViewportClientClass__Offset); return v; }
			
		}
		
		static readonly int GameViewportClientClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference GameViewportClientClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GameViewportClientClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GameViewportClientClassName__Offset, false);}
			
		}
		
		static readonly int LocalPlayerClass__Offset;
		/// <summary>The class to use for local players.</summary>
		public TSubclassOf<ULocalPlayer>  LocalPlayerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LocalPlayerClass__Offset); return v; }
			
		}
		
		static readonly int LocalPlayerClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference LocalPlayerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+LocalPlayerClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocalPlayerClassName__Offset, false);}
			
		}
		
		static readonly int WorldSettingsClass__Offset;
		/// <summary>The class for WorldSettings *</summary>
		public TSubclassOf<AWorldSettings>  WorldSettingsClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldSettingsClass__Offset); return v; }
			
		}
		
		static readonly int WorldSettingsClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference WorldSettingsClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+WorldSettingsClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldSettingsClassName__Offset, false);}
			
		}
		
		static readonly int NavigationSystemClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference NavigationSystemClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+NavigationSystemClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int NavigationSystemClass__Offset;
		/// <summary>The class for NavigationSystem *</summary>
		public TSubclassOf<UNavigationSystem>  NavigationSystemClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavigationSystemClass__Offset); return v; }
			
		}
		
		static readonly int AvoidanceManagerClassName__Offset;
		/// <summary>Name of behavior tree manager class</summary>
		public FStringClassReference AvoidanceManagerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+AvoidanceManagerClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int AvoidanceManagerClass__Offset;
		/// <summary>The class for behavior tree manager *</summary>
		public TSubclassOf<UAvoidanceManager>  AvoidanceManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AvoidanceManagerClass__Offset); return v; }
			
		}
		
		static readonly int PhysicsCollisionHandlerClass__Offset;
		/// <summary>PhysicsCollisionHandler class we should use by default *</summary>
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset); return v; }
			
		}
		
		static readonly int PhysicsCollisionHandlerClassName__Offset;
		/// <summary>Name of PhysicsCollisionHandler class we should use by default.</summary>
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
		/// <summary>name of Controller class to be used as default AIController class for pawns</summary>
		public FStringClassReference AIControllerClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+AIControllerClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int GameUserSettings__Offset;
		/// <summary>Global instance of the user game settings</summary>
		public UGameUserSettings GameUserSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameUserSettings__Offset); if (v == IntPtr.Zero)return null; UGameUserSettings retValue = new UGameUserSettings(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelScriptActorClass__Offset;
		/// <summary>@todo document</summary>
		public TSubclassOf<ALevelScriptActor>  LevelScriptActorClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelScriptActorClass__Offset); return v; }
			
		}
		
		static readonly int LevelScriptActorClassName__Offset;
		/// <summary>@todo document</summary>
		public FStringClassReference LevelScriptActorClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+LevelScriptActorClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelScriptActorClassName__Offset, false);}
			
		}
		
		static readonly int DefaultBlueprintBaseClassName__Offset;
		/// <summary>Name of the base class to use for new blueprints, configurable on a per-game basis</summary>
		public FStringClassReference DefaultBlueprintBaseClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+DefaultBlueprintBaseClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultBlueprintBaseClassName__Offset, false);}
			
		}
		
		static readonly int GameSingletonClassName__Offset;
		/// <summary>Name of a singleton class to create at startup time, configurable per game</summary>
		public FStringClassReference GameSingletonClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+GameSingletonClassName__Offset, typeof(FStringClassReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GameSingletonClassName__Offset, false);}
			
		}
		
		static readonly int GameSingleton__Offset;
		/// <summary>A UObject spawned at initialization time to handle game-specific data</summary>
		public UObject GameSingleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameSingleton__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayOnConsoleSaveDir__Offset;
		/// <summary>Path that levels for play on console will be saved to (relative to FPaths::GameSavedDir())</summary>
		public FString PlayOnConsoleSaveDir
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PlayOnConsoleSaveDir__Offset, typeof(FString));}
			
		}
		
		static readonly int DefaultTexture__Offset;
		/// <summary>A global default texture.</summary>
		public UTexture2D DefaultTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultDiffuseTexture__Offset;
		/// <summary>A global default diffuse texture.</summary>
		public UTexture DefaultDiffuseTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultDiffuseTexture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultDiffuseTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultDiffuseTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultDiffuseTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultBSPVertexTexture__Offset;
		/// <summary>@todo document</summary>
		public UTexture2D DefaultBSPVertexTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBSPVertexTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultBSPVertexTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultBSPVertexTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBSPVertexTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int HighFrequencyNoiseTexture__Offset;
		/// <summary>Texture used to get random image grain values for post processing</summary>
		public UTexture2D HighFrequencyNoiseTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + HighFrequencyNoiseTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int HighFrequencyNoiseTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference HighFrequencyNoiseTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+HighFrequencyNoiseTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultBokehTexture__Offset;
		/// <summary>Texture used to blur out of focus content, mimics the Bokeh shape of actual cameras</summary>
		public UTexture2D DefaultBokehTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBokehTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultBokehTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultBokehTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultBokehTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int WireframeMaterial__Offset;
		/// <summary>The material used to render wireframe meshes.</summary>
		public UMaterial WireframeMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WireframeMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WireframeMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString WireframeMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+WireframeMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int GeomMaterial__Offset;
		/// <summary>A translucent material used to render things in geometry mode.</summary>
		public UMaterial GeomMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GeomMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GeomMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference GeomMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+GeomMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DebugMeshMaterial__Offset;
		/// <summary>A material used to render debug meshes.</summary>
		public UMaterial DebugMeshMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DebugMeshMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugMeshMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference DebugMeshMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DebugMeshMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LevelColorationLitMaterial__Offset;
		/// <summary>Material used for visualizing level membership in lit view port modes.</summary>
		public UMaterial LevelColorationLitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelColorationLitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelColorationLitMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString LevelColorationLitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LevelColorationLitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int LevelColorationUnlitMaterial__Offset;
		/// <summary>Material used for visualizing level membership in unlit view port modes.</summary>
		public UMaterial LevelColorationUnlitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelColorationUnlitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelColorationUnlitMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString LevelColorationUnlitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LevelColorationUnlitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int LightingTexelDensityMaterial__Offset;
		/// <summary>Material used for visualizing lighting only w/ lightmap texel density.</summary>
		public UMaterial LightingTexelDensityMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightingTexelDensityMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LightingTexelDensityName__Offset;
		/// <summary>@todo document</summary>
		public FString LightingTexelDensityName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+LightingTexelDensityName__Offset, typeof(FString));}
			
		}
		
		static readonly int ShadedLevelColorationLitMaterial__Offset;
		/// <summary>Material used for visualizing level membership in lit view port modes. Uses shading to show axis directions.</summary>
		public UMaterial ShadedLevelColorationLitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadedLevelColorationLitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ShadedLevelColorationLitMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString ShadedLevelColorationLitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ShadedLevelColorationLitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int ShadedLevelColorationUnlitMaterial__Offset;
		/// <summary>Material used for visualizing level membership in unlit view port modes.  Uses shading to show axis directions.</summary>
		public UMaterial ShadedLevelColorationUnlitMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadedLevelColorationUnlitMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ShadedLevelColorationUnlitMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString ShadedLevelColorationUnlitMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ShadedLevelColorationUnlitMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int RemoveSurfaceMaterial__Offset;
		/// <summary>Material used to indicate that the associated BSP surface should be removed.</summary>
		public UMaterial RemoveSurfaceMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RemoveSurfaceMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RemoveSurfaceMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference RemoveSurfaceMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+RemoveSurfaceMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int VertexColorMaterial__Offset;
		/// <summary>Material that renders vertex color as emmissive.</summary>
		public UMaterial VertexColorMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorMaterialName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorMaterialName__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_ColorOnly__Offset;
		/// <summary>Material for visualizing vertex colors on meshes in the scene (color only, no alpha)</summary>
		public UMaterial VertexColorViewModeMaterial_ColorOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_ColorOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_ColorOnly__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_ColorOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_ColorOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_AlphaAsColor__Offset;
		/// <summary>Material for visualizing vertex colors on meshes in the scene (alpha channel as color)</summary>
		public UMaterial VertexColorViewModeMaterial_AlphaAsColor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_AlphaAsColor__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_AlphaAsColor__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_AlphaAsColor
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_AlphaAsColor__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_RedOnly__Offset;
		/// <summary>Material for visualizing vertex colors on meshes in the scene (red only)</summary>
		public UMaterial VertexColorViewModeMaterial_RedOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_RedOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_RedOnly__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_RedOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_RedOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_GreenOnly__Offset;
		/// <summary>Material for visualizing vertex colors on meshes in the scene (green only)</summary>
		public UMaterial VertexColorViewModeMaterial_GreenOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_GreenOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_GreenOnly__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_GreenOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_GreenOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int VertexColorViewModeMaterial_BlueOnly__Offset;
		/// <summary>Material for visualizing vertex colors on meshes in the scene (blue only)</summary>
		public UMaterial VertexColorViewModeMaterial_BlueOnly
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VertexColorViewModeMaterial_BlueOnly__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VertexColorViewModeMaterialName_BlueOnly__Offset;
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_BlueOnly
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+VertexColorViewModeMaterialName_BlueOnly__Offset, typeof(FString));}
			
		}
		
		static readonly int BoneWeightMaterial__Offset;
		/// <summary>Material used to render bone weights on skeletal meshes</summary>
		public UMaterial BoneWeightMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BoneWeightMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BoneWeightMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference BoneWeightMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+BoneWeightMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int ConstraintLimitMaterial__Offset;
		/// <summary>Material used to render constraint limits</summary>
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
		/// <summary>Material that renders a message about lightmap settings being invalid.</summary>
		public UMaterial InvalidLightmapSettingsMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InvalidLightmapSettingsMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InvalidLightmapSettingsMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference InvalidLightmapSettingsMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+InvalidLightmapSettingsMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int PreviewShadowsIndicatorMaterial__Offset;
		/// <summary>Material that renders a message about preview shadows being used.</summary>
		public UMaterial PreviewShadowsIndicatorMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewShadowsIndicatorMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreviewShadowsIndicatorMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference PreviewShadowsIndicatorMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+PreviewShadowsIndicatorMaterialName__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreviewShadowsIndicatorMaterialName__Offset, false);}
			
		}
		
		static readonly int ArrowMaterial__Offset;
		/// <summary>Material that 'fakes' lighting, used for arrows, widgets.</summary>
		public UMaterial ArrowMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ArrowMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference ArrowMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+ArrowMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LightingOnlyBrightness__Offset;
		/// <summary>@todo document</summary>
		public FLinearColor LightingOnlyBrightness
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightingOnlyBrightness__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int ShaderComplexityColors__Offset;
		/// <summary>The colors used to render shader complexity.</summary>
		public TStructArray<FLinearColor> ShaderComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ShaderComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ShaderComplexityColors__Offset, false);}
			
		}
		
		static readonly int QuadComplexityColors__Offset;
		/// <summary>The colors used to render quad complexity.</summary>
		public TStructArray<FLinearColor> QuadComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+QuadComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+QuadComplexityColors__Offset, false);}
			
		}
		
		static readonly int LightComplexityColors__Offset;
		/// <summary>The colors used to render light complexity.</summary>
		public TStructArray<FLinearColor> LightComplexityColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LightComplexityColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LightComplexityColors__Offset, false);}
			
		}
		
		static readonly int StationaryLightOverlapColors__Offset;
		/// <summary>The colors used to render stationary light overlap.</summary>
		public TStructArray<FLinearColor> StationaryLightOverlapColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StationaryLightOverlapColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StationaryLightOverlapColors__Offset, false);}
			
		}
		
		static readonly int LODColorationColors__Offset;
		/// <summary>The colors used to render LOD coloration.</summary>
		public TStructArray<FLinearColor> LODColorationColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODColorationColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODColorationColors__Offset, false);}
			
		}
		
		static readonly int HLODColorationColors__Offset;
		/// <summary>The colors used to render LOD coloration.</summary>
		public TStructArray<FLinearColor> HLODColorationColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HLODColorationColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HLODColorationColors__Offset, false);}
			
		}
		
		static readonly int StreamingAccuracyColors__Offset;
		/// <summary>The colors used for texture streaming accuracy debug view modes.</summary>
		public TStructArray<FLinearColor> StreamingAccuracyColors
		{
			get{ CheckIsValid();return new TStructArray<FLinearColor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingAccuracyColors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingAccuracyColors__Offset, false);}
			
		}
		
		static readonly int MaxPixelShaderAdditiveComplexityCount__Offset;
		/// <summary>
		/// Complexity limits for the various complexity view mode combinations.
		/// These limits are used to map instruction counts to ShaderComplexityColors.
		/// </summary>
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
		/// <summary>Minimum lightmap density value for coloring.</summary>
		public float MinLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int IdealLightMapDensity__Offset;
		/// <summary>Ideal lightmap density value for coloring.</summary>
		public float IdealLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+IdealLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int MaxLightMapDensity__Offset;
		/// <summary>Maximum lightmap density value for coloring.</summary>
		public float MaxLightMapDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxLightMapDensity__Offset, typeof(float));}
			
		}
		
		static readonly int bRenderLightMapDensityGrayscale__Offset;
		/// <summary>If true, then render gray scale density.</summary>
		public bool bRenderLightMapDensityGrayscale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderLightMapDensityGrayscale__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int RenderLightMapDensityGrayscaleScale__Offset;
		/// <summary>The scale factor when rendering gray scale density.</summary>
		public float RenderLightMapDensityGrayscaleScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RenderLightMapDensityGrayscaleScale__Offset, typeof(float));}
			
		}
		
		static readonly int RenderLightMapDensityColorScale__Offset;
		/// <summary>The scale factor when rendering color density.</summary>
		public float RenderLightMapDensityColorScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RenderLightMapDensityColorScale__Offset, typeof(float));}
			
		}
		
		static readonly int LightMapDensityVertexMappedColor__Offset;
		/// <summary>The color to render vertex mapped objects in for LightMap Density view mode.</summary>
		public FLinearColor LightMapDensityVertexMappedColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightMapDensityVertexMappedColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int LightMapDensitySelectedColor__Offset;
		/// <summary>The color to render selected objects in for LightMap Density view mode.</summary>
		public FLinearColor LightMapDensitySelectedColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LightMapDensitySelectedColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int StatColorMappings__Offset;
		/// <summary>@todo document</summary>
		public TStructArray<FStatColorMapping> StatColorMappings
		{
			get{ CheckIsValid();return new TStructArray<FStatColorMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StatColorMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StatColorMappings__Offset, false);}
			
		}
		
		static readonly int EditorBrushMaterial__Offset;
		/// <summary>A material used to render the sides of the builder brush/volumes/etc.</summary>
		public UMaterial EditorBrushMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + EditorBrushMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterial retValue = new UMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int EditorBrushMaterialName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference EditorBrushMaterialName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+EditorBrushMaterialName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int DefaultPhysMaterial__Offset;
		/// <summary>PhysicalMaterial to use if none is defined for a particular object.</summary>
		public UPhysicalMaterial DefaultPhysMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysMaterial__Offset); if (v == IntPtr.Zero)return null; UPhysicalMaterial retValue = new UPhysicalMaterial(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultPhysMaterialName__Offset;
		/// <summary>@todo document</summary>
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
		/// <summary>Texture used for pre-integrated skin shading</summary>
		public UTexture2D PreIntegratedSkinBRDFTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreIntegratedSkinBRDFTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PreIntegratedSkinBRDFTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference PreIntegratedSkinBRDFTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+PreIntegratedSkinBRDFTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int MiniFontTexture__Offset;
		/// <summary>Texture used to do font rendering in shaders</summary>
		public UTexture2D MiniFontTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MiniFontTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MiniFontTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference MiniFontTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+MiniFontTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int WeightMapPlaceholderTexture__Offset;
		/// <summary>Texture used as a placeholder for terrain weight-maps to give the material the correct texture format.</summary>
		public UTexture WeightMapPlaceholderTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WeightMapPlaceholderTexture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WeightMapPlaceholderTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference WeightMapPlaceholderTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+WeightMapPlaceholderTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int LightMapDensityTexture__Offset;
		/// <summary>Texture used to display LightMapDensity</summary>
		public UTexture2D LightMapDensityTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LightMapDensityTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LightMapDensityTextureName__Offset;
		/// <summary>@todo document</summary>
		public FStringAssetReference LightMapDensityTextureName
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+LightMapDensityTextureName__Offset, typeof(FStringAssetReference));}
			
		}
		
		static readonly int GameViewport__Offset;
		/// <summary>The view port representing the current game instance. Can be 0 so don't use without checking.</summary>
		public UGameViewportClient GameViewport
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameViewport__Offset); if (v == IntPtr.Zero)return null; UGameViewportClient retValue = new UGameViewportClient(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DeferredCommands__Offset;
		/// <summary>Array of deferred command strings/ execs that get executed at the end of the frame</summary>
		public TStructArray<FString> DeferredCommands
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DeferredCommands__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DeferredCommands__Offset, false);}
			
		}
		
		static readonly int TickCycles__Offset;
		/// <summary>@todo document</summary>
		public int TickCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TickCycles__Offset, typeof(int));}
			
		}
		
		static readonly int GameCycles__Offset;
		/// <summary>@todo document</summary>
		public int GameCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+GameCycles__Offset, typeof(int));}
			
		}
		
		static readonly int ClientCycles__Offset;
		/// <summary>@todo document</summary>
		public int ClientCycles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ClientCycles__Offset, typeof(int));}
			
		}
		
		static readonly int NearClipPlane__Offset;
		/// <summary>The distance of the camera's near clipping plane.</summary>
		public float NearClipPlane
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NearClipPlane__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NearClipPlane__Offset, false);}
			
		}
		
		static readonly int bHardwareSurveyEnabled__Offset;
		/// <summary>DEPRECATED - Can a runtime game/application report anonymous hardware survey statistics (such as display resolution and GPU model) back to Epic?</summary>
		public bool bHardwareSurveyEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHardwareSurveyEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSubtitlesEnabled__Offset;
		/// <summary>Flag for completely disabling subtitles for localized sounds.</summary>
		public bool bSubtitlesEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubtitlesEnabled__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubtitlesEnabled__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSubtitlesForcedOff__Offset;
		/// <summary>Flag for forcibly disabling subtitles even if you try to turn them back on they will be off</summary>
		public bool bSubtitlesForcedOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSubtitlesForcedOff__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSubtitlesForcedOff__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MaximumLoopIterationCount__Offset;
		/// <summary>Script maximum loop iteration count used as a threshold to warn users about script execution runaway</summary>
		public int MaximumLoopIterationCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaximumLoopIterationCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaximumLoopIterationCount__Offset, false);}
			
		}
		
		static readonly int bCanBlueprintsTickByDefault__Offset;
		/// <summary>
		/// Controls whether Blueprint subclasses of actors or components can tick by default.
		/// Blueprints that derive from native C++ classes that have bCanEverTick=true will always be able to tick
		/// Blueprints that derive from exactly AActor or UActorComponent will always be able to tick
		/// Otherwise, they can tick as long as the parent doesn't have meta=(ChildCannotTick) and either bCanBlueprintsTickByDefault is true or the parent has meta=(ChildCanTick)
		/// </summary>
		public bool bCanBlueprintsTickByDefault
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBlueprintsTickByDefault__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBlueprintsTickByDefault__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOptimizeAnimBlueprintMemberVariableAccess__Offset;
		/// <summary>Controls whether anim blueprint nodes that access member variables of their class directly should use the optimized path that avoids a thunk to the Blueprint VM. This will force all anim blueprints to be recompiled.</summary>
		public bool bOptimizeAnimBlueprintMemberVariableAccess
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOptimizeAnimBlueprintMemberVariableAccess__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOptimizeAnimBlueprintMemberVariableAccess__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bAllowMultiThreadedAnimationUpdate__Offset;
		/// <summary>Controls whether by default we allow anim blueprint graph updates to be performed on non-game threads. This enables some extra checks in the anim blueprint compiler that will warn when unsafe operations are being attempted. This will force all anim blueprints to be recompiled.</summary>
		public bool bAllowMultiThreadedAnimationUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowMultiThreadedAnimationUpdate__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowMultiThreadedAnimationUpdate__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableEditorPSysRealtimeLOD__Offset;
		/// <summary>@todo document</summary>
		public bool bEnableEditorPSysRealtimeLOD
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableEditorPSysRealtimeLOD__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bSmoothFrameRate__Offset;
		/// <summary>Whether to enable framerate smoothing.</summary>
		public bool bSmoothFrameRate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmoothFrameRate__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmoothFrameRate__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseFixedFrameRate__Offset;
		/// <summary>Whether to use a fixed framerate.</summary>
		public bool bUseFixedFrameRate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedFrameRate__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedFrameRate__Offset, 1,0,64,64);}
			
		}
		
		static readonly int FixedFrameRate__Offset;
		/// <summary>The fixed framerate to use.</summary>
		public float FixedFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FixedFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedFrameRate__Offset, false);}
			
		}
		
		static readonly int SmoothedFrameRateRange__Offset;
		/// <summary>Range of framerates in which smoothing will kick in</summary>
		public FFloatRange SmoothedFrameRateRange
		{
			get{ CheckIsValid();return (FFloatRange)Marshal.PtrToStructure(_this.Get()+SmoothedFrameRateRange__Offset, typeof(FFloatRange));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmoothedFrameRateRange__Offset, false);}
			
		}
		
		static readonly int bCheckForMultiplePawnsSpawnedInAFrame__Offset;
		/// <summary>
		/// Whether we should check for more than N pawns spawning in a single frame.
		/// Basically, spawning pawns and all of their attachments can be slow.  And on consoles it
		/// can be really slow.  If this bool is true we will display a
		/// </summary>
		public bool bCheckForMultiplePawnsSpawnedInAFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheckForMultiplePawnsSpawnedInAFrame__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int NumPawnsAllowedToBeSpawnedInAFrame__Offset;
		/// <summary>If bCheckForMultiplePawnsSpawnedInAFrame==true, then we will check to see that no more than this number of pawns are spawned in a frame. *</summary>
		public int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumPawnsAllowedToBeSpawnedInAFrame__Offset, typeof(int));}
			
		}
		
		static readonly int bShouldGenerateLowQualityLightmaps__Offset;
		/// <summary>Whether or not the LQ lightmaps should be generated during lighting rebuilds.  This has been moved to r.SupportLowQualityLightmaps.</summary>
		public bool bShouldGenerateLowQualityLightmaps
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldGenerateLowQualityLightmaps__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int C_WorldBox__Offset;
		/// <summary>Color preferences.</summary>
		public FColor C_WorldBox
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_WorldBox__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BrushWire__Offset;
		/// <summary>@todo document</summary>
		public FColor C_BrushWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BrushWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_AddWire__Offset;
		/// <summary>@todo document</summary>
		public FColor C_AddWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_AddWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_SubtractWire__Offset;
		/// <summary>@todo document</summary>
		public FColor C_SubtractWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_SubtractWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_SemiSolidWire__Offset;
		/// <summary>@todo document</summary>
		public FColor C_SemiSolidWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_SemiSolidWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_NonSolidWire__Offset;
		/// <summary>@todo document</summary>
		public FColor C_NonSolidWire
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_NonSolidWire__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_WireBackground__Offset;
		/// <summary>@todo document</summary>
		public FColor C_WireBackground
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_WireBackground__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_ScaleBoxHi__Offset;
		/// <summary>@todo document</summary>
		public FColor C_ScaleBoxHi
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_ScaleBoxHi__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_VolumeCollision__Offset;
		/// <summary>@todo document</summary>
		public FColor C_VolumeCollision
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_VolumeCollision__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BSPCollision__Offset;
		/// <summary>@todo document</summary>
		public FColor C_BSPCollision
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BSPCollision__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_OrthoBackground__Offset;
		/// <summary>@todo document</summary>
		public FColor C_OrthoBackground
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_OrthoBackground__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_Volume__Offset;
		/// <summary>@todo document</summary>
		public FColor C_Volume
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_Volume__Offset, typeof(FColor));}
			
		}
		
		static readonly int C_BrushShape__Offset;
		/// <summary>@todo document</summary>
		public FColor C_BrushShape
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+C_BrushShape__Offset, typeof(FColor));}
			
		}
		
		static readonly int StreamingDistanceFactor__Offset;
		/// <summary>Fudge factor for tweaking the distance based miplevel determination</summary>
		public float StreamingDistanceFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceFactor__Offset, false);}
			
		}
		
		static readonly int TransitionType__Offset;
		/// <summary>The current transition type.</summary>
		public ETransitionType TransitionType
		{
			get{ CheckIsValid();return (ETransitionType)Marshal.PtrToStructure(_this.Get()+TransitionType__Offset, typeof(ETransitionType));}
			
		}
		
		static readonly int TransitionDescription__Offset;
		/// <summary>The current transition description text.</summary>
		public FString TransitionDescription
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TransitionDescription__Offset, typeof(FString));}
			
		}
		
		static readonly int TransitionGameMode__Offset;
		/// <summary>The gamemode for the destination map</summary>
		public FString TransitionGameMode
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+TransitionGameMode__Offset, typeof(FString));}
			
		}
		
		static readonly int MeshLODRange__Offset;
		/// <summary>Level of detail range control for meshes</summary>
		public float MeshLODRange
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MeshLODRange__Offset, typeof(float));}
			
		}
		
		static readonly int bAllowMatureLanguage__Offset;
		/// <summary>whether mature language is allowed *</summary>
		public bool bAllowMatureLanguage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowMatureLanguage__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CameraRotationThreshold__Offset;
		/// <summary>camera rotation (deg) beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
		public float CameraRotationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraRotationThreshold__Offset, typeof(float));}
			
		}
		
		static readonly int CameraTranslationThreshold__Offset;
		/// <summary>camera movement beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
		public float CameraTranslationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraTranslationThreshold__Offset, typeof(float));}
			
		}
		
		static readonly int PrimitiveProbablyVisibleTime__Offset;
		/// <summary>The amount of time a primitive is considered to be probably visible after it was last actually visible.</summary>
		public float PrimitiveProbablyVisibleTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PrimitiveProbablyVisibleTime__Offset, typeof(float));}
			
		}
		
		static readonly int MaxOcclusionPixelsFraction__Offset;
		/// <summary>Max screen pixel fraction where retesting when unoccluded is worth the GPU time.</summary>
		public float MaxOcclusionPixelsFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxOcclusionPixelsFraction__Offset, typeof(float));}
			
		}
		
		static readonly int bPauseOnLossOfFocus__Offset;
		/// <summary>Whether to pause the game if focus is lost.</summary>
		public bool bPauseOnLossOfFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseOnLossOfFocus__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int MaxParticleResize__Offset;
		/// <summary>
		/// The maximum allowed size to a ParticleEmitterInstance::Resize call.
		/// If larger, the function will return without resizing.
		/// </summary>
		public int MaxParticleResize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleResize__Offset, typeof(int));}
			
		}
		
		static readonly int MaxParticleResizeWarn__Offset;
		/// <summary>If the resize request is larger than this, spew out a warning to the log</summary>
		public int MaxParticleResizeWarn
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleResizeWarn__Offset, typeof(int));}
			
		}
		
		static readonly int PendingDroppedNotes__Offset;
		/// <summary>@todo document</summary>
		public TStructArray<FDropNoteInfo> PendingDroppedNotes
		{
			get{ CheckIsValid();return new TStructArray<FDropNoteInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PendingDroppedNotes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PendingDroppedNotes__Offset, false);}
			
		}
		
		static readonly int PhysicErrorCorrection__Offset;
		/// <summary>Error correction data for replicating simulated physics (rigid bodies)</summary>
		public FRigidBodyErrorCorrection PhysicErrorCorrection
		{
			get{ CheckIsValid();return (FRigidBodyErrorCorrection)Marshal.PtrToStructure(_this.Get()+PhysicErrorCorrection__Offset, typeof(FRigidBodyErrorCorrection));}
			
		}
		
		static readonly int NetClientTicksPerSecond__Offset;
		/// <summary>Number of times to tick each client per second</summary>
		public float NetClientTicksPerSecond
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetClientTicksPerSecond__Offset, typeof(float));}
			
		}
		
		static readonly int DisplayGamma__Offset;
		/// <summary>Current display gamma setting</summary>
		public float DisplayGamma
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DisplayGamma__Offset, typeof(float));}
			
		}
		
		static readonly int MinDesiredFrameRate__Offset;
		/// <summary>Minimum desired framerate setting</summary>
		public float MinDesiredFrameRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredFrameRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredFrameRate__Offset, false);}
			
		}
		
		static readonly int DefaultSelectedMaterialColor__Offset;
		/// <summary>Default color of selected objects in the level viewport (additive)</summary>
		public FLinearColor DefaultSelectedMaterialColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+DefaultSelectedMaterialColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectedMaterialColor__Offset;
		/// <summary>Color of selected objects in the level viewport (additive)</summary>
		public FLinearColor SelectedMaterialColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectedMaterialColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectionOutlineColor__Offset;
		/// <summary>Color of the selection outline color.  Generally the same as selected material color unless the selection material color is being overridden</summary>
		public FLinearColor SelectionOutlineColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectionOutlineColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SubduedSelectionOutlineColor__Offset;
		/// <summary>Subdued version of the selection outline color. Used for indicating sub-selection of components vs actors</summary>
		public FLinearColor SubduedSelectionOutlineColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SubduedSelectionOutlineColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int SelectedMaterialColorOverride__Offset;
		/// <summary>An override to use in some cases instead of the selected material color</summary>
		public FLinearColor SelectedMaterialColorOverride
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SelectedMaterialColorOverride__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int bIsOverridingSelectedColor__Offset;
		/// <summary>Whether or not selection color is being overridden</summary>
		public bool bIsOverridingSelectedColor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsOverridingSelectedColor__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableOnScreenDebugMessages__Offset;
		/// <summary>If true, then disable OnScreenDebug messages. Can be toggled in real-time.</summary>
		public bool bEnableOnScreenDebugMessages
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableOnScreenDebugMessages__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bEnableOnScreenDebugMessagesDisplay__Offset;
		/// <summary>If true, then disable the display of OnScreenDebug messages (used when running)</summary>
		public bool bEnableOnScreenDebugMessagesDisplay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableOnScreenDebugMessagesDisplay__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bSuppressMapWarnings__Offset;
		/// <summary>If true, then skip drawing map warnings on screen even in non (UE_BUILD_SHIPPING || UE_BUILD_TEST) builds</summary>
		public bool bSuppressMapWarnings
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressMapWarnings__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDisableAILogging__Offset;
		/// <summary>determines whether AI logging should be processed or not</summary>
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
		/// <summary>Semaphore to control screen saver inhibitor thread access.</summary>
		public int ScreenSaverInhibitorSemaphore
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ScreenSaverInhibitorSemaphore__Offset, typeof(int));}
			
		}
		
		static readonly int bLockReadOnlyLevels__Offset;
		/// <summary>true if the the user cannot modify levels that are read only.</summary>
		public bool bLockReadOnlyLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockReadOnlyLevels__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ParticleEventManagerClassPath__Offset;
		/// <summary>Particle event manager *</summary>
		public FString ParticleEventManagerClassPath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ParticleEventManagerClassPath__Offset, typeof(FString));}
			
		}
		
		static readonly int SelectionHighlightIntensity__Offset;
		/// <summary>Used to alter the intensity level of the selection highlight on selected objects</summary>
		public float SelectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int SelectionMeshSectionHighlightIntensity__Offset;
		/// <summary>Used to alter the intensity level of the selection highlight on selected mesh sections in mesh editors</summary>
		public float SelectionMeshSectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionMeshSectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int BSPSelectionHighlightIntensity__Offset;
		/// <summary>Used to alter the intensity level of the selection highlight on selected BSP surfaces</summary>
		public float BSPSelectionHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BSPSelectionHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int HoverHighlightIntensity__Offset;
		/// <summary>Used to alter the intensity level of the selection highlight on hovered objects</summary>
		public float HoverHighlightIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HoverHighlightIntensity__Offset, typeof(float));}
			
		}
		
		static readonly int SelectionHighlightIntensityBillboards__Offset;
		/// <summary>Used to alter the intensity level of the selection highlight on selected billboard objects</summary>
		public float SelectionHighlightIntensityBillboards
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SelectionHighlightIntensityBillboards__Offset, typeof(float));}
			
		}
		
		static readonly int NetDriverDefinitions__Offset;
		/// <summary>A list of named UNetDriver definitions</summary>
		public TStructArray<FNetDriverDefinition> NetDriverDefinitions
		{
			get{ CheckIsValid();return new TStructArray<FNetDriverDefinition>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NetDriverDefinitions__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NetDriverDefinitions__Offset, false);}
			
		}
		
		static readonly int ServerActors__Offset;
		/// <summary>A configurable list of actors that are automatically spawned upon server startup (just prior to InitGame)</summary>
		public TStructArray<FString> ServerActors
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ServerActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ServerActors__Offset, false);}
			
		}
		
		static readonly int RuntimeServerActors__Offset;
		/// <summary>Runtime-modified list of server actors, allowing plugins to use serveractors, without permanently adding them to config files</summary>
		public TStructArray<FString> RuntimeServerActors
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RuntimeServerActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RuntimeServerActors__Offset, false);}
			
		}
		
		static readonly int bStartedLoadMapMovie__Offset;
		/// <summary>true if the loading movie was started during LoadMap().</summary>
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
			GeomMaterial__Offset=GetPropertyOffset(NativeClassPtr,"GeomMaterial");
			GeomMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"GeomMaterialName");
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
			BoneWeightMaterial__Offset=GetPropertyOffset(NativeClassPtr,"BoneWeightMaterial");
			BoneWeightMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"BoneWeightMaterialName");
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
			EditorBrushMaterial__Offset=GetPropertyOffset(NativeClassPtr,"EditorBrushMaterial");
			EditorBrushMaterialName__Offset=GetPropertyOffset(NativeClassPtr,"EditorBrushMaterialName");
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
