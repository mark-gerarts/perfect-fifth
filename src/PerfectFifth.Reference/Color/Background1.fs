module P5Reference.Color.Background1

open P5.Core
open P5.Color

let draw p5 =
    // R, G & B integer values
    background p5 (RGB(255, 204, 0))

let run node = display node draw
