module P5Reference.Math.Fract1

open P5.Core
open P5.Typography
open P5.Math

let draw p5 =
    text p5 (string 1.4215e-15) 10 25
    text p5 (fract p5 1.4215e-15 |> string) 10 75

let run node = display node draw
