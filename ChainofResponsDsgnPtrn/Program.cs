using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.of.Responsibility.DesignPattern
{
    //COK ORTAK KOD VAR DİYE BİR DE ABSTRACT CLASS İLE YAPMAYI DENIYORUZ ! 

    abstract class AResim
    {

        protected string tipi_; 
        public string _tipi
        {
            get
            {
                return tipi_ ;
            }

        }

        public void goster(string uzanti_)
        {
            if (uzanti_ == _tipi)
                Console.WriteLine(tipi_ + " uzantılı resim gösteriliyor.");
            else
                sonraki.goster(uzanti_);
        }

        private AResim _sonraki;
        public AResim sonraki
        {
            get
            {
                return _sonraki;
            }
            set
            {
                _sonraki = value;
            }
        }


        public AResim(string tipi__)
        {
            this.tipi_ = tipi__; 
        }
    }

    class CBmpResim : AResim
    {
        public CBmpResim()
            : base("BMP")
        {

        }
    }

    class CJpgResim : AResim
    {
        public CJpgResim()
            : base("JPG")
        {

        }
    }


    class CGifResim : AResim
    {
        public CGifResim()
            : base("GİF")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            CBmpResim A = new CBmpResim();
            CJpgResim B = new CJpgResim();
            CGifResim C = new CGifResim();

            A.sonraki = B;
            B.sonraki = C;

            A.goster("JPG");

        }
    }
}
