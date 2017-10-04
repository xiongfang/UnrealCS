using System;
namespace UnrealEngine
{
	/// <summary>
	/// Information about a particule curve being viewed.
	/// Property could be an FInterpCurve, a DistributionFloat or a DistributionVector
	/// </summary>
	public partial struct FCurveEdEntry
	{
		public UObject CurveObject;
		public FColor CurveColor;
		public FString CurveName;
		public int bHideCurve;
		public int bColorCurve;
		public int bFloatingPointColorCurve;
		public int bClamp;
		public float ClampLow;
		public float ClampHigh;
		
	}
	
}
