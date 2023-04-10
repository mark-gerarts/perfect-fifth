module P5Reference.Math.Dist

open P5.Core
open P5.Color
open P5.Shape
open P5.Math
open P5.Events
open P5.Structure
open P5.Transform
open P5.Typography
open P5.Data

// Fancy!
let draw p5 _ =
    background p5 (Grayscale 200)
    fill p5 (Grayscale 0)

    let x1 = 10.0
    let y1 = 90.0
    let x2 = mouseX p5
    let y2 = mouseY p5

    line p5 x1 y1 x2 y2
    circle p5 x1 y1 7
    circle p5 x2 y2 7

    // d is the length of the line
    // the distance from point 1 to point 2.
    let d = dist p5 x1 y1 x2 y2

    // Let's write d along the line we are drawing!
    push p5
    translate p5 ((x1 + x2) / 2.0) ((y1 + y2) / 2.0)
    rotate p5 (atan2 (y2 - y1) (x2 - x1))
    text p5 (nfcWithPrecision p5 d 1) 0 -5
    pop p5


let run node = animate node noSetup draw
