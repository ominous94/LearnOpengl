#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D Texture0;
uniform sampler2D Texture1;
//in vec4 vertexColor; // 从顶点着色器传来的输入变量（名称相同、类型相同）

void main()
{
    // FragColor = vertexColor;
    //FragColor = vec4(1.0f, 0.5f,0.2f,1.0f);
    //FragColor = texture(Texture0, TexCoord) * vec4(ourColor,1.0);
    FragColor = mix(texture(Texture0,TexCoord), texture(Texture1, TexCoord), 0.5);
}