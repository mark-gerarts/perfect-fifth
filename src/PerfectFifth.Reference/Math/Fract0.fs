module P5Reference.Math.Fract0

open P5.Core
open P5.Typography
open P5.Math

let draw p5 =
    text p5 (string 7345.73472742) 10 25
    text p5 (fract p5 7345.73472742 |> string) 10 75

let run node = display node draw
