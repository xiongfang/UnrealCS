using System;
namespace UnrealEngine
{
	public partial class UEngine:UObject
	{
		/// <summary>Fonts.</summary>
		public UFont TinyFont;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference TinyFontName;
		
		/// <summary>@todo document</summary>
		public UFont SmallFont;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference SmallFontName;
		
		/// <summary>@todo document</summary>
		public UFont MediumFont;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference MediumFontName;
		
		/// <summary>@todo document</summary>
		public UFont LargeFont;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference LargeFontName;
		
		/// <summary>@todo document</summary>
		public UFont SubtitleFont;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference SubtitleFontName;
		
		/// <summary>The class to use for the game console.</summary>
		public TSubclassOf<UConsole>  ConsoleClass;
		
		/// <summary>@todo document</summary>
		public FStringClassReference ConsoleClassName;
		
		/// <summary>The class to use for the game viewport client.</summary>
		public TSubclassOf<UGameViewportClient>  GameViewportClientClass;
		
		/// <summary>@todo document</summary>
		public FStringClassReference GameViewportClientClassName;
		
		/// <summary>The class to use for local players.</summary>
		public TSubclassOf<ULocalPlayer>  LocalPlayerClass;
		
		/// <summary>@todo document</summary>
		public FStringClassReference LocalPlayerClassName;
		
		/// <summary>The class for WorldSettings *</summary>
		public TSubclassOf<AWorldSettings>  WorldSettingsClass;
		
		/// <summary>@todo document</summary>
		public FStringClassReference WorldSettingsClassName;
		
		/// <summary>@todo document</summary>
		public FStringClassReference NavigationSystemClassName;
		
		/// <summary>The class for NavigationSystem *</summary>
		public TSubclassOf<UNavigationSystem>  NavigationSystemClass;
		
		/// <summary>Name of behavior tree manager class</summary>
		public FStringClassReference AvoidanceManagerClassName;
		
		/// <summary>The class for behavior tree manager *</summary>
		public TSubclassOf<UAvoidanceManager>  AvoidanceManagerClass;
		
		/// <summary>PhysicsCollisionHandler class we should use by default *</summary>
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass;
		
		/// <summary>Name of PhysicsCollisionHandler class we should use by default.</summary>
		public FStringClassReference PhysicsCollisionHandlerClassName;
		
		public FStringClassReference GameUserSettingsClassName;
		
		public TSubclassOf<UGameUserSettings>  GameUserSettingsClass;
		
		/// <summary>name of Controller class to be used as default AIController class for pawns</summary>
		public FStringClassReference AIControllerClassName;
		
		/// <summary>Global instance of the user game settings</summary>
		public UGameUserSettings GameUserSettings;
		
		/// <summary>@todo document</summary>
		public TSubclassOf<ALevelScriptActor>  LevelScriptActorClass;
		
		/// <summary>@todo document</summary>
		public FStringClassReference LevelScriptActorClassName;
		
		/// <summary>Name of the base class to use for new blueprints, configurable on a per-game basis</summary>
		public FStringClassReference DefaultBlueprintBaseClassName;
		
		/// <summary>Name of a singleton class to create at startup time, configurable per game</summary>
		public FStringClassReference GameSingletonClassName;
		
		/// <summary>A UObject spawned at initialization time to handle game-specific data</summary>
		public UObject GameSingleton;
		
		/// <summary>Path that levels for play on console will be saved to (relative to FPaths::GameSavedDir())</summary>
		public FString PlayOnConsoleSaveDir;
		
		/// <summary>A global default texture.</summary>
		public UTexture2D DefaultTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultTextureName;
		
		/// <summary>A global default diffuse texture.</summary>
		public UTexture DefaultDiffuseTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultDiffuseTextureName;
		
		/// <summary>@todo document</summary>
		public UTexture2D DefaultBSPVertexTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultBSPVertexTextureName;
		
		/// <summary>Texture used to get random image grain values for post processing</summary>
		public UTexture2D HighFrequencyNoiseTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference HighFrequencyNoiseTextureName;
		
