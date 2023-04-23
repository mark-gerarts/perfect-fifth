module P5Reference.Math.RandomSeed

open P5.Core
open P5.Color
open P5.Shape
open P5.Math

let draw p5 =
    randomSeed p5 99

    for i in { 0.0 .. 100.0 } do
        let r = randomBetween p5 0 255
        stroke p5 (Grayscale r)
        line p5 i 0 i 100

let run node = display node draw
