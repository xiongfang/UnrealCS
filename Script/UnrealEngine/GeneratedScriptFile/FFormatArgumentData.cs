using System;
namespace UnrealEngine
{
	/// <summary>
	/// Used to pass argument/value pairs into FText::Format.
	/// The full C++ struct is located here: Engine\Source\Runtime\Core\Public\Internationalization\Text.h
	/// </summary>
	public partial struct FFormatArgumentData
	{
		public FString ArgumentName;
		public EFormatArgumentType ArgumentValueType;
		public FText ArgumentValue;
		public int ArgumentValueInt;
		public float ArgumentValueFloat;
		
	}
	
}
