module P5Reference.Color.Fill9

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // percentage RGBA notation
    fill p5 (Name "rgba(100%,0%,100%,0.5)")
    square p5 20 20 60

let run node = display node draw
