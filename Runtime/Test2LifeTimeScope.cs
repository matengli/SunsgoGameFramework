using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class Test2LifeTimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);
        
        Debug.Log("Test2LifeTimeScope");

        GameStart();
    }

    public async UniTask GameStart()
    {
        await UniTask.WaitForSeconds(1.0f);
        Debug.Log("GameStart");
        await UniTask.WaitForSeconds(1.0f);
        Debug.Log("GameStart2");
    }
}