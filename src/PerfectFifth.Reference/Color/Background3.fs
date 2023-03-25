module P5Reference.Color.Background3

open P5.Core
open P5.Color

let draw p5 =
    // Named SVG/CSS color string
    background p5 (Name "red")

let run node = display node draw
