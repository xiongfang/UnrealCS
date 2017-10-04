using System;
namespace UnrealEngine
{
	public partial struct FExpressionInput
	{
		/// <summary>UMaterial expression that this input is connected to, or NULL if not connected.</summary>
		public UMaterialExpression Expression;
		/// <summary>Index into Expression's outputs array that this input is connected to.</summary>
		public int OutputIndex;
		/// <summary>
		/// optional FName of the input.
		/// Note that this is the only member which is not derived from the output currently connected.
		/// </summary>
		public FString InputName;
		public int Mask;
		public int MaskR;
		public int MaskG;
		public int MaskB;
		public int MaskA;
		/// <summary>Material expression name that this input is connected to, or None if not connected. Used only in cooked builds</summary>
		public FName ExpressionName;
		
	}
	
}
