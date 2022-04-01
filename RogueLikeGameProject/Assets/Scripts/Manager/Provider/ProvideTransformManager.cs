using UFramework.Core;
using UFramework.GameCommon;
using UnityEngine;

public class ProvideTransformManager : MonoBehaviour, IServiceProvider
{
    public void Register()
    {
        App.Instance<TransformManager>(GetComponent<TransformManager>());
    }

    public void Init()
    {
        App.Make<IUIManager>().Init(App.Make<TransformManager>().CanvasTrans);
    }
}