#pragma once

namespace UnrealEngine
{
	class _UKismetTextLibrary
	{
		static MonoString* Format(UKismetTextLibrary* _this,MonoString* InPattern,MonoArray* InArgs)
		{
			FText InPattern_temp=FText::FromString(MonoStringToFString(InPattern));
			FText ___ret = _this->Format(InPattern_temp,MonoArrayToTArray<FFormatArgumentData>(InArgs));
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsTimespan_Timespan(UKismetTextLibrary* _this,FTimespan* InTimespan)
		{
			FText ___ret = _this->AsTimespan_Timespan(*InTimespan);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsTime_DateTime(UKismetTextLibrary* _this,FDateTime* In)
		{
			FText ___ret = _this->AsTime_DateTime(*In);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsDateTime_DateTime(UKismetTextLibrary* _this,FDateTime* In)
		{
			FText ___ret = _this->AsDateTime_DateTime(*In);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsDate_DateTime(UKismetTextLibrary* _this,FDateTime* InDateTime)
		{
			FText ___ret = _this->AsDate_DateTime(*InDateTime);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsPercent_Float(UKismetTextLibrary* _this,float Value,int32 RoundingMode,int32 bUseGrouping,int32 MinimumIntegralDigits,int32 MaximumIntegralDigits,int32 MinimumFractionalDigits,int32 MaximumFractionalDigits)
		{
			FText ___ret = _this->AsPercent_Float(Value,(TEnumAsByte<ERoundingMode>)RoundingMode,bUseGrouping>0?true:false,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsCurrency_Float(UKismetTextLibrary* _this,float Value,int32 RoundingMode,int32 bUseGrouping,int32 MinimumIntegralDigits,int32 MaximumIntegralDigits,int32 MinimumFractionalDigits,int32 MaximumFractionalDigits,MonoString* CurrencyCode)
		{
			FString CurrencyCode_temp=MonoStringToFString(CurrencyCode);
			FText ___ret = _this->AsCurrency_Float(Value,(TEnumAsByte<ERoundingMode>)RoundingMode,bUseGrouping>0?true:false,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits,CurrencyCode_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsCurrency_Integer(UKismetTextLibrary* _this,int32 Value,int32 RoundingMode,int32 bUseGrouping,int32 MinimumIntegralDigits,int32 MaximumIntegralDigits,int32 MinimumFractionalDigits,int32 MaximumFractionalDigits,MonoString* CurrencyCode)
		{
			FString CurrencyCode_temp=MonoStringToFString(CurrencyCode);
			FText ___ret = _this->AsCurrency_Integer(Value,(TEnumAsByte<ERoundingMode>)RoundingMode,bUseGrouping>0?true:false,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits,CurrencyCode_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* AsCurrencyBase(UKismetTextLibrary* _this,int32 BaseValue,MonoString* CurrencyCode)
		{
			FString CurrencyCode_temp=MonoStringToFString(CurrencyCode);
			FText ___ret = _this->AsCurrencyBase(BaseValue,CurrencyCode_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_FloatToText(UKismetTextLibrary* _this,float Value,int32 RoundingMode,int32 bUseGrouping,int32 MinimumIntegralDigits,int32 MaximumIntegralDigits,int32 MinimumFractionalDigits,int32 MaximumFractionalDigits)
		{
			FText ___ret = _this->Conv_FloatToText(Value,(TEnumAsByte<ERoundingMode>)RoundingMode,bUseGrouping>0?true:false,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_IntToText(UKismetTextLibrary* _this,int32 Value,int32 bUseGrouping,int32 MinimumIntegralDigits,int32 MaximumIntegralDigits)
		{
			FText ___ret = _this->Conv_IntToText(Value,bUseGrouping>0?true:false,MinimumIntegralDigits,MaximumIntegralDigits);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_ByteToText(UKismetTextLibrary* _this,int32 Value)
		{
			FText ___ret = _this->Conv_ByteToText(Value);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_BoolToText(UKismetTextLibrary* _this,int32 InBool)
		{
			FText ___ret = _this->Conv_BoolToText(InBool>0?true:false);
			return FStringToMonoString(___ret.ToString());
			
		}
		static int32 NotEqual_IgnoreCase_TextText(UKismetTextLibrary* _this,MonoString* A,MonoString* B)
		{
			FText A_temp=FText::FromString(MonoStringToFString(A));
			FText B_temp=FText::FromString(MonoStringToFString(B));
			bool ___ret = _this->NotEqual_IgnoreCase_TextText(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_TextText(UKismetTextLibrary* _this,MonoString* A,MonoString* B)
		{
			FText A_temp=FText::FromString(MonoStringToFString(A));
			FText B_temp=FText::FromString(MonoStringToFString(B));
			bool ___ret = _this->NotEqual_TextText(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_IgnoreCase_TextText(UKismetTextLibrary* _this,MonoString* A,MonoString* B)
		{
			FText A_temp=FText::FromString(MonoStringToFString(A));
			FText B_temp=FText::FromString(MonoStringToFString(B));
			bool ___ret = _this->EqualEqual_IgnoreCase_TextText(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_TextText(UKismetTextLibrary* _this,MonoString* A,MonoString* B)
		{
			FText A_temp=FText::FromString(MonoStringToFString(A));
			FText B_temp=FText::FromString(MonoStringToFString(B));
			bool ___ret = _this->EqualEqual_TextText(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 FindTextInLocalizationTable(UKismetTextLibrary* _this,MonoString* Namespace,MonoString* Key,MonoString** OutText)
		{
			FString Namespace_temp=MonoStringToFString(Namespace);
			FString Key_temp=MonoStringToFString(Key);
			FText OutText_temp;
			bool ___ret = _this->FindTextInLocalizationTable(Namespace_temp,Key_temp,OutText_temp);
			return ___ret?1:0;
			*OutText=FStringToMonoString(OutText_temp.ToString());
			
		}
		static MonoString* GetEmptyText(UKismetTextLibrary* _this)
		{
			FText ___ret = _this->GetEmptyText();
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* TextTrimPrecedingAndTrailing(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			FText ___ret = _this->TextTrimPrecedingAndTrailing(InText_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* TextTrimTrailing(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			FText ___ret = _this->TextTrimTrailing(InText_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* TextTrimPreceding(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			FText ___ret = _this->TextTrimPreceding(InText_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static int32 TextIsCultureInvariant(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			bool ___ret = _this->TextIsCultureInvariant(InText_temp);
			return ___ret?1:0;
			
		}
		static int32 TextIsTransient(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			bool ___ret = _this->TextIsTransient(InText_temp);
			return ___ret?1:0;
			
		}
		static int32 TextIsEmpty(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			bool ___ret = _this->TextIsEmpty(InText_temp);
			return ___ret?1:0;
			
		}
		static MonoString* Conv_NameToText(UKismetTextLibrary* _this,MonoString* InName)
		{
			FName InName_temp=MonoStringToFName(InName);
			FText ___ret = _this->Conv_NameToText(InName_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_StringToText(UKismetTextLibrary* _this,MonoString* InString)
		{
			FString InString_temp=MonoStringToFString(InString);
			FText ___ret = _this->Conv_StringToText(InString_temp);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_TextToString(UKismetTextLibrary* _this,MonoString* InText)
		{
			FText InText_temp=FText::FromString(MonoStringToFString(InText));
			FString ___ret = _this->Conv_TextToString(InText_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_ColorToText(UKismetTextLibrary* _this,FLinearColor* InColor)
		{
			FText ___ret = _this->Conv_ColorToText(*InColor);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_ObjectToText(UKismetTextLibrary* _this,UObject* InObj)
		{
			FText ___ret = _this->Conv_ObjectToText(InObj);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_TransformToText(UKismetTextLibrary* _this,FTransform* InTrans)
		{
			FText ___ret = _this->Conv_TransformToText(*InTrans);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_RotatorToText(UKismetTextLibrary* _this,FRotator* InRot)
		{
			FText ___ret = _this->Conv_RotatorToText(*InRot);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_Vector2dToText(UKismetTextLibrary* _this,FVector2D* InVec)
		{
			FText ___ret = _this->Conv_Vector2dToText(*InVec);
			return FStringToMonoString(___ret.ToString());
			
		}
		static MonoString* Conv_VectorToText(UKismetTextLibrary* _this,FVector* InVec)
		{
			FText ___ret = _this->Conv_VectorToText(*InVec);
			return FStringToMonoString(___ret.ToString());
			
		}
		static UClass* StaticClass(){return UKismetTextLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Format",(const void*)Format);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsTimespan_Timespan",(const void*)AsTimespan_Timespan);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsTime_DateTime",(const void*)AsTime_DateTime);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsDateTime_DateTime",(const void*)AsDateTime_DateTime);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsDate_DateTime",(const void*)AsDate_DateTime);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsPercent_Float",(const void*)AsPercent_Float);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsCurrency_Float",(const void*)AsCurrency_Float);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsCurrency_Integer",(const void*)AsCurrency_Integer);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::AsCurrencyBase",(const void*)AsCurrencyBase);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_FloatToText",(const void*)Conv_FloatToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_IntToText",(const void*)Conv_IntToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_ByteToText",(const void*)Conv_ByteToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_BoolToText",(const void*)Conv_BoolToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::NotEqual_IgnoreCase_TextText",(const void*)NotEqual_IgnoreCase_TextText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::NotEqual_TextText",(const void*)NotEqual_TextText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::EqualEqual_IgnoreCase_TextText",(const void*)EqualEqual_IgnoreCase_TextText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::EqualEqual_TextText",(const void*)EqualEqual_TextText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::FindTextInLocalizationTable",(const void*)FindTextInLocalizationTable);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::GetEmptyText",(const void*)GetEmptyText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextTrimPrecedingAndTrailing",(const void*)TextTrimPrecedingAndTrailing);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextTrimTrailing",(const void*)TextTrimTrailing);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextTrimPreceding",(const void*)TextTrimPreceding);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextIsCultureInvariant",(const void*)TextIsCultureInvariant);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextIsTransient",(const void*)TextIsTransient);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::TextIsEmpty",(const void*)TextIsEmpty);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_NameToText",(const void*)Conv_NameToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_StringToText",(const void*)Conv_StringToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_TextToString",(const void*)Conv_TextToString);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_ColorToText",(const void*)Conv_ColorToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_ObjectToText",(const void*)Conv_ObjectToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_TransformToText",(const void*)Conv_TransformToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_RotatorToText",(const void*)Conv_RotatorToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_Vector2dToText",(const void*)Conv_Vector2dToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::Conv_VectorToText",(const void*)Conv_VectorToText);
			mono_add_internal_call("UnrealEngine.UKismetTextLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
