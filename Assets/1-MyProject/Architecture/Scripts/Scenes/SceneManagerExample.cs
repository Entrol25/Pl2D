
namespace Architecture
{
    public sealed class SceneManagerExample : SceneManagerBase// sealed - запрещает наследование
    {
        public override void InitSceneMap()
        {// инициализирует список сцен
            this.sceneConfigMap[SceneConfigExample.SCENE_NAME] = new SceneConfigExample();
            this.sceneConfigMap[SceneConfigGame_1.SCENE_NAME] = new SceneConfigGame_1();
        }
    }
}
