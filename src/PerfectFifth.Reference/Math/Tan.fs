module P5Reference.Math.Tan

open P5.Core
open P5.Shape
open P5.Math

let draw p5 =
    let a = 0.0
    let inc = twoPi / 50.0

    for i in { 0.0..2.0..100.0 } do
        let a' = a + (i * inc / 2.0)
        line p5 i 50 i (50.0 + (tan a') * 2.0)

let run node = display node draw
