module P5Reference.Color.Color0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    let c = color p5 (RGB(255, 204, 0))
    fill p5 (P5Color c)
    noStroke p5
    rect p5 30 20 55 55

let run node = display node draw