		/// <summary>Texture used to blur out of focus content, mimics the Bokeh shape of actual cameras</summary>
		public UTexture2D DefaultBokehTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultBokehTextureName;
		
		/// <summary>The material used to render wireframe meshes.</summary>
		public UMaterial WireframeMaterial;
		
		/// <summary>@todo document</summary>
		public FString WireframeMaterialName;
		
		/// <summary>A translucent material used to render things in geometry mode.</summary>
		public UMaterial GeomMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference GeomMaterialName;
		
		/// <summary>A material used to render debug meshes.</summary>
		public UMaterial DebugMeshMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DebugMeshMaterialName;
		
		/// <summary>Material used for visualizing level membership in lit view port modes.</summary>
		public UMaterial LevelColorationLitMaterial;
		
		/// <summary>@todo document</summary>
		public FString LevelColorationLitMaterialName;
		
		/// <summary>Material used for visualizing level membership in unlit view port modes.</summary>
		public UMaterial LevelColorationUnlitMaterial;
		
		/// <summary>@todo document</summary>
		public FString LevelColorationUnlitMaterialName;
		
		/// <summary>Material used for visualizing lighting only w/ lightmap texel density.</summary>
		public UMaterial LightingTexelDensityMaterial;
		
		/// <summary>@todo document</summary>
		public FString LightingTexelDensityName;
		
		/// <summary>Material used for visualizing level membership in lit view port modes. Uses shading to show axis directions.</summary>
		public UMaterial ShadedLevelColorationLitMaterial;
		
		/// <summary>@todo document</summary>
		public FString ShadedLevelColorationLitMaterialName;
		
		/// <summary>Material used for visualizing level membership in unlit view port modes.  Uses shading to show axis directions.</summary>
		public UMaterial ShadedLevelColorationUnlitMaterial;
		
		/// <summary>@todo document</summary>
		public FString ShadedLevelColorationUnlitMaterialName;
		
		/// <summary>Material used to indicate that the associated BSP surface should be removed.</summary>
		public UMaterial RemoveSurfaceMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference RemoveSurfaceMaterialName;
		
		/// <summary>Material that renders vertex color as emmissive.</summary>
		public UMaterial VertexColorMaterial;
		
		/// <summary>@todo document</summary>
		public FString VertexColorMaterialName;
		
		/// <summary>Material for visualizing vertex colors on meshes in the scene (color only, no alpha)</summary>
		public UMaterial VertexColorViewModeMaterial_ColorOnly;
		
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_ColorOnly;
		
		/// <summary>Material for visualizing vertex colors on meshes in the scene (alpha channel as color)</summary>
		public UMaterial VertexColorViewModeMaterial_AlphaAsColor;
		
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_AlphaAsColor;
		
		/// <summary>Material for visualizing vertex colors on meshes in the scene (red only)</summary>
		public UMaterial VertexColorViewModeMaterial_RedOnly;
		
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_RedOnly;
		
		/// <summary>Material for visualizing vertex colors on meshes in the scene (green only)</summary>
		public UMaterial VertexColorViewModeMaterial_GreenOnly;
		
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_GreenOnly;
		
		/// <summary>Material for visualizing vertex colors on meshes in the scene (blue only)</summary>
		public UMaterial VertexColorViewModeMaterial_BlueOnly;
		
		/// <summary>@todo document</summary>
		public FString VertexColorViewModeMaterialName_BlueOnly;
		
		/// <summary>Material used to render bone weights on skeletal meshes</summary>
		public UMaterial BoneWeightMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference BoneWeightMaterialName;
		
		/// <summary>Material used to render constraint limits</summary>
		public UMaterial ConstraintLimitMaterial;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialX;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialXAxis;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialY;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialYAxis;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialZ;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialZAxis;
		
		public UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic;
		
		/// <summary>Material that renders a message about lightmap settings being invalid.</summary>
		public UMaterial InvalidLightmapSettingsMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference InvalidLightmapSettingsMaterialName;
		
