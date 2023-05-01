module P5Reference.ThreeD.CreateCamera

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Transform
open P5.Math

let setup p5 =
    createWebGLCanvas p5 100 100
    background p5 (Grayscale 0)
    createCamera p5

let draw p5 (camera: P5Camera) =
    background p5 (Grayscale 0)
    // The camera will automatically
    // rotate to look at [0, 0, 0].
    camera.lookAt 0 0 0

    // The camera will move on the x axis.
    let t = (frameCount p5 |> float) / 60.0
    camera.setPosition (sin t * 200.0) 0 100
    cube p5 20

    // A 'ground' box to give the viewer
    // a better idea of where the camera
    // is looking.
    translate3D p5 0 50 0
    rotateX p5 halfPi
    box p5 150 150 20

let run node = simulate node setup noUpdate draw
