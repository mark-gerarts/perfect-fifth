module P5Reference.Color.NoFill0

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    square p5 15 10 55
    noFill p5
    square p5 20 20 60

let run node = display node draw
