#version 330 core
out vec4 FragColor;

in vec4 vertexColor; // 从顶点着色器传来的输入变量（名称相同、类型相同）

void main()
{
    // FragColor = vertexColor;
    FragColor = vec4(1.0f, 0.5f,0.2f,1.0f);
}