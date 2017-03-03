#pragma once

namespace UnrealEngine
{
	class _UDataTableFunctionLibrary
	{
		static int32 GetDataTableRowFromName(UDataTableFunctionLibrary* _this,UDataTable* Table,MonoString* RowName,FTableRowBase* OutRow)
		{
			FName RowName_temp=MonoStringToFName(RowName);
			bool ___ret = _this->GetDataTableRowFromName(Table,RowName_temp,*OutRow);
			return ___ret?1:0;
			
		}
		static void GetDataTableRowNames(UDataTableFunctionLibrary* _this,UDataTable* Table,MonoArray** OutRowNames)
		{
			TArray<FName> OutRowNames_temp;
			_this->GetDataTableRowNames(Table,OutRowNames_temp);
			*OutRowNames=TArrayToMonoArray(OutRowNames_temp,"UnrealEngine.FName,UnrealEngine");
			
		}
		static void EvaluateCurveTableRow(UDataTableFunctionLibrary* _this,UCurveTable* CurveTable,MonoString* RowName,float InXY,int32* OutResult,float* OutXY,MonoString* ContextString)
		{
			FName RowName_temp=MonoStringToFName(RowName);
			TEnumAsByte<EEvaluateCurveTableResult::Type> OutResult_temp;
			FString ContextString_temp=MonoStringToFString(ContextString);
			_this->EvaluateCurveTableRow(CurveTable,RowName_temp,InXY,OutResult_temp,*OutXY,ContextString_temp);
			*OutResult=(int)OutResult_temp;
			
		}
		static UClass* StaticClass(){return UDataTableFunctionLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDataTableFunctionLibrary::GetDataTableRowFromName",(const void*)GetDataTableRowFromName);
			mono_add_internal_call("UnrealEngine.UDataTableFunctionLibrary::GetDataTableRowNames",(const void*)GetDataTableRowNames);
			mono_add_internal_call("UnrealEngine.UDataTableFunctionLibrary::EvaluateCurveTableRow",(const void*)EvaluateCurveTableRow);
			mono_add_internal_call("UnrealEngine.UDataTableFunctionLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
