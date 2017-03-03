using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetTextLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Format(IntPtr _this,string InPattern,FFormatArgumentData[] InArgs);
/// <summary>Used for formatting text using the FText::Format function and utilized by the UK2Node_FormatText</summary>
public static string Format(string InPattern,FFormatArgumentData[] InArgs)
{
	string ___ret = Format(IntPtr.Zero,InPattern,InArgs);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsTimespan_Timespan(IntPtr _this,ref FTimespan InTimespan);
/// <summary>Converts a passed in time span to a text, formatted as a time span</summary>
public static string AsTimespan_Timespan(FTimespan InTimespan)
{
	string ___ret = AsTimespan_Timespan(IntPtr.Zero,ref InTimespan);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsTimeZoneTime_DateTime(IntPtr _this,ref FDateTime InDateTime,string InTimeZone);
/// <summary>Converts a passed in date & time to a text, formatted as a time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
public static string AsTimeZoneTime_DateTime(FDateTime InDateTime,string InTimeZone)
{
	string ___ret = AsTimeZoneTime_DateTime(IntPtr.Zero,ref InDateTime,InTimeZone);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsTime_DateTime(IntPtr _this,ref FDateTime In);
/// <summary>Converts a passed in date & time to a text, formatted as a time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
public static string AsTime_DateTime(FDateTime In)
{
	string ___ret = AsTime_DateTime(IntPtr.Zero,ref In);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsTimeZoneDateTime_DateTime(IntPtr _this,ref FDateTime InDateTime,string InTimeZone);
/// <summary>Converts a passed in date & time to a text, formatted as a date & time using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
public static string AsTimeZoneDateTime_DateTime(FDateTime InDateTime,string InTimeZone)
{
	string ___ret = AsTimeZoneDateTime_DateTime(IntPtr.Zero,ref InDateTime,InTimeZone);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsDateTime_DateTime(IntPtr _this,ref FDateTime In);
/// <summary>Converts a passed in date & time to a text, formatted as a date & time using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
public static string AsDateTime_DateTime(FDateTime In)
{
	string ___ret = AsDateTime_DateTime(IntPtr.Zero,ref In);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsTimeZoneDate_DateTime(IntPtr _this,ref FDateTime InDateTime,string InTimeZone);
/// <summary>Converts a passed in date & time to a text, formatted as a date using the given timezone (default is the local timezone). This will convert the given date & time from UTC to the given timezone (taking into account DST).</summary>
public static string AsTimeZoneDate_DateTime(FDateTime InDateTime,string InTimeZone)
{
	string ___ret = AsTimeZoneDate_DateTime(IntPtr.Zero,ref InDateTime,InTimeZone);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsDate_DateTime(IntPtr _this,ref FDateTime InDateTime);
/// <summary>Converts a passed in date & time to a text, formatted as a date using an invariant timezone. This will use the given date & time as-is, so it's assumed to already be in the correct timezone.</summary>
public static string AsDate_DateTime(FDateTime InDateTime)
{
	string ___ret = AsDate_DateTime(IntPtr.Zero,ref InDateTime);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsPercent_Float(IntPtr _this,float Value,int RoundingMode,int bUseGrouping,int MinimumIntegralDigits,int MaximumIntegralDigits,int MinimumFractionalDigits,int MaximumFractionalDigits);
/// <summary>Converts a passed in float to a text, formatted as a percent</summary>
public static string AsPercent_Float(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3)
{
	string ___ret = AsPercent_Float(IntPtr.Zero,Value,(int)RoundingMode,bUseGrouping?1:0,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsCurrency_Float(IntPtr _this,float Value,int RoundingMode,int bUseGrouping,int MinimumIntegralDigits,int MaximumIntegralDigits,int MinimumFractionalDigits,int MaximumFractionalDigits,string CurrencyCode);
/// <summary>Converts a passed in float to a text formatted as a currency</summary>
public static string AsCurrency_Float(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,string CurrencyCode=default(string))
{
	string ___ret = AsCurrency_Float(IntPtr.Zero,Value,(int)RoundingMode,bUseGrouping?1:0,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits,CurrencyCode);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsCurrency_Integer(IntPtr _this,int Value,int RoundingMode,int bUseGrouping,int MinimumIntegralDigits,int MaximumIntegralDigits,int MinimumFractionalDigits,int MaximumFractionalDigits,string CurrencyCode);
/// <summary>Converts a passed in integer to a text formatted as a currency</summary>
public static string AsCurrency_Integer(int Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3,string CurrencyCode=default(string))
{
	string ___ret = AsCurrency_Integer(IntPtr.Zero,Value,(int)RoundingMode,bUseGrouping?1:0,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits,CurrencyCode);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string AsCurrencyBase(IntPtr _this,int BaseValue,string CurrencyCode);
/// <summary>
/// Generate an FText that represents the passed number as currency in the current culture.
/// BaseVal is specified in the smallest fractional value of the currency and will be converted for formatting according to the selected culture.
/// Keep in mind the CurrencyCode is completely independent of the culture it's displayed in (and they do not imply one another).
/// For example: FText::AsCurrencyBase(650, TEXT("EUR")); would return an FText of "<EUR>6.50" in most English cultures (en_US/en_UK) and "6,50<EUR>" in Spanish (es_ES) (where <EUR> is U+20AC)
/// </summary>
public static string AsCurrencyBase(int BaseValue,string CurrencyCode)
{
	string ___ret = AsCurrencyBase(IntPtr.Zero,BaseValue,CurrencyCode);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_FloatToText(IntPtr _this,float Value,int RoundingMode,int bUseGrouping,int MinimumIntegralDigits,int MaximumIntegralDigits,int MinimumFractionalDigits,int MaximumFractionalDigits);
/// <summary>Converts a passed in float to a text based on formatting options</summary>
public static string Conv_FloatToText(float Value,ERoundingMode RoundingMode,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324,int MinimumFractionalDigits=0,int MaximumFractionalDigits=3)
{
	string ___ret = Conv_FloatToText(IntPtr.Zero,Value,(int)RoundingMode,bUseGrouping?1:0,MinimumIntegralDigits,MaximumIntegralDigits,MinimumFractionalDigits,MaximumFractionalDigits);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_IntToText(IntPtr _this,int Value,int bUseGrouping,int MinimumIntegralDigits,int MaximumIntegralDigits);
/// <summary>Converts a passed in integer to a text based on formatting options</summary>
public static string Conv_IntToText(int Value,bool bUseGrouping=true,int MinimumIntegralDigits=1,int MaximumIntegralDigits=324)
{
	string ___ret = Conv_IntToText(IntPtr.Zero,Value,bUseGrouping?1:0,MinimumIntegralDigits,MaximumIntegralDigits);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ByteToText(IntPtr _this,int Value);
/// <summary>Converts a byte value to text</summary>
public static string Conv_ByteToText(byte Value)
{
	string ___ret = Conv_ByteToText(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_BoolToText(IntPtr _this,int InBool);
/// <summary>Converts a boolean value to text, either 'true' or 'false'</summary>
public static string Conv_BoolToText(bool InBool)
{
	string ___ret = Conv_BoolToText(IntPtr.Zero,InBool?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_IgnoreCase_TextText(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are linguistically not equal (A != B), ignoring case.</summary>
public static bool NotEqual_IgnoreCase_TextText(string A,string B)
{
	int ___ret = NotEqual_IgnoreCase_TextText(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_TextText(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are linguistically not equal (A != B).</summary>
public static bool NotEqual_TextText(string A,string B)
{
	int ___ret = NotEqual_TextText(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_IgnoreCase_TextText(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are linguistically equal (A == B), ignoring case.</summary>
public static bool EqualEqual_IgnoreCase_TextText(string A,string B)
{
	int ___ret = EqualEqual_IgnoreCase_TextText(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_TextText(IntPtr _this,string A,string B);
/// <summary>Returns true if A and B are linguistically equal (A == B).</summary>
public static bool EqualEqual_TextText(string A,string B)
{
	int ___ret = EqualEqual_TextText(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FindTextInLocalizationTable(IntPtr _this,string Namespace,string Key,out string OutText);
/// <summary>Attempts to find existing Text using the representation found in the loc tables for the specified namespace and key.</summary>
public static bool FindTextInLocalizationTable(string Namespace,string Key,out string OutText)
{
	int ___ret = FindTextInLocalizationTable(IntPtr.Zero,Namespace,Key,out OutText);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetEmptyText(IntPtr _this);
/// <summary>Returns an empty piece of text.</summary>
public static string GetEmptyText()
{
	string ___ret = GetEmptyText(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TextTrimPrecedingAndTrailing(IntPtr _this,string InText);
/// <summary>Removes whitespace characters from the front and end of the text.</summary>
public static string TextTrimPrecedingAndTrailing(string InText)
{
	string ___ret = TextTrimPrecedingAndTrailing(IntPtr.Zero,InText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TextTrimTrailing(IntPtr _this,string InText);
/// <summary>Removes trailing whitespace characters.</summary>
public static string TextTrimTrailing(string InText)
{
	string ___ret = TextTrimTrailing(IntPtr.Zero,InText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TextTrimPreceding(IntPtr _this,string InText);
/// <summary>Removes whitespace characters from the front of the text.</summary>
public static string TextTrimPreceding(string InText)
{
	string ___ret = TextTrimPreceding(IntPtr.Zero,InText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int TextIsCultureInvariant(IntPtr _this,string InText);
/// <summary>Returns true if text is culture invariant.</summary>
public static bool TextIsCultureInvariant(string InText)
{
	int ___ret = TextIsCultureInvariant(IntPtr.Zero,InText);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int TextIsTransient(IntPtr _this,string InText);
/// <summary>Returns true if text is transient.</summary>
public static bool TextIsTransient(string InText)
{
	int ___ret = TextIsTransient(IntPtr.Zero,InText);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int TextIsEmpty(IntPtr _this,string InText);
/// <summary>Returns true if text is empty.</summary>
public static bool TextIsEmpty(string InText)
{
	int ___ret = TextIsEmpty(IntPtr.Zero,InText);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_NameToText(IntPtr _this,string InName);
/// <summary>Converts string to localizable text</summary>
public static string Conv_NameToText(string InName)
{
	string ___ret = Conv_NameToText(IntPtr.Zero,InName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_StringToText(IntPtr _this,string InString);
/// <summary>Converts string to localizable text</summary>
public static string Conv_StringToText(string InString)
{
	string ___ret = Conv_StringToText(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_TextToString(IntPtr _this,string InText);
/// <summary>Converts localizable text to the string</summary>
public static string Conv_TextToString(string InText)
{
	string ___ret = Conv_TextToString(IntPtr.Zero,InText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ColorToText(IntPtr _this,ref FLinearColor InColor);
/// <summary>Converts a linear color value to a localizable text, in the form '(R=,G=,B=,A=)'</summary>
public static string Conv_ColorToText(FLinearColor InColor)
{
	string ___ret = Conv_ColorToText(IntPtr.Zero,ref InColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ObjectToText(IntPtr _this,IntPtr InObj);
/// <summary>Converts a UObject value to a localizable text by calling the object's GetName method</summary>
public static string Conv_ObjectToText(UObject InObj)
{
	string ___ret = Conv_ObjectToText(IntPtr.Zero,InObj);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_TransformToText(IntPtr _this,ref FTransform InTrans);
/// <summary>Converts a transform value to a localizable text, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
public static string Conv_TransformToText(FTransform InTrans)
{
	string ___ret = Conv_TransformToText(IntPtr.Zero,ref InTrans);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_RotatorToText(IntPtr _this,ref FRotator InRot);
/// <summary>Converts a rotator value to a localizable text, in the form 'P= Y= R='</summary>
public static string Conv_RotatorToText(FRotator InRot)
{
	string ___ret = Conv_RotatorToText(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_Vector2dToText(IntPtr _this,ref FVector2D InVec);
/// <summary>Converts a vector2d value to a localizable text, in the form 'X= Y='</summary>
public static string Conv_Vector2dToText(FVector2D InVec)
{
	string ___ret = Conv_Vector2dToText(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_VectorToText(IntPtr _this,ref FVector InVec);
/// <summary>Converts a vector value to a localizable text, in the form 'X= Y= Z='</summary>
public static string Conv_VectorToText(FVector InVec)
{
	string ___ret = Conv_VectorToText(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
