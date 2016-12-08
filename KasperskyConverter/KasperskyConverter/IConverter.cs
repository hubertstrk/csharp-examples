﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyConverter
{
	public interface IConverter<T>
	{
		T[] Convert( string[] lines );
	}
}
