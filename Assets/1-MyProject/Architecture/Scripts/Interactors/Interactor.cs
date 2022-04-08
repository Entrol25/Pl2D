
namespace Architecture
{
    public abstract class Interactor // базовый класс 
    {
        // когда все Repository и Interactor созданы
        public virtual void OnCreate() { }
        /* каждый Interactor инициализируется. 
         Когда все Repository и Interactor сделали OnCreate() */
        public virtual void Initialize() { }
        // когда все Repository и Interactor проинициализированы
        public virtual void OnStart() { }
    }
}