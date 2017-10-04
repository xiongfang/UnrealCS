using System;
namespace UnrealEngine
{
	public partial class UAnimCompress:UObject
	{
		/// <summary>Name of Compression Scheme used for this asset</summary>
		public FString Description;
		
		/// <summary>Compression algorithms requiring a skeleton should set this value to true.</summary>
		public bool bNeedsSkeleton;
		
		/// <summary>Format for bitwise compression of translation data.</summary>
		public AnimationCompressionFormat TranslationCompressionFormat;
		
		/// <summary>Format for bitwise compression of rotation data.</summary>
		public AnimationCompressionFormat RotationCompressionFormat;
		
		/// <summary>Format for bitwise compression of scale data.</summary>
		public AnimationCompressionFormat ScaleCompressionFormat;
		
		
	}
	
}
