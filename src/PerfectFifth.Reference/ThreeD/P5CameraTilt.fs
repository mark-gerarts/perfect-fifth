module P5Reference.ThreeD.P5CameraTilt

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Transform

let setup p5 =
    createWebGLCanvas p5 100 100
    normalMaterial p5
    let cam = createCamera p5
    cam.tilt (-0.8)

    (cam, 0.01)

let update p5 (cam, delta) =
    let newDelta =
        match (frameCount p5) % 160 with
        | 0 -> delta * -1.0
        | _ -> delta

    (cam, newDelta)

let draw p5 (cam: P5Camera, delta) =
    background p5 (Grayscale 200)
    cam.tilt (delta)

    let frameCount = frameCount p5 |> float
    rotateY p5 (frameCount * 0.01)
    translate3D p5 0 -100 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20
    translate3D p5 0 35 0
    cube p5 20

let run node = simulate node setup update draw
