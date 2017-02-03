#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// This class indicates a location where a player can spawn when the game begins
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/PlayerStart/
	/// </summary>
	public partial class APlayerStart
	{
		static readonly int PlayerStartTag__Offset;
		/// <summary>Used when searching for which playerstart to use.</summary>
		public FName PlayerStartTag
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PlayerStartTag__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayerStartTag__Offset, false);}
			
		}
		
		static readonly int ArrowComponent__Offset;
		public UArrowComponent ArrowComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ArrowComponent__Offset); if (v == IntPtr.Zero)return null; UArrowComponent retValue = new UArrowComponent(); retValue._this = v; return retValue; }
			
		}
		
		static APlayerStart()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerStart");
			PlayerStartTag__Offset=GetPropertyOffset(NativeClassPtr,"PlayerStartTag");
			ArrowComponent__Offset=GetPropertyOffset(NativeClassPtr,"ArrowComponent");
			
		}
		
	}
	
}
#endif
#endif
