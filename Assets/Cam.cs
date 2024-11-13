using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Cam : MonoBehaviour
{

    float rotation = 0;
    public Material lutMaterial;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("OnRenderImage called");

        if (lutMaterial != null)
        {
            Graphics.Blit(source, destination, lutMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }

    }

}
