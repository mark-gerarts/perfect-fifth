module P5Reference.Math.Sin

open P5.Core
open P5.Shape
open P5.Math

let draw p5 =
    let a = 0.0
    let inc = twoPi / 25.0

    for i in { 0.0 .. 25.0 } do
        let a' = a + (i * inc)
        line p5 (i * 4.0) 50 (i * 4.0) (50.0 + (sin a') * 40.0)

let run node = display node draw
