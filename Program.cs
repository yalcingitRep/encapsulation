using System;
namespace encapsulation{
    class Program{
        public static void Main(string[] args){
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Isim = "yalcin";
            ogrenci.Soyisim = "mrl";
            ogrenci.OgrenciNo = 1;
            ogrenci.Sinif = 11;
            ogrenci.OgrenciGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciGetir();
        }
    }

    class Ogrenci{
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim{
            get{
                return isim;
            }
            set{
                isim = value;
            }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
        
            set
            {
                if(value < 1){
                    sinif = 1;
                }else{
                    sinif = value;
                }
            }
        }
        public Ogrenci(){  
        }

        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif){
         Isim = isim;
         Soyisim = soyisim;
         OgrenciNo = ogrenciNo;
         Sinif = sinif;   
        }
        public void OgrenciGetir(){
            Console.WriteLine("----------Ogrenci Bilgileri-----------");
            Console.WriteLine("Ogrenci Adi : " + this.Isim);
            Console.WriteLine("Ogrenci SoyAdi : " + this.Soyisim);
            Console.WriteLine("Ogrenci no : " + this.OgrenciNo);
            Console.WriteLine("Ogrenci sinif : " + Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur(){
            this.Sinif = this.Sinif - 1;
        }
    }
}