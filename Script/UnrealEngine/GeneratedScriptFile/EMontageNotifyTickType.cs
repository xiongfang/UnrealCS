using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Ticking method for AnimNotifies in AnimMontages.</summary>
	public enum EMontageNotifyTickType:byte
	{
		/// <summary>Queue notifies, and trigger them at the end of the evaluation phase (faster). Not suitable for changing sections or montage position.</summary>
		Queued=0,
		/// <summary>Trigger notifies as they are encountered (Slower). Suitable for changing sections or montage position.</summary>
		BranchingPoint=1,
		EMontageNotifyTickType_MAX=2,
		
	}
	
}
