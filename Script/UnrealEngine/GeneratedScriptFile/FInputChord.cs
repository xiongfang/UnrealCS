using System;
namespace UnrealEngine
{
	/// <summary>An Input Chord is a key and the modifier keys that are to be held with it.</summary>
	public partial struct FInputChord
	{
		/// <summary>The Key is the core of the chord.</summary>
		public FKey Key;
		/// <summary>Whether the shift key is part of the chord.</summary>
		public bool bShift;
		/// <summary>Whether the control key is part of the chord.</summary>
		public bool bCtrl;
		/// <summary>Whether the alt key is part of the chord.</summary>
		public bool bAlt;
		/// <summary>Whether the command key is part of the chord.</summary>
		public bool bCmd;
		
	}
	
}
