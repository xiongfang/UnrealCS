using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERotatorQuantization:byte
	{
		/// <summary>The rotator will be compressed to 8 bits per component.</summary>
		ByteComponents=0,
		/// <summary>The rotator will be compressed to 16 bits per component.</summary>
		ShortComponents=1,
		ERotatorQuantization_MAX=2,
		
	}
	
}
