using System;
namespace UnrealEngine
{
	public partial class UKismetRenderingLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Must be paired with a BeginDrawCanvasToRenderTarget to complete rendering to a render target.</summary>
		public extern static void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context);
		/// <summary>
		/// Returns a Canvas object that can be used to draw to the specified render target.
		/// Canvas has functions like DrawMaterial with size parameters that can be used to draw to a specific area of a render target.
		/// Be sure to call EndDrawCanvasToRenderTarget to complete the rendering!
		/// </summary>
		public extern static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,out UCanvas Canvas,out FVector2D Size,out FDrawToRenderTargetContext Context);
		/// <summary>Exports a Texture2D as a HDR image onto the disk.</summary>
		public extern static void ExportTexture2D(UObject WorldContextObject,UTexture2D Texture,FString FilePath,FString FileName);
		/// <summary>Exports a render target as a HDR image onto the disk.</summary>
		public extern static void ExportRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FString FilePath,FString FileName);
		/// <summary>
		/// Renders a quad with the material applied to the specified render target.
		/// This sets the render target even if it is already set, which is an expensive operation.
		/// Use BeginDrawCanvasToRenderTarget / EndDrawCanvasToRenderTarget instead if rendering multiple primitives to the same render target.
		/// </summary>
		public extern static void DrawMaterialToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UMaterialInterface Material);
		/// <summary>Creates a new render target and initializes it to the specified dimensions</summary>
		public extern static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject,int Width=256,int Height=256);
		/// <summary>Clears the specified render target with the given ClearColor.</summary>
		public extern static void ClearRenderTarget2D(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FLinearColor ClearColor=default(FLinearColor));
		
	}
	
}
