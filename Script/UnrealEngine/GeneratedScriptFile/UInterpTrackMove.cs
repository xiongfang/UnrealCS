using System;
namespace UnrealEngine
{
	public partial class UInterpTrackMove:UInterpTrack
	{
		/// <summary>Actual position keyframe data.</summary>
		public FInterpCurveVector PosTrack;
		
		/// <summary>Actual rotation keyframe data, stored as Euler angles in degrees, for easy editing on curve.</summary>
		public FInterpCurveVector EulerTrack;
		
		public FInterpLookupTrack LookupTrack;
		
		/// <summary>When using IMR_LookAtGroup, specifies the Group which this track should always point its actor at.</summary>
		public FName LookAtGroupName;
		
		/// <summary>Controls the tightness of the curve for the translation path.</summary>
		public float LinCurveTension;
		
		/// <summary>Controls the tightness of the curve for the rotation path.</summary>
		public float AngCurveTension;
		
		/// <summary>
		/// Use a Quaternion linear interpolation between keys.
		/// This is robust and will find the 'shortest' distance between keys, but does not support ease in/out.
		/// </summary>
		public bool bUseQuatInterpolation;
		
		/// <summary>In the editor, show a small arrow at each keyframe indicating the rotation at that key.</summary>
		public bool bShowArrowAtKeys;
		
		/// <summary>Disable previewing of this track - will always position  AActor  at Time=0.0. Useful when keyframing an object relative to this group.</summary>
		public bool bDisableMovement;
		
		/// <summary>If false, when this track is displayed on the Curve Editor in Matinee, do not show the Translation tracks.</summary>
		public bool bShowTranslationOnCurveEd;
		
		/// <summary>If false, when this track is displayed on the Curve Editor in Matinee, do not show the Rotation tracks.</summary>
		public bool bShowRotationOnCurveEd;
		
		/// <summary>If true, 3D representation of this track in the 3D viewport is disabled.</summary>
		public bool bHide3DTrack;
		
		public EInterpTrackMoveRotMode RotMode;
		
		
	}
	
}
