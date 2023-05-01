module P5Reference.ThreeD.P5CameraCamera0

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Environment

let setup p5 =
    createWebGLCanvas p5 100 100
    createCamera p5

let draw p5 (cam: P5Camera) =
    let t = (frameCount p5 |> float) * 0.01
    background p5 (Grayscale 204)
    //move the camera away from the plane by a sin wave
    cam.camera (0, 0, (20.0 + sin t * 10.0), 0, 0, 0, 0, 1, 0)
    plane p5 10 10

let run node = simulate node setup noUpdate draw
