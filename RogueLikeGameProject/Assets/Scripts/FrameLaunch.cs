using UFramework.Bootstarp;
using UFramework.Core;
using UFramework.Promise;
using UFramework.Tween;
using UnityEngine;
using UApplication = UFramework.Core.Application;

public class FrameLaunch : MonoBehaviour
{
    private UApplication _application;
    private void Awake () {
        _application = UApplication.New ();
        _application.Bootstrap (
            new SystemProviderBootstrap (this),
            new CustomProviderBootstrap ());

        App.DebugLevel = DebugLevel.Production;
    }

    void Start () {
        _application.Init ();
    }

    void Update () {
        float deltaTime = Time.deltaTime;
        App.Make<IPromiseTimer> ().LocalUpdate (deltaTime);
        App.Make<ITweenManager> ().LocalUpdate (deltaTime);
    }
}
