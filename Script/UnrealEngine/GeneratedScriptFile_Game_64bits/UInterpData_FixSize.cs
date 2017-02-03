#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpData
	{
		static readonly int InterpLength__Offset;
		public float InterpLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InterpLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpLength__Offset, false);}
			
		}
		
		static readonly int PathBuildTime__Offset;
		public float PathBuildTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PathBuildTime__Offset, typeof(float));}
			
		}
		
		static readonly int InterpGroups__Offset;
		public TObjectArray<UInterpGroup>  InterpGroups
		{
					get{ CheckIsValid();return new TObjectArray<UInterpGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InterpGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InterpGroups__Offset, false);}
			
		}
		
		static readonly int CurveEdSetup__Offset;
		public UInterpCurveEdSetup CurveEdSetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurveEdSetup__Offset); if (v == IntPtr.Zero)return null; UInterpCurveEdSetup retValue = new UInterpCurveEdSetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int EdSectionStart__Offset;
		public float EdSectionStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EdSectionStart__Offset, typeof(float));}
			
		}
		
		static readonly int EdSectionEnd__Offset;
		public float EdSectionEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EdSectionEnd__Offset, typeof(float));}
			
		}
		
		static readonly int bShouldBakeAndPrune__Offset;
		public bool bShouldBakeAndPrune
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBakeAndPrune__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShouldBakeAndPrune__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CachedDirectorGroup__Offset;
		public UInterpGroupDirector CachedDirectorGroup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CachedDirectorGroup__Offset); if (v == IntPtr.Zero)return null; UInterpGroupDirector retValue = new UInterpGroupDirector(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AllEventNames__Offset;
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
