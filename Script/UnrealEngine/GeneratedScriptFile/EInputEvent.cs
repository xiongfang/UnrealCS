using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>EInputEvent</summary>
	public enum EInputEvent:byte
	{
		IE_Pressed=0,
		IE_Released=1,
		IE_Repeat=2,
		IE_DoubleClick=3,
		IE_Axis=4,
		IE_MAX=5,
		
	}
	
}
