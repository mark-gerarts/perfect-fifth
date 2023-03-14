module P5Reference.Color.Green

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    let c = color p5 (RGB(20, 75, 200))
    fill p5 (P5Color c)
    rect p5 15 20 35 60

    let greenValue = green p5 (P5Color c) |> int
    print p5 (string greenValue)
    fill p5 (RGB(0, greenValue, 0))
    rect p5 50 20 35 60
    describe p5 "blue rect on left and green on right, both with black outlines & 35×60."

let run node = display node draw
