using System;
using UFramework.Core;
using UFramework.GameCommon;
using UnityEngine;

public class InteractiveBoard : BaseUI
{
    public override void OnShow(params object[] args)
    {
    }

    private void Update()
    {
        MobileInput();
    }

    #region 移动端移动逻辑

    private void MobileInput()
    {
        if (Input.touchCount <= 0)
        {
            return;
        }

        Touch touch = Input.touches[0];
        RectTransform canvasTrans = App.Make<TransformManager>().CanvasTrans;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvasTrans,
            touch.position,
            null,
            out Vector2 targetPos);

        // 对屏幕三分之一出的屏幕进行触摸响应
        if (touch.position.x > Screen.width / 3)
        {
            TouchEnd();
            return;
        }

        if (touch.phase == TouchPhase.Began)
        {
            TouchStart(targetPos);
        }

        if (touch.phase == TouchPhase.Moved)
        {
            TouchMove(targetPos);
        }

        if (touch.phase == TouchPhase.Ended)
        {
            TouchEnd();
        }
    }

    private Vector2? touchStartPos = null;

    private void TouchStart(Vector2 touchPos)
    {
    }

    private void TouchMove(Vector2 touchPos)
    {
    }

    private void TouchEnd()
    {
    }

    #endregion
}