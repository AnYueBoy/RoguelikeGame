using UFramework.Core;
using UnityEngine;

public class ProvideTransformManager : MonoBehaviour, IServiceProvider
{
    public void Register()
    {
    }

    public void Init()
    {
        App.Instance<TransformManager>(GetComponent<TransformManager>());
    }
}