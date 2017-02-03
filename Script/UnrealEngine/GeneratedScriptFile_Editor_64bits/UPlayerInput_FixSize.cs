#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Object within PlayerController that processes player input.
	/// Only exists on the client in network games.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	public partial class UPlayerInput
	{
		static readonly int DebugExecBindings__Offset;
		/// <summary>Generic bindings of keys to Exec()-compatible strings for development purposes only</summary>
		public TStructArray<FKeyBind> DebugExecBindings
		{
			get{ CheckIsValid();return new TStructArray<FKeyBind>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugExecBindings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugExecBindings__Offset, false);}
			
		}
		
		static readonly int InvertedAxis__Offset;
		/// <summary>List of Axis Mappings that have been inverted</summary>
		public TStructArray<FName> InvertedAxis
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InvertedAxis__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InvertedAxis__Offset, false);}
			
		}
		
		static UPlayerInput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerInput");
			DebugExecBindings__Offset=GetPropertyOffset(NativeClassPtr,"DebugExecBindings");
			InvertedAxis__Offset=GetPropertyOffset(NativeClassPtr,"InvertedAxis");
			
		}
		
	}
	
}
#endif
#endif
