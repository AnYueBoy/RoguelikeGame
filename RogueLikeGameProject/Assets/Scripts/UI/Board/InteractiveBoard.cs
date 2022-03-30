using System;
using UFramework.GameCommon;
using UnityEngine;

public class InteractiveBoard : BaseUI
{
    // [SerializeField] private rect
    public override void OnShow(params object[] args)
    {
    }

    private void Update()
    {
    }

    #region 移动端移动逻辑

    private void MobileInput()
    {
        if (Input.touchCount <= 0)
        {
            return;
        }

        Touch touch = Input.touches[0];
        // RectTransformUtility.ScreenPointToLocalPointInRectangle()
    }

    private void TouchStart(Touch touch)
    {
    }

    private void TouchMove(Touch touch)
    {
    }

    private void TouchEnd(Touch touch)
    {
    }

    #endregion
}