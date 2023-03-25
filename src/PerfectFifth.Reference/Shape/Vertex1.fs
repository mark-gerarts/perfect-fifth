module P5Reference.Shape.Vertex1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering

let draw p5 =
    createCanvasWithMode p5 100 100 WebGL
    background p5 (RGB(240, 240, 240))
    fill p5 (RGB(237, 34, 93))
    noStroke p5
    beginShape p5
    vertex p5 0 35
    vertex p5 35 0
    vertex p5 0 -35
    vertex p5 -35 0
    endShape p5

let run node = display node draw
