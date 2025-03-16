using System;

internal class DelegateveEvent
{
    /// <summary>
    /// Bunu hep yapacaksın bu bir nesne değil metottur. Eğer event sorusu ise eventini oluştur değilse nesnesini oluştur.
    /// </summary>
    internal delegate void MyDelegate(int x, string y);

    /// <summary>
    /// Sadece delegate sorusu varsa bunu yap!
    /// </summary>
    internal MyDelegate myDelegate;

    /// <summary>
    /// Bunu new yapamazsın! DelegateveEvent sınıfından nesne oluştur MyEvent' a ulaş ve ona += ile eklemeye başla! Metotu RunEvent yap!
    /// </summary>
    internal event MyDelegate MyEvent;

    internal void RunEvent()
    {
        MyEvent?.DynamicInvoke(5, "");
    }
    internal void RunEventWithIndex(int index)
    {
        if (index < MyEvent?.GetInvocationList().Length && index > -1)
            MyEvent?.GetInvocationList()[index].DynamicInvoke();
        else
            Console.WriteLine("Geçersiz indis girdiniz!");
    }
}