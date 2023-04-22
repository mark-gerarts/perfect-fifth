module P5Reference.Math.RandomGaussian0

open P5.Core
open P5.Math
open P5.Shape

let draw p5 =
    for y in { 0.0 .. 100.0 } do
        let x = randomGaussianFromMeanAndSd p5 50 15
        line p5 50 y x y

let run node = display node draw
