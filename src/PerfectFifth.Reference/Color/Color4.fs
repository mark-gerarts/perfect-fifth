module P5Reference.Color.Color4

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    // RGB and RGBA color strings are also supported these all set to the same
    // color (solid blue)
    noStroke p5
    let c = color p5 (Name "rgb(0,0,255)")
    fill p5 (P5Color c)
    square p5 10 10 35

    fill p5 (Name "rgb(0%, 0%, 100%)")
    square p5 55 10 35

    fill p5 (Name "rgba(0, 0, 255, 1)")
    square p5 10 55 35

    fill p5 (Name "rgba(0%, 0%, 100%, 1)")
    square p5 55 55 35

    describe p5 "Four blue rects in each corner of the canvas, each are 35×35."

let run node = display node draw
