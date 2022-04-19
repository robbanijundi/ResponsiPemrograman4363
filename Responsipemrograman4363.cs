using System;
namespace ResponsiPemrograman4363


{
	class karyawan
	{
		public int nim { get; set;} 
		public string nama { get; set;}
		public int gaji { get; set;}
		public int gajinaik { get; set;}
		
		
		
		public karyawan (int NIM, string Nama; int gajipokok)
		{
				nim = NIM;
				nama = Nama;
				gaji = gajipokok;
			gajinaik = 10;
			
				if (gajipokok < 0)
				{
					gaji - 0;
				}
		}
		
		public void getdapetbonus()
		{
				int bonus - gaji/ gajinaik;
				gaki = gaji + bonus;
				Console.Writeline("{0} \t{1}\t\t\t {2}", nim, nama, gaji);
		}
		
		public void PrintAndShow()
		{
				Console.Writeline("{0} \t{1}\t\t\t {2}", nim, nama, gaji);
		}
		
		public class MainProgram
		{
				static void Main(String[] args)
				{
					Console.Writeline("NIM\t\t\t Nama\t\t\t Gaji");
					Console.Writeline("..............................");
					
				Karyawan karyawan1 - new Karyawan(21114363, "Jundi", 10000000);
					Karyawan karyawan2 - new Karyawan(21114356, "Fafa", 8000000);
					
				karyawan1.PrintAndShow();
					karyawan2.PrintAndShow();
					
					Console.Writeline("\n\n Asyik kalian dapat kenaikan gaji 10% :)");
					Console.Writeline("\n\n NIM\t\t\t Nama \t\t\t Gaji");
					Console.Writeline("............................................");
					
				karyawan1.getdapetbonus();
				karyawan2.getdapetbonus();
				
				}
			}
}
}
			
				
				
				
				
				