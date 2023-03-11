module P5Reference.Color.Blue

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    let c = color p5 (RGB(175, 100, 220))
    fill p5 (P5Color c)

    rect p5 15 20 35 60

    let blueValue = blue p5 (P5Color c)
    fill p5 (RGB(0, 0, int blueValue))
    rect p5 50 20 35 60
    describe p5 "Left half of canvas light purple and right half a royal blue."

let run node = display node draw
