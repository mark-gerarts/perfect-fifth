module P5Reference.Transform.RotateX

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Transform

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    background p5 (Grayscale 255)
    rotateX p5 (float t / 1000.0)
    boxWithDefaults p5

let run node = animate node setup draw
