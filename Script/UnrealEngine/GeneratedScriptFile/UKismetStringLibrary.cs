using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetStringLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TimeSecondsToString(IntPtr _this,float InSeconds);
/// <summary>Convert a number of seconds into minutes:seconds.milliseconds format string</summary>
public static string TimeSecondsToString(float InSeconds)
{
	string ___ret = TimeSecondsToString(IntPtr.Zero,InSeconds);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Mid(IntPtr _this,string SourceString,int Start,int Count);
/// <summary>@return the substring from Start position for Count characters.</summary>
public static string Mid(string SourceString,int Start,int Count)
{
	string ___ret = Mid(IntPtr.Zero,SourceString,Start,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string RightChop(IntPtr _this,string SourceString,int Count);
/// <summary>@return the string to the right of the specified location, counting forward from the left (from the beginning of the word).</summary>
public static string RightChop(string SourceString,int Count)
{
	string ___ret = RightChop(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Right(IntPtr _this,string SourceString,int Count);
/// <summary>@return the string to the right of the specified location, counting back from the right (end of the word).</summary>
public static string Right(string SourceString,int Count)
{
	string ___ret = Right(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string LeftChop(IntPtr _this,string SourceString,int Count);
/// <summary>@return the left most characters from the string chopping the given number of characters from the end</summary>
public static string LeftChop(string SourceString,int Count)
{
	string ___ret = LeftChop(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Left(IntPtr _this,string SourceString,int Count);
/// <summary>@return the left most given number of characters</summary>
public static string Left(string SourceString,int Count)
{
	string ___ret = Left(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Split(IntPtr _this,string SourceString,string InStr,out string LeftS,out string RightS,int SearchCase,int SearchDir);
/// <summary>
/// Splits this string at given string position case sensitive.
/// @param InStr The string to search and split at
/// @param LeftS out the string to the left of InStr, not updated if return is false
/// @param RightS out the string to the right of InStr, not updated if return is false
/// @param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
/// @return true if string is split, otherwise false
/// </summary>
public static bool Split(string SourceString,string InStr,out string LeftS,out string RightS,ESearchCase SearchCase=ESearchCase.IgnoreCase,ESearchDir SearchDir=ESearchDir.FromStart)
{
	int ___ret = Split(IntPtr.Zero,SourceString,InStr,out LeftS,out RightS,(int)SearchCase,(int)SearchDir);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ReplaceInline(IntPtr _this,out string SourceString,string SearchText,string ReplacementText,int SearchCase);
/// <summary>
/// Replace all occurrences of SearchText with ReplacementText in this string.
/// @param       SearchText      the text that should be removed from this string
/// @param       ReplacementText         the text to insert in its place
/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @return      the number of occurrences of SearchText that were replaced.
/// </summary>
public static int ReplaceInline(out string SourceString,string SearchText,string ReplacementText,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = ReplaceInline(IntPtr.Zero,out SourceString,SearchText,ReplacementText,(int)SearchCase);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Replace(IntPtr _this,string SourceString,string From,string To,int SearchCase);
/// <summary>
/// Replace all occurrences of a substring in this string
/// @param From substring to replace
/// @param To substring to replace From with
/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @return a copy of this string with the replacement made
/// </summary>
public static string Replace(string SourceString,string From,string To,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	string ___ret = Replace(IntPtr.Zero,SourceString,From,To,(int)SearchCase);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Reverse(IntPtr _this,string SourceString);
/// <summary>Returns a copy of this string, with the characters in reverse order</summary>
public static string Reverse(string SourceString)
{
	string ___ret = Reverse(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CullArray(IntPtr _this,string SourceString,out FString[] InArray);
/// <summary>
/// Takes an array of strings and removes any zero length entries.
/// @param       InArray The array to cull
/// @return      The number of elements left in InArray
/// </summary>
public static int CullArray(string SourceString,out FString[] InArray)
{
	int ___ret = CullArray(IntPtr.Zero,SourceString,out InArray);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TrimTrailing(IntPtr _this,string SourceString);
/// <summary>Removes trailing whitespace characters</summary>
public static string TrimTrailing(string SourceString)
{
	string ___ret = TrimTrailing(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Trim(IntPtr _this,string SourceString);
/// <summary>Removes whitespace characters from the front of this string.</summary>
public static string Trim(string SourceString)
{
	string ___ret = Trim(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int MatchesWildcard(IntPtr _this,string SourceString,string Wildcard,int SearchCase);
/// <summary>
/// Searches this string for a given wild card
/// @param Wildcard              *?-type wildcard
/// @param SearchCase    Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @return true if this string matches the *?-type wildcard given.
/// @warning This is a simple, SLOW routine. Use with caution
/// </summary>
public static bool MatchesWildcard(string SourceString,string Wildcard,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = MatchesWildcard(IntPtr.Zero,SourceString,Wildcard,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EndsWith(IntPtr _this,string SourceString,string InSuffix,int SearchCase);
/// <summary>
/// Test whether this string ends with given string.
/// @param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @return true if this string ends with specified text, false otherwise
/// </summary>
public static bool EndsWith(string SourceString,string InSuffix,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = EndsWith(IntPtr.Zero,SourceString,InSuffix,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int StartsWith(IntPtr _this,string SourceString,string InPrefix,int SearchCase);
/// <summary>
/// Test whether this string starts with given string.
/// @param SearchCase            Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @return true if this string begins with specified text, false otherwise
/// </summary>
public static bool StartsWith(string SourceString,string InPrefix,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = StartsWith(IntPtr.Zero,SourceString,InPrefix,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsNumeric(IntPtr _this,string SourceString);
/// <summary>
/// * Checks if a string contains only numeric characters
/// * @param       SourceString    The string to check
/// * @return true if the string only contains numeric characters
/// </summary>
public static bool IsNumeric(string SourceString)
{
	int ___ret = IsNumeric(IntPtr.Zero,SourceString);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string RightPad(IntPtr _this,string SourceString,int ChCount);
/// <summary>
/// * Pad the right of this string for a specified number of characters
/// * @param       SourceString    The string to pad
/// * @param       ChCount                 Amount of padding required
/// * @return      The padded string
/// </summary>
public static string RightPad(string SourceString,int ChCount)
{
	string ___ret = RightPad(IntPtr.Zero,SourceString,ChCount);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string LeftPad(IntPtr _this,string SourceString,int ChCount);
/// <summary>
/// * Pad the left of this string for a specified number of characters
/// * @param       SourceString    The string to pad
/// * @param       ChCount                 Amount of padding required
/// * @return      The padded string
/// </summary>
public static string LeftPad(string SourceString,int ChCount)
{
	string ___ret = LeftPad(IntPtr.Zero,SourceString,ChCount);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string ToLower(IntPtr _this,string SourceString);
/// <summary>
/// Returns a string converted to Lower case
/// @param        SourceString    The string to convert
/// @return       The string in lower case
/// </summary>
public static string ToLower(string SourceString)
{
	string ___ret = ToLower(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string ToUpper(IntPtr _this,string SourceString);
/// <summary>
/// Returns a string converted to Upper case
/// @param       SourceString    The string to convert
/// @return      The string in upper case
/// </summary>
public static string ToUpper(string SourceString)
{
	string ___ret = ToUpper(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FString[] GetCharacterArrayFromString(IntPtr _this,string SourceString);
/// <summary>
/// Returns an array that contains one entry for each character in SourceString
/// @param        SourceString    The string to break apart into characters
/// @return       An array containing one entry for each character in SourceString
/// </summary>
public static FString[] GetCharacterArrayFromString(string SourceString)
{
	FString[] ___ret = GetCharacterArrayFromString(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string JoinStringArray(IntPtr _this,FString[] SourceArray,string Separator);
/// <summary>
/// Concatenates an array of strings into a single string.
/// @param SourceArray - The array of strings to concatenate.
/// @param Separator - The string used to separate each element.
/// @return The final, joined, separated string.
/// </summary>
public static string JoinStringArray(FString[] SourceArray,string Separator=" ")
{
	string ___ret = JoinStringArray(IntPtr.Zero,SourceArray,Separator);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FString[] ParseIntoArray(IntPtr _this,string SourceString,string Delimiter,int CullEmptyStrings);
/// <summary>
/// Gets an array of strings from a source string divided up by a separator and empty strings can optionally be culled.
/// @param SourceString - The string to chop up
/// @param Delimiter - The string to delimit on
/// @param CullEmptyStrings = true - Cull (true) empty strings or add them to the array (false)
/// @return The array of string that have been separated
/// </summary>
public static FString[] ParseIntoArray(string SourceString,string Delimiter=" ",bool CullEmptyStrings=true)
{
	FString[] ___ret = ParseIntoArray(IntPtr.Zero,SourceString,Delimiter,CullEmptyStrings?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCharacterAsNumber(IntPtr _this,string SourceString,int Index);
/// <summary>
/// Gets a single character from the string (as an integer)
/// @param SourceString - The string to convert
/// @param Index - Location of the character whose value is required
/// @return The integer value of the character or 0 if index is out of range
/// </summary>
public static int GetCharacterAsNumber(string SourceString,int Index=0)
{
	int ___ret = GetCharacterAsNumber(IntPtr.Zero,SourceString,Index);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Contains(IntPtr _this,string SearchIn,string Substring,int bUseCase,int bSearchFromEnd);
/// <summary>
/// Returns whether this string contains the specified substring.
/// @param SubStr                 Find to search for
/// @param SearchCase             Indicates whether the search is case sensitive or not ( defaults to ESearchCase::IgnoreCase )
/// @param SearchDir                      Indicates whether the search starts at the begining or at the end ( defaults to ESearchDir::FromStart )
/// @return                                       Returns whether the string contains the substring
/// </summary>
public static bool Contains(string SearchIn,string Substring,bool bUseCase=false,bool bSearchFromEnd=false)
{
	int ___ret = Contains(IntPtr.Zero,SearchIn,Substring,bUseCase?1:0,bSearchFromEnd?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FindSubstring(IntPtr _this,string SearchIn,string Substring,int bUseCase,int bSearchFromEnd,int StartPosition);
/// <summary>
/// Finds the starting index of a substring in the a specified string
/// @param SearchIn The string to search within
/// @param Substring The string to look for in the SearchIn string
/// @param bUseCase Whether or not to be case-sensitive
/// @param bSearchFromEnd Whether or not to start the search from the end of the string instead of the beginning
/// @param StartPosition The position to start the search from
/// @return The index (starting from 0 if bSearchFromEnd is false) of the first occurence of the substring
/// </summary>
public static int FindSubstring(string SearchIn,string Substring,bool bUseCase=false,bool bSearchFromEnd=false,int StartPosition=-1)
{
	int ___ret = FindSubstring(IntPtr.Zero,SearchIn,Substring,bUseCase?1:0,bSearchFromEnd?1:0,StartPosition);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetSubstring(IntPtr _this,string SourceString,int StartIndex,int Length);
/// <summary>
/// Returns a substring from the string starting at the specified position
/// @param SourceString - The string to get the substring from
/// @param StartIndex - The location in SourceString to use as the start of the substring
/// @param Length The length of the requested substring
/// @return The requested substring
/// </summary>
public static string GetSubstring(string SourceString,int StartIndex=0,int Length=1)
{
	string ___ret = GetSubstring(IntPtr.Zero,SourceString,StartIndex,Length);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Len(IntPtr _this,string S);
/// <summary>
/// Returns the number of characters in the string
/// @param SourceString - The string to measure
/// @return The number of chars in the string
/// </summary>
public static int Len(string S)
{
	int ___ret = Len(IntPtr.Zero,S);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_StriStri(IntPtr _this,string A,string B);
/// <summary>
/// Test if the input string are not equal (A != B), ignoring case differences
/// @param A - The string to compare against
/// @param B - The string to compare
/// @return Returns true if the input strings are not equal, false if they are equal
/// </summary>
public static bool NotEqual_StriStri(string A,string B)
{
	int ___ret = NotEqual_StriStri(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_StrStr(IntPtr _this,string A,string B);
/// <summary>
/// Test if the input string are not equal (A != B)
/// @param A - The string to compare against
/// @param B - The string to compare
/// @return Returns true if the input strings are not equal, false if they are equal
/// </summary>
public static bool NotEqual_StrStr(string A,string B)
{
	int ___ret = NotEqual_StrStr(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_StriStri(IntPtr _this,string A,string B);
/// <summary>
/// Test if the input strings are equal (A == B), ignoring case
/// @param A - The string to compare against
/// @param B - The string to compare
/// @returns True if the strings are equal, false otherwise
/// </summary>
public static bool EqualEqual_StriStri(string A,string B)
{
	int ___ret = EqualEqual_StriStri(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_StrStr(IntPtr _this,string A,string B);
/// <summary>
/// Test if the input strings are equal (A == B)
/// @param A - The string to compare against
/// @param B - The string to compare
/// @returns True if the strings are equal, false otherwise
/// </summary>
public static bool EqualEqual_StrStr(string A,string B)
{
	int ___ret = EqualEqual_StrStr(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Concat_StrStr(IntPtr _this,string A,string B);
/// <summary>
/// Concatenates two strings together to make a new string
/// @param A - The original string
/// @param B - The string to append to A
/// @returns A new string which is the concatenation of A+B
/// </summary>
public static string Concat_StrStr(string A,string B)
{
	string ___ret = Concat_StrStr(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Name(IntPtr _this,string AppendTo,string Prefix,string InName,string Suffix);
/// <summary>
/// Converts a color->string, creating a new string in the form AppendTo+Prefix+InName+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InName - The name value to convert
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Name(string AppendTo,string Prefix,string InName,string Suffix)
{
	string ___ret = BuildString_Name(IntPtr.Zero,AppendTo,Prefix,InName,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Color(IntPtr _this,string AppendTo,string Prefix,ref FLinearColor InColor,string Suffix);
/// <summary>
/// Converts a color->string, creating a new string in the form AppendTo+Prefix+InColor+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InColor - The linear color value to convert. Uses the standard ToString conversion
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Color(string AppendTo,string Prefix,FLinearColor InColor,string Suffix)
{
	string ___ret = BuildString_Color(IntPtr.Zero,AppendTo,Prefix,ref InColor,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Object(IntPtr _this,string AppendTo,string Prefix,IntPtr InObj,string Suffix);
/// <summary>
/// Converts a object->string, creating a new string in the form AppendTo+Prefix+object name+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InObj - The object to convert. Will insert the name of the object into the conversion string
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Object(string AppendTo,string Prefix,UObject InObj,string Suffix)
{
	string ___ret = BuildString_Object(IntPtr.Zero,AppendTo,Prefix,InObj,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Rotator(IntPtr _this,string AppendTo,string Prefix,ref FRotator InRot,string Suffix);
/// <summary>
/// Converts a rotator->string, creating a new string in the form AppendTo+Prefix+InRot+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InRot - The rotator value to convert. Uses the standard ToString conversion
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Rotator(string AppendTo,string Prefix,FRotator InRot,string Suffix)
{
	string ___ret = BuildString_Rotator(IntPtr.Zero,AppendTo,Prefix,ref InRot,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Vector2d(IntPtr _this,string AppendTo,string Prefix,ref FVector2D InVector2d,string Suffix);
/// <summary>
/// Converts a vector2d->string, creating a new string in the form AppendTo+Prefix+InVector2d+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InVector2d - The vector2d value to convert. Uses the standard FVector2D::ToString conversion
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Vector2d(string AppendTo,string Prefix,FVector2D InVector2d,string Suffix)
{
	string ___ret = BuildString_Vector2d(IntPtr.Zero,AppendTo,Prefix,ref InVector2d,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Vector(IntPtr _this,string AppendTo,string Prefix,ref FVector InVector,string Suffix);
/// <summary>
/// Converts a vector->string, creating a new string in the form AppendTo+Prefix+InVector+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InVector - The vector value to convert. Uses the standard FVector::ToString conversion
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Vector(string AppendTo,string Prefix,FVector InVector,string Suffix)
{
	string ___ret = BuildString_Vector(IntPtr.Zero,AppendTo,Prefix,ref InVector,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Bool(IntPtr _this,string AppendTo,string Prefix,int InBool,string Suffix);
/// <summary>
/// Converts a boolean->string, creating a new string in the form AppendTo+Prefix+InBool+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InBool - The bool value to convert. Will add "true" or "false" to the conversion string
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Bool(string AppendTo,string Prefix,bool InBool,string Suffix)
{
	string ___ret = BuildString_Bool(IntPtr.Zero,AppendTo,Prefix,InBool?1:0,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Int(IntPtr _this,string AppendTo,string Prefix,int InInt,string Suffix);
/// <summary>
/// Converts a int->string, creating a new string in the form AppendTo+Prefix+InInt+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InInt - The int value to convert
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Int(string AppendTo,string Prefix,int InInt,string Suffix)
{
	string ___ret = BuildString_Int(IntPtr.Zero,AppendTo,Prefix,InInt,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Float(IntPtr _this,string AppendTo,string Prefix,float InFloat,string Suffix);
/// <summary>
/// Converts a float->string, create a new string in the form AppendTo+Prefix+InFloat+Suffix
/// @param AppendTo - An existing string to use as the start of the conversion string
/// @param Prefix - A string to use as a prefix, after the AppendTo string
/// @param InFloat - The float value to convert
/// @param Suffix - A suffix to append to the end of the conversion string
/// @return A new string built from the passed parameters
/// </summary>
public static string BuildString_Float(string AppendTo,string Prefix,float InFloat,string Suffix)
{
	string ___ret = BuildString_Float(IntPtr.Zero,AppendTo,Prefix,InFloat,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToColor(IntPtr _this,string InString,out FLinearColor OutConvertedColor,out int OutIsValid);
/// <summary>Convert String Back To Color. IsValid indicates whether or not the string could be successfully converted.</summary>
public static void Conv_StringToColor(string InString,out FLinearColor OutConvertedColor,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToColor(IntPtr.Zero,InString,out OutConvertedColor,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToRotator(IntPtr _this,string InString,out FRotator OutConvertedRotator,out int OutIsValid);
/// <summary>Convert String Back To Rotator. IsValid indicates whether or not the string could be successfully converted.</summary>
public static void Conv_StringToRotator(string InString,out FRotator OutConvertedRotator,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToRotator(IntPtr.Zero,InString,out OutConvertedRotator,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToVector2D(IntPtr _this,string InString,out FVector2D OutConvertedVector2D,out int OutIsValid);
/// <summary>Convert String Back To Vector2D. IsValid indicates whether or not the string could be successfully converted.</summary>
public static void Conv_StringToVector2D(string InString,out FVector2D OutConvertedVector2D,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToVector2D(IntPtr.Zero,InString,out OutConvertedVector2D,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToVector(IntPtr _this,string InString,out FVector OutConvertedVector,out int OutIsValid);
/// <summary>Convert String Back To Vector. IsValid indicates whether or not the string could be successfully converted.</summary>
public static void Conv_StringToVector(string InString,out FVector OutConvertedVector,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToVector(IntPtr.Zero,InString,out OutConvertedVector,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Conv_StringToFloat(IntPtr _this,string InString);
/// <summary>Converts a string to a float value</summary>
public static float Conv_StringToFloat(string InString)
{
	float ___ret = Conv_StringToFloat(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_StringToInt(IntPtr _this,string InString);
/// <summary>Converts a string to a int value</summary>
public static int Conv_StringToInt(string InString)
{
	int ___ret = Conv_StringToInt(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_StringToName(IntPtr _this,string InString);
/// <summary>Converts a string to a name value</summary>
public static string Conv_StringToName(string InString)
{
	string ___ret = Conv_StringToName(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_NameToString(IntPtr _this,string InName);
/// <summary>Converts a name value to a string</summary>
public static string Conv_NameToString(string InName)
{
	string ___ret = Conv_NameToString(IntPtr.Zero,InName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ColorToString(IntPtr _this,ref FLinearColor InColor);
/// <summary>Converts a linear color value to a string, in the form '(R=,G=,B=,A=)'</summary>
public static string Conv_ColorToString(FLinearColor InColor)
{
	string ___ret = Conv_ColorToString(IntPtr.Zero,ref InColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ObjectToString(IntPtr _this,IntPtr InObj);
/// <summary>Converts a UObject value to a string by calling the object's GetName method</summary>
public static string Conv_ObjectToString(UObject InObj)
{
	string ___ret = Conv_ObjectToString(IntPtr.Zero,InObj);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_TransformToString(IntPtr _this,ref FTransform InTrans);
/// <summary>Converts a transform value to a string, in the form 'Translation: X= Y= Z= Rotation: P= Y= R= Scale: X= Y= Z='</summary>
public static string Conv_TransformToString(FTransform InTrans)
{
	string ___ret = Conv_TransformToString(IntPtr.Zero,ref InTrans);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_RotatorToString(IntPtr _this,ref FRotator InRot);
/// <summary>Converts a rotator value to a string, in the form 'P= Y= R='</summary>
public static string Conv_RotatorToString(FRotator InRot)
{
	string ___ret = Conv_RotatorToString(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_Vector2dToString(IntPtr _this,ref FVector2D InVec);
/// <summary>Converts a vector2d value to a string, in the form 'X= Y='</summary>
public static string Conv_Vector2dToString(FVector2D InVec)
{
	string ___ret = Conv_Vector2dToString(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_VectorToString(IntPtr _this,ref FVector InVec);
/// <summary>Converts a vector value to a string, in the form 'X= Y= Z='</summary>
public static string Conv_VectorToString(FVector InVec)
{
	string ___ret = Conv_VectorToString(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_BoolToString(IntPtr _this,int InBool);
/// <summary>Converts a boolean value to a string, either 'true' or 'false'</summary>
public static string Conv_BoolToString(bool InBool)
{
	string ___ret = Conv_BoolToString(IntPtr.Zero,InBool?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ByteToString(IntPtr _this,int InByte);
/// <summary>Converts a byte value to a string</summary>
public static string Conv_ByteToString(byte InByte)
{
	string ___ret = Conv_ByteToString(IntPtr.Zero,InByte);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_IntToString(IntPtr _this,int InInt);
/// <summary>Converts an integer value to a string</summary>
public static string Conv_IntToString(int InInt)
{
	string ___ret = Conv_IntToString(IntPtr.Zero,InInt);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_FloatToString(IntPtr _this,float InFloat);
/// <summary>Converts a float value to a string</summary>
public static string Conv_FloatToString(float InFloat)
{
	string ___ret = Conv_FloatToString(IntPtr.Zero,InFloat);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
