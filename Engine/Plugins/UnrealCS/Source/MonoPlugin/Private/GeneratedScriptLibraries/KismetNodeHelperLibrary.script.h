#pragma once

namespace UnrealEngine
{
	class _UKismetNodeHelperLibrary
	{
		static int32 GetEnumeratorValueFromIndex(UKismetNodeHelperLibrary* _this,UEnum* Enum,int32 EnumeratorIndex)
		{
			uint8 ___ret = _this->GetEnumeratorValueFromIndex(Enum,EnumeratorIndex);
			return (uint8)___ret;
			
		}
		static int32 GetValidValue(UKismetNodeHelperLibrary* _this,UEnum* Enum,int32 EnumeratorValue)
		{
			uint8 ___ret = _this->GetValidValue(Enum,EnumeratorValue);
			return (uint8)___ret;
			
		}
		static MonoString* GetEnumeratorUserFriendlyName(UKismetNodeHelperLibrary* _this,UEnum* Enum,int32 EnumeratorValue)
		{
			FString ___ret = _this->GetEnumeratorUserFriendlyName(Enum,EnumeratorValue);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetEnumeratorName(UKismetNodeHelperLibrary* _this,UEnum* Enum,int32 EnumeratorValue)
		{
			FName ___ret = _this->GetEnumeratorName(Enum,EnumeratorValue);
			return FNameToMonoString(___ret);
			
		}
		static int32 GetFirstUnmarkedBit(UKismetNodeHelperLibrary* _this,int32 Data,int32 StartIdx,int32 NumBits)
		{
			int32 ___ret = _this->GetFirstUnmarkedBit(Data,StartIdx,NumBits);
			return ___ret;
			
		}
		static int32 GetRandomUnmarkedBit(UKismetNodeHelperLibrary* _this,int32 Data,int32 StartIdx,int32 NumBits)
		{
			int32 ___ret = _this->GetRandomUnmarkedBit(Data,StartIdx,NumBits);
			return ___ret;
			
		}
		static int32 GetUnmarkedBit(UKismetNodeHelperLibrary* _this,int32 Data,int32 StartIdx,int32 NumBits,int32 bRandom)
		{
			int32 ___ret = _this->GetUnmarkedBit(Data,StartIdx,NumBits,bRandom>0?true:false);
			return ___ret;
			
		}
		static int32 HasMarkedBit(UKismetNodeHelperLibrary* _this,int32 Data,int32 NumBits)
		{
			bool ___ret = _this->HasMarkedBit(Data,NumBits);
			return ___ret?1:0;
			
		}
		static int32 HasUnmarkedBit(UKismetNodeHelperLibrary* _this,int32 Data,int32 NumBits)
		{
			bool ___ret = _this->HasUnmarkedBit(Data,NumBits);
			return ___ret?1:0;
			
		}
		static void ClearAllBits(UKismetNodeHelperLibrary* _this,int32* Data)
		{
			_this->ClearAllBits(*Data);
			
		}
		static void ClearBit(UKismetNodeHelperLibrary* _this,int32* Data,int32 Index)
		{
			_this->ClearBit(*Data,Index);
			
		}
		static void MarkBit(UKismetNodeHelperLibrary* _this,int32* Data,int32 Index)
		{
			_this->MarkBit(*Data,Index);
			
		}
		static int32 BitIsMarked(UKismetNodeHelperLibrary* _this,int32 Data,int32 Index)
		{
			bool ___ret = _this->BitIsMarked(Data,Index);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UKismetNodeHelperLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetEnumeratorValueFromIndex",(const void*)GetEnumeratorValueFromIndex);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetValidValue",(const void*)GetValidValue);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetEnumeratorUserFriendlyName",(const void*)GetEnumeratorUserFriendlyName);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetEnumeratorName",(const void*)GetEnumeratorName);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetFirstUnmarkedBit",(const void*)GetFirstUnmarkedBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetRandomUnmarkedBit",(const void*)GetRandomUnmarkedBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::GetUnmarkedBit",(const void*)GetUnmarkedBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::HasMarkedBit",(const void*)HasMarkedBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::HasUnmarkedBit",(const void*)HasUnmarkedBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::ClearAllBits",(const void*)ClearAllBits);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::ClearBit",(const void*)ClearBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::MarkBit",(const void*)MarkBit);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::BitIsMarked",(const void*)BitIsMarked);
			mono_add_internal_call("UnrealEngine.UKismetNodeHelperLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
