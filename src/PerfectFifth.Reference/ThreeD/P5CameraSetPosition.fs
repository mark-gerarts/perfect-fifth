module P5Reference.ThreeD.P5CameraSetPosition

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.ThreeD
open P5.Events

let setup p5 =
    createWebGLCanvas p5 100 100
    normalMaterial p5
    createCamera p5

let draw p5 (cam: P5Camera) =
    background p5 (Grayscale 200)

    // '1' key
    if keyIsDown p5 49 then
        do cam.setPosition 30 0 80

    // '2' key
    if keyIsDown p5 50 then
        do cam.setPosition 0 0 80

    // '3' key
    if keyIsDown p5 51 then
        do cam.setPosition -30 0 80

    cube p5 20

let run node = simulate node setup noUpdate draw
