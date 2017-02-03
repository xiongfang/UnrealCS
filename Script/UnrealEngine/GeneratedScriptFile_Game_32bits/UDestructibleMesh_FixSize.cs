#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDestructibleMesh
	{
		static readonly int DefaultDestructibleParameters__Offset;
		public FDestructibleParameters DefaultDestructibleParameters
		{
			get{ CheckIsValid();return (FDestructibleParameters)Marshal.PtrToStructure(_this.Get()+DefaultDestructibleParameters__Offset, typeof(FDestructibleParameters));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultDestructibleParameters__Offset, false);}
			
		}
		
		static readonly int FractureEffects__Offset;
		public TStructArray<FFractureEffect> FractureEffects
		{
			get{ CheckIsValid();return new TStructArray<FFractureEffect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FractureEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FractureEffects__Offset, false);}
			
		}
		
		static UDestructibleMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DestructibleMesh");
			DefaultDestructibleParameters__Offset=GetPropertyOffset(NativeClassPtr,"DefaultDestructibleParameters");
			FractureEffects__Offset=GetPropertyOffset(NativeClassPtr,"FractureEffects");
			
		}
		
	}
	
}
#endif
#endif
