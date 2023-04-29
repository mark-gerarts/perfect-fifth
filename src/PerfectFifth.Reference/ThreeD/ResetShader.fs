module P5Reference.ThreeD.ResetShader

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Structure
open P5.Transform

let vertSrc =
    """
attribute vec3 aPosition;
attribute vec2 aTexCoord;
uniform mat4 uProjectionMatrix;
uniform mat4 uModelViewMatrix;
varying vec2 vTexCoord;

void main() {
    vTexCoord = aTexCoord;
    vec4 position = vec4(aPosition, 1.0);
    gl_Position = uProjectionMatrix * uModelViewMatrix * position;
}
"""

let fragSrc =
    """
precision mediump float;

varying vec2 vTexCoord;

void main() {
    vec2 uv = vTexCoord;
    vec3 color = vec3(uv.x, uv.y, min(uv.x + uv.y, 1.0));
    gl_FragColor = vec4(color, 1.0);
}
"""

let setup p5 =
    // Shaders require WEBGL mode to work
    createWebGLCanvas p5 100 100

    // Create our shader
    createShader p5 vertSrc fragSrc

let draw p5 shaderProgram =
    let width = width p5 |> float
    let t = millis p5 |> float

    // Clear the scene
    background p5 (Grayscale 200)

    // Draw a box using our shader
    // shader() sets the active shader with our shader
    shader p5 shaderProgram
    push p5
    translate3D p5 (-width / 4.0) 0 0
    rotateX p5 (t * 0.00025)
    rotateY p5 (t * 0.0005)
    cube p5 (width / 4.0)
    pop p5

    // Draw a box using the default fill shader
    // resetShader() restores the default fill shader
    resetShader p5
    fill p5 (RGB(255, 0, 0))
    push p5
    translate3D p5 (width / 4.0) 0 0
    rotateX p5 (t * 0.00025)
    rotateY p5 (t * 0.0005)
    cube p5 (width / 4.0)
    pop p5

let run node = simulate node setup noUpdate draw
