module P5Reference.Color.Background6

open P5.Core
open P5.Color

let draw p5 =
    // integer RGB notation
    background p5 (Name "rgb(0,255,0)")

let run node = display node draw
