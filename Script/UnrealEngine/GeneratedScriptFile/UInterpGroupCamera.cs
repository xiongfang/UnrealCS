using System;
namespace UnrealEngine
{
	public partial class UInterpGroupCamera:UInterpGroup
	{
		public UCameraAnim CameraAnimInst;
		
		/// <summary>
		/// this is interaction property info for CameraAnim
		/// this information isn't really saved with it
		/// </summary>
		public FCameraPreviewInfo Target;
		
		/// <summary>When compress, tolerance option *</summary>
		public float CompressTolerance;
		
		
	}
	
}
