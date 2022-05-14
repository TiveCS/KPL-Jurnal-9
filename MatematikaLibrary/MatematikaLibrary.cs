namespace MatematikaLibrary
{
	public static class MatematikaLibrary
	{

		public static int FPB(int input1, int input2)
		{
			// Cari angka paling tinggi sebagai angka maksimal pembagian
			int highest = Math.Max(input1, input2);

			int currentFPB = 1;
			
			// Loop sampai angka paling tinggi dari input
			for (int i = 2; i <= highest; i++)
			{
				int d1 = input1 % i;
				int d2 = input2 % i;

				// Jika hasil modulo habis dibagi dan juga
				// Hasil modulo sama-sama 0, maka set nilai FPB tertinggi pada angka ke-i
				if (d1 == 0 && d2 == 0)
				{
					currentFPB = i;
				}
			}

			return currentFPB;
		}

		public static int KPK(int input1, int input2)
		{

			int base1 = input1, base2 = input2;

			// Loop jika input1 tidak sama dengan input2
			while (input1 != input2)
			{
				
				// Lakukan penjumlahan untuk input tersebut jika
				// input tersebut kurang dari input yang lain
				while(input1 < input2)
				{
					input1 += base1;
				}
				while(input2 < input1)
				{
					input2 += base2;
				}
			}

			return input1;
		}

		public static string Turunan(int[] persamaan)
		{
			// Ambil tiap angka pada persamaan array
			int a = persamaan[0], b = persamaan[1], c = persamaan[2];

			a = a * 3;
			b = b * 2;
			c = c * 1;

			// Cek jika b & c adalah negatif
			bool negB = b < 0;
			bool negC = c < 0;

			// Lakukan formating string untuk b dan c
			string bString = negB ? $"- {b * -1}x" : $"+ {b}x";
			string cString = negC ? $"- {c * -1}" : $"+ {b}";

			// Ganti setiap angka 1x agar tidak ditulis di string
			string t = $"{a}x2 {bString} {cString}";
			t = t.Replace("1x", "x");

			return t;
		}

		public static string Integral(int[] persamaan)
		{
			// Ambil tiap angka pada persamaan array
			int a = persamaan[0], b = persamaan[1], c = persamaan[2], d = persamaan[3];

			a = a / 4;
			b = b / 3;
			c = c / 2;
			d = d / 1;

			// Cek jika b, c & d adalah negatif
			bool negB = b < 0;
			bool negC = c < 0;
			bool negD = d < 0;

			// Lakukan formating string untuk b, c & d
			string bString = negB ? $"- {b * -1}x3" : $"+ {b}x3";
			string cString = negC ? $"- {c * -1}x2" : $"+ {b}x2";
			string dString = negD ? $"- {d * -1}x" : $"+ {d}x";

			// Ganti setiap angka 1x agar tidak ditulis di string
			string t = $"{a}x4 {bString} {cString} {dString} + C";
			t = t.Replace("1x", "x");

			return t;
		}

	}
}