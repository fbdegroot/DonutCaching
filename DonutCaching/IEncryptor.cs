using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DonutCaching
{
	public interface IEncryptor
	{
		string Encrypt(string plainText);
		string Decrypt(string encryptedText);
	}
}