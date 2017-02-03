using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum used to indicate success or failure of EvaluateCurveTableRow.</summary>
	public enum EEvaluateCurveTableResult:byte
	{
		/// <summary>Found the row successfully.</summary>
		RowFound=0,
		/// <summary>Failed to find the row.</summary>
		RowNotFound=1,
		EEvaluateCurveTableResult_MAX=2,
		
	}
	
}
