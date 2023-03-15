module P5Reference.Color.Lightness

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5
    colorMode p5 ModeHSL
    let c = color p5 (RGBA(156, 100, 50, 1))
    fill p5 (P5Color c)
    rect p5 15 20 35 60
    let value = lightness p5 (P5Color c) |> int
    fill p5 (Grayscale value)
    rect p5 50 20 35 60
    describe p5 "light pastel green rect on left and dark grey rect on right, both 35×60."

let run node = display node draw
