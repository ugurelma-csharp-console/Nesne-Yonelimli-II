using System;

namespace C_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim Belirleyiciler
            /* 
             * public: Çözümdeki bütün projelerden ulaşılabilir.
             * internal: Sadece kendi projesindeki sınıflardan ulaşılabilir.
             * protected: Sadece kendisi ve kendisinden türetilen sınıflardan ulaşılır.
             * private: Sadece kendi sınıfından ulaşılır.
            */
            #endregion

            #region Abstract Sield Interface
            /*
             * abstract class: Sınıfı soyutlar yani bu sınıftan obje oluşturulmasını önler.
             * Abstract Methot: Metodun gövdesi yoktur. Bunu override ile kalıtılmış sınıfda yazabilirsin.
             * Virtual Methot: Metodun gövdesi vardır. Bunun gövdesini de kalıtılmış sınıfa override ile güncelleyebilirsin.
             * sealed class: Bu sınıfın kalıtılmasını önler.
             * Field: Get Set yoksa
             * Property: Get Set varsa
             * interface IOrnek {} ile başlar, bunda field yoktur, erişim belirleyiciler yoktur; property, void-int-bool-string MethotIsmi() vardır.
             * UML çizimleri için Hafta 6 sayfa 25 e bak.
             */
            #endregion

            #region UML Tasarım
            /*
             * >>>>Bağlantı (Kesiksiz ışın): Ya birinde ya diğerinde ya da ikisinde de o nesneler var olup olmadığı hakkında bilgi verir.(Rakamlara dikkat et)
             * Rakamların mantığı şu: Rakamın karşısındaki nesne içinde o nesneden rakam kadar vardır.
             * >>>>Birleşme (Kesiksiz bir ışın ve ucunda boş bir eşkenar dörgen); nesne boş eşkenarın içerisindeki nesnede ama consturctor da değil
             * >>>>Composition (Kesiksiz bir ışın ve ucunda dolu bir eşkenar dörgen); nesne dolu eşkenarın içerisindeki nesnede ama consturctor da
             * >>>>Bağımlılık (Kesikli ışın): Bir nesne diğer nesnenin constructor ünde vardır.
             */
            #endregion

            #region Delegate
            /*
             * public/internal delegate void Delegete1(); ---> Şeklinde tanımlanır.
             * public/internal Delegate1 delegate1; ---> Şeklinde nesne oluşturulur.
             * Sınıftan delegate1 nesnesi çağrılır ve delegate1 += Metot1; ---> Şeklinde metotlar eklenir.
             * GetInvocationList() ---> Metotların listesidir.
             * Invoke() --> Parametre varsa burada yazılır ve fonksiyon çağrılır.
             */
            #endregion

            #region Event
            /*
             * public/internal delegate void Delegete1(); ---> Şeklinde delegate tanımlanır.
             * public/internal event Delegate1 Event1; ---> Şeklinde event oluşturulur.
             */
            #endregion

            #region Generic List
            /*
             * Kod tekrarını önler; casting yani tür dönüşümü işleminde runtime da kolaylık sağlar; kodun okunurluğunu artırır.
             * public class GenericList<T> where T: class, string, MyClass, int, new() {}
             * class herhangi bir sınıf T nesnesi olarak belirlenir.
             * new() bu sınıftan yeni bir nesnenin türetilebileceğini gösterir.
             */
            #endregion

            #region Presentation Layer - Business Logic Layer - Data Access Layer
            /*
             * Presentation Layer: Kullanıcı ile iletişime geçilen katman (Front-end)
             * Business Logic Layer: Presentation ile Data Access Layer arasında bağlantıyı sağlayan katman (Back-end)
             * Data Acces Layer: Veri tabanı işlemlerinin yapıldığı katman (Data-base)
             * Kullanım amacı; uygulamayı daha modüler, bakımı kolay ve ölçeklenebilir hale getirmek için tercih edilir. Kodun yeniden kullanılabilirliğini, test edilebilirliğini ve güvenilirliğini artırır.
             */
            #endregion

            #region Windows Form - Task
            /*
             * Task'lar görev elemanıdır. Task tsk = Task.Factory.StartNew(()=> "{} ya da FoksiyonTask()")
             * Dispose(), Wait(), Start()
             */
            #endregion

            #region Thread
            /*
             * Aynı anda birden fazla işlemi çalıştırmak için kullanılan bir nesnedir.
             * Thread t1 = new Thread(()=> Fonksiyon() ya da {"İçine yaz!"} );
             * t1.Start(); ile başlat.
             */
            #endregion
        }
    }
}
