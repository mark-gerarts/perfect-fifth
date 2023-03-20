module P5Reference.Color.Color7

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noStroke p5
    let c = color p5 (RGB(50, 55, 100))
    fill p5 (P5Color c)
    rect p5 0 10 45 80

    colorModeMaxAll p5 ModeHSB 100
    fill p5 (RGB(50, 55, 100))
    rect p5 55 10 45 80

let run node = display node draw
