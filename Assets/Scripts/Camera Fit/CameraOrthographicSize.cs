using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class CameraFit : MonoBehaviour
{
    [Tooltip("Enable/disable camera changes")]
    public bool active = true;
    private float lastAspect;
    
    [Tooltip("Cameras to resize")]
    public  Camera[] cameras;

    public event EventHandler OnCameraResize;

    protected abstract void Resize();

    protected void Refresh()
    {
        if (cameras == null || cameras.Length <= 0)
            return;
        foreach (var cam in cameras)
        {
            if (cam == null)
                continue;

            if (Mathf.Abs(cam.aspect - lastAspect) > 0.01f)
            {
                Resize();
                OnCameraResize?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}


public class CameraOrthographicSize : CameraFit
{
    [Tooltip("Dimensions which are affected by size changes.\n" +
        "0 - vertical (same as orthographic size change in Camera)\n" +
        "1 - horizontal (size affects horizontal dimension of camera orthographic size)\n" +
        "Anything between (size affect partially both dimensions)")]
    [Range(0, 1)]
    public float horizontalFit;

    [Tooltip("Size of orthographic camera (similar to Camera orthographic size")] 
    public float size;

    private void Awake()
    {
        Resize();
    }

    protected override void Resize()
    {
        if (cameras == null || cameras.Length <= 0)
            return;
        foreach (var cam in cameras)
        {
            if (cam == null || cam.orthographic == false)
                continue;

            cam.orthographicSize = size * ((1 - horizontalFit) + horizontalFit / cam.aspect);
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (active)
            Resize();
    }

    private void OnValidate()
    {
        if (active)
            Resize();
    }
#endif
}