		/// <summary>Material that renders a message about preview shadows being used.</summary>
		public UMaterial PreviewShadowsIndicatorMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference PreviewShadowsIndicatorMaterialName;
		
		/// <summary>Material that 'fakes' lighting, used for arrows, widgets.</summary>
		public UMaterial ArrowMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference ArrowMaterialName;
		
		/// <summary>@todo document</summary>
		public FLinearColor LightingOnlyBrightness;
		
		/// <summary>
		/// Complexity limits for the various complexity view mode combinations.
		/// These limits are used to map instruction counts to ShaderComplexityColors.
		/// </summary>
		public float MaxPixelShaderAdditiveComplexityCount;
		
		public float MaxES2PixelShaderAdditiveComplexityCount;
		
		/// <summary>Minimum lightmap density value for coloring.</summary>
		public float MinLightMapDensity;
		
		/// <summary>Ideal lightmap density value for coloring.</summary>
		public float IdealLightMapDensity;
		
		/// <summary>Maximum lightmap density value for coloring.</summary>
		public float MaxLightMapDensity;
		
		/// <summary>If true, then render gray scale density.</summary>
		public bool bRenderLightMapDensityGrayscale;
		
		/// <summary>The scale factor when rendering gray scale density.</summary>
		public float RenderLightMapDensityGrayscaleScale;
		
		/// <summary>The scale factor when rendering color density.</summary>
		public float RenderLightMapDensityColorScale;
		
		/// <summary>The color to render vertex mapped objects in for LightMap Density view mode.</summary>
		public FLinearColor LightMapDensityVertexMappedColor;
		
		/// <summary>The color to render selected objects in for LightMap Density view mode.</summary>
		public FLinearColor LightMapDensitySelectedColor;
		
		/// <summary>A material used to render the sides of the builder brush/volumes/etc.</summary>
		public UMaterial EditorBrushMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference EditorBrushMaterialName;
		
		/// <summary>PhysicalMaterial to use if none is defined for a particular object.</summary>
		public UPhysicalMaterial DefaultPhysMaterial;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference DefaultPhysMaterialName;
		
		/// <summary>Texture used for pre-integrated skin shading</summary>
		public UTexture2D PreIntegratedSkinBRDFTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference PreIntegratedSkinBRDFTextureName;
		
		/// <summary>Texture used to do font rendering in shaders</summary>
		public UTexture2D MiniFontTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference MiniFontTextureName;
		
		/// <summary>Texture used as a placeholder for terrain weight-maps to give the material the correct texture format.</summary>
		public UTexture WeightMapPlaceholderTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference WeightMapPlaceholderTextureName;
		
		/// <summary>Texture used to display LightMapDensity</summary>
		public UTexture2D LightMapDensityTexture;
		
		/// <summary>@todo document</summary>
		public FStringAssetReference LightMapDensityTextureName;
		
		/// <summary>The view port representing the current game instance. Can be 0 so don't use without checking.</summary>
		public UGameViewportClient GameViewport;
		
		/// <summary>@todo document</summary>
		public int TickCycles;
		
		/// <summary>@todo document</summary>
		public int GameCycles;
		
		/// <summary>@todo document</summary>
		public int ClientCycles;
		
		/// <summary>The distance of the camera's near clipping plane.</summary>
		public float NearClipPlane;
		
		/// <summary>DEPRECATED - Can a runtime game/application report anonymous hardware survey statistics (such as display resolution and GPU model) back to Epic?</summary>
		public bool bHardwareSurveyEnabled;
		
		/// <summary>Flag for completely disabling subtitles for localized sounds.</summary>
		public bool bSubtitlesEnabled;
		
		/// <summary>Flag for forcibly disabling subtitles even if you try to turn them back on they will be off</summary>
		public bool bSubtitlesForcedOff;
		
		/// <summary>Script maximum loop iteration count used as a threshold to warn users about script execution runaway</summary>
		public int MaximumLoopIterationCount;
		
