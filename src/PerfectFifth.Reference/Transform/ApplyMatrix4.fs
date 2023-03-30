module P5Reference.Transform.ApplyMatrix4

open P5.Core
open P5.Color
open P5.Shape
open P5.Transform
open P5.Math
open P5.Rendering

let setup p5 =
    createWebGLCanvas p5 100 100
    noFill p5

let draw p5 t =
    background p5 (Grayscale 200)
    rotateY p5 (pi / 6.0)
    stroke p5 (Grayscale 153)
    cube p5 35
    let rad = float t / 1000.0
    // Set rotation angles
    let ct = cos rad
    let st = sin rad
    // Matrix for rotation around the Y axis
    applyMatrix4x4 p5 ct 0 st 0 0 1 0 0 -st 0 ct 0 0 0 0 1
    stroke p5 (Grayscale 255)
    cube p5 50

let run node = animate node setup draw
