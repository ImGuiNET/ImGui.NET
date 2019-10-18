﻿using System;
using System.Text;

namespace ImGuiNET
{
	public unsafe struct NullTerminatedString
	{
		public readonly byte* Data;

		public NullTerminatedString(IntPtr data) : this((byte*)data) { }
		public NullTerminatedString(byte* data)
		{
			Data = data;
		}

		public override string ToString()
		{
			if (Data == null) { return null; }

			int length = 0;
			byte* ptr = Data;
			while (*ptr != 0)
			{
				length += 1;
				ptr += 1;
			}

			return Encoding.ASCII.GetString(Data, length);
		}

		public static implicit operator string(NullTerminatedString nts) => nts.ToString();
	}
}