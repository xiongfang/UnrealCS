using System;
namespace UnrealEngine
{
	/// <summary>Struct containing mappings for legacy method of binding keys to exec commands.</summary>
	public partial struct FKeyBind
	{
		/// <summary>The key to be bound to the command</summary>
		public FKey Key;
		/// <summary>The command to execute when the key is pressed/released</summary>
		public FString Command;
		/// <summary>Whether the control key needs to be held when the key event occurs</summary>
		public bool Control;
		/// <summary>Whether the shift key needs to be held when the key event occurs</summary>
		public bool Shift;
		/// <summary>Whether the alt key needs to be held when the key event occurs</summary>
		public bool Alt;
		/// <summary>Whether the command key needs to be held when the key event occurs</summary>
		public bool Cmd;
		/// <summary>Whether the control key must not be held when the key event occurs</summary>
		public bool bIgnoreCtrl;
		/// <summary>Whether the shift key must not be held when the key event occurs</summary>
		public bool bIgnoreShift;
		/// <summary>Whether the alt key must not be held when the key event occurs</summary>
		public bool bIgnoreAlt;
		/// <summary>Whether the command key must not be held when the key event occurs</summary>
		public bool bIgnoreCmd;
		public bool bDisabled;
		
	}
	
}
