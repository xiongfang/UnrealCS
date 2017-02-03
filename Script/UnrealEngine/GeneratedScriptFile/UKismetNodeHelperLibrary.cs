using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetNodeHelperLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetEnumeratorValueFromIndex(IntPtr _this,IntPtr Enum,int EnumeratorIndex);
/// <summary>
/// @param Enum - Enumeration
/// @param EnumeratorIndex - Input index
/// @return - The value of the enumerator, or INDEX_NONE
/// </summary>
public static byte GetEnumeratorValueFromIndex(UEnum Enum,byte EnumeratorIndex)
{
	int ___ret = GetEnumeratorValueFromIndex(IntPtr.Zero,Enum,EnumeratorIndex);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetValidValue(IntPtr _this,IntPtr Enum,int EnumeratorValue);
/// <summary>
/// @param Enum - Enumeration
/// @param EnumeratorIndex - Input value
/// @return - if EnumeratorIndex is valid return EnumeratorIndex, otherwise return MAX value of Enum
/// </summary>
public static byte GetValidValue(UEnum Enum,byte EnumeratorValue)
{
	int ___ret = GetValidValue(IntPtr.Zero,Enum,EnumeratorValue);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetEnumeratorUserFriendlyName(IntPtr _this,IntPtr Enum,int EnumeratorValue);
/// <summary>
/// Gets enumerator name as FString. Use DeisplayName when possible.
/// @param Enum - Enumeration
/// @param EnumeratorValue - Value of searched enumeration
/// @return - name of the searched enumerator, or NAME_None
/// </summary>
public static string GetEnumeratorUserFriendlyName(UEnum Enum,byte EnumeratorValue)
{
	string ___ret = GetEnumeratorUserFriendlyName(IntPtr.Zero,Enum,EnumeratorValue);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetEnumeratorName(IntPtr _this,IntPtr Enum,int EnumeratorValue);
/// <summary>
/// Gets enumerator name.
/// @param Enum - Enumeration
/// @param EnumeratorValue - Value of searched enumeration
/// @return - name of the searched enumerator, or NAME_None
/// </summary>
public static string GetEnumeratorName(UEnum Enum,byte EnumeratorValue)
{
	string ___ret = GetEnumeratorName(IntPtr.Zero,Enum,EnumeratorValue);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetFirstUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits);
/// <summary>
/// Gets the first index not already marked starting from a specific index and returns the bit index selected
/// @param Data - The integer containing the bits that are being set
/// @param StartIdx - The index to start looking for an available index from
/// @param NumBits - The logical number of bits we want to track
/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
/// </summary>
public static int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits)
{
	int ___ret = GetFirstUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetRandomUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits);
/// <summary>
/// Gets a random not already marked bit and returns the bit index selected
/// @param Data - The integer containing the bits that are being set
/// @param NumBits - The logical number of bits we want to track
/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
/// </summary>
public static int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits)
{
	int ___ret = GetRandomUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits,int bRandom);
/// <summary>
/// Gets an already unmarked bit and returns the bit index selected
/// @param Data - The integer containing the bits that are being set
/// @param StartIdx - The index to start with when determining the selection'
/// @param NumBits - The logical number of bits we want to track
/// @param bRandom - Whether to select a random index or not
/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
/// </summary>
public static int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom)
{
	int ___ret = GetUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits,bRandom?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMarkedBit(IntPtr _this,int Data,int NumBits);
/// <summary>
/// Returns whether there exists a marked bit in the data
/// @param Data - The data being tested against
/// @param NumBits - The logical number of bits we want to track
/// @return - Whether there is a bit marked in the data
/// </summary>
public static bool HasMarkedBit(int Data,int NumBits)
{
	int ___ret = HasMarkedBit(IntPtr.Zero,Data,NumBits);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasUnmarkedBit(IntPtr _this,int Data,int NumBits);
/// <summary>
/// Returns whether there exists an unmarked bit in the data
/// @param Data - The data being tested against
/// @param NumBits - The logical number of bits we want to track
/// @return - Whether there is a bit not marked in the data
/// </summary>
public static bool HasUnmarkedBit(int Data,int NumBits)
{
	int ___ret = HasUnmarkedBit(IntPtr.Zero,Data,NumBits);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearAllBits(IntPtr _this,out int Data);
/// <summary>
/// Clears all of the bit in the data
/// @param Data - The integer containing the bits that are being cleared
/// </summary>
public static void ClearAllBits(out int Data)
{
	ClearAllBits(IntPtr.Zero,out Data);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearBit(IntPtr _this,out int Data,int Index);
/// <summary>
/// Clears the bit at index "Index" in the data
/// @param Data - The integer containing the bits that are being cleared
/// @param Index - The bit index into the Data that we are clearing
/// </summary>
public static void ClearBit(out int Data,int Index)
{
	ClearBit(IntPtr.Zero,out Data,Index);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MarkBit(IntPtr _this,out int Data,int Index);
/// <summary>
/// Sets the bit at index "Index" in the data
/// @param Data - The integer containing the bits that are being set
/// @param Index - The bit index into the Data that we are setting
/// </summary>
public static void MarkBit(out int Data,int Index)
{
	MarkBit(IntPtr.Zero,out Data,Index);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BitIsMarked(IntPtr _this,int Data,int Index);
/// <summary>
/// Returns whether the bit at index "Index" is set or not in the data
/// @param Data - The integer containing the bits that are being tested against
/// @param Index - The bit index into the Data that we are inquiring
/// @return  - Whether the bit at index "Index" is set or not
/// </summary>
public static bool BitIsMarked(int Data,int Index)
{
	int ___ret = BitIsMarked(IntPtr.Zero,Data,Index);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
