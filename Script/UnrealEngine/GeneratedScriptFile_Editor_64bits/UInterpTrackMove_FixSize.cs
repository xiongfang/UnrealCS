#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Track containing data for moving an actor around over time.</summary>
	public partial class UInterpTrackMove
	{
		static readonly int PosTrack__Offset;
		/// <summary>Actual position keyframe data.</summary>
		public FInterpCurveVector PosTrack
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+PosTrack__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int EulerTrack__Offset;
		/// <summary>Actual rotation keyframe data, stored as Euler angles in degrees, for easy editing on curve.</summary>
		public FInterpCurveVector EulerTrack
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+EulerTrack__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int LookupTrack__Offset;
		public FInterpLookupTrack LookupTrack
		{
			get{ CheckIsValid();return (FInterpLookupTrack)Marshal.PtrToStructure(_this.Get()+LookupTrack__Offset, typeof(FInterpLookupTrack));}
			
		}
		
		static readonly int LookAtGroupName__Offset;
		/// <summary>When using IMR_LookAtGroup, specifies the Group which this track should always point its actor at.</summary>
		public FName LookAtGroupName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LookAtGroupName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LookAtGroupName__Offset, false);}
			
		}
		
		static readonly int LinCurveTension__Offset;
		/// <summary>Controls the tightness of the curve for the translation path.</summary>
		public float LinCurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinCurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinCurveTension__Offset, false);}
			
		}
		
		static readonly int AngCurveTension__Offset;
		/// <summary>Controls the tightness of the curve for the rotation path.</summary>
		public float AngCurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngCurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngCurveTension__Offset, false);}
			
		}
		
		static readonly int bUseQuatInterpolation__Offset;
		/// <summary>
		/// Use a Quaternion linear interpolation between keys.
		/// This is robust and will find the 'shortest' distance between keys, but does not support ease in/out.
		/// </summary>
		public bool bUseQuatInterpolation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseQuatInterpolation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseQuatInterpolation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bShowArrowAtKeys__Offset;
		/// <summary>In the editor, show a small arrow at each keyframe indicating the rotation at that key.</summary>
		public bool bShowArrowAtKeys
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowArrowAtKeys__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowArrowAtKeys__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDisableMovement__Offset;
		/// <summary>Disable previewing of this track - will always position  AActor  at Time=0.0. Useful when keyframing an object relative to this group.</summary>
		public bool bDisableMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMovement__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMovement__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bShowTranslationOnCurveEd__Offset;
		/// <summary>If false, when this track is displayed on the Curve Editor in Matinee, do not show the Translation tracks.</summary>
		public bool bShowTranslationOnCurveEd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowTranslationOnCurveEd__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowTranslationOnCurveEd__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bShowRotationOnCurveEd__Offset;
		/// <summary>If false, when this track is displayed on the Curve Editor in Matinee, do not show the Rotation tracks.</summary>
		public bool bShowRotationOnCurveEd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowRotationOnCurveEd__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowRotationOnCurveEd__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bHide3DTrack__Offset;
		/// <summary>If true, 3D representation of this track in the 3D viewport is disabled.</summary>
		public bool bHide3DTrack
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHide3DTrack__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHide3DTrack__Offset, 1,0,32,32);}
			
		}
		
		static readonly int RotMode__Offset;
		public EInterpTrackMoveRotMode RotMode
		{
			get{ CheckIsValid();return (EInterpTrackMoveRotMode)Marshal.PtrToStructure(_this.Get()+RotMode__Offset, typeof(EInterpTrackMoveRotMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotMode__Offset, false);}
			
		}
		
		static UInterpTrackMove()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackMove");
			PosTrack__Offset=GetPropertyOffset(NativeClassPtr,"PosTrack");
			EulerTrack__Offset=GetPropertyOffset(NativeClassPtr,"EulerTrack");
			LookupTrack__Offset=GetPropertyOffset(NativeClassPtr,"LookupTrack");
			LookAtGroupName__Offset=GetPropertyOffset(NativeClassPtr,"LookAtGroupName");
			LinCurveTension__Offset=GetPropertyOffset(NativeClassPtr,"LinCurveTension");
			AngCurveTension__Offset=GetPropertyOffset(NativeClassPtr,"AngCurveTension");
			bUseQuatInterpolation__Offset=GetPropertyOffset(NativeClassPtr,"bUseQuatInterpolation");
			bShowArrowAtKeys__Offset=GetPropertyOffset(NativeClassPtr,"bShowArrowAtKeys");
			bDisableMovement__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMovement");
			bShowTranslationOnCurveEd__Offset=GetPropertyOffset(NativeClassPtr,"bShowTranslationOnCurveEd");
			bShowRotationOnCurveEd__Offset=GetPropertyOffset(NativeClassPtr,"bShowRotationOnCurveEd");
			bHide3DTrack__Offset=GetPropertyOffset(NativeClassPtr,"bHide3DTrack");
			RotMode__Offset=GetPropertyOffset(NativeClassPtr,"RotMode");
			
		}
		
	}
	
}
#endif
#endif
