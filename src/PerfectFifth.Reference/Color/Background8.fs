module P5Reference.Color.Background8

open P5.Core
open P5.Color

let draw p5 =
    // percentage RGB notation
    background p5 (Name "rgb(100%,0%,10%)")

let run node = display node draw
