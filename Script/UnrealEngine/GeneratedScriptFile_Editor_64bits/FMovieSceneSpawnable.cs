#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>MovieSceneSpawnable describes an object that can be spawned for this MovieScene</summary>
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FMovieSceneSpawnable
	{
		/// <summary>
		/// Unique identifier of the spawnable object. // @todo sequencer: Guids need to be handled carefully when the asset is duplicated (or loaded after being copied on disk).
		/// //                                     Sometimes we'll need to generate fresh Guids.
		/// </summary>
		[FieldOffset(0)]
		public FGuid Guid;
		/// <summary>Name label // @todo sequencer: Should be editor-only probably</summary>
		[FieldOffset(16)]
		public FString Name;
		/// <summary>Set of GUIDs to possessable object bindings that are bound to an object inside this spawnable // @todo sequencer: This should be a TSet, but they don't duplicate correctly atm</summary>
		public TStructArray<FGuid> ChildPossessables
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		/// <summary>Deprecated generated class</summary>
		
	}
	
}
#endif
#endif
