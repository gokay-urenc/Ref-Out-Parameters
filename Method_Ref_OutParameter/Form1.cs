using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_Ref_OutParameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = 5;
            Degistir(ref deger);
        }

        void Degistir(ref int sayi)
        {
            sayi = 19; // Sayı isimli parametreye gönderilen değeri değiştirmek.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kalan = 0;
            int a = Hesapla(16, 3, ref kalan);
            MessageBox.Show("Bölme işleminden kalan sonuç: " + kalan);
            MessageBox.Show("Bölme işleminin sonucu: " + a);
        }

        int Hesapla(int sayi1, int sayi2, ref int kln)
        {
            int sonuc = sayi1 / sayi2;
            kln = sayi1 % sayi2;
            return sonuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi_1 = 7, sayi_2 = 19, sonuc;
            Toplama(sayi_1, sayi_2, out sonuc);
        }

        void Toplama(int a1, int a2, out int a3)
        {
            a3 = a1 + a2;
        }
    }
}
// Ref parametresi => Method içerisine parametre üzerinden gönderilen değerin bir        kopyasını oluşturarak isimlerini oluşturulan kopya üzerinde yapar. Ref'in genel       kullanım amacı method dışında değer gönderebilmektir. Değer dönen methodlarda return  sadece 1 değer dönebilir. Ref ve out parametreleri ile bu değişebilir.
// Out parametresi => Ref parametresi gibi method gövdesinden method dışına değer        çıkarmak için kullanılan diğer bir yöntemdir. Out anahtar kelimesi ile bir parametre  alınıyorsa o parametreye method içerisinde bir değer ataması yapılmalıdır. Out        parametresinin ilk değeri olmak zorunda değildir.