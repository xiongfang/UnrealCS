#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for tracks that animate an object property</summary>
	public partial class UMovieScenePropertyTrack
	{
		static readonly int PropertyName__Offset;
		/// <summary>Name of the property being changed</summary>
		public FName PropertyName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PropertyName__Offset, typeof(FName));}
			
		}
		
		static readonly int PropertyPath__Offset;
		/// <summary>Path to the property from the source object being changed</summary>
		public FString PropertyPath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+PropertyPath__Offset, typeof(FString));}
			
		}
		
		static readonly int Sections__Offset;
		/// <summary>All the sections in this list</summary>
		public TObjectArray<UMovieSceneSection>  Sections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sections__Offset, false);}
			
		}
		
		static UMovieScenePropertyTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieScenePropertyTrack");
			PropertyName__Offset=GetPropertyOffset(NativeClassPtr,"PropertyName");
			PropertyPath__Offset=GetPropertyOffset(NativeClassPtr,"PropertyPath");
			Sections__Offset=GetPropertyOffset(NativeClassPtr,"Sections");
			
		}
		
	}
	
}
#endif
#endif
