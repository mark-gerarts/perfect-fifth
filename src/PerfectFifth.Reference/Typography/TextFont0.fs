module P5Reference.Typography.TextFont0

open P5.Core
open P5.Color
open P5.Typography

let draw p5 =
    fill p5 (Grayscale 0)
    setTextSize p5 12
    setTextFontByName p5 "Georgia"
    text p5 "Georgia" 12 30
    setTextFontByName p5 "Helvetica"
    text p5 "Helvetica" 12 60

let run node = display node draw
