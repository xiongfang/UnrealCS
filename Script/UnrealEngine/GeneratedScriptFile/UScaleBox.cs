using System;
namespace UnrealEngine
{
	public partial class UScaleBox:UContentWidget
	{
		public extern void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale);
		public extern void SetUserSpecifiedScale(float InUserSpecifiedScale);
		public extern void SetStretchDirection(EStretchDirection InStretchDirection);
		public extern void SetStretch(EStretch InStretch);
		/// <summary>The stretching rule to apply when content is stretched</summary>
		public EStretch Stretch;
		
		/// <summary>Controls in what direction content can be scaled</summary>
		public EStretchDirection StretchDirection;
		
		/// <summary>Optional scale that can be specified by the User. Used only for UserSpecified stretching.</summary>
		public float UserSpecifiedScale;
		
		/// <summary>Optional bool to ignore the inherited scale. Applies inverse scaling to counteract parents before applying the local scale operation.</summary>
		public bool IgnoreInheritedScale;
		
		
	}
	
}
