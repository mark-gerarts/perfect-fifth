module P5Reference.Color.P5ColorToString1

open P5.Core
open P5.Color
open P5.Typography

let draw p5 =
    let color = color p5 (RGB(100, 130, 250))
    text p5 (color.toStringf "#rrggbb") 25 25

let run node = display node draw
