module P5Reference.ThreeD.LoadShader

open P5.Core
open P5.Color
open P5.Shape
open P5.ThreeD
open P5.Rendering

let preload p5 =
    loadShader p5 "assets/shader.vert" "assets/shader.frag"

let setup p5 mandel =
    createWebGLCanvas p5 100 100
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

let run node =
    simulateWithPreload node preload setup noUpdate draw
