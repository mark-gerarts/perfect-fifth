module P5Reference.Math.Map0

open P5.Core
open P5.Shape
open P5.Math
open P5.Environment

let draw p5 =
    let value = 25
    let m = map p5 value 0 100 0 (width p5 |> float)
    circle p5 m 50 10

let run node = display node draw
