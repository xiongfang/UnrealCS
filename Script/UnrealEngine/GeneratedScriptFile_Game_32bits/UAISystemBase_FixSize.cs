#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAISystemBase
	{
		static readonly int AISystemClassName__Offset;
		public FStringClassReference AISystemClassName
		{
			get{ CheckIsValid();return (FStringClassReference)Marshal.PtrToStructure(_this.Get()+AISystemClassName__Offset, typeof(FStringClassReference));}
			
		}
		
		static readonly int AISystemModuleName__Offset;
		public FName AISystemModuleName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AISystemModuleName__Offset, typeof(FName));}
			
		}
		
		static readonly int bInstantiateAISystemOnClient__Offset;
		public bool bInstantiateAISystemOnClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInstantiateAISystemOnClient__Offset, 1, 0, 1, 255);}
			
		}
		
		static UAISystemBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AISystemBase");
			AISystemClassName__Offset=GetPropertyOffset(NativeClassPtr,"AISystemClassName");
			AISystemModuleName__Offset=GetPropertyOffset(NativeClassPtr,"AISystemModuleName");
			bInstantiateAISystemOnClient__Offset=GetPropertyOffset(NativeClassPtr,"bInstantiateAISystemOnClient");
			
		}
		
	}
	
}
#endif
#endif
