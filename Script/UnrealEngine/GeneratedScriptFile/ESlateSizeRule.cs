using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The sizing options of UWidgets</summary>
	public enum ESlateSizeRule:byte
	{
		/// <summary>Only requests as much room as it needs based on the widgets desired size.</summary>
		Automatic=0,
		/// <summary>Greedily attempts to fill all available room based on the percentage value 0..1</summary>
		Fill=1,
		ESlateSizeRule_MAX=2,
		
	}
	
}
