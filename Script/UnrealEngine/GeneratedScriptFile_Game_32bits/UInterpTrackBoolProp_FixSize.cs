#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackBoolProp
	{
		static readonly int BoolTrack__Offset;
		public TStructArray<FBoolTrackKey> BoolTrack
		{
			get{ CheckIsValid();return new TStructArray<FBoolTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BoolTrack__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BoolTrack__Offset, false);}
			
		}
		
		static readonly int PropertyName__Offset;
		public FName PropertyName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PropertyName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PropertyName__Offset, false);}
			
		}
		
		static UInterpTrackBoolProp()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackBoolProp");
			BoolTrack__Offset=GetPropertyOffset(NativeClassPtr,"BoolTrack");
			PropertyName__Offset=GetPropertyOffset(NativeClassPtr,"PropertyName");
			
		}
		
	}
	
}
#endif
#endif
