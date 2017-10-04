using System;
namespace UnrealEngine
{
	public partial class UCameraAnimInst:UObject
	{
		/// <summary>Changes the scale of the animation while playing.</summary>
		public extern void SetScale(float NewDuration);
		/// <summary>Changes the running duration of this active anim, while maintaining playback position.</summary>
		public extern void SetDuration(float NewDuration);
		/// <summary>Stops this instance playing whatever animation it is playing.</summary>
		public extern void Stop(bool bImmediate=false);
		/// <summary>which CameraAnim this is an instance of</summary>
		public UCameraAnim CamAnim;
		
		public UInterpGroupInst InterpGroupInst;
		
		/// <summary>Multiplier for playback rate.  1.0 = normal.</summary>
		public float PlayRate;
		
		/// <summary>cached movement track from the currently playing anim so we don't have to go find it every frame</summary>
		public UInterpTrackMove MoveTrack;
		
		public UInterpTrackInstMove MoveInst;
		
		public ECameraAnimPlaySpace PlaySpace;
		
		
	}
	
}
