using System;
namespace UnrealEngine
{
	public partial class UUserInterfaceSettings:UDeveloperSettings
	{
		/// <summary>Widget to use when the Default Cursor is requested.</summary>
		public FStringClassReference DefaultCursor;
		
		/// <summary>Widget to use when the TextEditBeam Cursor is requested.</summary>
		public FStringClassReference TextEditBeamCursor;
		
		/// <summary>Widget to use when the Crosshairs Cursor is requested.</summary>
		public FStringClassReference CrosshairsCursor;
		
		/// <summary>Widget to use when the Hand Cursor is requested.</summary>
		public FStringClassReference HandCursor;
		
		/// <summary>Widget to use when the GrabHand Cursor is requested.</summary>
		public FStringClassReference GrabHandCursor;
		
		/// <summary>Widget to use when the GrabHandClosed Cursor is requested.</summary>
		public FStringClassReference GrabHandClosedCursor;
		
		/// <summary>Widget to use when the SlashedCircle Cursor is requested.</summary>
		public FStringClassReference SlashedCircleCursor;
		
		/// <summary>An optional application scale to apply on top of the custom scaling rules.  So if you want to expose a property in your game title, you can modify this underlying value to scale the entire UI.</summary>
		public float ApplicationScale;
		
		/// <summary>Set DPI Scale Rule to Custom, and this class will be used instead of any of the built-in rules.</summary>
		public FStringClassReference CustomScalingRuleClass;
		
		/// <summary>Controls how the UI is scaled at different resolutions based on the DPI Scale Rule</summary>
		public FRuntimeFloatCurve UIScaleCurve;
		
		/// <summary>If false, widget references will be stripped during cook for server builds and not loaded at runtime.</summary>
		public bool bLoadWidgetsOnDedicatedServer;
		
		public UClass CustomScalingRuleClassInstance;
		
		public UDPICustomScalingRule CustomScalingRule;
		
		
	}
	
}
