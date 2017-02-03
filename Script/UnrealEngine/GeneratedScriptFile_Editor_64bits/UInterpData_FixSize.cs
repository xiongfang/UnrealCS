#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Interpolation data, containing keyframe tracks, event tracks etc.
	/// This does not contain any  AActor  references or state, so can safely be stored in
	/// packages, shared between multiple MatineeActors etc.
	/// </summary>
	public partial class UInterpData
	{
		static readonly int InterpLength__Offset;
		/// <summary>Duration of interpolation sequence - in seconds.</summary>
		public float InterpLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InterpLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpLength__Offset, false);}
			
		}
		
		static readonly int PathBuildTime__Offset;
		/// <summary>Position in Interp to move things to for path-building in editor.</summary>
		public float PathBuildTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PathBuildTime__Offset, typeof(float));}
			
		}
		
		static readonly int InterpGroups__Offset;
		/// <summary>Actual interpolation data. Groups of InterpTracks.</summary>
		public TObjectArray<UInterpGroup>  InterpGroups
		{
					get{ CheckIsValid();return new TObjectArray<UInterpGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InterpGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InterpGroups__Offset, false);}
			
		}
		
		static readonly int CurveEdSetup__Offset;
		/// <summary>Used for curve editor to remember curve-editing setup. Only loaded in editor.</summary>
		public UInterpCurveEdSetup CurveEdSetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurveEdSetup__Offset); if (v == IntPtr.Zero)return null; UInterpCurveEdSetup retValue = new UInterpCurveEdSetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InterpFilters__Offset;
		/// <summary>Used for filtering which tracks are currently visible.</summary>
		public TObjectArray<UInterpFilter>  InterpFilters
		{
					get{ CheckIsValid();return new TObjectArray<UInterpFilter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InterpFilters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InterpFilters__Offset, false);}
			
		}
		
		static readonly int SelectedFilter__Offset;
		/// <summary>The currently selected filter.</summary>
		public UInterpFilter SelectedFilter
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SelectedFilter__Offset); if (v == IntPtr.Zero)return null; UInterpFilter retValue = new UInterpFilter(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DefaultFilters__Offset;
		/// <summary>Array of default filters.</summary>
		public TObjectArray<UInterpFilter>  DefaultFilters
		{
					get{ CheckIsValid();return new TObjectArray<UInterpFilter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultFilters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultFilters__Offset, false);}
			
		}
		
		static readonly int EdSectionStart__Offset;
		/// <summary>Used in editor for defining sections to loop, stretch etc.</summary>
		public float EdSectionStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EdSectionStart__Offset, typeof(float));}
			
		}
		
		static readonly int EdSectionEnd__Offset;
		/// <summary>Used in editor for defining sections to loop, stretch etc.</summary>
		public float EdSectionEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EdSectionEnd__Offset, typeof(float));}
			
		}
		
		static readonly int bShouldBakeAndPrune__Offset;
		/// <summary>If true, then the matinee should be baked and pruned at cook time.</summary>
		public bool bShouldBakeAndPrune
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBakeAndPrune__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldBakeAndPrune__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CachedDirectorGroup__Offset;
		/// <summary>Cached version of the director group, if any, for easy access while in game</summary>
		public UInterpGroupDirector CachedDirectorGroup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CachedDirectorGroup__Offset); if (v == IntPtr.Zero)return null; UInterpGroupDirector retValue = new UInterpGroupDirector(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AllEventNames__Offset;
		/// <summary>Unique names of all events contained across all event tracks</summary>
		public TStructArray<FName> AllEventNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AllEventNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AllEventNames__Offset, false);}
			
		}
		
		static UInterpData()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpData");
			InterpLength__Offset=GetPropertyOffset(NativeClassPtr,"InterpLength");
			PathBuildTime__Offset=GetPropertyOffset(NativeClassPtr,"PathBuildTime");
			InterpGroups__Offset=GetPropertyOffset(NativeClassPtr,"InterpGroups");
			CurveEdSetup__Offset=GetPropertyOffset(NativeClassPtr,"CurveEdSetup");
			InterpFilters__Offset=GetPropertyOffset(NativeClassPtr,"InterpFilters");
			SelectedFilter__Offset=GetPropertyOffset(NativeClassPtr,"SelectedFilter");
			DefaultFilters__Offset=GetPropertyOffset(NativeClassPtr,"DefaultFilters");
			EdSectionStart__Offset=GetPropertyOffset(NativeClassPtr,"EdSectionStart");
			EdSectionEnd__Offset=GetPropertyOffset(NativeClassPtr,"EdSectionEnd");
			bShouldBakeAndPrune__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBakeAndPrune");
			CachedDirectorGroup__Offset=GetPropertyOffset(NativeClassPtr,"CachedDirectorGroup");
			AllEventNames__Offset=GetPropertyOffset(NativeClassPtr,"AllEventNames");
			
		}
		
	}
	
}
#endif
#endif