		/// <summary>
		/// Controls whether Blueprint subclasses of actors or components can tick by default.
		/// Blueprints that derive from native C++ classes that have bCanEverTick=true will always be able to tick
		/// Blueprints that derive from exactly AActor or UActorComponent will always be able to tick
		/// Otherwise, they can tick as long as the parent doesn't have meta=(ChildCannotTick) and either bCanBlueprintsTickByDefault is true or the parent has meta=(ChildCanTick)
		/// </summary>
		public bool bCanBlueprintsTickByDefault;
		
		/// <summary>Controls whether anim blueprint nodes that access member variables of their class directly should use the optimized path that avoids a thunk to the Blueprint VM. This will force all anim blueprints to be recompiled.</summary>
		public bool bOptimizeAnimBlueprintMemberVariableAccess;
		
		/// <summary>Controls whether by default we allow anim blueprint graph updates to be performed on non-game threads. This enables some extra checks in the anim blueprint compiler that will warn when unsafe operations are being attempted. This will force all anim blueprints to be recompiled.</summary>
		public bool bAllowMultiThreadedAnimationUpdate;
		
		/// <summary>@todo document</summary>
		public bool bEnableEditorPSysRealtimeLOD;
		
		/// <summary>Whether to enable framerate smoothing.</summary>
		public bool bSmoothFrameRate;
		
		/// <summary>Whether to use a fixed framerate.</summary>
		public bool bUseFixedFrameRate;
		
		/// <summary>The fixed framerate to use.</summary>
		public float FixedFrameRate;
		
		/// <summary>Range of framerates in which smoothing will kick in</summary>
		public FFloatRange SmoothedFrameRateRange;
		
		/// <summary>
		/// Whether we should check for more than N pawns spawning in a single frame.
		/// Basically, spawning pawns and all of their attachments can be slow.  And on consoles it
		/// can be really slow.  If this bool is true we will display a
		/// </summary>
		public bool bCheckForMultiplePawnsSpawnedInAFrame;
		
		/// <summary>If bCheckForMultiplePawnsSpawnedInAFrame==true, then we will check to see that no more than this number of pawns are spawned in a frame. *</summary>
		public int NumPawnsAllowedToBeSpawnedInAFrame;
		
		/// <summary>Whether or not the LQ lightmaps should be generated during lighting rebuilds.  This has been moved to r.SupportLowQualityLightmaps.</summary>
		public bool bShouldGenerateLowQualityLightmaps;
		
		/// <summary>Color preferences.</summary>
		public FColor C_WorldBox;
		
		/// <summary>@todo document</summary>
		public FColor C_BrushWire;
		
		/// <summary>@todo document</summary>
		public FColor C_AddWire;
		
		/// <summary>@todo document</summary>
		public FColor C_SubtractWire;
		
		/// <summary>@todo document</summary>
		public FColor C_SemiSolidWire;
		
		/// <summary>@todo document</summary>
		public FColor C_NonSolidWire;
		
		/// <summary>@todo document</summary>
		public FColor C_WireBackground;
		
		/// <summary>@todo document</summary>
		public FColor C_ScaleBoxHi;
		
		/// <summary>@todo document</summary>
		public FColor C_VolumeCollision;
		
		/// <summary>@todo document</summary>
		public FColor C_BSPCollision;
		
		/// <summary>@todo document</summary>
		public FColor C_OrthoBackground;
		
		/// <summary>@todo document</summary>
		public FColor C_Volume;
		
		/// <summary>@todo document</summary>
		public FColor C_BrushShape;
		
		/// <summary>Fudge factor for tweaking the distance based miplevel determination</summary>
		public float StreamingDistanceFactor;
		
		/// <summary>The current transition type.</summary>
		public ETransitionType TransitionType;
		
		/// <summary>The current transition description text.</summary>
		public FString TransitionDescription;
		
		/// <summary>The gamemode for the destination map</summary>
		public FString TransitionGameMode;
		
		/// <summary>Level of detail range control for meshes</summary>
		public float MeshLODRange;
		
		/// <summary>whether mature language is allowed *</summary>
		public bool bAllowMatureLanguage;
		
		/// <summary>camera rotation (deg) beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
		public float CameraRotationThreshold;
		
		/// <summary>camera movement beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
		public float CameraTranslationThreshold;
		
