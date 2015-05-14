using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace VoxelBusters.RuntimeSerialization.Benchmark
{
	[System.Serializable, RuntimeSerializable(true)]
	public class BenchmarkSampleBase
	{
		[Multiline]
		public 			string					stringField				= "BenchmarkSampleBase";
		public 			char					charField				= 'c';
		public 			double					doubleField				= 99;
		public 			float					floatField				= 11.11f;
	}

	[System.Serializable, RuntimeSerializable(true)]
	public class BenchmarkSample : BenchmarkSampleBase
	{
		public 			int						intField				= 10;
		public 			ushort					ushortField				= 128;
		public 			int[,]					int2DArray				= new int[,]{{1, 2, 3}, {3, 2, 1}};
		public 			DateTime				dateTime;

#pragma warning disable
		private 		long					m_privateLongField		= 9787;
		private 		string[]				m_privateStringArray	= null;
#pragma warning restore
	}
}
