using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
    [SerializeField] private RectTransform canvasTrans;
    public RectTransform CanvasTrans => canvasTrans;
}