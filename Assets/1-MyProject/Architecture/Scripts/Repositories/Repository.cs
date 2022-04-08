
namespace Architecture
{
    public abstract class Repository // базовый класс 
    {
        public abstract void OnCreate();
        /* каждый Repository инициализируется и сохраняется */
        public abstract void Initialize();
        public abstract void Save();
        public abstract void OnStart();
    }
}