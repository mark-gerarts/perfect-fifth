module P5Reference.Color.ColorMode1

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noStroke p5
    colorModeMaxAll p5 ModeHSB 100

    for i in seq { 0..99 } do
        for j in seq { 0..99 } do
            stroke p5 (RGB(i, j, 100))
            point p5 i j

let run node = display node draw
