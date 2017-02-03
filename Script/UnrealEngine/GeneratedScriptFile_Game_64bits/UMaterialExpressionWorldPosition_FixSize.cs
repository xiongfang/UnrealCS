#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionWorldPosition
	{
		static readonly int WorldPositionShaderOffset__Offset;
		public EWorldPositionIncludedOffsets WorldPositionShaderOffset
		{
			get{ CheckIsValid();return (EWorldPositionIncludedOffsets)Marshal.PtrToStructure(_this.Get()+WorldPositionShaderOffset__Offset, typeof(EWorldPositionIncludedOffsets));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldPositionShaderOffset__Offset, false);}
			
		}
		
		static UMaterialExpressionWorldPosition()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionWorldPosition");
			WorldPositionShaderOffset__Offset=GetPropertyOffset(NativeClassPtr,"WorldPositionShaderOffset");
			
		}
		
	}
	
}
#endif
#endif
