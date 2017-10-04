using System;
namespace UnrealEngine
{
	/// <summary>Structure for custom channel setup information.</summary>
	public partial struct FCustomChannelSetup
	{
		/// <summary>Which channel you'd like to customize *</summary>
		public ECollisionChannel Channel;
		/// <summary>Name of channel you'd like to show up *</summary>
		public FName Name;
		/// <summary>Default Response for the channel</summary>
		public ECollisionResponse DefaultResponse;
		/// <summary>Sets meta data TraceType="1" for the enum entry if true. Otherwise, this channel will be treated as object query channel, so you can query object types*</summary>
		public bool bTraceType;
		/// <summary>Specifies if this is static object. Otherwise it will be dynamic object. This is used for query all objects vs all static objects vs all dynamic objects *</summary>
		public bool bStaticObject;
		
	}
	
}
