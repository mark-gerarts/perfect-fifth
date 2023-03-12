module P5Reference.Color.Brightness0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5
    colorModeMaxAll p5 ModeHSB 255
    let c = color p5 (RGB(0, 126, 255))
    fill p5 (P5Color c)
    rect p5 15 20 35 60
    let value = brightness p5 (P5Color c) |> int
    fill p5 (Grayscale value)
    rect p5 50 20 35 60

    describe p5 "Left half of canvas salmon pink and the right half with its brightness colored white."

let run node = display node draw
