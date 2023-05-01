module P5Reference.ThreeD.P5CameraLookAt

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
    normalMaterial p5
    createCamera p5

let draw p5 (cam: P5Camera) =
    background p5 (Grayscale 200)

    let frameCount = frameCount p5 |> float

    if frameCount % 60.0 = 0 then
        do cam.lookAt (randomBetween p5 -100 100) (randomBetween p5 -50 50) 0

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

let run node = simulate node setup noUpdate draw
