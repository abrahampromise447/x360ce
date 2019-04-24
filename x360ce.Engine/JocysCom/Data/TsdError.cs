﻿using System.ComponentModel;

namespace JocysCom.ClassLibrary.Data
{
	public enum TsdError
	{
		None = 0,
		[Description("7-bit Decoder Error: Number is too large.")]
		Decoder7BitNumberIsTooLargeError = 1,
		[Description("7-bit Decoder Error: Stream is too short.")]
		Decoder7BitStreamIsTooShortError = 2,
	}
}