#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneLevelVisibilitySection
	{
		static readonly int Visibility__Offset;
		public ELevelVisibility Visibility
		{
			get{ CheckIsValid();return (ELevelVisibility)Marshal.PtrToStructure(_this.Get()+Visibility__Offset, typeof(ELevelVisibility));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Visibility__Offset, false);}
			
		}
		
		static readonly int LevelNames__Offset;
		public TStructArray<FName> LevelNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LevelNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LevelNames__Offset, false);}
			
		}
		
		static UMovieSceneLevelVisibilitySection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneLevelVisibilitySection");
			Visibility__Offset=GetPropertyOffset(NativeClassPtr,"Visibility");
			LevelNames__Offset=GetPropertyOffset(NativeClassPtr,"LevelNames");
			
		}
		
	}
	
}
#endif
#endif
