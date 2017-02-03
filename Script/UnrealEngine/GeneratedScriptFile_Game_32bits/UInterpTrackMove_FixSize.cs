#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackMove
	{
		static readonly int PosTrack__Offset;
		public FInterpCurveVector PosTrack
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+PosTrack__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int EulerTrack__Offset;
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
		public FName LookAtGroupName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LookAtGroupName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LookAtGroupName__Offset, false);}
			
		}
		
		static readonly int LinCurveTension__Offset;
		public float LinCurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LinCurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LinCurveTension__Offset, false);}
			
		}
		
		static readonly int AngCurveTension__Offset;
		public float AngCurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AngCurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AngCurveTension__Offset, false);}
			
		}
		
		static readonly int bUseQuatInterpolation__Offset;
		public bool bUseQuatInterpolation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseQuatInterpolation__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseQuatInterpolation__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bShowArrowAtKeys__Offset;
		public bool bShowArrowAtKeys
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowArrowAtKeys__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowArrowAtKeys__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bDisableMovement__Offset;
		public bool bDisableMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMovement__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMovement__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bShowTranslationOnCurveEd__Offset;
		public bool bShowTranslationOnCurveEd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowTranslationOnCurveEd__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowTranslationOnCurveEd__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bShowRotationOnCurveEd__Offset;
		public bool bShowRotationOnCurveEd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowRotationOnCurveEd__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowRotationOnCurveEd__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bHide3DTrack__Offset;
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
