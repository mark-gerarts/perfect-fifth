module P5Reference.Color.Red

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    let c = color p5 (RGB(255, 204, 0))
    fill p5 (P5Color c)
    rect p5 15 20 35 60

    let redValue = red p5 (P5Color c) |> int
    print p5 (string redValue)
    fill p5 (RGB(redValue, 0, 0))
    rect p5 50 20 35 60

let run node = display node draw
