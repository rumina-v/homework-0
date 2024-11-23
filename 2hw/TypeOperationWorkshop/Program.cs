namespace TypeOperationWorkshop;

class Pogram
{
	// 1 задание
	public class Solution 
	{
		public string AddBinary(string a, string b) 
		{
			int result = BinaryToDecimal(a) + BinaryToDecimal(b);
			
			return DecimalToBinary(result);
		}

		int BinaryToDecimal(string binaryNumber)
		{
			int decimalNumber = 0;

			for (int i = 0; i < binaryNumber.Length; i++)
			{
				char bit = binaryNumber[binaryNumber.Length - 1 - i];
				if (bit == '1')
				{
					decimalNumber += (1 << i);
				}
			}
			
			return decimalNumber;
		}

		int IntPow(int x, int stepen)
		{
			if (stepen == 0)
				return 1;
			
			for (int i = 1; i < stepen; i++)
				x *= x;
			
			return x;
		}

		string DecimalToBinary(int decimalInput)
		{
			string binaryOutput = "";

			if (decimalInput == 0)
				return "0";

			while (decimalInput > 0)
			{
				int remainder = decimalInput % 2;
				binaryOutput = remainder + binaryOutput;
				decimalInput /= 2;
			}
			
			return binaryOutput;
		}
	}
}