
int a = 60, b = 45;
int fpb = MatematikaLibrary.MatematikaLibrary.FPB(a, b);

Console.WriteLine("FPB 60 & 45: " + fpb);

int c = 12, d = 8;
int kpk = MatematikaLibrary.MatematikaLibrary.KPK(c, d);
Console.WriteLine("KPK 12 & 8: " + kpk);

string turunan = MatematikaLibrary.MatematikaLibrary.Turunan(new int[]{1, 4, -12, 9});
Console.WriteLine("Turunan (x3 + 4x2 - 12x + 9): " + turunan);

string integral = MatematikaLibrary.MatematikaLibrary.Integral(new int[] {4, 6, 12, 9});
Console.WriteLine("Integral (4x3 + 6x2 + 12x + 9): " + integral);