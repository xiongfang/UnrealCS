using System;
namespace UnrealEngine
{
	/// <summary>
	/// Defines a mapping between an action and key
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	public partial struct FInputActionKeyMapping
	{
		/// <summary>Friendly name of action, e.g "jump"</summary>
		public FName ActionName;
		/// <summary>Key to bind it to.</summary>
		public FKey Key;
		/// <summary>true if one of the Shift keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bShift;
		/// <summary>true if one of the Ctrl keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bCtrl;
		/// <summary>true if one of the Alt keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bAlt;
		/// <summary>true if one of the Cmd keys must be down when the KeyEvent is received to be acknowledged</summary>
		public bool bCmd;
		
	}
	
}
