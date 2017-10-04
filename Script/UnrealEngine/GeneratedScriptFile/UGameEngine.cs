using System;
namespace UnrealEngine
{
	public partial class UGameEngine:UEngine
	{
		/// <summary>Maximium delta time the engine uses to populate FApp::DeltaTime. If 0, unbound.</summary>
		public float MaxDeltaTime;
		
		/// <summary>Maximium time (in seconds) between the flushes of the logs on the server (best effort). If 0, this will happen every tick.</summary>
		public float ServerFlushLogInterval;
		
		public UGameInstance GameInstance;
		
		
	}
	
}
