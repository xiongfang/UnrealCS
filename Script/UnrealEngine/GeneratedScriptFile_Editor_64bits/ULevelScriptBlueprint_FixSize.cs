#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A level blueprint is a specialized type of blueprint. It is used to house
	/// global, level-wide logic. In a level blueprint, you can operate on specific
	/// level-actor instances through blueprint's node-based interface. UE3 users
	/// should be familiar with this concept, as it is very similar to Kismet.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Blueprints/UserGuide/Types/LevelBlueprint/index.html
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Blueprints/index.html
	/// @see UBlueprint
	/// @see ALevelScriptActor
	/// </summary>
	public partial class ULevelScriptBlueprint
	{
		static readonly int FriendlyName__Offset;
		/// <summary>The friendly name to use for UI</summary>
		public FString FriendlyName
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+FriendlyName__Offset, typeof(FString));}
			
		}
		
		static ULevelScriptBlueprint()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelScriptBlueprint");
			FriendlyName__Offset=GetPropertyOffset(NativeClassPtr,"FriendlyName");
			
		}
		
	}
	
}
#endif
#endif
