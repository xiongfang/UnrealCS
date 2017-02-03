#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpGroupInst
	{
		static readonly int Group__Offset;
		/// <summary>UInterpGroup within the InterpData that this is an instance of.</summary>
		public UInterpGroup Group
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Group__Offset); if (v == IntPtr.Zero)return null; UInterpGroup retValue = new UInterpGroup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GroupActor__Offset;
		/// <summary>
		/// Actor that this Group instance is acting upon.
		/// NB: that this may be set to NULL at any time as a result of the  AActor  being destroyed.
		/// </summary>
		public AActor GroupActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GroupActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TrackInst__Offset;
		/// <summary>Array if InterpTrack instances. TrackInst.Num() == UInterpGroup.InterpTrack.Num() must be true.</summary>
		public TObjectArray<UInterpTrackInst>  TrackInst
		{
					get{ CheckIsValid();return new TObjectArray<UInterpTrackInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TrackInst__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TrackInst__Offset, false);}
			
		}
		
		static UInterpGroupInst()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpGroupInst");
			Group__Offset=GetPropertyOffset(NativeClassPtr,"Group");
			GroupActor__Offset=GetPropertyOffset(NativeClassPtr,"GroupActor");
			TrackInst__Offset=GetPropertyOffset(NativeClassPtr,"TrackInst");
			
		}
		
	}
	
}
#endif
#endif
