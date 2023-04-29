module P5Reference.ThreeD.CreateShader

open P5.Core
open P5.Color
open P5.Shape
open P5.ThreeD
open P5.Rendering

let vs =
    """
precision highp float; varying vec2 vPos;
attribute vec3 aPosition;
void main() { vPos = (gl_Position = vec4(aPosition,1.0)).xy; }
"""

let fs =
    """
precision highp float; varying vec2 vPos;
uniform vec2 p;
uniform float r;
const int I = 500;
void main() {
  vec2 c = p + vPos * r, z = c;
  float n = 0.0;
  for (int i = I; i > 0; i --) {
    if(z.x*z.x+z.y*z.y > 4.0) {
      n = float(i)/float(I);
      break;
    }
    z = vec2(z.x*z.x-z.y*z.y, 2.0*z.x*z.y) + c;
  }
  gl_FragColor = vec4(0.5-cos(n*17.0)/2.0,0.5-cos(n*13.0)/2.0,0.5-cos(n*23.0)/2.0,1.0);
}
"""

let setup p5 =
    createWebGLCanvas p5 100 100
    let mandel = createShader p5 vs fs
    shader p5 mandel
    noStroke p5
    // Be sure to use ResizeArray for array data.
    mandel.setUniform "p" (ResizeArray [ -0.74364388703; 0.13182590421 ])
    mandel

let draw p5 (mandel: P5Shader) =
    let t = (millis p5 |> float) / 2000.0
    let data = 1.5 * exp (-6.5 * (1.0 + sin t))
    mandel.setUniform "r" data
    quad p5 -1 -1 1 -1 1 1 -1 1

let run node = simulate node setup noUpdate draw
