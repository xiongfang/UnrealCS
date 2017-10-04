using System;
namespace UnrealEngine
{
	public partial class UAnimNotifyState_TimedParticleEffect:UAnimNotifyState
	{
		/// <summary>The particle system to spawn for the notify state</summary>
		public UParticleSystem PSTemplate;
		
		/// <summary>The socket or bone to attach the system to</summary>
		public FName SocketName;
		
		/// <summary>Offset from the socket or bone to place the particle system</summary>
		public FVector LocationOffset;
		
		/// <summary>Rotation offset from the socket or bone for the particle system</summary>
		public FRotator RotationOffset;
		
		/// <summary>Whether the particle system should be immediately destroyed at the end of the notify state or be allowed to finish</summary>
		public bool bDestroyAtEnd;
		
		
	}
	
}
