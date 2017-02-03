using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialPositionTransformSource:byte
	{
		/// <summary>Local space</summary>
		TRANSFORMPOSSOURCE_Local=0,
		/// <summary>Absolute world space</summary>
		TRANSFORMPOSSOURCE_World=1,
		/// <summary>Camera relative world space</summary>
		TRANSFORMPOSSOURCE_TranslatedWorld=2,
		/// <summary>View space (differs from camera space in the shadow passes)</summary>
		TRANSFORMPOSSOURCE_View=3,
		/// <summary>Camera space</summary>
		TRANSFORMPOSSOURCE_Camera=4,
		/// <summary>Particle space</summary>
		TRANSFORMPOSSOURCE_Particle=5,
		TRANSFORMPOSSOURCE_MAX=6,
		
	}
	
}
