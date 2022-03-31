using System.Collections;
using System.Collections.Generic;
using UFramework.Core;
using UFramework.Tween;
using UnityEngine;

public class CustomProviderBootstrap : IBootstrap
{
    public void Bootstrap()
    {
        IServiceProvider[] providerArray = {
        };

        foreach (IServiceProvider provider in providerArray)
        {
            if (provider == null)
            {
                continue;
            }

            if (App.IsRegistered(provider))
            {
                continue;
            }

            App.Register(provider);
        }
    }
}