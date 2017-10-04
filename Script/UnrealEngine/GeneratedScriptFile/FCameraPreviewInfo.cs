using System;
namespace UnrealEngine
{
	/// <summary>Preview APawn class for this track</summary>
	public partial struct FCameraPreviewInfo
	{
		public TSubclassOf<APawn>  PawnClass;
		public UAnimSequence AnimSeq;
		/// <summary>for now this is read-only. It has maintenance issue to be resolved if I enable this.</summary>
		public FVector Location;
		public FRotator Rotation;
		/// <summary>APawn Inst - CameraAnimInst doesn't really exist in editor *</summary>
		public APawn PawnInst;
		
	}
	
}
