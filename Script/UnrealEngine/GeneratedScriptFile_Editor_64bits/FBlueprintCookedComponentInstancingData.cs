#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Cooked data for a Blueprint component template.</summary>
	[StructLayout(LayoutKind.Explicit,Size=88)]
	public partial struct FBlueprintCookedComponentInstancingData
	{
		/// <summary>Flag indicating whether or not this contains valid cooked data. Note that an empty changed property list can also be a valid template data context.</summary>
		public bool bIsValid
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>List of property info records with values that differ between the template and the component class CDO. This list will be generated at cook time.</summary>
		public TStructArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBlueprintComponentChangedPropertyInfo>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
