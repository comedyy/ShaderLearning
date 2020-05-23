using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplacementDemo : MonoBehaviour
{
    public Shader _replace_shader;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 100, 100), "RenderType替换"))
        {
            // replacementTag == "RenderType"的时候。
            // 先查找_replace_shader中是否包含"RenderType"这个标签，以及标签值。（找到了两个subshader，一个是RenderType="Transparent", 另外一个是RenderType="Opaque"）
            // 遍历所有场景物件，所有有RenderType=“Transparent”的，使用我们的第一个subshader替代。所有拥有RenderType="Opaque"的，使用我们第二个subshader替代。
            // 都没有的，则不显示。
            Camera.main.SetReplacementShader(_replace_shader, "RenderType");
        }
        if (GUI.Button(new Rect(100, 300, 100, 100), "全部替换"))     
        {
            // replacementTag == null的时候，所有物体统统使用_replace_shader的第一个subshader渲染
            Camera.main.SetReplacementShader(_replace_shader, null); 
        }
        if (GUI.Button(new Rect(100, 200, 100, 100), "重置shader"))
        {
            Camera.main.ResetReplacementShader();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
