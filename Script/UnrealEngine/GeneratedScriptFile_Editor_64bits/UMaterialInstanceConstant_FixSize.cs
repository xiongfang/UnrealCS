#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Material Instances may be used to change the appearance of a material without incurring an expensive recompilation of the material.
	/// General modification of the material cannot be supported without recompilation, so the instances are limited to changing the values of
	/// predefined material parameters. The parameters are statically defined in the compiled material by a unique name, type and default value.
	/// </summary>
	public partial class UMaterialInstanceConstant
	{
		static readonly int ParameterStateId__Offset;
		/// <summary>
		/// Unique ID for this material instance's parameter set
		/// Updated on changes in the editor to allow those changes to be detected
		/// </summary>
		public FGuid ParameterStateId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+ParameterStateId__Offset, typeof(FGuid));}
			
		}
		
		static UMaterialInstanceConstant()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialInstanceConstant");
			ParameterStateId__Offset=GetPropertyOffset(NativeClassPtr,"ParameterStateId");
			
		}
		
	}
	
}
#endif
#endif
