module P5Reference.ThreeD.Lights

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Transform

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    let t' = (t |> float) / 1000.0

    background p5 (Grayscale 0)
    lights p5
    rotateX p5 t'
    rotateY p5 t'
    rotateZ p5 t'
    boxWithDefaults p5

let run node = animate node setup draw