		/// <summary>The amount of time a primitive is considered to be probably visible after it was last actually visible.</summary>
		public float PrimitiveProbablyVisibleTime;
		
		/// <summary>Max screen pixel fraction where retesting when unoccluded is worth the GPU time.</summary>
		public float MaxOcclusionPixelsFraction;
		
		/// <summary>Whether to pause the game if focus is lost.</summary>
		public bool bPauseOnLossOfFocus;
		
		/// <summary>
		/// The maximum allowed size to a ParticleEmitterInstance::Resize call.
		/// If larger, the function will return without resizing.
		/// </summary>
		public int MaxParticleResize;
		
		/// <summary>If the resize request is larger than this, spew out a warning to the log</summary>
		public int MaxParticleResizeWarn;
		
		/// <summary>Error correction data for replicating simulated physics (rigid bodies)</summary>
		public FRigidBodyErrorCorrection PhysicErrorCorrection;
		
		/// <summary>Number of times to tick each client per second</summary>
		public float NetClientTicksPerSecond;
		
		/// <summary>Current display gamma setting</summary>
		public float DisplayGamma;
		
		/// <summary>Minimum desired framerate setting</summary>
		public float MinDesiredFrameRate;
		
		/// <summary>Default color of selected objects in the level viewport (additive)</summary>
		public FLinearColor DefaultSelectedMaterialColor;
		
		/// <summary>Color of selected objects in the level viewport (additive)</summary>
		public FLinearColor SelectedMaterialColor;
		
		/// <summary>Color of the selection outline color.  Generally the same as selected material color unless the selection material color is being overridden</summary>
		public FLinearColor SelectionOutlineColor;
		
		/// <summary>Subdued version of the selection outline color. Used for indicating sub-selection of components vs actors</summary>
		public FLinearColor SubduedSelectionOutlineColor;
		
		/// <summary>An override to use in some cases instead of the selected material color</summary>
		public FLinearColor SelectedMaterialColorOverride;
		
		/// <summary>Whether or not selection color is being overridden</summary>
		public bool bIsOverridingSelectedColor;
		
		/// <summary>If true, then disable OnScreenDebug messages. Can be toggled in real-time.</summary>
		public bool bEnableOnScreenDebugMessages;
		
		/// <summary>If true, then disable the display of OnScreenDebug messages (used when running)</summary>
		public bool bEnableOnScreenDebugMessagesDisplay;
		
		/// <summary>If true, then skip drawing map warnings on screen even in non (UE_BUILD_SHIPPING || UE_BUILD_TEST) builds</summary>
		public bool bSuppressMapWarnings;
		
		/// <summary>determines whether AI logging should be processed or not</summary>
		public bool bDisableAILogging;
		
		public uint bEnableVisualLogRecordingOnStart;
		
		/// <summary>Semaphore to control screen saver inhibitor thread access.</summary>
		public int ScreenSaverInhibitorSemaphore;
		
		/// <summary>true if the the user cannot modify levels that are read only.</summary>
		public bool bLockReadOnlyLevels;
		
		/// <summary>Particle event manager *</summary>
		public FString ParticleEventManagerClassPath;
		
		/// <summary>Used to alter the intensity level of the selection highlight on selected objects</summary>
		public float SelectionHighlightIntensity;
		
		/// <summary>Used to alter the intensity level of the selection highlight on selected mesh sections in mesh editors</summary>
		public float SelectionMeshSectionHighlightIntensity;
		
		/// <summary>Used to alter the intensity level of the selection highlight on selected BSP surfaces</summary>
		public float BSPSelectionHighlightIntensity;
		
		/// <summary>Used to alter the intensity level of the selection highlight on hovered objects</summary>
		public float HoverHighlightIntensity;
		
		/// <summary>Used to alter the intensity level of the selection highlight on selected billboard objects</summary>
		public float SelectionHighlightIntensityBillboards;
		
		/// <summary>true if the loading movie was started during LoadMap().</summary>
		public bool bStartedLoadMapMovie;
		
		public int NextWorldContextHandle;
		
		
	}
	
}
