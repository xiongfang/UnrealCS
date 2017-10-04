using System;
namespace UnrealEngine
{
	public partial class UAnimNotify_PlayParticleEffect:UAnimNotify
	{
		/// <summary>Particle System to Spawn</summary>
		public UParticleSystem PSTemplate;
		
		/// <summary>Location offset from the socket</summary>
		public FVector LocationOffset;
		
		/// <summary>Rotation offset from socket</summary>
		public FRotator RotationOffset;
		
		/// <summary>Should attach to the bone/socket</summary>
		public bool Attached;
		
		/// <summary>SocketName to attach to</summary>
		public FName SocketName;
		
		
	}
	
}
