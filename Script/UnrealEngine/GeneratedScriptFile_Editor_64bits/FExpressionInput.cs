#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FExpressionInput
	{
		/// <summary>UMaterial expression that this input is connected to, or NULL if not connected.</summary>
		/// <summary>Index into Expression's outputs array that this input is connected to.</summary>
		[FieldOffset(8)]
		public int OutputIndex;
		/// <summary>
		/// optional FName of the input.
		/// Note that this is the only member which is not derived from the output currently connected.
		/// </summary>
		[FieldOffset(16)]
		public FString InputName;
		[FieldOffset(32)]
		public int Mask;
		[FieldOffset(36)]
		public int MaskR;
		[FieldOffset(40)]
		public int MaskG;
		[FieldOffset(44)]
		public int MaskB;
		[FieldOffset(48)]
		public int MaskA;
		/// <summary>Material expression name that this input is connected to, or None if not connected. Used only in cooked builds</summary>
		[FieldOffset(52)]
		public FName ExpressionName;
		
	}
	
}
#endif
#endif
