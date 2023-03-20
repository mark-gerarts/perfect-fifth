module P5Reference.Color.ColorMode3

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    noFill p5
    colorModeMaxAlpha p5 ModeRGB 255 255 255 1
    background p5 (Grayscale 255)
    strokeWeight p5 4
    stroke p5 (RGBA(255, 0, 10, 0.3))
    circle p5 40 40 50
    circle p5 50 50 40

let run node = display node draw
