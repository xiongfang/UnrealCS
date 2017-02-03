#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlueprintCore
	{
		static readonly int SkeletonGeneratedClass__Offset;
		public TSubclassOf<UObject>  SkeletonGeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletonGeneratedClass__Offset); return v; }
			
		}
		
		static readonly int GeneratedClass__Offset;
		public TSubclassOf<UObject>  GeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GeneratedClass__Offset); return v; }
			
		}
		
		static readonly int bLegacyNeedToPurgeSkelRefs__Offset;
		public bool bLegacyNeedToPurgeSkelRefs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLegacyNeedToPurgeSkelRefs__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bLegacyGeneratedClassIsAuthoritative__Offset;
		public bool bLegacyGeneratedClassIsAuthoritative
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLegacyGeneratedClassIsAuthoritative__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int BlueprintGuid__Offset;
		public FGuid BlueprintGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+BlueprintGuid__Offset, typeof(FGuid));}
			
		}
		
		static UBlueprintCore()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlueprintCore");
			SkeletonGeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"SkeletonGeneratedClass");
			GeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"GeneratedClass");
			bLegacyNeedToPurgeSkelRefs__Offset=GetPropertyOffset(NativeClassPtr,"bLegacyNeedToPurgeSkelRefs");
			bLegacyGeneratedClassIsAuthoritative__Offset=GetPropertyOffset(NativeClassPtr,"bLegacyGeneratedClassIsAuthoritative");
			BlueprintGuid__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintGuid");
			
		}
		
	}
	
}
#endif
#endif
