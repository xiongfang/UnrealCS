#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALevelStreamingVolume
	{
		static readonly int StreamingLevelNames__Offset;
		/// <summary>Levels names affected by this level streaming volume.</summary>
		public TStructArray<FName> StreamingLevelNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingLevelNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingLevelNames__Offset, false);}
			
		}
		
		static readonly int bEditorPreVisOnly__Offset;
		/// <summary>If true, this streaming volume should only be used for editor streaming level previs.</summary>
		public bool bEditorPreVisOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditorPreVisOnly__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEditorPreVisOnly__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDisabled__Offset;
		/// <summary>
		/// If true, this streaming volume is ignored by the streaming volume code.  Used to either
		/// disable a level streaming volume without disassociating it from the level, or to toggle
		/// the control of a level's streaming between Kismet and volume streaming.
		/// </summary>
		public bool bDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisabled__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisabled__Offset, 1,0,2,2);}
			
		}
		
		static readonly int StreamingUsage__Offset;
		/// <summary>Determines what this volume is used for, e.g. whether to control loading, loading and visibility or just visibilty (blocking on load)</summary>
		public EStreamingVolumeUsage StreamingUsage
		{
			get{ CheckIsValid();return (EStreamingVolumeUsage)Marshal.PtrToStructure(_this.Get()+StreamingUsage__Offset, typeof(EStreamingVolumeUsage));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingUsage__Offset, false);}
			
		}
		
		static ALevelStreamingVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelStreamingVolume");
			StreamingLevelNames__Offset=GetPropertyOffset(NativeClassPtr,"StreamingLevelNames");
			bEditorPreVisOnly__Offset=GetPropertyOffset(NativeClassPtr,"bEditorPreVisOnly");
			bDisabled__Offset=GetPropertyOffset(NativeClassPtr,"bDisabled");
			StreamingUsage__Offset=GetPropertyOffset(NativeClassPtr,"StreamingUsage");
			
		}
		
	}
	
}
#endif
#endif
