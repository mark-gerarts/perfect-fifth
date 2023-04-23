module P5Reference.Events.RequestPointerLock

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Events
open P5.ThreeD

let setup p5 =
    createWebGLCanvas p5 100 100
    requestPointerLock p5
    createCamera p5

let draw p5 (cam: P5Camera) =
    background p5 (Grayscale 255)
    cam.pan (-movedX p5 * 0.001)
    cam.tilt (movedY p5 * 0.001)
    sphere p5 25

let run node = simulate node setup noUpdate draw
