module P5Reference.Color.Alpha

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5

    let c = color p5 (RGBA(0, 126, 255, 102))
    fill p5 (P5Color c)

    rect p5 15 15 35 70

    let value = alpha p5 (P5Color c)
    fill p5 (Grayscale <| int value)

    rect p5 50 15 35 70
    describe p5 "Left half of canvas light blue and right half light charcoal grey."

let run node = display node draw
