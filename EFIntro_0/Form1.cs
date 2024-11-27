using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFIntro_0
{
    public partial class Form1 : Form
    {

        /*
                    ORM(Object Relational Mapping)

        Veritabanındaki şema yapısını , kullandıgınız programlama dilinde olusturma işlemidir...Class'larınız veritabanınızdaki tablolarla, property'leriniz tablolarınızdaki sütunlarla eşleştirilir...Veritabanınızdaki verileriniz ilgili class'lardan olusan instance'lar olarak görülür...

        --Entity Framework

        --Veri erişimi acısından 3 yöntemi vardır ...

        a => ModelFirst(Siz manual class yaratarak varolan veritabanınızdaki tablolarla eşleştirmeyi elle yaparsınız)

        b => DBFirst(Database First*)

        c => CodeFirst*


        -- DBFirst yaklasımı => Sizin veritabanınız Management Studio'da (Sql Server'da ise) önceden olusturulmustur. Siz projenize bu hazır veritabanını entegre edersiniz...Siz projenize bu hazır veritabanınızı entegre etmek icin EntityFramework'e bir emir verirsiniz...Bu emir karsılıgında EntityFramework  veritabanınızı önce bir sınıf halinde yansıma olarak projenize getirir...Sonra bu veritabanınızdaki tabloları class olarak ayrıca acar,icerisindeki sütunları property yapar ve verilerinizi de instance olarak getirir..Sonra acılan bu class'lar(tabloları temsil eden class'lar) Property olarak ilgili tiplerinde veritabanı sınıfı icerisine konulur ki (Veritabanı sınıfınızın tabloları temsil eden sınıflarınızı tanımasını saglar)... Siz projenizdeki veritabanı işlemlerini veritabanının kendi sınıfından instance alarak yaparken, ilgili verileri eklemek icin tabloların sizin projenizde dönüsmüs oldugu class'lardan instance alarak yaparsınız...


            Dezavantajları : DBFirst yaklasımı bir veritabanını en hızlı şekilde projeniz entegre edeceginiz bir yaklasımıdır...Ancak bunun karsılıgında Entity Framework'un olusturdugu yapı sabittir(Bir kütüphane kullandıgınız halde siz hakimiyet elinizde kalarak hala manuel işlemler yapabilirsiniz...Ancak bir kütüphane üzerindeki direkt bir hazır yapıyı kullanıyorsanız o zaman esnekliginizi tamamen kütüphaneye bırakır ve hakimiyetten vazgecersiniz) BU sabit yapıyı degiştirmek hic saglıklı degildir....Kullanmak istemeyebileceginiz yapıları zorunlu bir şekilde icerisine entegre edip sizi onlara bagımlı kılar...DBFirst ile olusturulan projelerin ayrıca müsteriye gönderilirken Veritabanınızın yedegini de alarak ayrı bir şekilde müsteriye kurulumunun yapılması gerekir...

        Avantajları : Cok hızlı geliştirme yapmanızı saglar...HAzır DB'yi direkt projenize entegre eder...




        --CodeFirst yaklasımı => Sizin veritabanınız yoktur...Veritabanınızı SQL'den de yaratmak istemezsiniz veya belli baslı durumlarda bu olay size hız kazandıracak olmasına ragmen büyük kısıtlılık saglayacagından (DBFirst'e yonlendireceginden dolayı SQL'den yaratmak saglıklı olmaz...Veya Database sisteminizin güvenlik durumundan emin degilseniz güvenlik sisteminizi kullandıgınız programlama dili üzerinden kurmak istersiniz) SQL'den baslamak istemeyebilirsiniz...BU yaklasımda veritabanını C#(veya kullandıgınız programlama dili neyse) kodları ile yaratırsınız...C# icerisinde OOP prensiplerini kullanarak düzgün bir normalizasyon ile class'larınızı tablo olarak göndermek (Migration) CodeFirst yontemidir...Bütün hakimiyet sizdedir...Her alanda özgürsünüzdür ve her türlü prensibi istediginiz gibi kullanabilirsiniz...Direkt Entity dedigimiz yapılarda da oldukca büyük özgürlük saglar....

        Entity : Veritabanımızdaki tabloları temsil eden sınıflardır...
         
         
         
         
         
         
         
         */





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
