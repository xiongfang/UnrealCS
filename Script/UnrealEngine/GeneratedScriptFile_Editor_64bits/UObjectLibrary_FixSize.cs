#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Class that holds a library of Objects</summary>
	public partial class UObjectLibrary
	{
		static readonly int ObjectBaseClass__Offset;
		/// <summary>Class that Objects must be of. If ContainsBlueprints is true, this is the native class that the blueprints are instances of and not UClass</summary>
		public UClass ObjectBaseClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ObjectBaseClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + ObjectBaseClass__Offset, value); }
			
		}
		
		static readonly int bHasBlueprintClasses__Offset;
		/// <summary>True if this library holds blueprint classes, false if it holds other objects</summary>
		public bool bHasBlueprintClasses
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBlueprintClasses__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHasBlueprintClasses__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Objects__Offset;
		/// <summary>List of Objects in library</summary>
		public TObjectArray<UObject>  Objects
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Objects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Objects__Offset, false);}
			
		}
		
		static readonly int bUseWeakReferences__Offset;
		/// <summary>If this library should use weak pointers</summary>
		public bool bUseWeakReferences
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseWeakReferences__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bIsFullyLoaded__Offset;
		/// <summary>True if we've already fully loaded this library, can't do it twice</summary>
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
