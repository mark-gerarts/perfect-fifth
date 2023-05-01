module P5Reference.ThreeD.SetCamera

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

    let cam1 = createCamera p5
    let cam2 = createCamera p5
    cam2.setPosition 30 0 50
    cam2.lookAt 0 0 0
    cam2.ortho ()

    (cam1, cam2, 1)

let drawBoxes p5 =
    let frameCount = frameCount p5 |> float
    rotateX p5 (frameCount * 0.01)
    translate3D p5 -100 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20
    translate3D p5 35 0 0
    cube p5 20

let update p5 (cam1, cam2, currentCamera) =
    let frameCount = frameCount p5

    let newCamera =
        match frameCount % 100, currentCamera with
        | 0, 1 -> 2
        | 0, 2 -> 1
        | _ -> currentCamera

    (cam1, cam2, newCamera)


let draw p5 (cam1: P5Camera, cam2: P5Camera, currentCamera) =
    let t = (frameCount p5 |> float) / 60.0
    background p5 (Grayscale 200)

    // camera 1:
    cam1.lookAt 0 0 0
    cam1.setPosition (sin t * 200.0) 0 100

    setCamera p5 (if currentCamera = 1 then cam1 else cam2)
    drawBoxes p5

let run node = simulate node setup update draw
