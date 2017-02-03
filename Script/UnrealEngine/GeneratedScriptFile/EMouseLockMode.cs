using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMouseLockMode:byte
	{
		/// <summary>Do not lock the mouse cursor to the viewport</summary>
		DoNotLock=0,
		/// <summary>Only lock the mouse cursor to the viewport when the mouse is captured</summary>
		LockOnCapture=1,
		/// <summary>Always lock the mouse cursor to the viewport</summary>
		LockAlways=2,
		EMouseLockMode_MAX=3,
		
	}
	
}
