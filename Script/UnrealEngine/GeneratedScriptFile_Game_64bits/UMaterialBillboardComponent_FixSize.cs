#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialBillboardComponent
	{
		static readonly int Elements__Offset;
		public TStructArray<FMaterialSpriteElement> Elements
		{
			get{ CheckIsValid();return new TStructArray<FMaterialSpriteElement>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Elements__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Elements__Offset, false);}
			
		}
		
		static UMaterialBillboardComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialBillboardComponent");
			Elements__Offset=GetPropertyOffset(NativeClassPtr,"Elements");
			
		}
		
	}
	
}
#endif
#endif
