#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneActorReferenceSection
	{
		static readonly int ActorGuidIndexCurve__Offset;
		public FIntegralCurve ActorGuidIndexCurve
		{
			get{ CheckIsValid();return (FIntegralCurve)Marshal.PtrToStructure(_this.Get()+ActorGuidIndexCurve__Offset, typeof(FIntegralCurve));}
			
		}
		
		static readonly int ActorGuidStrings__Offset;
		public TStructArray<FString> ActorGuidStrings
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActorGuidStrings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActorGuidStrings__Offset, false);}
			
		}
		
		static UMovieSceneActorReferenceSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneActorReferenceSection");
			ActorGuidIndexCurve__Offset=GetPropertyOffset(NativeClassPtr,"ActorGuidIndexCurve");
			ActorGuidStrings__Offset=GetPropertyOffset(NativeClassPtr,"ActorGuidStrings");
			
		}
		
	}
	
}
#endif
#endif
