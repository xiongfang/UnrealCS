using System;
namespace UnrealEngine
{
	public partial class UKismetStringLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Convert a number of seconds into minutes:seconds.milliseconds format string</summary>
		public extern static FString TimeSecondsToString(float InSeconds);
		/// <summary>@return the substring from Start position for Count characters.</summary>
		public extern static FString Mid(FString SourceString,int Start,int Count);
		/// <summary>@return the string to the right of the specified location, counting forward from the left (from the beginning of the word).</summary>
		public extern static FString RightChop(FString SourceString,int Count);
		/// <summary>@return the string to the right of the specified location, counting back from the right (end of the word).</summary>
		public extern static FString Right(FString SourceString,int Count);
		/// <summary>@return the left most characters from the string chopping the given number of characters from the end</summary>
		public extern static FString LeftChop(FString SourceString,int Count);
		/// <summary>@return the left most given number of characters</summary>
		public extern static FString Left(FString SourceString,int Count);
		/// <summary>
		/// Splits this string at given string position case sensitive.
		/// @param InStr The string to search and split at
		/// @param LeftS out the string to the left of InStr, not updated if return is false
		/// @param RightS out the string to the right of InStr, not updated if return is false
		/// @param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
		/// @return true if string is split, otherwise false
		/// </summary>
		public extern static bool Split(FString SourceString,FString InStr,out FString LeftS,out FString RightS,ESearchCase SearchCase=ESearchCase.IgnoreCase,ESearchDir SearchDir=ESearchDir.FromStart);
		/// <summary>
		/// Replace all occurrences of SearchText with ReplacementText in this string.
		/// @param       SearchText      the text that should be removed from this string
		/// @param       ReplacementText         the text to insert in its place
		/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @return      the number of occurrences of SearchText that were replaced.
		/// </summary>
		public extern static int ReplaceInline(out FString SourceString,FString SearchText,FString ReplacementText,ESearchCase SearchCase=ESearchCase.IgnoreCase);
		/// <summary>
		/// Replace all occurrences of a substring in this string
		/// @param From substring to replace
		/// @param To substring to replace From with
		/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @return a copy of this string with the replacement made
		/// </summary>
		public extern static FString Replace(FString SourceString,FString From,FString To,ESearchCase SearchCase=ESearchCase.IgnoreCase);
		/// <summary>Returns a copy of this string, with the characters in reverse order</summary>
		public extern static FString Reverse(FString SourceString);
		/// <summary>Removes trailing whitespace characters</summary>
		public extern static FString TrimTrailing(FString SourceString);
		/// <summary>Removes whitespace characters from the front of this string.</summary>
		public extern static FString Trim(FString SourceString);
		/// <summary>
		/// Searches this string for a given wild card
		/// @param Wildcard              *?-type wildcard
		/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @return true if this string matches the *?-type wildcard given.
		/// @warning This is a simple, SLOW routine. Use with caution
		/// </summary>
		public extern static bool MatchesWildcard(FString SourceString,FString Wildcard,ESearchCase SearchCase=ESearchCase.IgnoreCase);
		/// <summary>
		/// Test whether this string ends with given string.
		/// @param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @return true if this string ends with specified text, false otherwise
		/// </summary>
		public extern static bool EndsWith(FString SourceString,FString InSuffix,ESearchCase SearchCase=ESearchCase.IgnoreCase);
		/// <summary>
		/// Test whether this string starts with given string.
		/// @param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @return true if this string begins with specified text, false otherwise
		/// </summary>
		public extern static bool StartsWith(FString SourceString,FString InPrefix,ESearchCase SearchCase=ESearchCase.IgnoreCase);
		/// <summary>
		/// * Checks if a string contains only numeric characters
		/// * @param       SourceString    The string to check
		/// * @return true if the string only contains numeric characters
		/// </summary>
		public extern static bool IsNumeric(FString SourceString);
		/// <summary>
		/// * Pad the right of this string for a specified number of characters
		/// * @param       SourceString    The string to pad
		/// * @param       ChCount                 Amount of padding required
		/// * @return      The padded string
		/// </summary>
		public extern static FString RightPad(FString SourceString,int ChCount);
		/// <summary>
		/// * Pad the left of this string for a specified number of characters
		/// * @param       SourceString    The string to pad
		/// * @param       ChCount                 Amount of padding required
		/// * @return      The padded string
		/// </summary>
		public extern static FString LeftPad(FString SourceString,int ChCount);
		/// <summary>
		/// Returns a string converted to Lower case
		/// @param        SourceString    The string to convert
		/// @return       The string in lower case
		/// </summary>
		public extern static FString ToLower(FString SourceString);
		/// <summary>
		/// Returns a string converted to Upper case
		/// @param       SourceString    The string to convert
		/// @return      The string in upper case
		/// </summary>
		public extern static FString ToUpper(FString SourceString);
		/// <summary>
		/// Gets a single character from the string (as an integer)
		/// @param SourceString - The string to convert
		/// @param Index - Location of the character whose value is required
		/// @return The integer value of the character or 0 if index is out of range
		/// </summary>
		public extern static int GetCharacterAsNumber(FString SourceString,int Index=0);
		/// <summary>
		/// Returns whether this string contains the specified substring.
		/// @param SubStr                 Find to search for
		/// @param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
		/// @param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
		/// @return                                       Returns whether the string contains the substring
		/// </summary>
		public extern static bool Contains(FString SearchIn,FString Substring,bool bUseCase=false,bool bSearchFromEnd=false);
		/// <summary>
		/// Finds the starting index of a substring in the a specified string
		/// @param SearchIn The string to search within
		/// @param Substring The string to look for in the SearchIn string
		/// @param bUseCase Whether or not to be case-sensitive
		/// @param bSearchFromEnd Whether or not to start the search from the end of the string instead of the beginning
		/// @param StartPosition The position to start the search from
		/// @return The index (starting from 0 if bSearchFromEnd is false) of the first occurence of the substring
		/// </summary>
		public extern static int FindSubstring(FString SearchIn,FString Substring,bool bUseCase=false,bool bSearchFromEnd=false,int StartPosition=-1);
		/// <summary>
		/// Returns a substring from the string starting at the specified position
		/// @param SourceString - The string to get the substring from
		/// @param StartIndex - The location in SourceString to use as the start of the substring
		/// @param Length The length of the requested substring
		/// @return The requested substring
		/// </summary>
		public extern static FString GetSubstring(FString SourceString,int StartIndex=0,int Length=1);
		/// <summary>
		/// Returns the number of characters in the string
		/// @param SourceString - The string to measure
		/// @return The number of chars in the string
		/// </summary>
		public extern static int Len(FString S);
		/// <summary>
		/// Test if the input string are not equal (A != B), ignoring case differences
		/// @param A - The string to compare against
		/// @param B - The string to compare
		/// @return Returns true if the input strings are not equal, false if they are equal
		/// </summary>
		public extern static bool NotEqual_StriStri(FString A,FString B);
		/// <summary>
		/// Test if the input string are not equal (A != B)
		/// @param A - The string to compare against
		/// @param B - The string to compare
		/// @return Returns true if the input strings are not equal, false if they are equal
		/// </summary>
		public extern static bool NotEqual_StrStr(FString A,FString B);
		/// <summary>
		/// Test if the input strings are equal (A == B), ignoring case
		/// @param A - The string to compare against
		/// @param B - The string to compare
		/// @returns True if the strings are equal, false otherwise
		/// </summary>
		public extern static bool EqualEqual_StriStri(FString A,FString B);
		/// <summary>
		/// Test if the input strings are equal (A == B)
		/// @param A - The string to compare against
		/// @param B - The string to compare
		/// @returns True if the strings are equal, false otherwise
		/// </summary>
		public extern static bool EqualEqual_StrStr(FString A,FString B);
		/// <summary>
		/// Concatenates two strings together to make a new string
		/// @param A - The original string
		/// @param B - The string to append to A
		/// @returns A new string which is the concatenation of A+B
		/// </summary>
		public extern static FString Concat_StrStr(FString A,FString B);
		/// <summary>
		/// Converts a color->string, creating a new string in the form AppendTo+Prefix+InName+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InName - The name value to convert
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Name(FString AppendTo,FString Prefix,FName InName,FString Suffix);
		/// <summary>
		/// Converts a color->string, creating a new string in the form AppendTo+Prefix+InColor+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InColor - The linear color value to convert. Uses the standard ToString conversion
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Color(FString AppendTo,FString Prefix,FLinearColor InColor,FString Suffix);
		/// <summary>
		/// Converts a object->string, creating a new string in the form AppendTo+Prefix+object name+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InObj - The object to convert. Will insert the name of the object into the conversion string
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Object(FString AppendTo,FString Prefix,UObject InObj,FString Suffix);
		/// <summary>
		/// Converts a rotator->string, creating a new string in the form AppendTo+Prefix+InRot+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InRot - The rotator value to convert. Uses the standard ToString conversion
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Rotator(FString AppendTo,FString Prefix,FRotator InRot,FString Suffix);
		/// <summary>
		/// Converts a vector2d->string, creating a new string in the form AppendTo+Prefix+InVector2d+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InVector2d - The vector2d value to convert. Uses the standard FVector2D::ToString conversion
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Vector2d(FString AppendTo,FString Prefix,FVector2D InVector2d,FString Suffix);
		/// <summary>
		/// Converts an IntVector->string, creating a new string in the form AppendTo+Prefix+InIntVector+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InIntVector - The intVector value to convert. Uses the standard FVector::ToString conversion
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_IntVector(FString AppendTo,FString Prefix,FIntVector InIntVector,FString Suffix);
		/// <summary>
		/// Converts a vector->string, creating a new string in the form AppendTo+Prefix+InVector+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InVector - The vector value to convert. Uses the standard FVector::ToString conversion
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Vector(FString AppendTo,FString Prefix,FVector InVector,FString Suffix);
		/// <summary>
		/// Converts a boolean->string, creating a new string in the form AppendTo+Prefix+InBool+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InBool - The bool value to convert. Will add "true" or "false" to the conversion string
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Bool(FString AppendTo,FString Prefix,bool InBool,FString Suffix);
		/// <summary>
		/// Converts a int->string, creating a new string in the form AppendTo+Prefix+InInt+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InInt - The int value to convert
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Int(FString AppendTo,FString Prefix,int InInt,FString Suffix);
		/// <summary>
		/// Converts a float->string, create a new string in the form AppendTo+Prefix+InFloat+Suffix
		/// @param AppendTo - An existing string to use as the start of the conversion string
		/// @param Prefix - A string to use as a prefix, after the AppendTo string
		/// @param InFloat - The float value to convert
		/// @param Suffix - A suffix to append to the end of the conversion string
		/// @return A new string built from the passed parameters
		/// </summary>
		public extern static FString BuildString_Float(FString AppendTo,FString Prefix,float InFloat,FString Suffix);
		/// <summary>Convert String Back To Color. IsValid indicates whether or not the string could be successfully converted.</summary>
		public extern static void Conv_StringToColor(FString InString,out FLinearColor OutConvertedColor,out bool OutIsValid);
		/// <summary>Convert String Back To Rotator. IsValid indicates whether or not the string could be successfully converted.</summary>
		public extern static void Conv_StringToRotator(FString InString,out FRotator OutConvertedRotator,out bool OutIsValid);
		/// <summary>Convert String Back To Vector2D. IsValid indicates whether or not the string could be successfully converted.</summary>
		public extern static void Conv_StringToVector2D(FString InString,out FVector2D OutConvertedVector2D,out bool OutIsValid);
		/// <summary>Convert String Back To Vector. IsValid indicates whether or not the string could be successfully converted.</summary>
		public extern static void Conv_StringToVector(FString InString,out FVector OutConvertedVector,out bool OutIsValid);
		/// <summary>Converts a string to a float value</summary>
		public extern static float Conv_StringToFloat(FString InString);
		/// <summary>Converts a string to a int value</summary>
		public extern static int Conv_StringToInt(FString InString);
		/// <summary>Converts a string to a name value</summary>
		public extern static FName Conv_StringToName(FString InString);
		/// <summary>Converts a name value to a string</summary>
		public extern static FString Conv_NameToString(FName InName);
		/// <summary>Converts a linear color value to a string, in the form '(R=,G=,B=,A=)'</summary>
		public extern static FString Conv_ColorToString(FLinearColor InColor);
		/// <summary>Converts a UObject value to a string by calling the object's GetName method</summary>
		public extern static FString Conv_ObjectToString(UObject InObj);
		/// <summary>Converts a transform value to a string, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
		public extern static FString Conv_TransformToString(FTransform InTrans);
		/// <summary>Converts a rotator value to a string, in the form 'P= Y= R='</summary>
		public extern static FString Conv_RotatorToString(FRotator InRot);
		/// <summary>Converts a vector2d value to a string, in the form 'X= Y='</summary>
		public extern static FString Conv_Vector2dToString(FVector2D InVec);
		/// <summary>Converts an IntVector value to a string, in the form 'X= Y= Z='</summary>
		public extern static FString Conv_IntVectorToString(FIntVector InIntVec);
		/// <summary>Converts a vector value to a string, in the form 'X= Y= Z='</summary>
		public extern static FString Conv_VectorToString(FVector InVec);
		/// <summary>Converts a boolean value to a string, either 'true' or 'false'</summary>
		public extern static FString Conv_BoolToString(bool InBool);
		/// <summary>Converts a byte value to a string</summary>
		public extern static FString Conv_ByteToString(byte InByte);
		/// <summary>Converts an integer value to a string</summary>
		public extern static FString Conv_IntToString(int InInt);
		/// <summary>Converts a float value to a string</summary>
		public extern static FString Conv_FloatToString(float InFloat);
		
	}
	
}
