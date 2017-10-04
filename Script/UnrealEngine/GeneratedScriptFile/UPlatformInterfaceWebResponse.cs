using System;
namespace UnrealEngine
{
	public partial class UPlatformInterfaceWebResponse:UObject
	{
		/// <summary>@return the value for the given header (or "" if no matching header)</summary>
		public extern virtual FString GetHeaderValue(FString HeaderName);
		/// <summary>Retrieve the header and value for the given index of header/value pair</summary>
		public extern virtual void GetHeader(int HeaderIndex,out FString Header,out FString Value);
		/// <summary>@return the number of header/value pairs</summary>
		public extern virtual int GetNumHeaders();
		/// <summary>This holds the original requested URL</summary>
		public FString OriginalURL;
		
		/// <summary>Result code from the response (200=OK, 404=Not Found, etc)</summary>
		public int ResponseCode;
		
		/// <summary>A user-specified tag specified with the request</summary>
		public int Tag;
		
		/// <summary>For string results, this is the response</summary>
		public FString StringResponse;
		
		
	}
	
}
