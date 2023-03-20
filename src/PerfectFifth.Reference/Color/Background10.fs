module P5Reference.Color.Background10

open P5.Core
open P5.Color

let draw p5 =
    // p5 Color object
    let c = color p5 (RGB(0, 0, 255))
    background p5 (P5Color c)

let run node = display node draw
