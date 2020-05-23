using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderLodDemo : MonoBehaviour
{
    // 通过修改Shader.globalMaximumLOD来改变shader使用的subshader。
    // 只有shader的subshader高于当前Shader.globalMaximumLOD,才能使用
    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 100, 100), "LOD=>100"))
        {
            Shader.globalMaximumLOD = 100;
        }
        if (GUI.Button(new Rect(100, 200, 100, 100), "LOD=>200"))
        {
            Shader.globalMaximumLOD = 200;
        }
    }
}
