module P5Reference.Math.Floor

open P5.Core
open P5.Color
open P5.Shape
open P5.Math
open P5.Events
open P5.Typography
open P5.Data

let draw p5 _ =
    background p5 (Grayscale 200)

    // map mouseX between 0 and 5.
    let ax = map p5 (mouseX p5) 0 100 0 5
    let ay = 66.0

    //Get the ceiling of the mapped number.
    let bx = floor (map p5 (mouseX p5) 0 100 0 5)
    let by = 33.0

    // Multiply the mapped numbers by 20 to more easily
    // see the changes.
    stroke p5 (Grayscale 0)
    fill p5 (Grayscale 0)
    line p5 0 ay (ax * 20.0) ay
    line p5 0 by (bx * 20.0) by

    // Reformat the float returned by map and draw it.
    noStroke p5
    text p5 (nfcWithPrecision p5 ax 2) ax (ay - 5.0)
    text p5 (nfcWithPrecision p5 bx 1) bx (by - 5.0)

let run node = animate node noSetup draw
