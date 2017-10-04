using System;
namespace UnrealEngine
{
	public partial class UKismetTextLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Converts a passed in time span to a text, formatted as a time span</summary>
		public extern static FText AsTimespan_Timespan(FTimespan InTimespan);
		/// <summary>Converts a passed in date & time to a text, formatted as a time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
		public extern static FText AsTimeZoneTime_DateTime(FDateTime InDateTime,FString InTimeZone);
		/// <summary>Converts a passed in date & time to a text, formatted as a time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
		public extern static FText AsTime_DateTime(FDateTime In);
		/// <summary>Converts a passed in date & time to a text, formatted as a date & time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
		public extern static FText AsTimeZoneDateTime_DateTime(FDateTime InDateTime,FString InTimeZone);
		/// <summary>Converts a passed in date & time to a text, formatted as a date & time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
		public extern static FText AsDateTime_DateTime(FDateTime In);
		/// <summary>Converts a passed in date & time to a text, formatted as a date using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
		public extern static FText AsTimeZoneDate_DateTime(FDateTime InDateTime,FString InTimeZone);
		/// <summary>Converts a passed in date & time to a text, formatted as a date using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
		public extern static FText AsDate_DateTime(FDateTime InDateTime);
		/// <summary>Converts a passed in float to a text, formatted as a percent</summary>
		public extern static FText AsPercent_Float(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3);
		/// <summary>Converts a passed in float to a text formatted as a currency</summary>
		public extern static FText AsCurrency_Float(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,FString CurrencyCode=default(FString));
		/// <summary>Converts a passed in integer to a text formatted as a currency</summary>
		public extern static FText AsCurrency_Integer(int Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,FString CurrencyCode=default(FString));
		/// <summary>
		/// Generate an FText that represents the passed number as currency in the current culture.
		/// BaseVal is specified in the smallest fractional value of the currency and will be converted for formatting according to the selected culture.
		/// Keep in mind the CurrencyCode is completely independent of the culture it's displayed in (and they do not imply one another).
		/// For example: FText::AsCurrencyBase(650, TEXT("EUR")); would return an FText of "<EUR>6.50" in most English cultures (en_US/en_UK) and "6,50<EUR>" in Spanish (es_ES) (where <EUR> is U+20AC)
		/// </summary>
		public extern static FText AsCurrencyBase(int BaseValue,FString CurrencyCode);
		/// <summary>Converts a passed in float to a text based on formatting options</summary>
		public extern static FText Conv_FloatToText(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3);
		/// <summary>Converts a passed in integer to a text based on formatting options</summary>
		public extern static FText Conv_IntToText(int Value,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324);
		/// <summary>Converts a byte value to text</summary>
		public extern static FText Conv_ByteToText(byte Value);
		/// <summary>Converts a boolean value to text, either 'true' or 'false'</summary>
		public extern static FText Conv_BoolToText(bool InBool);
		/// <summary>Returns true if A and B are linguistically not equal (A != B), ignoring case.</summary>
		public extern static bool NotEqual_IgnoreCase_TextText(FText A,FText B);
		/// <summary>Returns true if A and B are linguistically not equal (A != B).</summary>
		public extern static bool NotEqual_TextText(FText A,FText B);
		/// <summary>Returns true if A and B are linguistically equal (A == B), ignoring case.</summary>
		public extern static bool EqualEqual_IgnoreCase_TextText(FText A,FText B);
		/// <summary>Returns true if A and B are linguistically equal (A == B).</summary>
		public extern static bool EqualEqual_TextText(FText A,FText B);
		/// <summary>Attempts to find existing Text using the representation found in the loc tables for the specified namespace and key.</summary>
		public extern static bool FindTextInLocalizationTable(FString Namespace,FString Key,out FText OutText);
		/// <summary>Returns an empty piece of text.</summary>
		public extern static FText GetEmptyText();
		/// <summary>Removes whitespace characters from the front and end of the text.</summary>
		public extern static FText TextTrimPrecedingAndTrailing(FText InText);
		/// <summary>Removes trailing whitespace characters.</summary>
		public extern static FText TextTrimTrailing(FText InText);
		/// <summary>Removes whitespace characters from the front of the text.</summary>
		public extern static FText TextTrimPreceding(FText InText);
		/// <summary>Returns true if text is culture invariant.</summary>
		public extern static bool TextIsCultureInvariant(FText InText);
		/// <summary>Returns true if text is transient.</summary>
		public extern static bool TextIsTransient(FText InText);
		/// <summary>Returns true if text is empty.</summary>
		public extern static bool TextIsEmpty(FText InText);
		/// <summary>Converts string to localizable text</summary>
		public extern static FText Conv_NameToText(FName InName);
		/// <summary>Converts string to localizable text</summary>
		public extern static FText Conv_StringToText(FString InString);
		/// <summary>Converts localizable text to the string</summary>
		public extern static FString Conv_TextToString(FText InText);
		/// <summary>Converts a linear color value to a localizable text, in the form '(R=,G=,B=,A=)'</summary>
		public extern static FText Conv_ColorToText(FLinearColor InColor);
		/// <summary>Converts a UObject value to a localizable text by calling the object's GetName method</summary>
		public extern static FText Conv_ObjectToText(UObject InObj);
		/// <summary>Converts a transform value to a localizable text, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
		public extern static FText Conv_TransformToText(FTransform InTrans);
		/// <summary>Converts a rotator value to a localizable text, in the form 'P= Y= R='</summary>
		public extern static FText Conv_RotatorToText(FRotator InRot);
		/// <summary>Converts a vector2d value to a localizable text, in the form 'X= Y='</summary>
		public extern static FText Conv_Vector2dToText(FVector2D InVec);
		/// <summary>Converts a vector value to a localizable text, in the form 'X= Y= Z='</summary>
		public extern static FText Conv_VectorToText(FVector InVec);
		
	}
	
}
