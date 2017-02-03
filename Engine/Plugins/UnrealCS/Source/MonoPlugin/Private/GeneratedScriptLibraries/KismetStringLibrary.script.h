#pragma once

namespace UnrealEngine
{
	class _UKismetStringLibrary
	{
		static MonoString* TimeSecondsToString(UKismetStringLibrary* _this,float InSeconds)
		{
			FString ___ret = _this->TimeSecondsToString(InSeconds);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Mid(UKismetStringLibrary* _this,MonoString* SourceString,int32 Start,int32 Count)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->Mid(SourceString_temp,Start,Count);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* RightChop(UKismetStringLibrary* _this,MonoString* SourceString,int32 Count)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->RightChop(SourceString_temp,Count);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Right(UKismetStringLibrary* _this,MonoString* SourceString,int32 Count)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->Right(SourceString_temp,Count);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* LeftChop(UKismetStringLibrary* _this,MonoString* SourceString,int32 Count)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->LeftChop(SourceString_temp,Count);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Left(UKismetStringLibrary* _this,MonoString* SourceString,int32 Count)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->Left(SourceString_temp,Count);
			return FStringToMonoString(___ret);
			
		}
		static int32 Split(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* InStr,MonoString** LeftS,MonoString** RightS,int32 SearchCase,int32 SearchDir)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString InStr_temp=MonoStringToFString(InStr);
			FString LeftS_temp;
			FString RightS_temp;
			bool ___ret = _this->Split(SourceString_temp,InStr_temp,LeftS_temp,RightS_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase,(TEnumAsByte<ESearchDir::Type>)SearchDir);
			return ___ret?1:0;
			*LeftS=FStringToMonoString(LeftS_temp);
			*RightS=FStringToMonoString(RightS_temp);
			
		}
		static int32 ReplaceInline(UKismetStringLibrary* _this,MonoString** SourceString,MonoString* SearchText,MonoString* ReplacementText,int32 SearchCase)
		{
			FString SourceString_temp;
			FString SearchText_temp=MonoStringToFString(SearchText);
			FString ReplacementText_temp=MonoStringToFString(ReplacementText);
			int32 ___ret = _this->ReplaceInline(SourceString_temp,SearchText_temp,ReplacementText_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase);
			return ___ret;
			*SourceString=FStringToMonoString(SourceString_temp);
			
		}
		static MonoString* Replace(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* From,MonoString* To,int32 SearchCase)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString From_temp=MonoStringToFString(From);
			FString To_temp=MonoStringToFString(To);
			FString ___ret = _this->Replace(SourceString_temp,From_temp,To_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Reverse(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->Reverse(SourceString_temp);
			return FStringToMonoString(___ret);
			
		}
		static int32 CullArray(UKismetStringLibrary* _this,MonoString* SourceString,MonoArray** InArray)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			TArray<FString> InArray_temp;
			int32 ___ret = _this->CullArray(SourceString_temp,InArray_temp);
			return ___ret;
			*InArray=TArrayToMonoArray(InArray_temp,"UnrealEngine.FString,UnrealEngine");
			
		}
		static MonoString* TrimTrailing(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->TrimTrailing(SourceString_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Trim(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->Trim(SourceString_temp);
			return FStringToMonoString(___ret);
			
		}
		static int32 MatchesWildcard(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* Wildcard,int32 SearchCase)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString Wildcard_temp=MonoStringToFString(Wildcard);
			bool ___ret = _this->MatchesWildcard(SourceString_temp,Wildcard_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase);
			return ___ret?1:0;
			
		}
		static int32 EndsWith(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* InSuffix,int32 SearchCase)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString InSuffix_temp=MonoStringToFString(InSuffix);
			bool ___ret = _this->EndsWith(SourceString_temp,InSuffix_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase);
			return ___ret?1:0;
			
		}
		static int32 StartsWith(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* InPrefix,int32 SearchCase)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString InPrefix_temp=MonoStringToFString(InPrefix);
			bool ___ret = _this->StartsWith(SourceString_temp,InPrefix_temp,(TEnumAsByte<ESearchCase::Type>)SearchCase);
			return ___ret?1:0;
			
		}
		static int32 IsNumeric(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			bool ___ret = _this->IsNumeric(SourceString_temp);
			return ___ret?1:0;
			
		}
		static MonoString* RightPad(UKismetStringLibrary* _this,MonoString* SourceString,int32 ChCount)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->RightPad(SourceString_temp,ChCount);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* LeftPad(UKismetStringLibrary* _this,MonoString* SourceString,int32 ChCount)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->LeftPad(SourceString_temp,ChCount);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* ToLower(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->ToLower(SourceString_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* ToUpper(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->ToUpper(SourceString_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoArray* GetCharacterArrayFromString(UKismetStringLibrary* _this,MonoString* SourceString)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			TArray<FString> ___ret = _this->GetCharacterArrayFromString(SourceString_temp);
			return TArrayToMonoArray(___ret,"UnrealEngine.FString,UnrealEngine");
			
		}
		static MonoString* JoinStringArray(UKismetStringLibrary* _this,MonoArray* SourceArray,MonoString* Separator)
		{
			FString Separator_temp=MonoStringToFString(Separator);
			FString ___ret = _this->JoinStringArray(MonoArrayToTArray<FString>(SourceArray),Separator_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoArray* ParseIntoArray(UKismetStringLibrary* _this,MonoString* SourceString,MonoString* Delimiter,int32 CullEmptyStrings)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString Delimiter_temp=MonoStringToFString(Delimiter);
			TArray<FString> ___ret = _this->ParseIntoArray(SourceString_temp,Delimiter_temp,CullEmptyStrings>0?true:false);
			return TArrayToMonoArray(___ret,"UnrealEngine.FString,UnrealEngine");
			
		}
		static int32 GetCharacterAsNumber(UKismetStringLibrary* _this,MonoString* SourceString,int32 Index)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			int32 ___ret = _this->GetCharacterAsNumber(SourceString_temp,Index);
			return ___ret;
			
		}
		static int32 Contains(UKismetStringLibrary* _this,MonoString* SearchIn,MonoString* Substring,int32 bUseCase,int32 bSearchFromEnd)
		{
			FString SearchIn_temp=MonoStringToFString(SearchIn);
			FString Substring_temp=MonoStringToFString(Substring);
			bool ___ret = _this->Contains(SearchIn_temp,Substring_temp,bUseCase>0?true:false,bSearchFromEnd>0?true:false);
			return ___ret?1:0;
			
		}
		static int32 FindSubstring(UKismetStringLibrary* _this,MonoString* SearchIn,MonoString* Substring,int32 bUseCase,int32 bSearchFromEnd,int32 StartPosition)
		{
			FString SearchIn_temp=MonoStringToFString(SearchIn);
			FString Substring_temp=MonoStringToFString(Substring);
			int32 ___ret = _this->FindSubstring(SearchIn_temp,Substring_temp,bUseCase>0?true:false,bSearchFromEnd>0?true:false,StartPosition);
			return ___ret;
			
		}
		static MonoString* GetSubstring(UKismetStringLibrary* _this,MonoString* SourceString,int32 StartIndex,int32 Length)
		{
			FString SourceString_temp=MonoStringToFString(SourceString);
			FString ___ret = _this->GetSubstring(SourceString_temp,StartIndex,Length);
			return FStringToMonoString(___ret);
			
		}
		static int32 Len(UKismetStringLibrary* _this,MonoString* S)
		{
			FString S_temp=MonoStringToFString(S);
			int32 ___ret = _this->Len(S_temp);
			return ___ret;
			
		}
		static int32 NotEqual_StriStri(UKismetStringLibrary* _this,MonoString* A,MonoString* B)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			bool ___ret = _this->NotEqual_StriStri(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 NotEqual_StrStr(UKismetStringLibrary* _this,MonoString* A,MonoString* B)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			bool ___ret = _this->NotEqual_StrStr(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_StriStri(UKismetStringLibrary* _this,MonoString* A,MonoString* B)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			bool ___ret = _this->EqualEqual_StriStri(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static int32 EqualEqual_StrStr(UKismetStringLibrary* _this,MonoString* A,MonoString* B)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			bool ___ret = _this->EqualEqual_StrStr(A_temp,B_temp);
			return ___ret?1:0;
			
		}
		static MonoString* Concat_StrStr(UKismetStringLibrary* _this,MonoString* A,MonoString* B)
		{
			FString A_temp=MonoStringToFString(A);
			FString B_temp=MonoStringToFString(B);
			FString ___ret = _this->Concat_StrStr(A_temp,B_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Name(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,MonoString* InName,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FName InName_temp=MonoStringToFName(InName);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Name(AppendTo_temp,Prefix_temp,InName_temp,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Color(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,FLinearColor* InColor,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Color(AppendTo_temp,Prefix_temp,*InColor,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Object(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,UObject* InObj,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Object(AppendTo_temp,Prefix_temp,InObj,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Rotator(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,FRotator* InRot,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Rotator(AppendTo_temp,Prefix_temp,*InRot,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Vector2d(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,FVector2D* InVector2d,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Vector2d(AppendTo_temp,Prefix_temp,*InVector2d,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Vector(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,FVector* InVector,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Vector(AppendTo_temp,Prefix_temp,*InVector,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Bool(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,int32 InBool,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Bool(AppendTo_temp,Prefix_temp,InBool>0?true:false,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Int(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,int32 InInt,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Int(AppendTo_temp,Prefix_temp,InInt,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* BuildString_Float(UKismetStringLibrary* _this,MonoString* AppendTo,MonoString* Prefix,float InFloat,MonoString* Suffix)
		{
			FString AppendTo_temp=MonoStringToFString(AppendTo);
			FString Prefix_temp=MonoStringToFString(Prefix);
			FString Suffix_temp=MonoStringToFString(Suffix);
			FString ___ret = _this->BuildString_Float(AppendTo_temp,Prefix_temp,InFloat,Suffix_temp);
			return FStringToMonoString(___ret);
			
		}
		static void Conv_StringToColor(UKismetStringLibrary* _this,MonoString* InString,FLinearColor* OutConvertedColor,int32* OutIsValid)
		{
			FString InString_temp=MonoStringToFString(InString);
			bool OutIsValid_temp;
			_this->Conv_StringToColor(InString_temp,*OutConvertedColor,OutIsValid_temp);
			*OutIsValid=OutIsValid_temp!=0;
			
		}
		static void Conv_StringToRotator(UKismetStringLibrary* _this,MonoString* InString,FRotator* OutConvertedRotator,int32* OutIsValid)
		{
			FString InString_temp=MonoStringToFString(InString);
			bool OutIsValid_temp;
			_this->Conv_StringToRotator(InString_temp,*OutConvertedRotator,OutIsValid_temp);
			*OutIsValid=OutIsValid_temp!=0;
			
		}
		static void Conv_StringToVector2D(UKismetStringLibrary* _this,MonoString* InString,FVector2D* OutConvertedVector2D,int32* OutIsValid)
		{
			FString InString_temp=MonoStringToFString(InString);
			bool OutIsValid_temp;
			_this->Conv_StringToVector2D(InString_temp,*OutConvertedVector2D,OutIsValid_temp);
			*OutIsValid=OutIsValid_temp!=0;
			
		}
		static void Conv_StringToVector(UKismetStringLibrary* _this,MonoString* InString,FVector* OutConvertedVector,int32* OutIsValid)
		{
			FString InString_temp=MonoStringToFString(InString);
			bool OutIsValid_temp;
			_this->Conv_StringToVector(InString_temp,*OutConvertedVector,OutIsValid_temp);
			*OutIsValid=OutIsValid_temp!=0;
			
		}
		static float Conv_StringToFloat(UKismetStringLibrary* _this,MonoString* InString)
		{
			FString InString_temp=MonoStringToFString(InString);
			float ___ret = _this->Conv_StringToFloat(InString_temp);
			return ___ret;
			
		}
		static int32 Conv_StringToInt(UKismetStringLibrary* _this,MonoString* InString)
		{
			FString InString_temp=MonoStringToFString(InString);
			int32 ___ret = _this->Conv_StringToInt(InString_temp);
			return ___ret;
			
		}
		static MonoString* Conv_StringToName(UKismetStringLibrary* _this,MonoString* InString)
		{
			FString InString_temp=MonoStringToFString(InString);
			FName ___ret = _this->Conv_StringToName(InString_temp);
			return FNameToMonoString(___ret);
			
		}
		static MonoString* Conv_NameToString(UKismetStringLibrary* _this,MonoString* InName)
		{
			FName InName_temp=MonoStringToFName(InName);
			FString ___ret = _this->Conv_NameToString(InName_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_ColorToString(UKismetStringLibrary* _this,FLinearColor* InColor)
		{
			FString ___ret = _this->Conv_ColorToString(*InColor);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_ObjectToString(UKismetStringLibrary* _this,UObject* InObj)
		{
			FString ___ret = _this->Conv_ObjectToString(InObj);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_TransformToString(UKismetStringLibrary* _this,FTransform* InTrans)
		{
			FString ___ret = _this->Conv_TransformToString(*InTrans);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_RotatorToString(UKismetStringLibrary* _this,FRotator* InRot)
		{
			FString ___ret = _this->Conv_RotatorToString(*InRot);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_Vector2dToString(UKismetStringLibrary* _this,FVector2D* InVec)
		{
			FString ___ret = _this->Conv_Vector2dToString(*InVec);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_VectorToString(UKismetStringLibrary* _this,FVector* InVec)
		{
			FString ___ret = _this->Conv_VectorToString(*InVec);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_BoolToString(UKismetStringLibrary* _this,int32 InBool)
		{
			FString ___ret = _this->Conv_BoolToString(InBool>0?true:false);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_ByteToString(UKismetStringLibrary* _this,int32 InByte)
		{
			FString ___ret = _this->Conv_ByteToString(InByte);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_IntToString(UKismetStringLibrary* _this,int32 InInt)
		{
			FString ___ret = _this->Conv_IntToString(InInt);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* Conv_FloatToString(UKismetStringLibrary* _this,float InFloat)
		{
			FString ___ret = _this->Conv_FloatToString(InFloat);
			return FStringToMonoString(___ret);
			
		}
		static UClass* StaticClass(){return UKismetStringLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::TimeSecondsToString",(const void*)TimeSecondsToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Mid",(const void*)Mid);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::RightChop",(const void*)RightChop);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Right",(const void*)Right);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::LeftChop",(const void*)LeftChop);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Left",(const void*)Left);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Split",(const void*)Split);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::ReplaceInline",(const void*)ReplaceInline);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Replace",(const void*)Replace);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Reverse",(const void*)Reverse);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::CullArray",(const void*)CullArray);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::TrimTrailing",(const void*)TrimTrailing);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Trim",(const void*)Trim);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::MatchesWildcard",(const void*)MatchesWildcard);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::EndsWith",(const void*)EndsWith);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::StartsWith",(const void*)StartsWith);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::IsNumeric",(const void*)IsNumeric);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::RightPad",(const void*)RightPad);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::LeftPad",(const void*)LeftPad);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::ToLower",(const void*)ToLower);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::ToUpper",(const void*)ToUpper);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::GetCharacterArrayFromString",(const void*)GetCharacterArrayFromString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::JoinStringArray",(const void*)JoinStringArray);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::ParseIntoArray",(const void*)ParseIntoArray);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::GetCharacterAsNumber",(const void*)GetCharacterAsNumber);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Contains",(const void*)Contains);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::FindSubstring",(const void*)FindSubstring);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::GetSubstring",(const void*)GetSubstring);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Len",(const void*)Len);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::NotEqual_StriStri",(const void*)NotEqual_StriStri);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::NotEqual_StrStr",(const void*)NotEqual_StrStr);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::EqualEqual_StriStri",(const void*)EqualEqual_StriStri);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::EqualEqual_StrStr",(const void*)EqualEqual_StrStr);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Concat_StrStr",(const void*)Concat_StrStr);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Name",(const void*)BuildString_Name);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Color",(const void*)BuildString_Color);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Object",(const void*)BuildString_Object);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Rotator",(const void*)BuildString_Rotator);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Vector2d",(const void*)BuildString_Vector2d);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Vector",(const void*)BuildString_Vector);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Bool",(const void*)BuildString_Bool);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Int",(const void*)BuildString_Int);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::BuildString_Float",(const void*)BuildString_Float);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToColor",(const void*)Conv_StringToColor);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToRotator",(const void*)Conv_StringToRotator);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToVector2D",(const void*)Conv_StringToVector2D);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToVector",(const void*)Conv_StringToVector);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToFloat",(const void*)Conv_StringToFloat);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToInt",(const void*)Conv_StringToInt);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_StringToName",(const void*)Conv_StringToName);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_NameToString",(const void*)Conv_NameToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_ColorToString",(const void*)Conv_ColorToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_ObjectToString",(const void*)Conv_ObjectToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_TransformToString",(const void*)Conv_TransformToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_RotatorToString",(const void*)Conv_RotatorToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_Vector2dToString",(const void*)Conv_Vector2dToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_VectorToString",(const void*)Conv_VectorToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_BoolToString",(const void*)Conv_BoolToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_ByteToString",(const void*)Conv_ByteToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_IntToString",(const void*)Conv_IntToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::Conv_FloatToString",(const void*)Conv_FloatToString);
			mono_add_internal_call("UnrealEngine.UKismetStringLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
