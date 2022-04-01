using UnityEngine;

public class InputManager
{
    private Vector2? curMoveDir;
    public Vector2? CurMoveDir => curMoveDir;

    public void setMoveDir(Vector2? moveDir)
    {
        curMoveDir = moveDir;
    }
}