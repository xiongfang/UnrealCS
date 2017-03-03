#pragma once

namespace UnrealEngine
{
	class _UCanvas
	{
		static FVector2D K2_TextSize(UCanvas* _this,UFont* RenderFont,MonoString* RenderText,FVector2D* Scale)
		{
			FString RenderText_temp=MonoStringToFString(RenderText);
			FVector2D ___ret = _this->K2_TextSize(RenderFont,RenderText_temp,*Scale);
			return ___ret;
			
		}
		static FVector2D K2_StrLen(UCanvas* _this,UFont* RenderFont,MonoString* RenderText)
		{
			FString RenderText_temp=MonoStringToFString(RenderText);
			FVector2D ___ret = _this->K2_StrLen(RenderFont,RenderText_temp);
			return ___ret;
			
		}
		static void K2_Deproject(UCanvas* _this,FVector2D* ScreenPosition,FVector* WorldOrigin,FVector* WorldDirection)
		{
			_this->K2_Deproject(*ScreenPosition,*WorldOrigin,*WorldDirection);
			
		}
		static FVector K2_Project(UCanvas* _this,FVector* WorldLocation)
		{
			FVector ___ret = _this->K2_Project(*WorldLocation);
			return ___ret;
			
		}
		static void K2_DrawPolygon(UCanvas* _this,UTexture* RenderTexture,FVector2D* ScreenPosition,FVector2D* Radius,int32 NumberOfSides,FLinearColor* RenderColor)
		{
			_this->K2_DrawPolygon(RenderTexture,*ScreenPosition,*Radius,NumberOfSides,*RenderColor);
			
		}
		static void K2_DrawMaterialTriangle(UCanvas* _this,UMaterialInterface* RenderMaterial,MonoArray* Triangles)
		{
			_this->K2_DrawMaterialTriangle(RenderMaterial,MonoArrayToTArray<FCanvasUVTri>(Triangles));
			
		}
		static void K2_DrawTriangle(UCanvas* _this,UTexture* RenderTexture,MonoArray* Triangles)
		{
			_this->K2_DrawTriangle(RenderTexture,MonoArrayToTArray<FCanvasUVTri>(Triangles));
			
		}
		static void K2_DrawBox(UCanvas* _this,FVector2D* ScreenPosition,FVector2D* ScreenSize,float Thickness)
		{
			_this->K2_DrawBox(*ScreenPosition,*ScreenSize,Thickness);
			
		}
		static void K2_DrawBorder(UCanvas* _this,UTexture* BorderTexture,UTexture* BackgroundTexture,UTexture* LeftBorderTexture,UTexture* RightBorderTexture,UTexture* TopBorderTexture,UTexture* BottomBorderTexture,FVector2D* ScreenPosition,FVector2D* ScreenSize,FVector2D* CoordinatePosition,FVector2D* CoordinateSize,FLinearColor* RenderColor,FVector2D* BorderScale,FVector2D* BackgroundScale,float Rotation,FVector2D* PivotPoint,FVector2D* CornerSize)
		{
			_this->K2_DrawBorder(BorderTexture,BackgroundTexture,LeftBorderTexture,RightBorderTexture,TopBorderTexture,BottomBorderTexture,*ScreenPosition,*ScreenSize,*CoordinatePosition,*CoordinateSize,*RenderColor,*BorderScale,*BackgroundScale,Rotation,*PivotPoint,*CornerSize);
			
		}
		static void K2_DrawText(UCanvas* _this,UFont* RenderFont,MonoString* RenderText,FVector2D* ScreenPosition,FLinearColor* RenderColor,float Kerning,FLinearColor* ShadowColor,FVector2D* ShadowOffset,int32 bCentreX,int32 bCentreY,int32 bOutlined,FLinearColor* OutlineColor)
		{
			FString RenderText_temp=MonoStringToFString(RenderText);
			_this->K2_DrawText(RenderFont,RenderText_temp,*ScreenPosition,*RenderColor,Kerning,*ShadowColor,*ShadowOffset,bCentreX>0?true:false,bCentreY>0?true:false,bOutlined>0?true:false,*OutlineColor);
			
		}
		static void K2_DrawMaterial(UCanvas* _this,UMaterialInterface* RenderMaterial,FVector2D* ScreenPosition,FVector2D* ScreenSize,FVector2D* CoordinatePosition,FVector2D* CoordinateSize,float Rotation,FVector2D* PivotPoint)
		{
			_this->K2_DrawMaterial(RenderMaterial,*ScreenPosition,*ScreenSize,*CoordinatePosition,*CoordinateSize,Rotation,*PivotPoint);
			
		}
		static void K2_DrawTexture(UCanvas* _this,UTexture* RenderTexture,FVector2D* ScreenPosition,FVector2D* ScreenSize,FVector2D* CoordinatePosition,FVector2D* CoordinateSize,FLinearColor* RenderColor,int32 BlendMode,float Rotation,FVector2D* PivotPoint)
		{
			_this->K2_DrawTexture(RenderTexture,*ScreenPosition,*ScreenSize,*CoordinatePosition,*CoordinateSize,*RenderColor,(TEnumAsByte<EBlendMode>)BlendMode,Rotation,*PivotPoint);
			
		}
		static void K2_DrawLine(UCanvas* _this,FVector2D* ScreenPositionA,FVector2D* ScreenPositionB,float Thickness,FLinearColor* RenderColor)
		{
			_this->K2_DrawLine(*ScreenPositionA,*ScreenPositionB,Thickness,*RenderColor);
			
		}
		static UClass* StaticClass(){return UCanvas::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCanvas::K2_TextSize",(const void*)K2_TextSize);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_StrLen",(const void*)K2_StrLen);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_Deproject",(const void*)K2_Deproject);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_Project",(const void*)K2_Project);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawPolygon",(const void*)K2_DrawPolygon);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawMaterialTriangle",(const void*)K2_DrawMaterialTriangle);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawTriangle",(const void*)K2_DrawTriangle);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawBox",(const void*)K2_DrawBox);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawBorder",(const void*)K2_DrawBorder);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawText",(const void*)K2_DrawText);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawMaterial",(const void*)K2_DrawMaterial);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawTexture",(const void*)K2_DrawTexture);
			mono_add_internal_call("UnrealEngine.UCanvas::K2_DrawLine",(const void*)K2_DrawLine);
			mono_add_internal_call("UnrealEngine.UCanvas::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
