#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneFolder
	{
		static readonly int FolderName__Offset;
		public FName FolderName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+FolderName__Offset, typeof(FName));}
			
		}
		
		static readonly int ChildFolders__Offset;
		public TObjectArray<UMovieSceneFolder>  ChildFolders
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneFolder>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildFolders__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildFolders__Offset, false);}
			
		}
		
		static readonly int ChildMasterTracks__Offset;
		public TObjectArray<UMovieSceneTrack>  ChildMasterTracks
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildMasterTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildMasterTracks__Offset, false);}
			
		}
		
		static readonly int ChildObjectBindingStrings__Offset;
		public TStructArray<FString> ChildObjectBindingStrings
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildObjectBindingStrings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildObjectBindingStrings__Offset, false);}
			
		}
		
		static UMovieSceneFolder()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneFolder");
			FolderName__Offset=GetPropertyOffset(NativeClassPtr,"FolderName");
			ChildFolders__Offset=GetPropertyOffset(NativeClassPtr,"ChildFolders");
			ChildMasterTracks__Offset=GetPropertyOffset(NativeClassPtr,"ChildMasterTracks");
			ChildObjectBindingStrings__Offset=GetPropertyOffset(NativeClassPtr,"ChildObjectBindingStrings");
			
		}
		
	}
	
}
#endif
#endif
