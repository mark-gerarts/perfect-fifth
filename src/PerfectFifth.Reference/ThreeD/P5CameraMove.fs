module P5Reference.ThreeD.P5CameraMove

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.ThreeD
open P5.Rendering
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    normalMaterial p5
    let cam = createCamera p5
    (cam, 0.5)

let update p5 (cam, delta) =
    match frameCount p5 % 150 with
    | 0 -> (cam, -delta)
    | _ -> (cam, delta)

let draw p5 (cam: P5Camera, delta) =
    background p5 (Grayscale 200)

    // move the camera along its local axes
    cam.move delta delta 0

    translate3D p5 -10 -10 0
    box p5 50 8 50
    translate3D p5 15 15 0
    box p5 50 8 50
    translate3D p5 15 15 0
    box p5 50 8 50
    translate3D p5 15 15 0
    box p5 50 8 50
    translate3D p5 15 15 0
    box p5 50 8 50
    translate3D p5 15 15 0
    box p5 50 8 50

let run node = simulate node setup update draw
