using System;
using JetBrains.Annotations;
using UFramework.Core;
using UFramework.GameCommon;
using UnityEngine;

public class InteractiveBoard : BaseUI
{
    [SerializeField] private RectTransform rockerTrans;
    [SerializeField] private RectTransform rockerJoyTrans;

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
            App.Make<TransformManager>().UICamera,
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

    private Vector2? touchStartPos;

    private void TouchStart(Vector2 touchPos)
    {
        touchStartPos = touchPos;
        rockerTrans.localPosition = touchPos;
    }

    private readonly float moveMaxDis = 100;

    private void TouchMove(Vector2 touchPos)
    {
        if (touchStartPos == null)
        {
            return;
        }

        Vector2 moveVec = touchPos - touchStartPos.Value;
        Vector2 moveDir = moveVec.normalized;
        App.Make<InputManager>().setMoveDir(moveDir);

        if (moveVec.magnitude > moveMaxDis)
        {
            rockerJoyTrans.localPosition = moveDir * moveMaxDis;
        }
        else
        {
            rockerJoyTrans.localPosition = moveVec;
        }
    }

    private void TouchEnd()
    {
        touchStartPos = null;
        App.Make<InputManager>().setMoveDir(null);
        rockerJoyTrans.localPosition = Vector2.zero;
    }

    #endregion
}