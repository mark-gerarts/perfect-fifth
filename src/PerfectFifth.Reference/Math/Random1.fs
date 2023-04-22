module P5Reference.Math.Random1

open P5.Core
open P5.Shape
open P5.Math

let draw p5 =
    for i in { 0.0 .. 100.0 } do
        let r = randomBetween p5 -50 50
        line p5 50 i (50.0 + r) i

let run node = display node draw
