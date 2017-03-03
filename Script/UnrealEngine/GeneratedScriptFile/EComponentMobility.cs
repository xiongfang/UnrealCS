using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Describes how often this component is allowed to move.</summary>
	public enum EComponentMobility:byte
	{
		/// <summary>
		/// Static objects cannot be moved or changed in game.
		/// - Allows baked lighting
		/// - Fastest rendering
		/// </summary>
		Static=0,
		/// <summary>
		/// A stationary light will only have its shadowing and bounced lighting from static geometry baked by Lightmass, all other lighting will be dynamic.
		/// - It can change color and intensity in game.
		/// - Can't move
		/// - Allows partial baked lighting
		/// - Dynamic shadows
		/// </summary>
		Stationary=1,
		/// <summary>
		/// Movable objects can be moved and changed in game.
		/// - Totally dynamic
		/// - Can cast dynamic shadows
		/// - Slowest rendering
		/// </summary>
		Movable=2,
		EComponentMobility_MAX=3,
		
	}
	
}
