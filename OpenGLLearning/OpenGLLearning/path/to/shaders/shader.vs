#version 330 core
layout (location = 0) in vec3 aPos; // 位置变量的属性位置值为0
//layout (location = 1) in vec3 aColor;
layout (location = 1) in vec2 aTexCoord;

//out vec3 ourColor;
out vec2 TexCoord;
//out vec4 vertexColor; // 为片段着色器指定一个颜色输出

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    //gl_Position = transform * vec4(aPos, 1.0); // 注意我们如何把一个vec3作为vec4的构造器的参数
    gl_Position = projection * view * model * vec4(aPos, 1.0);
    //gl_Position = model * vec4(aPos, 1.0);
    //ourColor = aColor;
    TexCoord = vec2(aTexCoord.x,aTexCoord.y);
}