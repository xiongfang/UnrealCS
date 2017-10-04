using System;
namespace UnrealEngine
{
	public partial class UDataTableFunctionLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Get a Row from a DataTable given a RowName</summary>
		public extern static bool GetDataTableRowFromName(UDataTable Table,FName RowName,out FTableRowBase OutRow);
		public extern static void EvaluateCurveTableRow(UCurveTable CurveTable,FName RowName,float InXY,EEvaluateCurveTableResult OutResult,out float OutXY,FString ContextString);
		
	}
	
}
