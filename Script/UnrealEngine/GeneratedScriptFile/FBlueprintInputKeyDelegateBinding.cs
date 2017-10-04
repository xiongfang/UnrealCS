using System;
namespace UnrealEngine
{
	public partial struct FBlueprintInputKeyDelegateBinding
	{
		public FInputChord InputChord;
		public EInputEvent InputKeyEvent;
		public FName FunctionNameToBind;
		public bool bConsumeInput;
		public bool bExecuteWhenPaused;
		public bool bOverrideParentBinding;
		
	}
	
}
