using System;
namespace UnrealEngine
{
	public partial class UKismetNodeHelperLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>
		/// @param Enum - Enumeration
		/// @param EnumeratorIndex - Input index
		/// @return - The value of the enumerator, or INDEX_NONE
		/// </summary>
		public extern static byte GetEnumeratorValueFromIndex(UEnum Enum,byte EnumeratorIndex);
		/// <summary>
		/// @param Enum - Enumeration
		/// @param EnumeratorIndex - Input value
		/// @return - if EnumeratorIndex is valid return EnumeratorIndex, otherwise return MAX value of Enum
		/// </summary>
		public extern static byte GetValidValue(UEnum Enum,byte EnumeratorValue);
		/// <summary>
		/// Gets enumerator name as FString. Use DeisplayName when possible.
		/// @param Enum - Enumeration
		/// @param EnumeratorValue - Value of searched enumeration
		/// @return - name of the searched enumerator, or NAME_None
		/// </summary>
		public extern static FString GetEnumeratorUserFriendlyName(UEnum Enum,byte EnumeratorValue);
		/// <summary>
		/// Gets enumerator name.
		/// @param Enum - Enumeration
		/// @param EnumeratorValue - Value of searched enumeration
		/// @return - name of the searched enumerator, or NAME_None
		/// </summary>
		public extern static FName GetEnumeratorName(UEnum Enum,byte EnumeratorValue);
		/// <summary>
		/// Gets the first index not already marked starting from a specific index and returns the bit index selected
		/// @param Data - The integer containing the bits that are being set
		/// @param StartIdx - The index to start looking for an available index from
		/// @param NumBits - The logical number of bits we want to track
		/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </summary>
		public extern static int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits);
		/// <summary>
		/// Gets a random not already marked bit and returns the bit index selected
		/// @param Data - The integer containing the bits that are being set
		/// @param NumBits - The logical number of bits we want to track
		/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </summary>
		public extern static int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits);
		/// <summary>
		/// Gets an already unmarked bit and returns the bit index selected
		/// @param Data - The integer containing the bits that are being set
		/// @param StartIdx - The index to start with when determining the selection'
		/// @param NumBits - The logical number of bits we want to track
		/// @param bRandom - Whether to select a random index or not
		/// @return - The index that was selected (returns INDEX_NONE if there was no unmarked bits to choose from)
		/// </summary>
		public extern static int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom);
		/// <summary>
		/// Returns whether there exists a marked bit in the data
		/// @param Data - The data being tested against
		/// @param NumBits - The logical number of bits we want to track
		/// @return - Whether there is a bit marked in the data
		/// </summary>
		public extern static bool HasMarkedBit(int Data,int NumBits);
		/// <summary>
		/// Returns whether there exists an unmarked bit in the data
		/// @param Data - The data being tested against
		/// @param NumBits - The logical number of bits we want to track
		/// @return - Whether there is a bit not marked in the data
		/// </summary>
		public extern static bool HasUnmarkedBit(int Data,int NumBits);
		/// <summary>
		/// Clears all of the bit in the data
		/// @param Data - The integer containing the bits that are being cleared
		/// </summary>
		public extern static void ClearAllBits(out int Data);
		/// <summary>
		/// Clears the bit at index "Index" in the data
		/// @param Data - The integer containing the bits that are being cleared
		/// @param Index - The bit index into the Data that we are clearing
		/// </summary>
		public extern static void ClearBit(out int Data,int Index);
		/// <summary>
		/// Sets the bit at index "Index" in the data
		/// @param Data - The integer containing the bits that are being set
		/// @param Index - The bit index into the Data that we are setting
		/// </summary>
		public extern static void MarkBit(out int Data,int Index);
		/// <summary>
		/// Returns whether the bit at index "Index" is set or not in the data
		/// @param Data - The integer containing the bits that are being tested against
		/// @param Index - The bit index into the Data that we are inquiring
		/// @return  - Whether the bit at index "Index" is set or not
		/// </summary>
		public extern static bool BitIsMarked(int Data,int Index);
		
	}
	
}
