module P5Reference.Color.ColorMode2

open P5.Core
open P5.Typography
open P5.Color

let draw p5 =
    colorModeMaxAll p5 ModeRGB 255
    let c = color p5 (RGB(127, 255, 0))
    colorModeMaxAll p5 ModeRGB 1
    let myColor = red p5 (P5Color c)
    textBounded p5 (string myColor) 10 10 80 80

let run node = display node draw
