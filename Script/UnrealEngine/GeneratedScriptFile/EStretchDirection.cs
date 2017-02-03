using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EStretchDirection:byte
	{
		/// <summary>Will scale the content up or down.</summary>
		Both=0,
		/// <summary>Will only make the content smaller, will never scale it larger than the content's desired size.</summary>
		DownOnly=1,
		/// <summary>Will only make the content larger, will never scale it smaller than the content's desired size.</summary>
		UpOnly=2,
		EStretchDirection_MAX=3,
		
	}
	
}
