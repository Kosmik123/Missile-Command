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

        float yExtent = camera.orthographicSize;
        float xExtent = yExtent * camera.aspect;

        return new Rect(
            transform.position.x - xExtent,
            transform.position.y - yExtent,
            2 * xExtent,
            2 * yExtent);
    }
}
