#pragma once

namespace UnrealEngine
{
	class _USlateBlueprintLibrary
	{
		static void AbsoluteToViewport(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FVector2D* AbsoluteDesktopCoordinate,FVector2D* PixelPosition,FVector2D* ViewportPosition)
		{
			_this->AbsoluteToViewport(WorldContextObject,*AbsoluteDesktopCoordinate,*PixelPosition,*ViewportPosition);
			
		}
		static void LocalToViewport(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FGeometry* Geometry,FVector2D* LocalCoordinate,FVector2D* PixelPosition,FVector2D* ViewportPosition)
		{
			_this->LocalToViewport(WorldContextObject,*Geometry,*LocalCoordinate,*PixelPosition,*ViewportPosition);
			
		}
		static FVector2D GetLocalSize(USlateBlueprintLibrary* _this,FGeometry* Geometry)
		{
			FVector2D ___ret = _this->GetLocalSize(*Geometry);
			return ___ret;
			
		}
		static FVector2D LocalToAbsolute(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* LocalCoordinate)
		{
			FVector2D ___ret = _this->LocalToAbsolute(*Geometry,*LocalCoordinate);
			return ___ret;
			
		}
		static FVector2D AbsoluteToLocal(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* AbsoluteCoordinate)
		{
			FVector2D ___ret = _this->AbsoluteToLocal(*Geometry,*AbsoluteCoordinate);
			return ___ret;
			
		}
		static int32 IsUnderLocation(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* AbsoluteCoordinate)
		{
			bool ___ret = _this->IsUnderLocation(*Geometry,*AbsoluteCoordinate);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return USlateBlueprintLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::AbsoluteToViewport",(const void*)AbsoluteToViewport);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::LocalToViewport",(const void*)LocalToViewport);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::GetLocalSize",(const void*)GetLocalSize);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::LocalToAbsolute",(const void*)LocalToAbsolute);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::AbsoluteToLocal",(const void*)AbsoluteToLocal);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::IsUnderLocation",(const void*)IsUnderLocation);
			mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
