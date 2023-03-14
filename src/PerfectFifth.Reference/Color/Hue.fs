module P5Reference.Color.Hue

open P5.Core
open P5.Typography
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5
    colorModeMaxAll p5 ModeHSB 255
    let c = color p5 (RGB(0, 126, 255))
    fill p5 (P5Color c)
    rect p5 15 20 35 60
    let value = hue p5 (P5Color c) |> int
    fill p5 (Grayscale value)
    rect p5 50 20 35 60
    describe p5 "salmon pink rect on left and black on right, both 35×60."

let run node = display node draw
