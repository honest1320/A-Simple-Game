using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace MyProject
{
    public interface IGenerateRandomImages
    {
        void generateRandomImage();
    }
    class AtikKutusu: IGenerateRandomImages
    {
        public void generateRandomImage()
        {
            Random random = new Random();
            int i = random.Next(0, 8);
            string filePath = @"photos";
            string[] paths = Directory.GetFiles(filePath);
            List<string> images = paths.ToList();
        }
    }
    class Organic
    {
        public int domates;
        public int salatalik;

        private int organicKutusu;
        public int OrganicKutusu
        {
            get {return organicKutusu; }
            set { organicKutusu = value; }
        }
        public Organic(int _domates, int _salatalik, int OrganicKutusu)
        {
             domates = _domates;
             salatalik =_salatalik;
            organicKutusu = OrganicKutusu;
        }
    }
    class Kagit
    {

        public int Gazete;
        public int Dergi;
        private int kagitKutusu;
      
        public int KagitKutusu
        {
            get { return kagitKutusu; }
            set { kagitKutusu = value; }
        }
        public Kagit (int _gazete, int _dergi, int KagitKutusu)
	    {
            Gazete=_gazete;
            Dergi=_dergi;
            kagitKutusu=KagitKutusu;
	    }
    }
    class Cam
    {
        public int camSise;
        public int Bardak;
        private int camKutusu;

        public int CamKutusu
        {
            get { return camKutusu; }
            set { camKutusu = value; }
        }
        public Cam (int _camSise, int _Bardak, int CamKutusu)
	    {
            camSise=_camSise;
            Bardak=_Bardak;
            camKutusu=CamKutusu;
	    }

    }
    class Metal
    {
        public int kolaKutusu;
        public int salcaKutusu;
        private int metaKutusu;

        public int MetalKutusu
        {
            get { return metaKutusu; }
            set { metaKutusu = value; }
        }
        public Metal (int _kolaKutusu, int _salcaKutusu, int MetalKutusu)
	    {
            kolaKutusu=_kolaKutusu;
            salcaKutusu=_salcaKutusu;
            metaKutusu=MetalKutusu;
	    }

    }

    
    
}
