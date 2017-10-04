using System;
namespace UnrealEngine
{
	public partial struct FAudioEQEffect
	{
		/// <summary>Center frequency in Hz for band 0</summary>
		public float FrequencyCenter0;
		/// <summary>Boost/cut of band 0</summary>
		public float Gain0;
		/// <summary>Bandwidth of band 0. Region is center frequency +/- Bandwidth /2</summary>
		public float Bandwidth0;
		/// <summary>Center frequency in Hz for band 1</summary>
		public float FrequencyCenter1;
		/// <summary>Boost/cut of band 1</summary>
		public float Gain1;
		/// <summary>Bandwidth of band 1. Region is center frequency +/- Bandwidth /2</summary>
		public float Bandwidth1;
		/// <summary>Center frequency in Hz for band 2</summary>
		public float FrequencyCenter2;
		/// <summary>Boost/cut of band 2</summary>
		public float Gain2;
		/// <summary>Bandwidth of band 2. Region is center frequency +/- Bandwidth /2</summary>
		public float Bandwidth2;
		/// <summary>Center frequency in Hz for band 3</summary>
		public float FrequencyCenter3;
		/// <summary>Boost/cut of band 3</summary>
		public float Gain3;
		/// <summary>Bandwidth of band 3. Region is center frequency +/- Bandwidth /2</summary>
		public float Bandwidth3;
		
	}
	
}
