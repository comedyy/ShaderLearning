﻿Shader "TexGen/EyeLinear" {
	Properties{
		_MainTex("Texture", 2D) = "" { /* used to be TexGen EyeLinear */ }
	}
		SubShader{
			Pass {
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#include "UnityCG.cginc"

				struct v2f {
					float4 pos : SV_POSITION;
					float3 uv : TEXCOORD0;
				};

				v2f vert(float4 v : POSITION)
				{
					v2f o;
					o.pos = UnityObjectToClipPos(v);

					// TexGen EyeLinear:
					// use view space vertex position
					o.uv = UnityObjectToViewPos(v);
					return o;
				}

				sampler2D _MainTex;
				half4 frag(v2f i) : SV_Target
				{
					return tex2D(_MainTex, i.uv.xy);
				}
				ENDCG
			}
	}
}