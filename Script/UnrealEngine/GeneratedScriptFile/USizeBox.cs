using System;
namespace UnrealEngine
{
	public partial class USizeBox:UContentWidget
	{
		public extern void ClearMaxAspectRatio();
		public extern void SetMaxAspectRatio(float InMaxAspectRatio);
		public extern void ClearMaxDesiredHeight();
		/// <summary>When specified, will report the MaxDesiredHeight if smaller than the content's desired height.</summary>
		public extern void SetMaxDesiredHeight(float InMaxDesiredHeight);
		public extern void ClearMaxDesiredWidth();
		/// <summary>When specified, will report the MaxDesiredWidth if smaller than the content's desired width.</summary>
		public extern void SetMaxDesiredWidth(float InMaxDesiredWidth);
		public extern void ClearMinDesiredHeight();
		/// <summary>When specified, will report the MinDesiredHeight if larger than the content's desired height.</summary>
		public extern void SetMinDesiredHeight(float InMinDesiredHeight);
		public extern void ClearMinDesiredWidth();
		/// <summary>When specified, will report the MinDesiredWidth if larger than the content's desired width.</summary>
		public extern void SetMinDesiredWidth(float InMinDesiredWidth);
		public extern void ClearHeightOverride();
		/// <summary>When specified, ignore the content's desired size and report the HeightOverride as the Box's desired height.</summary>
		public extern void SetHeightOverride(float InHeightOverride);
		public extern void ClearWidthOverride();
		/// <summary>When specified, ignore the content's desired size and report the WidthOverride as the Box's desired width.</summary>
		public extern void SetWidthOverride(float InWidthOverride);
		public bool bOverride_WidthOverride;
		
		public bool bOverride_HeightOverride;
		
		public bool bOverride_MinDesiredWidth;
		
		public bool bOverride_MinDesiredHeight;
		
		public bool bOverride_MaxDesiredWidth;
		
		public bool bOverride_MaxDesiredHeight;
		
		public bool bOverride_MaxAspectRatio;
		
		/// <summary>When specified, ignore the content's desired size and report the WidthOverride as the Box's desired width.</summary>
		public float WidthOverride;
		
		/// <summary>When specified, ignore the content's desired size and report the HeightOverride as the Box's desired height.</summary>
		public float HeightOverride;
		
		/// <summary>When specified, will report the MinDesiredWidth if larger than the content's desired width.</summary>
		public float MinDesiredWidth;
		
		/// <summary>When specified, will report the MinDesiredHeight if larger than the content's desired height.</summary>
		public float MinDesiredHeight;
		
		/// <summary>When specified, will report the MaxDesiredWidth if smaller than the content's desired width.</summary>
		public float MaxDesiredWidth;
		
		/// <summary>When specified, will report the MaxDesiredHeight if smaller than the content's desired height.</summary>
		public float MaxDesiredHeight;
		
		public float MaxAspectRatio;
		
		
	}
	
}
