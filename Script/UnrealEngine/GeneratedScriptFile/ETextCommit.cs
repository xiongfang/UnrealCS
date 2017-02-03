using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Additional information about a text committal</summary>
	public enum ETextCommit:byte
	{
		/// <summary>Losing focus or similar event caused implicit commit</summary>
		Default=0,
		/// <summary>User committed via the enter key</summary>
		OnEnter=1,
		/// <summary>User committed via tabbing away or moving focus explicitly away</summary>
		OnUserMovedFocus=2,
		/// <summary>Keyboard focus was explicitly cleared via the escape key or other similar action</summary>
		OnCleared=3,
		ETextCommit_MAX=4,
		
	}
	
}
