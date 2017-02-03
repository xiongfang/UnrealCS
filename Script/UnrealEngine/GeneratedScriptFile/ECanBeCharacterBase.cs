using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Determines whether a Character can attempt to step up onto a component when they walk in to it.</summary>
	public enum ECanBeCharacterBase:byte
	{
		/// <summary>Character cannot step up onto this Component.</summary>
		ECB_No=0,
		/// <summary>Character can step up onto this Component.</summary>
		ECB_Yes=1,
		/// <summary>
		/// Owning actor determines whether character can step up onto this Component (default true unless overridden in code).
		/// @see AActor::CanBeBaseForCharacter()
		/// </summary>
		ECB_Owner=2,
		ECB_MAX=3,
		
	}
	
}
