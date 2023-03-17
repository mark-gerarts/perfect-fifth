module P5Reference.Color.ColorMode0

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    noStroke p5
    colorModeMaxAll p5 ModeRGB 100

    for i in seq { 0..99 } do
        for j in seq { 0..99 } do
            stroke p5 (RGB(i, j, 0))
            point p5 i j

    describe p5 "Green to red gradient from bottom left to top right with shading from top left"

let run node = display node draw
