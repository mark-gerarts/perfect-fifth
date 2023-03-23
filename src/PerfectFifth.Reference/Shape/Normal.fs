module P5Reference.Shape.Normal

open P5.Core
open P5.Color
open P5.ThreeD
open P5.Shape
open P5.Rendering
open P5.Transform

let setup p5 =
    createCanvasWithMode p5 100 100 WebGL
    noStroke p5

let draw p5 t =
    background p5 (Grayscale 255)
    rotateY p5 (float t / 1000.0)
    normalMaterial p5
    beginShapeWithMode p5 TriangleStrip
    normal p5 -0.4 0.4 0.8
    vertex3D p5 -30 30 0

    normal p5 0 0 1
    vertex3D p5 -30 -30 30
    vertex3D p5 30 30 30

    normal p5 0.4 -0.4 0.8
    vertex3D p5 30 -30 0
    endShape p5

let run node = animate node setup draw
