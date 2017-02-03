using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Filtering method for deciding whether to trigger a notify.</summary>
	public enum ENotifyFilterType:byte
	{
		/// <summary>No filtering.</summary>
		NoFiltering=0,
		/// <summary>Filter By Skeletal Mesh LOD.</summary>
		LOD=1,
		ENotifyFilterType_MAX=2,
		
	}
	
}
