#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UObjectLibrary
	{
		static readonly int ObjectBaseClass__Offset;
		public UClass ObjectBaseClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ObjectBaseClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ObjectBaseClass__Offset, value); }
			
		}
		
		static readonly int bHasBlueprintClasses__Offset;
		public bool bHasBlueprintClasses
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBlueprintClasses__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHasBlueprintClasses__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Objects__Offset;
		public TObjectArray<UObject>  Objects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Objects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Objects__Offset, false);}
			
		}
		
		static readonly int bUseWeakReferences__Offset;
		public bool bUseWeakReferences
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseWeakReferences__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsFullyLoaded__Offset;
		public bool bIsFullyLoaded
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFullyLoaded__Offset, 1, 0, 1, 255);}
			
		}
		
		static UObjectLibrary()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ObjectLibrary");
			ObjectBaseClass__Offset=GetPropertyOffset(NativeClassPtr,"ObjectBaseClass");
			bHasBlueprintClasses__Offset=GetPropertyOffset(NativeClassPtr,"bHasBlueprintClasses");
			Objects__Offset=GetPropertyOffset(NativeClassPtr,"Objects");
			bUseWeakReferences__Offset=GetPropertyOffset(NativeClassPtr,"bUseWeakReferences");
			bIsFullyLoaded__Offset=GetPropertyOffset(NativeClassPtr,"bIsFullyLoaded");
			
		}
		
	}
	
}
#endif
#endif
