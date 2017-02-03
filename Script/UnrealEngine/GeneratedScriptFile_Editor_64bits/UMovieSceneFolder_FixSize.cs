#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Reprents a folder used for organizing objects in tracks in a movie scene.</summary>
	public partial class UMovieSceneFolder
	{
		static readonly int FolderName__Offset;
		/// <summary>The name of this folder.</summary>
		public FName FolderName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+FolderName__Offset, typeof(FName));}
			
		}
		
		static readonly int ChildFolders__Offset;
		/// <summary>The folders contained by this folder.</summary>
		public TObjectArray<UMovieSceneFolder>  ChildFolders
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneFolder>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildFolders__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildFolders__Offset, false);}
			
		}
		
		static readonly int ChildMasterTracks__Offset;
		/// <summary>The master tracks contained by this folder.</summary>
		public TObjectArray<UMovieSceneTrack>  ChildMasterTracks
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildMasterTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildMasterTracks__Offset, false);}
			
		}
		
		static readonly int ChildObjectBindingStrings__Offset;
		/// <summary>The guid strings used to serialize the guids for the object bindings contained by this folder.</summary>
		public TStructArray<FString> ChildObjectBindingStrings
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildObjectBindingStrings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildObjectBindingStrings__Offset, false);}
			
		}
		
		static readonly int FolderColor__Offset;
		/// <summary>This folder's color</summary>
		public FColor FolderColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+FolderColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FolderColor__Offset, false);}
			
		}
		
		static UMovieSceneFolder()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneFolder");
			FolderName__Offset=GetPropertyOffset(NativeClassPtr,"FolderName");
			ChildFolders__Offset=GetPropertyOffset(NativeClassPtr,"ChildFolders");
			ChildMasterTracks__Offset=GetPropertyOffset(NativeClassPtr,"ChildMasterTracks");
			ChildObjectBindingStrings__Offset=GetPropertyOffset(NativeClassPtr,"ChildObjectBindingStrings");
			FolderColor__Offset=GetPropertyOffset(NativeClassPtr,"FolderColor");
			
		}
		
	}
	
}
#endif
#endif
