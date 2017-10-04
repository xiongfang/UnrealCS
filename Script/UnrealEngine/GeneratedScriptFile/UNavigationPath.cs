using System;
namespace UnrealEngine
{
	public partial class UNavigationPath:UObject
	{
		public extern bool IsStringPulled();
		public extern bool IsValid();
		public extern bool IsPartial();
		public extern float GetPathCost();
		public extern float GetPathLength();
		/// <summary>if enabled path will request recalculation if it gets invalidated due to a change to underlying navigation</summary>
		public extern void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation);
		public extern void EnableDebugDrawing(bool bShouldDrawDebugData,FLinearColor PathColor=default(FLinearColor));
		/// <summary>UObject end</summary>
		public extern FString GetDebugString();
		public ENavigationOptionFlag RecalculateOnInvalidation;
		
		
	}
	
}
