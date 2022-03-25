using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRectProvider
{
    Rect GetRect();
}

[RequireComponent(typeof(Camera))]
public class CameraRectProvider : MonoBehaviour, IRectProvider
{
    public Rect GetRect()
    {
        var camera = GetComponent<Camera>();
        if (camera.orthographic == false)
            throw new System.Exception("Wrong camera orthographic mode");

        float height = camera.orthographicSize;
        float width = height * camera.aspect;

        return new Rect(
            transform.position.x,
            transform.position.y,
            width,
            height);
    }
}
