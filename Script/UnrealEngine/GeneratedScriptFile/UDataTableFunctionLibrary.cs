using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UDataTableFunctionLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetDataTableRowFromName(IntPtr _this,IntPtr Table,string RowName,out FTableRowBase OutRow);
/// <summary>Get a Row from a DataTable given a RowName</summary>
public static bool GetDataTableRowFromName(UDataTable Table,string RowName,out FTableRowBase OutRow)
{
	int ___ret = GetDataTableRowFromName(IntPtr.Zero,Table,RowName,out OutRow);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetDataTableRowNames(IntPtr _this,IntPtr Table,out FName[] OutRowNames);
public static void GetDataTableRowNames(UDataTable Table,out FName[] OutRowNames)
{
	GetDataTableRowNames(IntPtr.Zero,Table,out OutRowNames);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EvaluateCurveTableRow(IntPtr _this,IntPtr CurveTable,string RowName,float InXY,out int OutResult,out float OutXY,string ContextString);
public static void EvaluateCurveTableRow(UCurveTable CurveTable,string RowName,float InXY,EEvaluateCurveTableResult OutResult,out float OutXY,string ContextString)
{
	int OutResult_temp;
	EvaluateCurveTableRow(IntPtr.Zero,CurveTable,RowName,InXY,out OutResult_temp,out OutXY,ContextString);
	OutResult=(EEvaluateCurveTableResult)OutResult_temp;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
