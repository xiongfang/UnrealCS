using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAudioOutputTarget:byte
	{
		/// <summary>Sound plays only from speakers.</summary>
		Speaker=0,
		/// <summary>Sound plays only from controller if present.</summary>
		Controller=1,
		/// <summary>Sound plays on the controller if present. If not present, it plays from speakers.</summary>
		ControllerFallbackToSpeaker=2,
		EAudioOutputTarget_MAX=3,
		
	}
	
}
