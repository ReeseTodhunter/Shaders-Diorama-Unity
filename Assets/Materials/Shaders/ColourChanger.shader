Shader "Reese/ColourChanger"
{

    Properties
    {
        _Colour("Colour", Color) = (1, 1, 1, 1)
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM //Start HLSL
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            //Properties defined as variables
            float4 _Colour;

            struct meshData
            {
                float4 vertex : POSITION;
            };

            struct vertextToFragments
            {
                float4 vertex : SV_POSITION;    //Clip-space position
            };

            vertextToFragments vert (meshData v)
            {
                vertextToFragments o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag (vertextToFragments i) : SV_Target
            {
                return _Colour; //Colour
            }
            ENDCG
        }
    }
}
