#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Plays different sounds depending on the number of active sounds
	/// Any time a new sound is played, the first group that has an available slot will be chosen
	/// </summary>
	public partial class USoundNodeGroupControl
	{
		static readonly int GroupSizes__Offset;
		/// <summary>How many active sounds are allowed for each group</summary>
		public TStructArray<int> GroupSizes
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GroupSizes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GroupSizes__Offset, false);}
			
		}
		
		static USoundNodeGroupControl()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeGroupControl");
			GroupSizes__Offset=GetPropertyOffset(NativeClassPtr,"GroupSizes");
			
		}
		
	}
	
}
#endif
#endif
