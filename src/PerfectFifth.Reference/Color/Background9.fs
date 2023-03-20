module P5Reference.Color.Background9

open P5.Core
open P5.Color

let draw p5 =
    // percentage RGBA notation
    background p5 (Name "rgba(100%,0%,100%,0.5)")

let run node = display node draw
