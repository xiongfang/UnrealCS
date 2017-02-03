#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpGroup
	{
		static readonly int InterpTracks__Offset;
		public TObjectArray<UInterpTrack>  InterpTracks
		{
					get{ CheckIsValid();return new TObjectArray<UInterpTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InterpTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InterpTracks__Offset, false);}
			
		}
		
		static readonly int GroupName__Offset;
		public FName GroupName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+GroupName__Offset, typeof(FName));}
			
		}
		
		static readonly int GroupColor__Offset;
		public FColor GroupColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+GroupColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupColor__Offset, false);}
			
		}
		
		static readonly int bCollapsed__Offset;
		public bool bCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollapsed__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bVisible__Offset;
		public bool bVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisible__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsFolder__Offset;
		public bool bIsFolder
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFolder__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsParented__Offset;
		public bool bIsParented
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParented__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIsSelected__Offset;
		public bool bIsSelected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSelected__Offset, 1, 0, 16, 16);}
			
		}
		
		static UInterpGroup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpGroup");
			InterpTracks__Offset=GetPropertyOffset(NativeClassPtr,"InterpTracks");
			GroupName__Offset=GetPropertyOffset(NativeClassPtr,"GroupName");
			GroupColor__Offset=GetPropertyOffset(NativeClassPtr,"GroupColor");
			bCollapsed__Offset=GetPropertyOffset(NativeClassPtr,"bCollapsed");
			bVisible__Offset=GetPropertyOffset(NativeClassPtr,"bVisible");
			bIsFolder__Offset=GetPropertyOffset(NativeClassPtr,"bIsFolder");
			bIsParented__Offset=GetPropertyOffset(NativeClassPtr,"bIsParented");
			bIsSelected__Offset=GetPropertyOffset(NativeClassPtr,"bIsSelected");
			
		}
		
	}
	
}
#endif
#endif
