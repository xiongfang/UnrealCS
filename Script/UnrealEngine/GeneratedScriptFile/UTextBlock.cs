using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTextBlock:UTextLayoutWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetText(IntPtr _this,string InText);
/// <summary>
/// Directly sets the widget text.
/// Warning: This will wipe any binding created for the Text property!
/// @param InText The text to assign to the widget
/// </summary>
public  void SetText(string InText)
{
	CheckIsValid();
	SetText(_this.Get(),InText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetText(IntPtr _this);
/// <summary>
/// Gets the widget text
/// @return The widget text
/// </summary>
public  string GetText()
{
	CheckIsValid();
	string ___ret = GetText(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinDesiredWidth(IntPtr _this,float InMinDesiredWidth);
/// <summary>
/// Set the minimum desired width for this text block
/// @param InMinDesiredWidth new minimum desired width
/// </summary>
public  void SetMinDesiredWidth(float InMinDesiredWidth)
{
	CheckIsValid();
	SetMinDesiredWidth(_this.Get(),InMinDesiredWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetJustification(IntPtr _this,int InJustification);
/// <summary>
/// Set the text justification for this text block
/// @param InJustification new justification
/// </summary>
public  void SetJustification(ETextJustify InJustification)
{
	CheckIsValid();
	SetJustification(_this.Get(),(int)InJustification);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFont(IntPtr _this,ref FSlateFontInfo InFontInfo);
/// <summary>
/// Dynamically set the font info for this text block
/// @param InFontInfo THe new font info
/// </summary>
public  void SetFont(FSlateFontInfo InFontInfo)
{
	CheckIsValid();
	SetFont(_this.Get(),ref InFontInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetShadowOffset(IntPtr _this,ref FVector2D InShadowOffset);
/// <summary>
/// Sets the offset that the text drop shadow should be drawn at
/// @param InShadowOffset                The new offset
/// </summary>
public  void SetShadowOffset(FVector2D InShadowOffset)
{
	CheckIsValid();
	SetShadowOffset(_this.Get(),ref InShadowOffset);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetShadowColorAndOpacity(IntPtr _this,ref FLinearColor InShadowColorAndOpacity);
/// <summary>
/// Sets the color and opacity of the text drop shadow
/// Note: if opacity is zero no shadow will be drawn
/// @param InShadowColorAndOpacity               The new drop shadow color and opacity
/// </summary>
public  void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
{
	CheckIsValid();
	SetShadowColorAndOpacity(_this.Get(),ref InShadowColorAndOpacity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOpacity(IntPtr _this,float InOpacity);
/// <summary>
/// Sets the opacity of the text in this text block
/// @param InOpacity              The new text opacity
/// </summary>
public  void SetOpacity(float InOpacity)
{
	CheckIsValid();
	SetOpacity(_this.Get(),InOpacity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColorAndOpacity(IntPtr _this,ref FSlateColor InColorAndOpacity);
/// <summary>
/// Sets the color and opacity of the text in this text block
/// @param InColorAndOpacity             The new text color and opacity
/// </summary>
public  void SetColorAndOpacity(FSlateColor InColorAndOpacity)
{
	CheckIsValid();
	SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
