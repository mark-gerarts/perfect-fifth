module P5Reference.ThreeD.Camera0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD

let setup p5 = createWebGLCanvas p5 100 100

let draw p5 t =
    let t = t |> float
    background p5 (Grayscale 204)
    //move the camera away from the plane by a sin wave
    camera p5 0 0 (20.0 + sin (t * 0.004) * 10.0) 0 0 0 0 1 0
    plane p5 10 10

let run node = animate node setup draw
