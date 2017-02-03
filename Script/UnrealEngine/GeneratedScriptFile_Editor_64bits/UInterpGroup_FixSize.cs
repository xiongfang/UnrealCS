#if WITH_EDITOR
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
		/// <summary>
		/// Within an InterpData, all GroupNames must be unique.
		/// Used for naming Variable connectors on the Action in Kismet and finding each groups object.
		/// </summary>
		public FName GroupName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+GroupName__Offset, typeof(FName));}
			
		}
		
		static readonly int GroupColor__Offset;
		/// <summary>Colour used for drawing tracks etc. related to this group.</summary>
		public FColor GroupColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+GroupColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GroupColor__Offset, false);}
			
		}
		
		static readonly int bCollapsed__Offset;
		/// <summary>Whether or not this group is folded away in the editor.</summary>
		public bool bCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollapsed__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bVisible__Offset;
		/// <summary>Whether or not this group is visible in the editor.</summary>
		public bool bVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisible__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bIsFolder__Offset;
		/// <summary>When enabled, this group is treated like a folder in the editor, which should only be used for organization.  Folders are never associated with actors and don't have a presence in the Kismet graph.</summary>
		public bool bIsFolder
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFolder__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsParented__Offset;
		/// <summary>When true, this group is considered a 'visual child' of another group.  This doesn't at all affect the behavior of the group, it's only for visual organization.  Also, it's implied that the parent is the next prior group in the array that doesn't have a parent.</summary>
		public bool bIsParented
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsParented__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bIsSelected__Offset;
		/// <summary>When enabled, this group will be selected in the interp editor.</summary>
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
