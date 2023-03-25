module P5Reference.Color.Color2

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // You can use named SVG & CSS colors
    let c = color p5 (Name "magenta")
    fill p5 (P5Color c)
    noStroke p5
    square p5 20 20 60

let run node = display node draw
