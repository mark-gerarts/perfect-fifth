module P5Reference.ThreeD.P5CameraPerspective

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Math
open P5.Transform
open P5.Structure

let setup p5 =
    createWebGLCanvas p5 100 100
    let cam = createCamera p5
    cam.perspective (pi / 3.0, 1, 0.1, 500)

let draw p5 _ =
    background p5 (Grayscale 200)
    orbitControl p5
    normalMaterial p5

    rotateX p5 -0.3
    rotateY p5 -0.2
    translate3D p5 0 0 -50

    let t = (frameCount p5 |> float) / 30.0
    push p5
    translate3D p5 -15 0 (sin t * 95.0)
    cube p5 30
    pop p5
    push p5
    translate3D p5 15 0 (sin (t + pi) * 95.0)
    cube p5 30
    pop p5

let run node = animate node setup draw
