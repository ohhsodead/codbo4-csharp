using System;

namespace CODBO4
{
	[Serializable]
	public class CODException : Exception
	{
		public CODException(string message) : base(message)
		{
		}

		public string ConnectionString { get; private set; }
	}
}