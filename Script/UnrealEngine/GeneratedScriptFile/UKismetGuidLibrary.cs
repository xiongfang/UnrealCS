using System;
namespace UnrealEngine
{
	public partial class UKismetGuidLibrary:UBlueprintFunctionLibrary
	{
		/// <summary>Converts a String of format EGuidFormats to a Guid. Returns Guid OutGuid, Returns bool Success</summary>
		public extern static void Parse_StringToGuid(FString GuidString,out FGuid OutGuid,out bool Success);
		/// <summary>Converts a GUID value to a string, in the form 'A-B-C-D'</summary>
		public extern static FString Conv_GuidToString(FGuid InGuid);
		/// <summary>Returns a new unique GUID</summary>
		public extern static FGuid NewGuid();
		/// <summary>Invalidates the given GUID</summary>
		public extern static void Invalidate_Guid(out FGuid InGuid);
		/// <summary>Checks whether the given GUID is valid</summary>
		public extern static bool IsValid_Guid(FGuid InGuid);
		/// <summary>Returns true if the values are not equal (A != B)</summary>
		public extern static bool NotEqual_GuidGuid(FGuid A,FGuid B);
		/// <summary>Returns true if the values are equal (A == B)</summary>
		public extern static bool EqualEqual_GuidGuid(FGuid A,FGuid B);
		
	}
	
}
