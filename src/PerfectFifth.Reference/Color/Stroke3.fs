module P5Reference.Color.Stroke3

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Named SVG/CSS color string
    stroke p5 (Name "red")
    strokeWeight p5 4
    square p5 20 20 60

let run node = display node draw
